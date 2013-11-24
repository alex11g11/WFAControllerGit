using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAController.DeviceComponents;

namespace WFAController.URLConnection
{
    static class URLConnector
    {
        private static string baseUrl = "http://192.168.1.3:81/Server/Home/";

        public static string AlarmSignaling(DeviceBase obj)
        {
            string controller = "AlarmSignalization";
            string param = "?DeviceSerial=" + obj.SerialNumber;

            string result = Send(controller, param);

            return result;
        }

        public static string ChangeState(DeviceBase obj)
        {
            string controller = "ChangeState";
            string param = "?DeviceSerial=" + obj.SerialNumber
                            + "&state=";// +obj.State;

            if (obj.State == true)
            {
                param += "1";
            }
            else 
            {
                param += "0";
            }

            string result = Send(controller, param);

            return result;
        }

        public static string AlarmSensor(DeviceBase obj)
        {
            string controller = "AlarmSensor";
            string param = "?DeviceSerial=" + obj.SerialNumber;

            string result = Send(controller, param);

            return result;
        }

        public static string ChangeTemperature(Senser obj)
        {
            string controller = "ChangeTemperature";
            string param = "?DeviceSerial=" + obj.SerialNumber 
                            + "&temperature=" + obj.Temperature;

            string result = Send(controller, param);

            return result;
        }

        public static string ResicwDevises()
        {
            string controller = "sendDevices";
            string param = "";

            string result = Send(controller, param);

            return result;
        }

        public static string AddDevice(DeviceBase obj)
        {
            string controller = "";

            string param = "?DeviceSerial=" + obj.SerialNumber
                            + "&Type=" + (int)obj.Type
                            + "&State=" + ((obj.State == true) ? 1 : 0);

            if (obj.Type == DeviceType.Sensor)
            {
                controller = "AddSensor";

                param += "&Tconst=" + ((Senser)obj).TemConst;
                param += "&Temp=" + ((Senser)obj).Temperature;
            }
            else
            {
                controller = "AddDevice";
            }

            string result = Send(controller, param);

            return result;
        }

        public static string AddSensor(Senser obj)
        {
            string controller = "AddSensor";
            string param = "?DeviceSerial=" + obj.SerialNumber
                            + "&Type=" + obj.Type
                            + "&State=" + obj.State
                            + "&tconst=" + obj.TemConst
                            + "&t=" + obj.Temperature;                        

            string result = Send(controller, param);

            return result;
        }

        private static string Send(string controller, string param)
        {
            try
            {
                var request = WebRequest.Create(baseUrl + controller + param);
                request.Method = "GET";

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                return reader.ReadToEnd();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            return "";
        }
    }
}
