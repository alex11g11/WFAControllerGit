﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAController.DeviceComponents;
using WFAController.Others;

namespace WFAController.DeviceTimin
{
    public delegate void ChangeDeviceList(List<DeviceBase> ListDevice);
    public delegate void ChangeDevice(DeviceBase Device,int ind);

    class DeviceRepository
    {
        private string ip = "192.168.1.4";
        private int port = 2200;

        List<DeviceBase> DeviceList;
        
        public event ChangeDeviceList ChangeDeviceList;
        public event ChangeDevice ChangeDevice;

        Thread listenThead;

        public DeviceRepository()
        {
            DeviceList = new List<DeviceBase>();

            listenThead = new Thread(StartListen);
        }

        public int Count
        {
            get { return DeviceList.Count; }
        }

        public void AddDevise(DeviceBase obj)
        {
            this.DeviceList.Add(obj);
            ChangeDeviceList(DeviceList);            
        }

        public void RemoveAt(int ind)
        {
            this.DeviceList.RemoveAt(ind);
            ChangeDeviceList(DeviceList);
            var str = URLConnection.URLConnector.RemoveDevice(DeviceList[ind]);
            MessageBox.Show(str);
        }

        public DeviceBase this[int i]
        {
            get
            {
                return DeviceList[i];
            }
            set
            {
                MessageBox.Show("index");
                DeviceList[i] = value;
                //ChangeDevice(this[i], i);
            }
        }

        public void Start()
        {
            listenThead.Start();
        }

        public void EventNow(int i)
        {
            ChangeDevice(this.DeviceList[i], i);
        }

        private void StartListen()
        {
            IPAddress localAddress = IPAddress.Parse(ip);
            TcpListener listener = new TcpListener(localAddress, port);

            listener.Start(1);

            while (true)
            {

                    TcpClient client = listener.AcceptTcpClient();

                    Socket Sock = client.Client;
                    byte[] remdata = new byte[4000];
                    int i = Sock.Receive(remdata);

                    List<Type> typeList = new List<Type>();

                    typeList.Add(typeof(List<Device>));
                    typeList.Add(typeof(Device));
                    typeList.Add(typeof(Packet));
                    typeList.Add(typeof(Sensor));

                    int j = 0;
                    while (j < typeList.Count)
                    {
                        if (Serializer.deserialize(remdata, typeList[j]) != null)
                        {
                            break;
                        }

                        j++;
                    }
                    //j++;
                    //MessageBox.Show("lol j = " + j);
                    if (j == 0)
                    {
                        try
                        {
                            var res = (List<Device>)Serializer.deserialize(remdata, typeof(List<Device>));

                            for (int g = 0; g < res.Count; g++)
                            {
                                if (res[g].Type == 4)
                                {
                                    this.AddDevise(DeviceConvert.DeviceToSenser(res[g]));
                                }
                                else
                                {
                                    this.AddDevise(DeviceConvert.DeviceToDeviceB(res[g]));
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show("main TCP listener " + e.ToString());
                        }
                    }

                    if (j == 1)
                    {
                        var res = (Device)Serializer.deserialize(remdata, typeof(Device));

                        for (int g = 0; g < DeviceList.Count; g++)
                        {
                            if (DeviceList[g].SerialNumber == res.DeviceSerial)
                            {
                                DeviceList[g].State = (res.State == 1) ? true : false;

                                this.ChangeDevice(DeviceList[g], g);
                            }
                        }
                    }

                    if (j == 2)
                    {
                        var res = (Packet)Serializer.deserialize(remdata, typeof(Packet));

                        for (int g = 0; g < DeviceList.Count; g++)
                        {
                            if (DeviceList[g].SerialNumber == res.device.DeviceSerial)
                            {
                                String str = "timing: ";

                                Timing timing = new Timing();

                                foreach (Time obj in res.time)
                                {
                                    timing.Add(new TimePeriod((DateTime)obj.From, (DateTime)obj.To));
                                    str += " <from = " + ((DateTime)obj.From).Hour + " To = " + ((DateTime)obj.To).Hour + ">";

                                }
                                DeviceList[g].TimingRuns = timing;
                            }
                        }

                    }

                    if (j == 3)
                    {
                        var res = (Sensor)Serializer.deserialize(remdata, typeof(Sensor));

                        for (int p = 0; p < DeviceList.Count; p++)
                        {
                            if (res.DeviceSerial == DeviceList[p].SerialNumber)
                            {
                                ((Senser)DeviceList[p]).TemConst = (int)res.tconst;
                                EventNow(p);
                            }
                        }

                    }

                    client.Close();
            }
        }
    }
}
