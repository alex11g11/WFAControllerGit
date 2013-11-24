namespace WFAController
{
    partial class DeviceCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.textBoxSN = new System.Windows.Forms.TextBox();
            this.labelSN = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTconst = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.numericUpDownTconst = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTemp = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTconst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCreate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonCreate.Location = new System.Drawing.Point(139, 111);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(121, 33);
            this.ButtonCreate.TabIndex = 0;
            this.ButtonCreate.Text = "Create";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // textBoxSN
            // 
            this.textBoxSN.Location = new System.Drawing.Point(89, 6);
            this.textBoxSN.Name = "textBoxSN";
            this.textBoxSN.Size = new System.Drawing.Size(166, 20);
            this.textBoxSN.TabIndex = 1;
            // 
            // labelSN
            // 
            this.labelSN.AutoSize = true;
            this.labelSN.Location = new System.Drawing.Point(12, 9);
            this.labelSN.Name = "labelSN";
            this.labelSN.Size = new System.Drawing.Size(71, 13);
            this.labelSN.TabIndex = 2;
            this.labelSN.Text = "Serial number";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(52, 35);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(31, 13);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "Type";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(89, 32);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(166, 21);
            this.comboBoxType.TabIndex = 7;
            this.comboBoxType.Text = "Signaling";
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCancel.Location = new System.Drawing.Point(12, 111);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 33);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelTconst
            // 
            this.labelTconst.AutoSize = true;
            this.labelTconst.Location = new System.Drawing.Point(48, 62);
            this.labelTconst.Name = "labelTconst";
            this.labelTconst.Size = new System.Drawing.Size(40, 13);
            this.labelTconst.TabIndex = 11;
            this.labelTconst.Text = "Tconst";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(48, 88);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(34, 13);
            this.labelTemp.TabIndex = 12;
            this.labelTemp.Text = "Temp";
            // 
            // numericUpDownTconst
            // 
            this.numericUpDownTconst.Location = new System.Drawing.Point(89, 60);
            this.numericUpDownTconst.Name = "numericUpDownTconst";
            this.numericUpDownTconst.Size = new System.Drawing.Size(164, 20);
            this.numericUpDownTconst.TabIndex = 13;
            // 
            // numericUpDownTemp
            // 
            this.numericUpDownTemp.Location = new System.Drawing.Point(89, 86);
            this.numericUpDownTemp.Name = "numericUpDownTemp";
            this.numericUpDownTemp.Size = new System.Drawing.Size(164, 20);
            this.numericUpDownTemp.TabIndex = 14;
            // 
            // DeviceCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 149);
            this.Controls.Add(this.numericUpDownTemp);
            this.Controls.Add(this.numericUpDownTconst);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.labelTconst);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelSN);
            this.Controls.Add(this.textBoxSN);
            this.Controls.Add(this.ButtonCreate);
            this.Name = "DeviceCreate";
            this.Text = "DeviceCreate";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTconst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.TextBox textBoxSN;
        private System.Windows.Forms.Label labelSN;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelTconst;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.NumericUpDown numericUpDownTconst;
        private System.Windows.Forms.NumericUpDown numericUpDownTemp;
    }
}