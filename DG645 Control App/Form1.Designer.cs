namespace DG645_Control_App
{
    partial class Form_MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainScreen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtbx_port = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbx_IP = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbx_trigger = new System.Windows.Forms.GroupBox();
            this.cmbbx_trigger_mode = new System.Windows.Forms.ComboBox();
            this.cmbbx_trigger_inhibit = new System.Windows.Forms.ComboBox();
            this.mtxtbx_holdoff = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mtxtbx_trigger_level = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtbx_trigger_rate_hz = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tooltxtbx_status_connection = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusCommand = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbx_AB = new System.Windows.Forms.GroupBox();
            this.cmbx_delay_AB = new System.Windows.Forms.ComboBox();
            this.cmbx_delay_A = new System.Windows.Forms.ComboBox();
            this.rbtn_neg_AB = new System.Windows.Forms.RadioButton();
            this.rbtn_pos_AB = new System.Windows.Forms.RadioButton();
            this.mtxtbx_offset_AB = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbx_amplitude_AB = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.mtxtbx_duration_B = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbx_delay_A = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.gbx_CD = new System.Windows.Forms.GroupBox();
            this.cmbx_delay_CD = new System.Windows.Forms.ComboBox();
            this.cmbx_delay_C = new System.Windows.Forms.ComboBox();
            this.rbtn_neg_CD = new System.Windows.Forms.RadioButton();
            this.rbtn_pos_CD = new System.Windows.Forms.RadioButton();
            this.mtxtbx_offset_CD = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbx_amplitude_CD = new System.Windows.Forms.MaskedTextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.mtxtbx_duration_D = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbx_delay_C = new System.Windows.Forms.MaskedTextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.gbx_EF = new System.Windows.Forms.GroupBox();
            this.cmbx_delay_EF = new System.Windows.Forms.ComboBox();
            this.cmbx_delay_E = new System.Windows.Forms.ComboBox();
            this.rbtn_neg_EF = new System.Windows.Forms.RadioButton();
            this.rbtn_pos_EF = new System.Windows.Forms.RadioButton();
            this.mtxtbx_offset_EF = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbx_amplitude_EF = new System.Windows.Forms.MaskedTextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.mtxtbx_duration_F = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbx_delay_E = new System.Windows.Forms.MaskedTextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.gbx_GH = new System.Windows.Forms.GroupBox();
            this.cmbx_delay_GH = new System.Windows.Forms.ComboBox();
            this.cmbx_delay_G = new System.Windows.Forms.ComboBox();
            this.rbtn_neg_GH = new System.Windows.Forms.RadioButton();
            this.rbtn_pos_GH = new System.Windows.Forms.RadioButton();
            this.mtxtbx_offset_GH = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbx_amplitude_GH = new System.Windows.Forms.MaskedTextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.mtxtbx_duration_H = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbx_delay_G = new System.Windows.Forms.MaskedTextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.gbx_T0 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbtn_neg_T0 = new System.Windows.Forms.RadioButton();
            this.rbtn_pos_T0 = new System.Windows.Forms.RadioButton();
            this.mtxtbx_offset_T0 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbx_amplitude_T0 = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mtxtbx_duration_T1 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtbx_delay_T0 = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbx_trigger.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbx_AB.SuspendLayout();
            this.gbx_CD.SuspendLayout();
            this.gbx_EF.SuspendLayout();
            this.gbx_GH.SuspendLayout();
            this.gbx_T0.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_disconnect);
            this.groupBox1.Controls.Add(this.button_connect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mtxtbx_port);
            this.groupBox1.Controls.Add(this.mtxtbx_IP);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_disconnect
            // 
            resources.ApplyResources(this.button_disconnect, "button_disconnect");
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_connect
            // 
            resources.ApplyResources(this.button_connect, "button_connect");
            this.button_connect.Name = "button_connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // mtxtbx_port
            // 
            resources.ApplyResources(this.mtxtbx_port, "mtxtbx_port");
            this.mtxtbx_port.Name = "mtxtbx_port";
            // 
            // mtxtbx_IP
            // 
            resources.ApplyResources(this.mtxtbx_IP, "mtxtbx_IP");
            this.mtxtbx_IP.Name = "mtxtbx_IP";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // gbx_trigger
            // 
            this.gbx_trigger.Controls.Add(this.cmbbx_trigger_mode);
            this.gbx_trigger.Controls.Add(this.cmbbx_trigger_inhibit);
            this.gbx_trigger.Controls.Add(this.mtxtbx_holdoff);
            this.gbx_trigger.Controls.Add(this.label9);
            this.gbx_trigger.Controls.Add(this.mtxtbx_trigger_level);
            this.gbx_trigger.Controls.Add(this.label8);
            this.gbx_trigger.Controls.Add(this.mtxtbx_trigger_rate_hz);
            this.gbx_trigger.Controls.Add(this.label5);
            this.gbx_trigger.Controls.Add(this.label10);
            this.gbx_trigger.Controls.Add(this.label7);
            this.gbx_trigger.Controls.Add(this.label6);
            this.gbx_trigger.Controls.Add(this.label4);
            this.gbx_trigger.Controls.Add(this.label3);
            resources.ApplyResources(this.gbx_trigger, "gbx_trigger");
            this.gbx_trigger.Name = "gbx_trigger";
            this.gbx_trigger.TabStop = false;
            // 
            // cmbbx_trigger_mode
            // 
            this.cmbbx_trigger_mode.FormattingEnabled = true;
            this.cmbbx_trigger_mode.Items.AddRange(new object[] {
            resources.GetString("cmbbx_trigger_mode.Items"),
            resources.GetString("cmbbx_trigger_mode.Items1"),
            resources.GetString("cmbbx_trigger_mode.Items2"),
            resources.GetString("cmbbx_trigger_mode.Items3"),
            resources.GetString("cmbbx_trigger_mode.Items4"),
            resources.GetString("cmbbx_trigger_mode.Items5"),
            resources.GetString("cmbbx_trigger_mode.Items6")});
            resources.ApplyResources(this.cmbbx_trigger_mode, "cmbbx_trigger_mode");
            this.cmbbx_trigger_mode.Name = "cmbbx_trigger_mode";
            this.cmbbx_trigger_mode.SelectionChangeCommitted += new System.EventHandler(this.cmbbx_trigger_mode_SelectionChangeCommitted);
            // 
            // cmbbx_trigger_inhibit
            // 
            this.cmbbx_trigger_inhibit.FormattingEnabled = true;
            this.cmbbx_trigger_inhibit.Items.AddRange(new object[] {
            resources.GetString("cmbbx_trigger_inhibit.Items"),
            resources.GetString("cmbbx_trigger_inhibit.Items1"),
            resources.GetString("cmbbx_trigger_inhibit.Items2"),
            resources.GetString("cmbbx_trigger_inhibit.Items3"),
            resources.GetString("cmbbx_trigger_inhibit.Items4"),
            resources.GetString("cmbbx_trigger_inhibit.Items5")});
            resources.ApplyResources(this.cmbbx_trigger_inhibit, "cmbbx_trigger_inhibit");
            this.cmbbx_trigger_inhibit.Name = "cmbbx_trigger_inhibit";
            this.cmbbx_trigger_inhibit.SelectionChangeCommitted += new System.EventHandler(this.cmbbx_trigger_inhibit_SelectionChangeCommitted);
            // 
            // mtxtbx_holdoff
            // 
            resources.ApplyResources(this.mtxtbx_holdoff, "mtxtbx_holdoff");
            this.mtxtbx_holdoff.Name = "mtxtbx_holdoff";
            this.mtxtbx_holdoff.Leave += new System.EventHandler(this.mtxtbx_holdoff_Leave);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // mtxtbx_trigger_level
            // 
            resources.ApplyResources(this.mtxtbx_trigger_level, "mtxtbx_trigger_level");
            this.mtxtbx_trigger_level.Name = "mtxtbx_trigger_level";
            this.mtxtbx_trigger_level.Leave += new System.EventHandler(this.mtxtbx_trigger_level_Leave);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // mtxtbx_trigger_rate_hz
            // 
            resources.ApplyResources(this.mtxtbx_trigger_rate_hz, "mtxtbx_trigger_rate_hz");
            this.mtxtbx_trigger_rate_hz.Name = "mtxtbx_trigger_rate_hz";
            this.mtxtbx_trigger_rate_hz.Leave += new System.EventHandler(this.mtxtbx_trigger_rate_hz_Leave);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tooltxtbx_status_connection,
            this.toolStripStatusCommand});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // tooltxtbx_status_connection
            // 
            this.tooltxtbx_status_connection.Name = "tooltxtbx_status_connection";
            resources.ApplyResources(this.tooltxtbx_status_connection, "tooltxtbx_status_connection");
            // 
            // toolStripStatusCommand
            // 
            this.toolStripStatusCommand.Name = "toolStripStatusCommand";
            resources.ApplyResources(this.toolStripStatusCommand, "toolStripStatusCommand");
            this.toolStripStatusCommand.Spring = true;
            // 
            // gbx_AB
            // 
            this.gbx_AB.Controls.Add(this.cmbx_delay_AB);
            this.gbx_AB.Controls.Add(this.cmbx_delay_A);
            this.gbx_AB.Controls.Add(this.rbtn_neg_AB);
            this.gbx_AB.Controls.Add(this.rbtn_pos_AB);
            this.gbx_AB.Controls.Add(this.mtxtbx_offset_AB);
            this.gbx_AB.Controls.Add(this.mtxtbx_amplitude_AB);
            this.gbx_AB.Controls.Add(this.label21);
            this.gbx_AB.Controls.Add(this.mtxtbx_duration_B);
            this.gbx_AB.Controls.Add(this.mtxtbx_delay_A);
            this.gbx_AB.Controls.Add(this.label23);
            this.gbx_AB.Controls.Add(this.label22);
            this.gbx_AB.Controls.Add(this.label12);
            this.gbx_AB.Controls.Add(this.label25);
            this.gbx_AB.Controls.Add(this.label26);
            this.gbx_AB.Controls.Add(this.label27);
            this.gbx_AB.Controls.Add(this.label28);
            this.gbx_AB.Controls.Add(this.label29);
            this.gbx_AB.Controls.Add(this.label30);
            resources.ApplyResources(this.gbx_AB, "gbx_AB");
            this.gbx_AB.Name = "gbx_AB";
            this.gbx_AB.TabStop = false;
            // 
            // cmbx_delay_AB
            // 
            this.cmbx_delay_AB.FormattingEnabled = true;
            this.cmbx_delay_AB.Items.AddRange(new object[] {
            resources.GetString("cmbx_delay_AB.Items"),
            resources.GetString("cmbx_delay_AB.Items1"),
            resources.GetString("cmbx_delay_AB.Items2"),
            resources.GetString("cmbx_delay_AB.Items3"),
            resources.GetString("cmbx_delay_AB.Items4"),
            resources.GetString("cmbx_delay_AB.Items5")});
            resources.ApplyResources(this.cmbx_delay_AB, "cmbx_delay_AB");
            this.cmbx_delay_AB.Name = "cmbx_delay_AB";
            this.cmbx_delay_AB.SelectedIndexChanged += new System.EventHandler(this.mtxtbx_duration_B_Leave);
            // 
            // cmbx_delay_A
            // 
            this.cmbx_delay_A.FormattingEnabled = true;
            this.cmbx_delay_A.Items.AddRange(new object[] {
            resources.GetString("cmbx_delay_A.Items"),
            resources.GetString("cmbx_delay_A.Items1"),
            resources.GetString("cmbx_delay_A.Items2"),
            resources.GetString("cmbx_delay_A.Items3"),
            resources.GetString("cmbx_delay_A.Items4"),
            resources.GetString("cmbx_delay_A.Items5"),
            resources.GetString("cmbx_delay_A.Items6")});
            resources.ApplyResources(this.cmbx_delay_A, "cmbx_delay_A");
            this.cmbx_delay_A.Name = "cmbx_delay_A";
            this.cmbx_delay_A.SelectedIndexChanged += new System.EventHandler(this.mtxtbx_delay_A_Leave);
            // 
            // rbtn_neg_AB
            // 
            resources.ApplyResources(this.rbtn_neg_AB, "rbtn_neg_AB");
            this.rbtn_neg_AB.Name = "rbtn_neg_AB";
            this.rbtn_neg_AB.UseVisualStyleBackColor = true;
            this.rbtn_neg_AB.CheckedChanged += new System.EventHandler(this.rbtn_pos_AB_CheckedChanged);
            // 
            // rbtn_pos_AB
            // 
            resources.ApplyResources(this.rbtn_pos_AB, "rbtn_pos_AB");
            this.rbtn_pos_AB.Checked = true;
            this.rbtn_pos_AB.Name = "rbtn_pos_AB";
            this.rbtn_pos_AB.TabStop = true;
            this.rbtn_pos_AB.UseVisualStyleBackColor = true;
            this.rbtn_pos_AB.CheckedChanged += new System.EventHandler(this.rbtn_pos_AB_CheckedChanged);
            // 
            // mtxtbx_offset_AB
            // 
            resources.ApplyResources(this.mtxtbx_offset_AB, "mtxtbx_offset_AB");
            this.mtxtbx_offset_AB.Name = "mtxtbx_offset_AB";
            this.mtxtbx_offset_AB.Leave += new System.EventHandler(this.mtxtbx_offset_AB_Leave);
            // 
            // mtxtbx_amplitude_AB
            // 
            resources.ApplyResources(this.mtxtbx_amplitude_AB, "mtxtbx_amplitude_AB");
            this.mtxtbx_amplitude_AB.Name = "mtxtbx_amplitude_AB";
            this.mtxtbx_amplitude_AB.Leave += new System.EventHandler(this.mtxtbx_amplitude_AB_Leave);
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // mtxtbx_duration_B
            // 
            resources.ApplyResources(this.mtxtbx_duration_B, "mtxtbx_duration_B");
            this.mtxtbx_duration_B.Name = "mtxtbx_duration_B";
            this.mtxtbx_duration_B.Leave += new System.EventHandler(this.mtxtbx_duration_B_Leave);
            // 
            // mtxtbx_delay_A
            // 
            resources.ApplyResources(this.mtxtbx_delay_A, "mtxtbx_delay_A");
            this.mtxtbx_delay_A.Name = "mtxtbx_delay_A";
            this.mtxtbx_delay_A.Leave += new System.EventHandler(this.mtxtbx_delay_A_Leave);
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // label30
            // 
            resources.ApplyResources(this.label30, "label30");
            this.label30.Name = "label30";
            // 
            // gbx_CD
            // 
            this.gbx_CD.Controls.Add(this.cmbx_delay_CD);
            this.gbx_CD.Controls.Add(this.cmbx_delay_C);
            this.gbx_CD.Controls.Add(this.rbtn_neg_CD);
            this.gbx_CD.Controls.Add(this.rbtn_pos_CD);
            this.gbx_CD.Controls.Add(this.mtxtbx_offset_CD);
            this.gbx_CD.Controls.Add(this.mtxtbx_amplitude_CD);
            this.gbx_CD.Controls.Add(this.label31);
            this.gbx_CD.Controls.Add(this.mtxtbx_duration_D);
            this.gbx_CD.Controls.Add(this.mtxtbx_delay_C);
            this.gbx_CD.Controls.Add(this.label33);
            this.gbx_CD.Controls.Add(this.label32);
            this.gbx_CD.Controls.Add(this.label24);
            this.gbx_CD.Controls.Add(this.label35);
            this.gbx_CD.Controls.Add(this.label36);
            this.gbx_CD.Controls.Add(this.label37);
            this.gbx_CD.Controls.Add(this.label38);
            this.gbx_CD.Controls.Add(this.label39);
            this.gbx_CD.Controls.Add(this.label40);
            resources.ApplyResources(this.gbx_CD, "gbx_CD");
            this.gbx_CD.Name = "gbx_CD";
            this.gbx_CD.TabStop = false;
            // 
            // cmbx_delay_CD
            // 
            this.cmbx_delay_CD.FormattingEnabled = true;
            this.cmbx_delay_CD.Items.AddRange(new object[] {
            resources.GetString("cmbx_delay_CD.Items"),
            resources.GetString("cmbx_delay_CD.Items1"),
            resources.GetString("cmbx_delay_CD.Items2"),
            resources.GetString("cmbx_delay_CD.Items3"),
            resources.GetString("cmbx_delay_CD.Items4"),
            resources.GetString("cmbx_delay_CD.Items5"),
            resources.GetString("cmbx_delay_CD.Items6"),
            resources.GetString("cmbx_delay_CD.Items7")});
            resources.ApplyResources(this.cmbx_delay_CD, "cmbx_delay_CD");
            this.cmbx_delay_CD.Name = "cmbx_delay_CD";
            this.cmbx_delay_CD.SelectedIndexChanged += new System.EventHandler(this.mtxtbx_duration_D_Leave);
            this.cmbx_delay_CD.SelectionChangeCommitted += new System.EventHandler(this.cmbbx_trigger_mode_SelectionChangeCommitted);
            // 
            // cmbx_delay_C
            // 
            this.cmbx_delay_C.FormattingEnabled = true;
            this.cmbx_delay_C.Items.AddRange(new object[] {
            resources.GetString("cmbx_delay_C.Items"),
            resources.GetString("cmbx_delay_C.Items1")});
            resources.ApplyResources(this.cmbx_delay_C, "cmbx_delay_C");
            this.cmbx_delay_C.Name = "cmbx_delay_C";
            this.cmbx_delay_C.SelectedIndexChanged += new System.EventHandler(this.mtxtbx_delay_C_Leave);
            this.cmbx_delay_C.SelectionChangeCommitted += new System.EventHandler(this.cmbbx_trigger_mode_SelectionChangeCommitted);
            // 
            // rbtn_neg_CD
            // 
            resources.ApplyResources(this.rbtn_neg_CD, "rbtn_neg_CD");
            this.rbtn_neg_CD.Name = "rbtn_neg_CD";
            this.rbtn_neg_CD.UseVisualStyleBackColor = true;
            this.rbtn_neg_CD.CheckedChanged += new System.EventHandler(this.rbtn_pos_CD_CheckedChanged);
            // 
            // rbtn_pos_CD
            // 
            resources.ApplyResources(this.rbtn_pos_CD, "rbtn_pos_CD");
            this.rbtn_pos_CD.Checked = true;
            this.rbtn_pos_CD.Name = "rbtn_pos_CD";
            this.rbtn_pos_CD.TabStop = true;
            this.rbtn_pos_CD.UseVisualStyleBackColor = true;
            this.rbtn_pos_CD.CheckedChanged += new System.EventHandler(this.rbtn_pos_CD_CheckedChanged);
            // 
            // mtxtbx_offset_CD
            // 
            resources.ApplyResources(this.mtxtbx_offset_CD, "mtxtbx_offset_CD");
            this.mtxtbx_offset_CD.Name = "mtxtbx_offset_CD";
            this.mtxtbx_offset_CD.Leave += new System.EventHandler(this.mtxtbx_offset_CD_Leave);
            // 
            // mtxtbx_amplitude_CD
            // 
            resources.ApplyResources(this.mtxtbx_amplitude_CD, "mtxtbx_amplitude_CD");
            this.mtxtbx_amplitude_CD.Name = "mtxtbx_amplitude_CD";
            this.mtxtbx_amplitude_CD.Leave += new System.EventHandler(this.mtxtbx_amplitude_CD_Leave);
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.Name = "label31";
            // 
            // mtxtbx_duration_D
            // 
            resources.ApplyResources(this.mtxtbx_duration_D, "mtxtbx_duration_D");
            this.mtxtbx_duration_D.Name = "mtxtbx_duration_D";
            this.mtxtbx_duration_D.Leave += new System.EventHandler(this.mtxtbx_duration_D_Leave);
            // 
            // mtxtbx_delay_C
            // 
            resources.ApplyResources(this.mtxtbx_delay_C, "mtxtbx_delay_C");
            this.mtxtbx_delay_C.Name = "mtxtbx_delay_C";
            this.mtxtbx_delay_C.Leave += new System.EventHandler(this.mtxtbx_delay_C_Leave);
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.Name = "label33";
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // label35
            // 
            resources.ApplyResources(this.label35, "label35");
            this.label35.Name = "label35";
            // 
            // label36
            // 
            resources.ApplyResources(this.label36, "label36");
            this.label36.Name = "label36";
            // 
            // label37
            // 
            resources.ApplyResources(this.label37, "label37");
            this.label37.Name = "label37";
            // 
            // label38
            // 
            resources.ApplyResources(this.label38, "label38");
            this.label38.Name = "label38";
            // 
            // label39
            // 
            resources.ApplyResources(this.label39, "label39");
            this.label39.Name = "label39";
            // 
            // label40
            // 
            resources.ApplyResources(this.label40, "label40");
            this.label40.Name = "label40";
            // 
            // gbx_EF
            // 
            this.gbx_EF.Controls.Add(this.cmbx_delay_EF);
            this.gbx_EF.Controls.Add(this.cmbx_delay_E);
            this.gbx_EF.Controls.Add(this.rbtn_neg_EF);
            this.gbx_EF.Controls.Add(this.rbtn_pos_EF);
            this.gbx_EF.Controls.Add(this.mtxtbx_offset_EF);
            this.gbx_EF.Controls.Add(this.mtxtbx_amplitude_EF);
            this.gbx_EF.Controls.Add(this.label41);
            this.gbx_EF.Controls.Add(this.mtxtbx_duration_F);
            this.gbx_EF.Controls.Add(this.mtxtbx_delay_E);
            this.gbx_EF.Controls.Add(this.label43);
            this.gbx_EF.Controls.Add(this.label42);
            this.gbx_EF.Controls.Add(this.label34);
            this.gbx_EF.Controls.Add(this.label45);
            this.gbx_EF.Controls.Add(this.label46);
            this.gbx_EF.Controls.Add(this.label47);
            this.gbx_EF.Controls.Add(this.label48);
            this.gbx_EF.Controls.Add(this.label49);
            this.gbx_EF.Controls.Add(this.label50);
            resources.ApplyResources(this.gbx_EF, "gbx_EF");
            this.gbx_EF.Name = "gbx_EF";
            this.gbx_EF.TabStop = false;
            // 
            // cmbx_delay_EF
            // 
            this.cmbx_delay_EF.FormattingEnabled = true;
            this.cmbx_delay_EF.Items.AddRange(new object[] {
            resources.GetString("cmbx_delay_EF.Items"),
            resources.GetString("cmbx_delay_EF.Items1"),
            resources.GetString("cmbx_delay_EF.Items2"),
            resources.GetString("cmbx_delay_EF.Items3")});
            resources.ApplyResources(this.cmbx_delay_EF, "cmbx_delay_EF");
            this.cmbx_delay_EF.Name = "cmbx_delay_EF";
            this.cmbx_delay_EF.SelectedIndexChanged += new System.EventHandler(this.mtxtbx_duration_F_Leave);
            this.cmbx_delay_EF.SelectionChangeCommitted += new System.EventHandler(this.cmbbx_trigger_mode_SelectionChangeCommitted);
            // 
            // cmbx_delay_E
            // 
            this.cmbx_delay_E.FormattingEnabled = true;
            this.cmbx_delay_E.Items.AddRange(new object[] {
            resources.GetString("cmbx_delay_E.Items"),
            resources.GetString("cmbx_delay_E.Items1"),
            resources.GetString("cmbx_delay_E.Items2")});
            resources.ApplyResources(this.cmbx_delay_E, "cmbx_delay_E");
            this.cmbx_delay_E.Name = "cmbx_delay_E";
            this.cmbx_delay_E.SelectedIndexChanged += new System.EventHandler(this.mtxtbx_delay_E_Leave);
            this.cmbx_delay_E.SelectionChangeCommitted += new System.EventHandler(this.cmbbx_trigger_mode_SelectionChangeCommitted);
            // 
            // rbtn_neg_EF
            // 
            resources.ApplyResources(this.rbtn_neg_EF, "rbtn_neg_EF");
            this.rbtn_neg_EF.Name = "rbtn_neg_EF";
            this.rbtn_neg_EF.UseVisualStyleBackColor = true;
            this.rbtn_neg_EF.CheckedChanged += new System.EventHandler(this.rbtn_pos_EF_CheckedChanged);
            // 
            // rbtn_pos_EF
            // 
            resources.ApplyResources(this.rbtn_pos_EF, "rbtn_pos_EF");
            this.rbtn_pos_EF.Checked = true;
            this.rbtn_pos_EF.Name = "rbtn_pos_EF";
            this.rbtn_pos_EF.TabStop = true;
            this.rbtn_pos_EF.UseVisualStyleBackColor = true;
            this.rbtn_pos_EF.CheckedChanged += new System.EventHandler(this.rbtn_pos_EF_CheckedChanged);
            // 
            // mtxtbx_offset_EF
            // 
            resources.ApplyResources(this.mtxtbx_offset_EF, "mtxtbx_offset_EF");
            this.mtxtbx_offset_EF.Name = "mtxtbx_offset_EF";
            this.mtxtbx_offset_EF.Leave += new System.EventHandler(this.mtxtbx_offset_EF_Leave);
            // 
            // mtxtbx_amplitude_EF
            // 
            resources.ApplyResources(this.mtxtbx_amplitude_EF, "mtxtbx_amplitude_EF");
            this.mtxtbx_amplitude_EF.Name = "mtxtbx_amplitude_EF";
            this.mtxtbx_amplitude_EF.Leave += new System.EventHandler(this.mtxtbx_amplitude_EF_Leave);
            // 
            // label41
            // 
            resources.ApplyResources(this.label41, "label41");
            this.label41.Name = "label41";
            // 
            // mtxtbx_duration_F
            // 
            resources.ApplyResources(this.mtxtbx_duration_F, "mtxtbx_duration_F");
            this.mtxtbx_duration_F.Name = "mtxtbx_duration_F";
            this.mtxtbx_duration_F.Leave += new System.EventHandler(this.mtxtbx_duration_F_Leave);
            // 
            // mtxtbx_delay_E
            // 
            resources.ApplyResources(this.mtxtbx_delay_E, "mtxtbx_delay_E");
            this.mtxtbx_delay_E.Name = "mtxtbx_delay_E";
            this.mtxtbx_delay_E.Leave += new System.EventHandler(this.mtxtbx_delay_E_Leave);
            // 
            // label43
            // 
            resources.ApplyResources(this.label43, "label43");
            this.label43.Name = "label43";
            // 
            // label42
            // 
            resources.ApplyResources(this.label42, "label42");
            this.label42.Name = "label42";
            // 
            // label34
            // 
            resources.ApplyResources(this.label34, "label34");
            this.label34.Name = "label34";
            // 
            // label45
            // 
            resources.ApplyResources(this.label45, "label45");
            this.label45.Name = "label45";
            // 
            // label46
            // 
            resources.ApplyResources(this.label46, "label46");
            this.label46.Name = "label46";
            // 
            // label47
            // 
            resources.ApplyResources(this.label47, "label47");
            this.label47.Name = "label47";
            // 
            // label48
            // 
            resources.ApplyResources(this.label48, "label48");
            this.label48.Name = "label48";
            // 
            // label49
            // 
            resources.ApplyResources(this.label49, "label49");
            this.label49.Name = "label49";
            // 
            // label50
            // 
            resources.ApplyResources(this.label50, "label50");
            this.label50.Name = "label50";
            // 
            // gbx_GH
            // 
            this.gbx_GH.Controls.Add(this.cmbx_delay_GH);
            this.gbx_GH.Controls.Add(this.cmbx_delay_G);
            this.gbx_GH.Controls.Add(this.rbtn_neg_GH);
            this.gbx_GH.Controls.Add(this.rbtn_pos_GH);
            this.gbx_GH.Controls.Add(this.mtxtbx_offset_GH);
            this.gbx_GH.Controls.Add(this.mtxtbx_amplitude_GH);
            this.gbx_GH.Controls.Add(this.label51);
            this.gbx_GH.Controls.Add(this.mtxtbx_duration_H);
            this.gbx_GH.Controls.Add(this.mtxtbx_delay_G);
            this.gbx_GH.Controls.Add(this.label53);
            this.gbx_GH.Controls.Add(this.label52);
            this.gbx_GH.Controls.Add(this.label44);
            this.gbx_GH.Controls.Add(this.label55);
            this.gbx_GH.Controls.Add(this.label56);
            this.gbx_GH.Controls.Add(this.label57);
            this.gbx_GH.Controls.Add(this.label58);
            this.gbx_GH.Controls.Add(this.label59);
            this.gbx_GH.Controls.Add(this.label60);
            resources.ApplyResources(this.gbx_GH, "gbx_GH");
            this.gbx_GH.Name = "gbx_GH";
            this.gbx_GH.TabStop = false;
            // 
            // cmbx_delay_GH
            // 
            this.cmbx_delay_GH.FormattingEnabled = true;
            this.cmbx_delay_GH.Items.AddRange(new object[] {
            resources.GetString("cmbx_delay_GH.Items"),
            resources.GetString("cmbx_delay_GH.Items1"),
            resources.GetString("cmbx_delay_GH.Items2"),
            resources.GetString("cmbx_delay_GH.Items3"),
            resources.GetString("cmbx_delay_GH.Items4"),
            resources.GetString("cmbx_delay_GH.Items5"),
            resources.GetString("cmbx_delay_GH.Items6")});
            resources.ApplyResources(this.cmbx_delay_GH, "cmbx_delay_GH");
            this.cmbx_delay_GH.Name = "cmbx_delay_GH";
            this.cmbx_delay_GH.SelectedIndexChanged += new System.EventHandler(this.mtxtbx_duration_H_Leave);
            this.cmbx_delay_GH.SelectionChangeCommitted += new System.EventHandler(this.cmbbx_trigger_mode_SelectionChangeCommitted);
            // 
            // cmbx_delay_G
            // 
            this.cmbx_delay_G.FormattingEnabled = true;
            this.cmbx_delay_G.Items.AddRange(new object[] {
            resources.GetString("cmbx_delay_G.Items"),
            resources.GetString("cmbx_delay_G.Items1"),
            resources.GetString("cmbx_delay_G.Items2"),
            resources.GetString("cmbx_delay_G.Items3"),
            resources.GetString("cmbx_delay_G.Items4"),
            resources.GetString("cmbx_delay_G.Items5")});
            resources.ApplyResources(this.cmbx_delay_G, "cmbx_delay_G");
            this.cmbx_delay_G.Name = "cmbx_delay_G";
            this.cmbx_delay_G.SelectedIndexChanged += new System.EventHandler(this.mtxtbx_delay_G_Leave);
            this.cmbx_delay_G.SelectionChangeCommitted += new System.EventHandler(this.cmbbx_trigger_mode_SelectionChangeCommitted);
            // 
            // rbtn_neg_GH
            // 
            resources.ApplyResources(this.rbtn_neg_GH, "rbtn_neg_GH");
            this.rbtn_neg_GH.Name = "rbtn_neg_GH";
            this.rbtn_neg_GH.UseVisualStyleBackColor = true;
            this.rbtn_neg_GH.CheckedChanged += new System.EventHandler(this.rbtn_pos_GH_CheckedChanged);
            // 
            // rbtn_pos_GH
            // 
            resources.ApplyResources(this.rbtn_pos_GH, "rbtn_pos_GH");
            this.rbtn_pos_GH.Checked = true;
            this.rbtn_pos_GH.Name = "rbtn_pos_GH";
            this.rbtn_pos_GH.TabStop = true;
            this.rbtn_pos_GH.UseVisualStyleBackColor = true;
            this.rbtn_pos_GH.CheckedChanged += new System.EventHandler(this.rbtn_pos_GH_CheckedChanged);
            // 
            // mtxtbx_offset_GH
            // 
            resources.ApplyResources(this.mtxtbx_offset_GH, "mtxtbx_offset_GH");
            this.mtxtbx_offset_GH.Name = "mtxtbx_offset_GH";
            this.mtxtbx_offset_GH.Leave += new System.EventHandler(this.mtxtbx_offset_GH_Leave);
            // 
            // mtxtbx_amplitude_GH
            // 
            resources.ApplyResources(this.mtxtbx_amplitude_GH, "mtxtbx_amplitude_GH");
            this.mtxtbx_amplitude_GH.Name = "mtxtbx_amplitude_GH";
            this.mtxtbx_amplitude_GH.Leave += new System.EventHandler(this.mtxtbx_amplitude_GH_Leave);
            // 
            // label51
            // 
            resources.ApplyResources(this.label51, "label51");
            this.label51.Name = "label51";
            // 
            // mtxtbx_duration_H
            // 
            resources.ApplyResources(this.mtxtbx_duration_H, "mtxtbx_duration_H");
            this.mtxtbx_duration_H.Name = "mtxtbx_duration_H";
            this.mtxtbx_duration_H.Leave += new System.EventHandler(this.mtxtbx_duration_H_Leave);
            // 
            // mtxtbx_delay_G
            // 
            resources.ApplyResources(this.mtxtbx_delay_G, "mtxtbx_delay_G");
            this.mtxtbx_delay_G.Name = "mtxtbx_delay_G";
            this.mtxtbx_delay_G.Leave += new System.EventHandler(this.mtxtbx_delay_G_Leave);
            // 
            // label53
            // 
            resources.ApplyResources(this.label53, "label53");
            this.label53.Name = "label53";
            // 
            // label52
            // 
            resources.ApplyResources(this.label52, "label52");
            this.label52.Name = "label52";
            // 
            // label44
            // 
            resources.ApplyResources(this.label44, "label44");
            this.label44.Name = "label44";
            // 
            // label55
            // 
            resources.ApplyResources(this.label55, "label55");
            this.label55.Name = "label55";
            // 
            // label56
            // 
            resources.ApplyResources(this.label56, "label56");
            this.label56.Name = "label56";
            // 
            // label57
            // 
            resources.ApplyResources(this.label57, "label57");
            this.label57.Name = "label57";
            // 
            // label58
            // 
            resources.ApplyResources(this.label58, "label58");
            this.label58.Name = "label58";
            // 
            // label59
            // 
            resources.ApplyResources(this.label59, "label59");
            this.label59.Name = "label59";
            // 
            // label60
            // 
            resources.ApplyResources(this.label60, "label60");
            this.label60.Name = "label60";
            // 
            // gbx_T0
            // 
            this.gbx_T0.Controls.Add(this.comboBox2);
            this.gbx_T0.Controls.Add(this.comboBox1);
            this.gbx_T0.Controls.Add(this.rbtn_neg_T0);
            this.gbx_T0.Controls.Add(this.rbtn_pos_T0);
            this.gbx_T0.Controls.Add(this.mtxtbx_offset_T0);
            this.gbx_T0.Controls.Add(this.mtxtbx_amplitude_T0);
            this.gbx_T0.Controls.Add(this.label11);
            this.gbx_T0.Controls.Add(this.mtxtbx_duration_T1);
            this.gbx_T0.Controls.Add(this.mtxtbx_delay_T0);
            this.gbx_T0.Controls.Add(this.label13);
            this.gbx_T0.Controls.Add(this.label61);
            this.gbx_T0.Controls.Add(this.label14);
            this.gbx_T0.Controls.Add(this.label15);
            this.gbx_T0.Controls.Add(this.label16);
            this.gbx_T0.Controls.Add(this.label17);
            this.gbx_T0.Controls.Add(this.label18);
            this.gbx_T0.Controls.Add(this.label19);
            this.gbx_T0.Controls.Add(this.label20);
            resources.ApplyResources(this.gbx_T0, "gbx_T0");
            this.gbx_T0.Name = "gbx_T0";
            this.gbx_T0.TabStop = false;
            // 
            // comboBox2
            // 
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            resources.GetString("comboBox2.Items"),
            resources.GetString("comboBox2.Items1"),
            resources.GetString("comboBox2.Items2"),
            resources.GetString("comboBox2.Items3"),
            resources.GetString("comboBox2.Items4"),
            resources.GetString("comboBox2.Items5"),
            resources.GetString("comboBox2.Items6"),
            resources.GetString("comboBox2.Items7"),
            resources.GetString("comboBox2.Items8"),
            resources.GetString("comboBox2.Items9")});
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.cmbbx_trigger_mode_SelectedIndexChanged);
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.cmbbx_trigger_mode_SelectionChangeCommitted);
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2"),
            resources.GetString("comboBox1.Items3"),
            resources.GetString("comboBox1.Items4"),
            resources.GetString("comboBox1.Items5"),
            resources.GetString("comboBox1.Items6"),
            resources.GetString("comboBox1.Items7"),
            resources.GetString("comboBox1.Items8"),
            resources.GetString("comboBox1.Items9")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.cmbbx_trigger_mode_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.cmbbx_trigger_mode_SelectionChangeCommitted);
            // 
            // rbtn_neg_T0
            // 
            resources.ApplyResources(this.rbtn_neg_T0, "rbtn_neg_T0");
            this.rbtn_neg_T0.Name = "rbtn_neg_T0";
            this.rbtn_neg_T0.UseVisualStyleBackColor = true;
            this.rbtn_neg_T0.CheckedChanged += new System.EventHandler(this.rbtn_pos_T0_CheckedChanged);
            // 
            // rbtn_pos_T0
            // 
            resources.ApplyResources(this.rbtn_pos_T0, "rbtn_pos_T0");
            this.rbtn_pos_T0.Checked = true;
            this.rbtn_pos_T0.Name = "rbtn_pos_T0";
            this.rbtn_pos_T0.TabStop = true;
            this.rbtn_pos_T0.UseVisualStyleBackColor = true;
            this.rbtn_pos_T0.CheckedChanged += new System.EventHandler(this.rbtn_pos_T0_CheckedChanged);
            // 
            // mtxtbx_offset_T0
            // 
            resources.ApplyResources(this.mtxtbx_offset_T0, "mtxtbx_offset_T0");
            this.mtxtbx_offset_T0.Name = "mtxtbx_offset_T0";
            this.mtxtbx_offset_T0.Leave += new System.EventHandler(this.mtxtbx_offset_T0_Leave);
            // 
            // mtxtbx_amplitude_T0
            // 
            resources.ApplyResources(this.mtxtbx_amplitude_T0, "mtxtbx_amplitude_T0");
            this.mtxtbx_amplitude_T0.Name = "mtxtbx_amplitude_T0";
            this.mtxtbx_amplitude_T0.Leave += new System.EventHandler(this.mtxtbx_amplitude_T0_Leave);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // mtxtbx_duration_T1
            // 
            resources.ApplyResources(this.mtxtbx_duration_T1, "mtxtbx_duration_T1");
            this.mtxtbx_duration_T1.Name = "mtxtbx_duration_T1";
            this.mtxtbx_duration_T1.Leave += new System.EventHandler(this.mtxtbx_duration_T1_Leave);
            // 
            // mtxtbx_delay_T0
            // 
            resources.ApplyResources(this.mtxtbx_delay_T0, "mtxtbx_delay_T0");
            this.mtxtbx_delay_T0.Name = "mtxtbx_delay_T0";
            this.mtxtbx_delay_T0.ReadOnly = true;
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label61
            // 
            resources.ApplyResources(this.label61, "label61");
            this.label61.Name = "label61";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form_MainScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbx_GH);
            this.Controls.Add(this.gbx_EF);
            this.Controls.Add(this.gbx_CD);
            this.Controls.Add(this.gbx_T0);
            this.Controls.Add(this.gbx_AB);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbx_trigger);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_MainScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_MainScreen_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbx_trigger.ResumeLayout(false);
            this.gbx_trigger.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbx_AB.ResumeLayout(false);
            this.gbx_AB.PerformLayout();
            this.gbx_CD.ResumeLayout(false);
            this.gbx_CD.PerformLayout();
            this.gbx_EF.ResumeLayout(false);
            this.gbx_EF.PerformLayout();
            this.gbx_GH.ResumeLayout(false);
            this.gbx_GH.PerformLayout();
            this.gbx_T0.ResumeLayout(false);
            this.gbx_T0.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Button button_disconnect;
        private Button button_connect;
        private Label label2;
        private Label label1;
        private MaskedTextBox mtxtbx_IP;
        private GroupBox gbx_trigger;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel tooltxtbx_status_connection;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private MaskedTextBox mtxtbx_trigger_rate_hz;
        private MaskedTextBox mtxtbx_trigger_level;
        private MaskedTextBox mtxtbx_holdoff;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label7;
        private MaskedTextBox mtxtbx_port;
        private GroupBox gbx_AB;
        private MaskedTextBox mtxtbx_offset_AB;
        private MaskedTextBox mtxtbx_amplitude_AB;
        private Label label21;
        private MaskedTextBox mtxtbx_duration_B;
        private MaskedTextBox mtxtbx_delay_A;
        private Label label23;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private GroupBox gbx_CD;
        private MaskedTextBox mtxtbx_offset_CD;
        private MaskedTextBox mtxtbx_amplitude_CD;
        private Label label31;
        private MaskedTextBox mtxtbx_duration_D;
        private MaskedTextBox mtxtbx_delay_C;
        private Label label33;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private Label label40;
        private GroupBox gbx_EF;
        private MaskedTextBox mtxtbx_offset_EF;
        private MaskedTextBox mtxtbx_amplitude_EF;
        private Label label41;
        private MaskedTextBox mtxtbx_duration_F;
        private MaskedTextBox mtxtbx_delay_E;
        private Label label43;
        private Label label45;
        private Label label46;
        private Label label47;
        private Label label48;
        private Label label49;
        private Label label50;
        private GroupBox gbx_GH;
        private MaskedTextBox mtxtbx_offset_GH;
        private MaskedTextBox mtxtbx_amplitude_GH;
        private Label label51;
        private MaskedTextBox mtxtbx_duration_H;
        private MaskedTextBox mtxtbx_delay_G;
        private Label label53;
        private Label label55;
        private Label label56;
        private Label label57;
        private Label label58;
        private Label label59;
        private Label label60;
        private GroupBox gbx_T0;
        private MaskedTextBox mtxtbx_offset_T0;
        private MaskedTextBox mtxtbx_amplitude_T0;
        private Label label11;
        private MaskedTextBox mtxtbx_duration_T1;
        private MaskedTextBox mtxtbx_delay_T0;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private RadioButton rbtn_neg_AB;
        private RadioButton rbtn_pos_AB;
        private RadioButton rbtn_neg_CD;
        private RadioButton rbtn_pos_CD;
        private RadioButton rbtn_neg_EF;
        private RadioButton rbtn_pos_EF;
        private RadioButton rbtn_neg_GH;
        private RadioButton rbtn_pos_GH;
        private RadioButton rbtn_neg_T0;
        private RadioButton rbtn_pos_T0;
        private ComboBox cmbbx_trigger_inhibit;
        private ComboBox cmbbx_trigger_mode;
        private ToolStripStatusLabel toolStripStatusCommand;
        private Label label22;
        private Label label12;
        private Label label32;
        private Label label24;
        private Label label42;
        private Label label34;
        private Label label52;
        private Label label44;
        private ComboBox comboBox1;
        private Label label61;
        private ComboBox cmbx_delay_AB;
        private ComboBox cmbx_delay_A;
        private ComboBox cmbx_delay_CD;
        private ComboBox cmbx_delay_C;
        private ComboBox cmbx_delay_EF;
        private ComboBox cmbx_delay_E;
        private ComboBox cmbx_delay_GH;
        private ComboBox cmbx_delay_G;
        private ComboBox comboBox2;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}