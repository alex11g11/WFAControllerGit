using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFAController.URLConnection;

namespace WFAController.DeviceComponents
{
    public enum DeviceType { Signaling = 1, Door, Conditioner, Sensor }

    public class DeviceBase
    {

        /// <summary>
        /// Device State (false - off, true - on)
        /// </summary>
        public bool State { get; set; }

        /// <summary>
        /// The unique identifier of the device
        /// </summary>
        public int SerialNumber { get; set; }

        public DeviceType Type { get; set; }

        public Timing TimingRuns { get; set; }

        public DeviceBase()
        {
            State = false;
            SerialNumber = -1;
            TimingRuns = new Timing();
        }

        public DeviceBase(int SerialNumber)
        {
            State = false;
            this.SerialNumber = SerialNumber;
            TimingRuns = new Timing();
        }

        public virtual string[] GetTableRows()
        {
            string[] str = { SerialNumber.ToString(), State.ToString(), Type.ToString(), "", "", "", "delete" };

            if (Type == DeviceType.Signaling)
            {
                str[5] = "ALARM";
            }

            return str;
        }

    }


    public partial class Device
    {
        public int Id { get; set; }
        public Nullable<int> DeviceSerial { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> State { get; set; }
        public string UserName { get; set; }
    }

    public class Packet
    {
        public Device device { get; set; }
        public List<Time> time { get; set; }
    }

    public partial class Time
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> From { get; set; }
        public Nullable<System.DateTime> To { get; set; }
        public Nullable<int> DeviceSerial { get; set; }
        public class TimeMetadata
        {
            public int Id { get; set; }
            public Nullable<System.DateTime> From { get; set; }
            public Nullable<System.DateTime> To { get; set; }
            public Nullable<int> DeviceSerial { get; set; }

        }

    }

    public static class DeviceConvert
    {
        public static DeviceBase DeviceToDeviceB(Device obj)
        {
            DeviceBase res = new DeviceBase();

            res.SerialNumber = (int)obj.DeviceSerial;
            res.Type = (DeviceType)obj.Type;
            if (obj.State == 0) res.State = false;
            else res.State = true;

            res.TimingRuns = null;

            return res;
        }
    }
}