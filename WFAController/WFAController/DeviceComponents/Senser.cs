using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAController.DeviceComponents
{
    public class Senser : DeviceBase
    {
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

            string[] at = { base.GetTableRows()[0], base.GetTableRows()[1], base.GetTableRows()[2], TemConst.ToString(), Temperature.ToString(), "ALARM" , "delete" };
        
            return at;
        } 
    }
}
