using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAController.DeviceComponents;
using WFAController.DeviceTimin;
using WFAController.Others;
using WFAController.URLConnection;

namespace WFAController
{
    public delegate void AddDevise(DeviceBase obj);

    public partial class MainForm : Form
    {
        DeviceTimingContol DeviceList;

        //int i = 2;
        Thread th;

        DeviceCreate deviceCreateForm;

        public MainForm()
        {
            InitializeComponent();

            this.comboBoxOBJ_Type.Items.Add(DeviceType.Signaling.ToString());
            this.comboBoxOBJ_Type.Items.Add(DeviceType.Door.ToString());
            this.comboBoxOBJ_Type.Items.Add(DeviceType.Conditioner.ToString());
            this.comboBoxOBJ_Type.Items.Add(DeviceType.Sensor.ToString());

            this.DeviceList = new DeviceTimingContol();

            this.DeviceList.ChangeDevice += DeviceList_ChangeDevice;
            this.DeviceList.ChangeDeviceList += DeviceList_ChangeDeviceList;

            DeviceList.Start();

            AddDevise obj = new AddDevise(deviceTableAdd);
            deviceCreateForm = new DeviceCreate(obj);

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDataSet1.Table". При необходимости она может быть перемещена или удалена.
            //this.tableTableAdapter.Fill(this.testDataSet1.Table);

        }

        void DeviceList_ChangeDeviceList(List<DeviceBase> ListDevice)
        {
            this.dataGridView1.Rows.Clear();

            foreach (DeviceBase obj in ListDevice)
            {
                this.dataGridView1.Rows.Add(obj.GetTableRows());
                //if (obj.Type == DeviceType.Sensor)
                //    ((Button)this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[1]).Enabled = false;//).Enabled = false;
            }
        }

        void DeviceList_ChangeDevice(DeviceBase Device, int ind)
        {
            //if (Device.Type == DeviceType.Sensor)
            //{
                this.dataGridView1.Rows[ind].SetValues(Device.GetTableRows());
            //}
            //else
            //{
            //    this.dataGridView1.Rows[ind].SetValues(Device.SerialNumber.ToString(),
            //                            Device.State.ToString(),
            //                            Device.Type.ToString());
            //}

            URLConnector.ChangeState(Device);
        }

        public void deviceTableAdd(DeviceBase obj)
        {
            if (obj != null)
            {
                //obj.TimingRuns.Add(new TimePeriod(new DateTime(Times.year, Times.month, 1, i, 0, 0, Times.sec), new DateTime(Times.year, Times.month, 1, i+5, 0, 0, Times.sec)));
                //i++;
                DeviceList.AddDevise(obj);

                this.labelResult.Text = URLConnector.AddDevice(obj);
            }

            this.Enabled = true;
        }

        private void buttonStartCreate_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            deviceCreateForm.Show();
        }

        private void buttonStartSimulations_Click(object sender, EventArgs e)
        {
            DateTime startTime = new DateTime(Times.year,Times.month,this.comboBoxDay.SelectedIndex + 1,
                                                (int)this.numericUpDownHour.Value,(int)this.numericUpDownMinute.Value,Times.sec);

            DeviceList.StartTime = startTime;
            DeviceList.TimeTick = (int)this.numericUpDownSpeed.Value;

            if (th == null)
            {
                th = new Thread(TimeTick);
                th.Start();

                this.buttonStartSimulations.Text = "Stop Simulations";
            }
            else 
            {
                th.Abort();
                th = null;
                this.buttonStartSimulations.Text = "Start Simulations";
            }
        }

