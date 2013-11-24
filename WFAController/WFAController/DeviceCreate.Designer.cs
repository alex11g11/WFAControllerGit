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
            this.SuspendLayout();
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCreate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonCreate.Location = new System.Drawing.Point(139, 59);
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
            this.buttonCancel.Location = new System.Drawing.Point(12, 59);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 33);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // DeviceCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 99);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelSN);
            this.Controls.Add(this.textBoxSN);
            this.Controls.Add(this.ButtonCreate);
            this.Name = "DeviceCreate";
            this.Text = "DeviceCreate";
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
    }
}