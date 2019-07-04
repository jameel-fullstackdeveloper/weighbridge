namespace WeightSoftware
{
    partial class Inwardsfrm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.txttime = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbpartyname = new System.Windows.Forms.ComboBox();
            this.txtbilty = new System.Windows.Forms.TextBox();
            this.cmbitemname = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmgkindbags = new System.Windows.Forms.ComboBox();
            this.txtbag = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtvechile = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtfare = new System.Windows.Forms.TextBox();
            this.cmdsave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbdriver = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtfirstweight = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtremarks = new System.Windows.Forms.TextBox();
            this.lblitemid = new System.Windows.Forms.Label();
            this.lblpartyid = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtpartynet = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtpartytare = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtpartyweight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.DimGray;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(711, 48);
            this.label14.TabIndex = 70;
            this.label14.Text = "INWARDS (FIRST WEIGHT)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbldate
            // 
            this.lbldate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.Green;
            this.lbldate.Location = new System.Drawing.Point(14, 110);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(108, 23);
            this.lbldate.TabIndex = 71;
            this.lbldate.Text = "Date :ffff";
            this.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbltime
            // 
            this.lbltime.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.Green;
            this.lbltime.Location = new System.Drawing.Point(454, 110);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(60, 23);
            this.lbltime.TabIndex = 75;
            this.lbltime.Text = "Time  :";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txttime
            // 
            this.txttime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txttime.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttime.Location = new System.Drawing.Point(517, 110);
            this.txttime.Name = "txttime";
            this.txttime.ReadOnly = true;
            this.txttime.Size = new System.Drawing.Size(121, 22);
            this.txttime.TabIndex = 91;
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtdate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(161, 110);
            this.txtdate.Name = "txtdate";
            this.txtdate.ReadOnly = true;
            this.txtdate.Size = new System.Drawing.Size(121, 22);
            this.txtdate.TabIndex = 90;
            this.txtdate.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(14, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 79;
            this.label2.Text = "Vechile No. :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(14, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 80;
            this.label3.Text = "Select Party Name :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(14, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 82;
            this.label4.Text = "Select Item Name :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbpartyname
            // 
            this.cmbpartyname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpartyname.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpartyname.FormattingEnabled = true;
            this.cmbpartyname.Location = new System.Drawing.Point(161, 195);
            this.cmbpartyname.MaxDropDownItems = 10;
            this.cmbpartyname.Name = "cmbpartyname";
            this.cmbpartyname.Size = new System.Drawing.Size(476, 22);
            this.cmbpartyname.TabIndex = 73;
            this.cmbpartyname.SelectedIndexChanged += new System.EventHandler(this.cmbpartyname_SelectedIndexChanged);
            this.cmbpartyname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbpartyname_KeyUp);
            // 
            // txtbilty
            // 
            this.txtbilty.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbilty.Location = new System.Drawing.Point(517, 154);
            this.txtbilty.Name = "txtbilty";
            this.txtbilty.Size = new System.Drawing.Size(121, 22);
            this.txtbilty.TabIndex = 72;
            this.txtbilty.Text = "Nil";
            this.txtbilty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbilty_KeyUp);
            // 
            // cmbitemname
            // 
            this.cmbitemname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbitemname.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbitemname.FormattingEnabled = true;
            this.cmbitemname.Location = new System.Drawing.Point(161, 237);
            this.cmbitemname.Name = "cmbitemname";
            this.cmbitemname.Size = new System.Drawing.Size(187, 22);
            this.cmbitemname.TabIndex = 74;
            this.cmbitemname.SelectedIndexChanged += new System.EventHandler(this.cmbitemname_SelectedIndexChanged);
            this.cmbitemname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbitemname_KeyUp);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(14, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 84;
            this.label5.Text = "Total Bags :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(402, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 85;
            this.label6.Text = "Kinds of Bags :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmgkindbags
            // 
            this.cmgkindbags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmgkindbags.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmgkindbags.FormattingEnabled = true;
            this.cmgkindbags.Items.AddRange(new object[] {
            "None",
            "Jute",
            "Plastic",
            "Jute,Plastic"});
            this.cmgkindbags.Location = new System.Drawing.Point(526, 279);
            this.cmgkindbags.Name = "cmgkindbags";
            this.cmgkindbags.Size = new System.Drawing.Size(111, 22);
            this.cmgkindbags.TabIndex = 77;
            this.cmgkindbags.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmgkindbags_KeyUp);
            // 
            // txtbag
            // 
            this.txtbag.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbag.Location = new System.Drawing.Point(161, 279);
            this.txtbag.Name = "txtbag";
            this.txtbag.Size = new System.Drawing.Size(121, 22);
            this.txtbag.TabIndex = 76;
            this.txtbag.Text = "0";
            this.txtbag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbag.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbag_KeyUp);
            this.txtbag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbag_KeyPress);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(434, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 23);
            this.label8.TabIndex = 86;
            this.label8.Text = "Bilty No. :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtvechile
            // 
            this.txtvechile.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvechile.Location = new System.Drawing.Point(161, 154);
            this.txtvechile.Name = "txtvechile";
            this.txtvechile.Size = new System.Drawing.Size(121, 22);
            this.txtvechile.TabIndex = 70;
            this.txtvechile.Text = "Nil";
            this.txtvechile.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtvechile_KeyUp);
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Green;
            this.label17.Location = new System.Drawing.Point(16, 315);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 23);
            this.label17.TabIndex = 88;
            this.label17.Text = "Fare :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtfare
            // 
            this.txtfare.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfare.Location = new System.Drawing.Point(161, 318);
            this.txtfare.Name = "txtfare";
            this.txtfare.Size = new System.Drawing.Size(121, 22);
            this.txtfare.TabIndex = 81;
            this.txtfare.Text = "0";
            this.txtfare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtfare.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtfare_KeyUp);
            this.txtfare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfare_KeyPress);
            // 
            // cmdsave
            // 
            this.cmdsave.Enabled = false;
            this.cmdsave.Location = new System.Drawing.Point(563, 445);
            this.cmdsave.Name = "cmdsave";
            this.cmdsave.Size = new System.Drawing.Size(75, 23);
            this.cmdsave.TabIndex = 97;
            this.cmdsave.Text = "SAVE";
            this.cmdsave.UseVisualStyleBackColor = true;
            this.cmdsave.Click += new System.EventHandler(this.cmdsave_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(368, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 23);
            this.label7.TabIndex = 102;
            this.label7.Text = "Weight With Driver :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbdriver
            // 
            this.cmbdriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdriver.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdriver.FormattingEnabled = true;
            this.cmbdriver.Items.AddRange(new object[] {
            "With Driver",
            "W/O Driver"});
            this.cmbdriver.Location = new System.Drawing.Point(526, 318);
            this.cmbdriver.Name = "cmbdriver";
            this.cmbdriver.Size = new System.Drawing.Size(111, 22);
            this.cmbdriver.TabIndex = 82;
            this.cmbdriver.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbdriver_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtdesc);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtfirstweight);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtremarks);
            this.groupBox1.Controls.Add(this.lblitemid);
            this.groupBox1.Controls.Add(this.lblpartyid);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbdriver);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmdsave);
            this.groupBox1.Controls.Add(this.txtfare);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtvechile);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtbag);
            this.groupBox1.Controls.Add(this.cmgkindbags);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbitemname);
            this.groupBox1.Controls.Add(this.txtbilty);
            this.groupBox1.Controls.Add(this.cmbpartyname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.txttime);
            this.groupBox1.Controls.Add(this.lbltime);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Location = new System.Drawing.Point(26, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 482);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(354, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 23);
            this.label11.TabIndex = 113;
            this.label11.Text = "Description :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new System.Drawing.Point(455, 237);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(177, 22);
            this.txtdesc.TabIndex = 75;
            this.txtdesc.Text = "Nil";
            this.txtdesc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdesc_KeyUp);
            this.txtdesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdesc_KeyPress);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(14, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 111;
            this.label10.Text = "First Weight :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtfirstweight
            // 
            this.txtfirstweight.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstweight.Location = new System.Drawing.Point(120, 444);
            this.txtfirstweight.Name = "txtfirstweight";
            this.txtfirstweight.Size = new System.Drawing.Size(121, 22);
            this.txtfirstweight.TabIndex = 110;
            this.txtfirstweight.Text = "0";
            this.txtfirstweight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(563, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 109;
            this.button3.Text = "Get";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(161, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(365, 78);
            this.richTextBox1.TabIndex = 108;
            this.richTextBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(256, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 107;
            this.label1.Text = "Remarks :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtremarks
            // 
            this.txtremarks.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremarks.Location = new System.Drawing.Point(329, 445);
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(197, 22);
            this.txtremarks.TabIndex = 86;
            this.txtremarks.Text = "Nil";
            this.txtremarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtremarks.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtremarks_KeyUp);
            // 
            // lblitemid
            // 
            this.lblitemid.AutoSize = true;
            this.lblitemid.Location = new System.Drawing.Point(337, 218);
            this.lblitemid.Name = "lblitemid";
            this.lblitemid.Size = new System.Drawing.Size(41, 13);
            this.lblitemid.TabIndex = 105;
            this.lblitemid.Text = "label10";
            this.lblitemid.Visible = false;
            // 
            // lblpartyid
            // 
            this.lblpartyid.AutoSize = true;
            this.lblpartyid.Location = new System.Drawing.Point(334, 176);
            this.lblpartyid.Name = "lblpartyid";
            this.lblpartyid.Size = new System.Drawing.Size(35, 13);
            this.lblpartyid.TabIndex = 104;
            this.lblpartyid.Text = "label1";
            this.lblpartyid.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtpartynet);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtpartytare);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtpartyweight);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 64);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Party Weight Information";
            // 
            // txtpartynet
            // 
            this.txtpartynet.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpartynet.Location = new System.Drawing.Point(504, 24);
            this.txtpartynet.Name = "txtpartynet";
            this.txtpartynet.Size = new System.Drawing.Size(111, 22);
            this.txtpartynet.TabIndex = 85;
            this.txtpartynet.Text = "0";
            this.txtpartynet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpartynet.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtpartynet_KeyUp);
            this.txtpartynet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpartynet_KeyPress);
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Maroon;
            this.label18.Location = new System.Drawing.Point(454, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 23);
            this.label18.TabIndex = 114;
            this.label18.Text = "Net :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpartytare
            // 
            this.txtpartytare.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpartytare.Location = new System.Drawing.Point(292, 24);
            this.txtpartytare.Name = "txtpartytare";
            this.txtpartytare.Size = new System.Drawing.Size(111, 22);
            this.txtpartytare.TabIndex = 84;
            this.txtpartytare.Text = "0";
            this.txtpartytare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpartytare.TextChanged += new System.EventHandler(this.txtpartytare_TextChanged);
            this.txtpartytare.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtpartytare_KeyUp);
            this.txtpartytare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpartytare_KeyPress);
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Maroon;
            this.label16.Location = new System.Drawing.Point(239, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 23);
            this.label16.TabIndex = 113;
            this.label16.Text = "Tare :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpartyweight
            // 
            this.txtpartyweight.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpartyweight.Location = new System.Drawing.Point(70, 24);
            this.txtpartyweight.Name = "txtpartyweight";
            this.txtpartyweight.Size = new System.Drawing.Size(111, 22);
            this.txtpartyweight.TabIndex = 83;
            this.txtpartyweight.Text = "0";
            this.txtpartyweight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpartyweight.TextChanged += new System.EventHandler(this.txtpartyweight_TextChanged);
            this.txtpartyweight.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtpartyweight_KeyUp_1);
            this.txtpartyweight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpartyweight_KeyPress);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 23);
            this.label9.TabIndex = 112;
            this.label9.Text = "Gross :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 74;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 578);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 75;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Inwardsfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(711, 609);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inwardsfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SONA FEEDS : INWARDS";
            this.Load += new System.EventHandler(this.Inwardsfrm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inwardsfrm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbpartyname;
        private System.Windows.Forms.TextBox txtbilty;
        private System.Windows.Forms.ComboBox cmbitemname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmgkindbags;
        private System.Windows.Forms.TextBox txtbag;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtvechile;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtfare;
        private System.Windows.Forms.Button cmdsave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbdriver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblitemid;
        private System.Windows.Forms.Label lblpartyid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtremarks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtpartynet;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtpartytare;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtpartyweight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtfirstweight;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdesc;
    }
}