        void TimeTick()
        {
            while (true)
            {
                DeviceList.TimeGo();

                this.labelNowDay.Text = DeviceList.StartTime.Day.ToString();
                this.labelNowHour.Text = DeviceList.StartTime.Hour.ToString();
                this.labelNowMinute.Text = DeviceList.StartTime.Minute.ToString();
                
                Thread.Sleep(10);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (DeviceList[e.RowIndex].State == false)
                {
                    DeviceList[e.RowIndex].State = true;
                    DeviceList.EventNow(e.RowIndex);
                }
                else
                {
                    DeviceList[e.RowIndex].State = false;
                    DeviceList.EventNow(e.RowIndex);
                }

                this.labelResult.Text = URLConnector.ChangeState(DeviceList[e.RowIndex]);
            }

            if (e.ColumnIndex == 5 && this.dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString() != "")
            {
                if (DeviceList[e.RowIndex].Type == DeviceType.Signaling)
                {
                    this.labelResult.Text = URLConnector.AlarmSignaling(DeviceList[e.RowIndex]);
                }
                else
                {
                    this.labelResult.Text = URLConnector.AlarmSensor(DeviceList[e.RowIndex]);
                }                
            }

            if (e.ColumnIndex == 6)
            {
                String str = "timing: ";

                if (DeviceList[e.RowIndex].TimingRuns != null)
                {
                    foreach (TimePeriod obj in DeviceList[e.RowIndex].TimingRuns)
                    {
                        str += " <from = day(" + obj.From.Day + ") " + obj.From.Hour + ":" + obj.From.Minute
                            +  " To = day(" + obj.From.Day + ") " + obj.To.Hour + ":" + obj.From.Minute + ">";
                    }
                }

                MessageBox.Show(str);
            }
            if (e.ColumnIndex == 7)
            {
                DeviceList.RemoveAt(e.RowIndex);
            }
        }

        public DeviceBase getDeviceDlyatest()
        {
            if ((DeviceType)(this.comboBoxOBJ_Type.SelectedIndex + 1) == DeviceType.Sensor)
            {
                DeviceBase obj = new DeviceBase();
                obj.Type = (DeviceType)(this.comboBoxOBJ_Type.SelectedIndex + 1);
                obj.SerialNumber = Convert.ToInt32(this.textBoxOBJ_SN.Text);
                obj.State = Convert.ToBoolean(this.comboBoxOBJ_state.Text);

                return obj;                
            }
            else 
            {
                Senser obj = new Senser();
                obj.Type = (DeviceType)(this.comboBoxOBJ_Type.SelectedIndex + 1);

                obj.SerialNumber    = Convert.ToInt32(this.textBoxOBJ_SN.Text);
                obj.State           = Convert.ToBoolean(this.comboBoxOBJ_state.Text);
                obj.TemConst        = Convert.ToInt32(this.textBoxOBJ_Tconst.Text);
                obj.Temperature     = Convert.ToInt32(this.textBoxOBJ_temp.Text);

                return obj;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.labelResult.Text = URLConnector.AlarmSignaling(getDeviceDlyatest());

            //URLConnector obj = new URLConnector();

            //this.label1.Text = obj.ChangeState(new DeviceBase(3));
            //this.label1.Text = obj.AlarmSensor(new DeviceBase(3));
            //this.label1.Text = obj.AlarmSignaling(new DeviceBase(3));
            //Senser f = new Senser();
            //f.Temperature = 99;
            //f.TemConst = 100;
            //f.SerialNumber = 700;
            //this.label1.Text = obj.ChangeTemperature(f);





            ////this.dataGridView1.Rows.Add("ool", "olo");

            //var request = WebRequest.Create("http://192.168.1.3:81/Server" + "/home/Rec" + "?i=" + i);
            //request.Method = "GET";
            //i++;
            ////WebRequest request = WebRequest.Create("http://www.contoso.com/default.html");
            //// If required by the server, set the credentials.
            //// request.Credentials = CredentialCache.DefaultCredentials;
            //// Get the response.
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //// Display the status.

            //// Get the stream containing content returned by the server.
            //Stream dataStream = response.GetResponseStream();
            //// Open the stream using a StreamReader for easy access.
            //StreamReader reader = new StreamReader(dataStream);
            //// Read the content.
            //string responseFromServer = reader.ReadToEnd();


            //this.button1.Text = responseFromServer;

            ////this.label1.Text = responseFromServer;
            ////Console.WriteLine(response.StatusDescription);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.labelResult.Text =  URLConnector.ChangeState(getDeviceDlyatest());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.labelResult.Text =  URLConnector.AddDevice(getDeviceDlyatest());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.labelResult.Text =  URLConnector.ChangeTemperature((Senser)getDeviceDlyatest());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeviceBase obj = new DeviceBase();
            obj.SerialNumber = 999;
            obj.State = true;
            obj.TimingRuns = null;
            obj.Type = DeviceType.Conditioner;

            this.labelResult.Text = URLConnector.AddDevice(obj);
        }

        private void buttonLoadDevices_Click(object sender, EventArgs e)
        {
            URLConnector.ResicwDevises();
        }

        private void buttonLoadTimng_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DeviceList.Count; i++)
            {
                URLConnector.LoadTiming(DeviceList[i]);
            }
        }

    }
}
