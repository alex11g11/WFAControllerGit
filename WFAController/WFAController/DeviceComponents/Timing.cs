using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAController.DeviceComponents
{
    public static class Times
    { 
        public static int year = 1;
        public static int month = 1;
        public static int sec = 0;
    }

    public class TimePeriod
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public TimePeriod()
        {

        }

        public TimePeriod(DateTime From, DateTime To)
        {
            this.From = new DateTime(Times.year,Times.month,From.Day,From.Hour,From.Minute,Times.sec);
            this.To = new DateTime(Times.year, Times.month, To.Day, To.Hour, To.Minute, Times.sec);            
        }
    }

    public class Timing : List<TimePeriod>
    {

        public Timing()
        { 
        
        }

        /// <summary>
        /// Сверяет теперешнее время с расписанием
        /// </summary>
        /// <param name="now">теперешнее время</param>
        /// <returns> 0 - менять не надо, 1 - вкл, 2 - выкл</returns>
        public int IsChangeTime(DateTime now)
        {
            int flg = 0;

            foreach (TimePeriod obj in this)
            {
                if (obj.To == now)
                {
                    flg = 2;
                    //MessageBox.Show("2");
                }
            }

            foreach (TimePeriod obj in this)
            {
                if (obj.From == now)
                {
                    flg = 1;
                    //MessageBox.Show("1");
                }
            }

            return flg;
        }

    }
}
