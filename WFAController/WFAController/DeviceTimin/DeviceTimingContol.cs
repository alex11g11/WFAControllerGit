using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAController.DeviceComponents;

namespace WFAController.DeviceTimin
{
    class DeviceTimingContol : DeviceRepository
    {
        public DateTime StartTime { get; set; }
        public int TimeTick { get; set; }

        public DeviceTimingContol()
        {
            
        }

        public DeviceTimingContol(DateTime StartTime)
        {
            this.StartTime = StartTime;
        }

        public void TimeGo()
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].TimingRuns != null)
                {
                    if (this[i].TimingRuns.IsChangeTime(StartTime) == 2)
                    {
                        this[i].State = false;
                        this.EventNow(i);
                    }
                    if (this[i].TimingRuns.IsChangeTime(StartTime) == 1)
                    {
                        this[i].State = true;
                        this.EventNow(i);
                    }
                }

                if (this[i].Type == DeviceType.Sensor)
                {
                    ((Senser)this[i]).ChangeTemp();
                    this.EventNow(i);
                }
            }

            StartTime = StartTime.Add(new TimeSpan(0, TimeTick, 0));
        }
    }
}
