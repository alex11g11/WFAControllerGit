using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAController.DeviceComponents
{
    public class Senser : DeviceBase
    {
        double period;
        bool alarm = false;

        /// <summary>
        /// Критическая темперотура
        /// </summary>
        public int TemConst { get; set; }

        public int Temperature { get; set; }

        public Senser()
        {
            this.State = true;
        }

        public Senser(int TemConst)
        {
            this.TemConst = TemConst;

            Temperature = 0;
        }

        public override string[] GetTableRows()
        {
            string[] str =  base.GetTableRows();

            string[] at = { base.GetTableRows()[0], base.GetTableRows()[1], base.GetTableRows()[2], TemConst.ToString(), Temperature.ToString(), "ALARM", "show","delete" };
        
            return at;
        }

        public void ChangeTemp()
        {
            
            Temperature = (int)(25 * Math.Sin(period));
            //MessageBox.Show("lol = " + period + " " + (25 * Math.Sin(period)) + " " + ((int)(25 * Math.Sin(period))));
            period += 0.01;

            URLConnection.URLConnector.ChangeTemperature(this);

            if (Temperature > TemConst && alarm == false)
            {
                alarm = true;
                URLConnection.URLConnector.AlarmSensor(this);
                //MessageBox.Show("ALARM: " + Temperature + " > " + TemConst);
            }
            else
            {
                if (Temperature < TemConst)
                {
                    alarm = false;
                }
            }
        }
    }
}
