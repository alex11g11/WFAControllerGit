using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAController.DeviceComponents;

namespace WFAController
{
    public partial class DeviceCreate : Form
    {
        AddDevise addDevise;

        public DeviceCreate()
        {
            InitializeComponent();
        }

        public DeviceCreate(AddDevise addDevise)
        {
            InitializeComponent();

            this.addDevise = addDevise;

            this.comboBoxType.Items.Add(DeviceType.Signaling.ToString()); 
            this.comboBoxType.Items.Add(DeviceType.Door.ToString());
            this.comboBoxType.Items.Add(DeviceType.Conditioner.ToString());
            this.comboBoxType.Items.Add(DeviceType.Sensor.ToString());

            this.numericUpDownTconst.Enabled = false;
            this.numericUpDownTemp.Enabled = false;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            if ((DeviceType)(this.comboBoxType.SelectedIndex + 1) == DeviceType.Sensor)
            {
                Senser obj = new Senser();
                obj.SerialNumber = Convert.ToInt32(this.textBoxSN.Text);
                obj.State = true;
                obj.Type = DeviceType.Sensor;
                obj.Temperature = (int)this.numericUpDownTemp.Value;
                obj.TemConst = (int)this.numericUpDownTconst.Value;
                addDevise(obj);
            }
            else
            {
                DeviceBase obj = new DeviceBase();
                obj.SerialNumber = Convert.ToInt32(this.textBoxSN.Text);
                obj.State = false;
                obj.Type = (DeviceType)(this.comboBoxType.SelectedIndex + 1);
                if (obj.Type == 0) obj.Type = (DeviceType)1;
                addDevise(obj);
            }

            this.textBoxSN.Text = "";
            this.comboBoxType.SelectedIndex = 0;
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            addDevise(null);

            this.textBoxSN.Text = "";
            this.comboBoxType.SelectedIndex = 0;
            this.Hide();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((DeviceType)(this.comboBoxType.SelectedIndex + 1) == DeviceType.Sensor)
            {
                this.numericUpDownTconst.Enabled = true;
                this.numericUpDownTemp.Enabled = true;
            }
            else
            {
                this.numericUpDownTconst.Enabled = false;
                this.numericUpDownTemp.Enabled = false;
            }
        }
    }
}
