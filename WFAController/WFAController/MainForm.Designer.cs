namespace WFAController
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonStartCreate = new System.Windows.Forms.Button();
            this.buttonStartSimulations = new System.Windows.Forms.Button();
            this.labelDay = new System.Windows.Forms.Label();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.numericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinute = new System.Windows.Forms.NumericUpDown();
            this.labelHour = new System.Windows.Forms.Label();
            this.labelMinute = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNowDay = new System.Windows.Forms.Label();
            this.labelNowHour = new System.Windows.Forms.Label();
            this.labelNowMinute = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxOBJ_SN = new System.Windows.Forms.TextBox();
            this.comboBoxOBJ_state = new System.Windows.Forms.ComboBox();
            this.comboBoxOBJ_Type = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxOBJ_Tconst = new System.Windows.Forms.TextBox();
            this.textBoxOBJ_temp = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonLoadDevices = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonLoadTimng = new System.Windows.Forms.Button();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.states = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tconst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperoture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALARM = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ShowTiming = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumber,
            this.states,
            this.Type,
            this.Tconst,
            this.Temperoture,
            this.ALARM,
            this.ShowTiming,
            this.delete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(844, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "AlarmSignaling";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStartCreate
            // 
            this.buttonStartCreate.Location = new System.Drawing.Point(699, 307);
            this.buttonStartCreate.Name = "buttonStartCreate";
            this.buttonStartCreate.Size = new System.Drawing.Size(78, 40);
            this.buttonStartCreate.TabIndex = 2;
            this.buttonStartCreate.Text = "Create Device";
            this.buttonStartCreate.UseVisualStyleBackColor = true;
            this.buttonStartCreate.Click += new System.EventHandler(this.buttonStartCreate_Click);
            // 
            // buttonStartSimulations
            // 
            this.buttonStartSimulations.Location = new System.Drawing.Point(22, 417);
            this.buttonStartSimulations.Name = "buttonStartSimulations";
            this.buttonStartSimulations.Size = new System.Drawing.Size(157, 50);
            this.buttonStartSimulations.TabIndex = 4;
            this.buttonStartSimulations.Text = "Start Simulations";
            this.buttonStartSimulations.UseVisualStyleBackColor = true;
            this.buttonStartSimulations.Click += new System.EventHandler(this.buttonStartSimulations_Click);
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(14, 301);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(26, 13);
            this.labelDay.TabIndex = 5;
            this.labelDay.Text = "Day";
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBoxDay.Location = new System.Drawing.Point(58, 298);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDay.TabIndex = 6;
            this.comboBoxDay.Text = "Monday";
            // 
            // numericUpDownHour
            // 
            this.numericUpDownHour.Location = new System.Drawing.Point(59, 325);
            this.numericUpDownHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHour.Name = "numericUpDownHour";
            this.numericUpDownHour.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownHour.TabIndex = 7;
            // 
            // numericUpDownMinute
            // 
            this.numericUpDownMinute.Location = new System.Drawing.Point(59, 352);
            this.numericUpDownMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinute.Name = "numericUpDownMinute";
            this.numericUpDownMinute.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMinute.TabIndex = 8;
            // 
            // labelHour
            // 
            this.labelHour.AutoSize = true;
            this.labelHour.Location = new System.Drawing.Point(14, 327);
            this.labelHour.Name = "labelHour";
            this.labelHour.Size = new System.Drawing.Size(30, 13);
            this.labelHour.TabIndex = 9;
            this.labelHour.Text = "Hour";
            // 
            // labelMinute
            // 
            this.labelMinute.AutoSize = true;
            this.labelMinute.Location = new System.Drawing.Point(14, 354);
            this.labelMinute.Name = "labelMinute";
            this.labelMinute.Size = new System.Drawing.Size(39, 13);
            this.labelMinute.TabIndex = 10;
            this.labelMinute.Text = "Minute";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(19, 393);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(34, 13);
            this.labelSpeed.TabIndex = 11;
            this.labelSpeed.Text = "1 c = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Minute";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(59, 391);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(39, 20);
            this.numericUpDownSpeed.TabIndex = 13;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hour";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Minute";
            // 
            // labelNowDay
            // 
            this.labelNowDay.AutoSize = true;
            this.labelNowDay.Location = new System.Drawing.Point(230, 417);
            this.labelNowDay.Name = "labelNowDay";
            this.labelNowDay.Size = new System.Drawing.Size(13, 13);
            this.labelNowDay.TabIndex = 17;
            this.labelNowDay.Text = "0";
            // 
            // labelNowHour
            // 
            this.labelNowHour.AutoSize = true;
            this.labelNowHour.Location = new System.Drawing.Point(230, 430);
            this.labelNowHour.Name = "labelNowHour";
            this.labelNowHour.Size = new System.Drawing.Size(13, 13);
            this.labelNowHour.TabIndex = 18;
            this.labelNowHour.Text = "0";
            // 
            // labelNowMinute
            // 
            this.labelNowMinute.AutoSize = true;
            this.labelNowMinute.Location = new System.Drawing.Point(230, 443);
            this.labelNowMinute.Name = "labelNowMinute";
            this.labelNowMinute.Size = new System.Drawing.Size(13, 13);
            this.labelNowMinute.TabIndex = 19;
            this.labelNowMinute.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(312, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 27);
            this.button2.TabIndex = 20;
            this.button2.Text = "ChangeState";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 27);
            this.button3.TabIndex = 22;
            this.button3.Text = "AlarmSensor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(312, 444);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 27);
            this.button4.TabIndex = 24;
            this.button4.Text = "ChangeTemperature";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(467, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "SN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(459, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "state";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(462, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "type";
            // 
            // textBoxOBJ_SN
            // 
            this.textBoxOBJ_SN.Location = new System.Drawing.Point(495, 356);
            this.textBoxOBJ_SN.Name = "textBoxOBJ_SN";
            this.textBoxOBJ_SN.Size = new System.Drawing.Size(100, 20);
            this.textBoxOBJ_SN.TabIndex = 30;
            // 
            // comboBoxOBJ_state
            // 
            this.comboBoxOBJ_state.FormattingEnabled = true;
            this.comboBoxOBJ_state.Items.AddRange(new object[] {
            "true",
            "false"});
            this.comboBoxOBJ_state.Location = new System.Drawing.Point(495, 379);
            this.comboBoxOBJ_state.Name = "comboBoxOBJ_state";
            this.comboBoxOBJ_state.Size = new System.Drawing.Size(100, 21);
            this.comboBoxOBJ_state.TabIndex = 31;
            this.comboBoxOBJ_state.Text = "true";
            // 
            // comboBoxOBJ_Type
            // 
            this.comboBoxOBJ_Type.FormattingEnabled = true;
            this.comboBoxOBJ_Type.Location = new System.Drawing.Point(495, 404);
            this.comboBoxOBJ_Type.Name = "comboBoxOBJ_Type";
            this.comboBoxOBJ_Type.Size = new System.Drawing.Size(100, 21);
            this.comboBoxOBJ_Type.TabIndex = 32;
            this.comboBoxOBJ_Type.Text = "Signaling";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(449, 430);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Tconst";
            // 
            // textBoxOBJ_Tconst
            // 
            this.textBoxOBJ_Tconst.Location = new System.Drawing.Point(495, 427);
            this.textBoxOBJ_Tconst.Name = "textBoxOBJ_Tconst";
            this.textBoxOBJ_Tconst.Size = new System.Drawing.Size(100, 20);
            this.textBoxOBJ_Tconst.TabIndex = 34;
            // 
            // textBoxOBJ_temp
            // 
            this.textBoxOBJ_temp.Location = new System.Drawing.Point(495, 450);
            this.textBoxOBJ_temp.Name = "textBoxOBJ_temp";
            this.textBoxOBJ_temp.Size = new System.Drawing.Size(100, 20);
            this.textBoxOBJ_temp.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(449, 453);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Temp";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(323, 323);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(30, 13);
            this.labelResult.TabIndex = 37;
            this.labelResult.Text = "io hk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "result";
            // 
            // buttonLoadDevices
            // 
            this.buttonLoadDevices.Location = new System.Drawing.Point(699, 353);
            this.buttonLoadDevices.Name = "buttonLoadDevices";
            this.buttonLoadDevices.Size = new System.Drawing.Size(78, 40);
            this.buttonLoadDevices.TabIndex = 39;
            this.buttonLoadDevices.Text = "Load Devices";
            this.buttonLoadDevices.UseVisualStyleBackColor = true;
            this.buttonLoadDevices.Click += new System.EventHandler(this.buttonLoadDevices_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(566, 295);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 40;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonLoadTimng
            // 
            this.buttonLoadTimng.Location = new System.Drawing.Point(699, 399);
            this.buttonLoadTimng.Name = "buttonLoadTimng";
            this.buttonLoadTimng.Size = new System.Drawing.Size(78, 40);
            this.buttonLoadTimng.TabIndex = 41;
            this.buttonLoadTimng.Text = "Load Timng";
            this.buttonLoadTimng.UseVisualStyleBackColor = true;
            this.buttonLoadTimng.Click += new System.EventHandler(this.buttonLoadTimng_Click);
            // 
            // SerialNumber
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SerialNumber.DefaultCellStyle = dataGridViewCellStyle1;
            this.SerialNumber.HeaderText = "SerialNumber";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // states
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.states.DefaultCellStyle = dataGridViewCellStyle2;
            this.states.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.states.HeaderText = "states";
            this.states.Name = "states";
            this.states.ReadOnly = true;
            this.states.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.states.ToolTipText = "Click to change the status";
            // 
            // Type
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type.DefaultCellStyle = dataGridViewCellStyle3;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Tconst
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tconst.DefaultCellStyle = dataGridViewCellStyle4;
            this.Tconst.HeaderText = "Tconst";
            this.Tconst.Name = "Tconst";
            this.Tconst.ReadOnly = true;
            this.Tconst.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Temperoture
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Temperoture.DefaultCellStyle = dataGridViewCellStyle5;
            this.Temperoture.HeaderText = "Temperoture";
            this.Temperoture.Name = "Temperoture";
            this.Temperoture.ReadOnly = true;
            this.Temperoture.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ALARM
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ALARM.DefaultCellStyle = dataGridViewCellStyle6;
            this.ALARM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ALARM.HeaderText = "ALARM";
            this.ALARM.Name = "ALARM";
            this.ALARM.ReadOnly = true;
            this.ALARM.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ShowTiming
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowTiming.DefaultCellStyle = dataGridViewCellStyle7;
            this.ShowTiming.HeaderText = "Show Timing";
            this.ShowTiming.Name = "ShowTiming";
            this.ShowTiming.ReadOnly = true;
            // 
            // delete
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.DefaultCellStyle = dataGridViewCellStyle8;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.delete.HeaderText = "delete";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete.Text = "Delete";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 481);
            this.Controls.Add(this.buttonLoadTimng);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonLoadDevices);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxOBJ_temp);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBoxOBJ_Tconst);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBoxOBJ_Type);
            this.Controls.Add(this.comboBoxOBJ_state);
            this.Controls.Add(this.textBoxOBJ_SN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelNowMinute);
            this.Controls.Add(this.labelNowHour);
            this.Controls.Add(this.labelNowDay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelMinute);
            this.Controls.Add(this.labelHour);
            this.Controls.Add(this.numericUpDownMinute);
            this.Controls.Add(this.numericUpDownHour);
            this.Controls.Add(this.comboBoxDay);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.buttonStartSimulations);
            this.Controls.Add(this.buttonStartCreate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Controller";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonStartCreate;
        private System.Windows.Forms.Button buttonStartSimulations;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.NumericUpDown numericUpDownHour;
        private System.Windows.Forms.NumericUpDown numericUpDownMinute;
        private System.Windows.Forms.Label labelHour;
        private System.Windows.Forms.Label labelMinute;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNowDay;
        private System.Windows.Forms.Label labelNowHour;
        private System.Windows.Forms.Label labelNowMinute;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxOBJ_SN;
        private System.Windows.Forms.ComboBox comboBoxOBJ_state;
        private System.Windows.Forms.ComboBox comboBoxOBJ_Type;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxOBJ_Tconst;
        private System.Windows.Forms.TextBox textBoxOBJ_temp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonLoadDevices;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonLoadTimng;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewButtonColumn states;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tconst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperoture;
        private System.Windows.Forms.DataGridViewButtonColumn ALARM;
        private System.Windows.Forms.DataGridViewButtonColumn ShowTiming;
        private System.Windows.Forms.DataGridViewButtonColumn delete;

    }
}

