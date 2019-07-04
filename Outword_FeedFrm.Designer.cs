namespace WeightSoftware
{
    partial class Outword_FeedFrm
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
            this.richTextBox1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblpartyid = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.txtnetweight = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtsecondweight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFirstWeight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtdiff = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txttotalbags = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtfeedweight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbpartyname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnget = new System.Windows.Forms.Button();
            this.lblfirstweightID = new System.Windows.Forms.Label();
            this.txtseconddate = new System.Windows.Forms.TextBox();
            this.txtsecondtime = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbentry = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbdriver = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtvechile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.txttime = new System.Windows.Forms.TextBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(162, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(365, 78);
            this.richTextBox1.TabIndex = 156;
            this.richTextBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.DimGray;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(701, 48);
            this.label14.TabIndex = 99;
            this.label14.Text = "OUTWARDS FEED (SECOND WEIGHT)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblpartyid
            // 
            this.lblpartyid.AutoSize = true;
            this.lblpartyid.Location = new System.Drawing.Point(308, 151);
            this.lblpartyid.Name = "lblpartyid";
            this.lblpartyid.Size = new System.Drawing.Size(35, 13);
            this.lblpartyid.TabIndex = 155;
            this.lblpartyid.Text = "label1";
            this.lblpartyid.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 614);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 103;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtnetweight
            // 
            this.txtnetweight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtnetweight.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnetweight.Location = new System.Drawing.Point(163, 396);
            this.txtnetweight.Name = "txtnetweight";
            this.txtnetweight.ReadOnly = true;
            this.txtnetweight.Size = new System.Drawing.Size(114, 22);
            this.txtnetweight.TabIndex = 148;
            this.txtnetweight.Text = "0";
            this.txtnetweight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Controls.Add(this.lblpartyid);
            this.groupBox3.Controls.Add(this.txtnetweight);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtsecondweight);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtFirstWeight);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtdiff);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.txttotalbags);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtfeedweight);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cmbpartyname);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnget);
            this.groupBox3.Controls.Add(this.lblfirstweightID);
            this.groupBox3.Controls.Add(this.txtseconddate);
            this.groupBox3.Controls.Add(this.txtsecondtime);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cmbentry);
            this.groupBox3.Location = new System.Drawing.Point(24, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(648, 464);
            this.groupBox3.TabIndex = 101;
            this.groupBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(18, 400);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 23);
            this.label10.TabIndex = 151;
            this.label10.Text = "Net Weight :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtsecondweight
            // 
            this.txtsecondweight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtsecondweight.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsecondweight.Location = new System.Drawing.Point(512, 364);
            this.txtsecondweight.Name = "txtsecondweight";
            this.txtsecondweight.ReadOnly = true;
            this.txtsecondweight.Size = new System.Drawing.Size(117, 22);
            this.txtsecondweight.TabIndex = 147;
            this.txtsecondweight.Text = "0";
            this.txtsecondweight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(387, 364);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 23);
            this.label11.TabIndex = 150;
            this.label11.Text = "Second Weight :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFirstWeight
            // 
            this.txtFirstWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtFirstWeight.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstWeight.Location = new System.Drawing.Point(163, 364);
            this.txtFirstWeight.Name = "txtFirstWeight";
            this.txtFirstWeight.ReadOnly = true;
            this.txtFirstWeight.Size = new System.Drawing.Size(114, 22);
            this.txtFirstWeight.TabIndex = 146;
            this.txtFirstWeight.Text = "0";
            this.txtFirstWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(18, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 23);
            this.label12.TabIndex = 149;
            this.label12.Text = "First Weight :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtdiff
            // 
            this.txtdiff.BackColor = System.Drawing.Color.Maroon;
            this.txtdiff.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiff.ForeColor = System.Drawing.Color.White;
            this.txtdiff.Location = new System.Drawing.Point(512, 396);
            this.txtdiff.Name = "txtdiff";
            this.txtdiff.ReadOnly = true;
            this.txtdiff.Size = new System.Drawing.Size(117, 22);
            this.txtdiff.TabIndex = 140;
            this.txtdiff.Text = "0";
            this.txtdiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Maroon;
            this.label19.Location = new System.Drawing.Point(390, 395);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 23);
            this.label19.TabIndex = 141;
            this.label19.Text = "Difference :";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txttotalbags
            // 
            this.txttotalbags.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txttotalbags.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalbags.Location = new System.Drawing.Point(163, 332);
            this.txttotalbags.Name = "txttotalbags";
            this.txttotalbags.ReadOnly = true;
            this.txttotalbags.Size = new System.Drawing.Size(114, 22);
            this.txttotalbags.TabIndex = 10;
            this.txttotalbags.Text = "0";
            this.txttotalbags.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Green;
            this.label16.Location = new System.Drawing.Point(18, 335);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 23);
            this.label16.TabIndex = 138;
            this.label16.Text = "Total Bags :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtfeedweight
            // 
            this.txtfeedweight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtfeedweight.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfeedweight.Location = new System.Drawing.Point(512, 332);
            this.txtfeedweight.Name = "txtfeedweight";
            this.txtfeedweight.ReadOnly = true;
            this.txtfeedweight.Size = new System.Drawing.Size(117, 22);
            this.txtfeedweight.TabIndex = 137;
            this.txtfeedweight.Text = "0";
            this.txtfeedweight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(387, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 23);
            this.label9.TabIndex = 136;
            this.label9.Text = "Feed Weight :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbpartyname
            // 
            this.cmbpartyname.BackColor = System.Drawing.Color.White;
            this.cmbpartyname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpartyname.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpartyname.FormattingEnabled = true;
            this.cmbpartyname.Location = new System.Drawing.Point(163, 172);
            this.cmbpartyname.MaxDropDownItems = 10;
            this.cmbpartyname.Name = "cmbpartyname";
            this.cmbpartyname.Size = new System.Drawing.Size(465, 22);
            this.cmbpartyname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(18, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 129;
            this.label3.Text = "Select Party Name :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(294, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 23);
            this.button1.TabIndex = 127;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnget
            // 
            this.btnget.Location = new System.Drawing.Point(551, 65);
            this.btnget.Name = "btnget";
            this.btnget.Size = new System.Drawing.Size(75, 23);
            this.btnget.TabIndex = 126;
            this.btnget.Text = "GET";
            this.btnget.UseVisualStyleBackColor = true;
            // 
            // lblfirstweightID
            // 
            this.lblfirstweightID.AutoSize = true;
            this.lblfirstweightID.Location = new System.Drawing.Point(67, 39);
            this.lblfirstweightID.Name = "lblfirstweightID";
            this.lblfirstweightID.Size = new System.Drawing.Size(41, 13);
            this.lblfirstweightID.TabIndex = 125;
            this.lblfirstweightID.Text = "label10";
            // 
            // txtseconddate
            // 
            this.txtseconddate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtseconddate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtseconddate.Location = new System.Drawing.Point(163, 140);
            this.txtseconddate.Name = "txtseconddate";
            this.txtseconddate.ReadOnly = true;
            this.txtseconddate.Size = new System.Drawing.Size(114, 22);
            this.txtseconddate.TabIndex = 123;
            this.txtseconddate.TabStop = false;
            // 
            // txtsecondtime
            // 
            this.txtsecondtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtsecondtime.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsecondtime.Location = new System.Drawing.Point(512, 141);
            this.txtsecondtime.Name = "txtsecondtime";
            this.txtsecondtime.ReadOnly = true;
            this.txtsecondtime.Size = new System.Drawing.Size(117, 22);
            this.txtsecondtime.TabIndex = 124;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Green;
            this.label13.Location = new System.Drawing.Point(435, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 23);
            this.label13.TabIndex = 122;
            this.label13.Text = "Time  :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Green;
            this.label15.Location = new System.Drawing.Point(18, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 23);
            this.label15.TabIndex = 121;
            this.label15.Text = "Date :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(18, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 96;
            this.label1.Text = "Select Vechile :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbentry
            // 
            this.cmbentry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbentry.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbentry.FormattingEnabled = true;
            this.cmbentry.Location = new System.Drawing.Point(163, 106);
            this.cmbentry.Name = "cmbentry";
            this.cmbentry.Size = new System.Drawing.Size(469, 24);
            this.cmbentry.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbdriver);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtvechile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtdate);
            this.groupBox1.Controls.Add(this.txttime);
            this.groupBox1.Controls.Add(this.lbltime);
            this.groupBox1.Controls.Add(this.lbldate);
            this.groupBox1.Location = new System.Drawing.Point(24, 520);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 85);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            // 
            // cmbdriver
            // 
            this.cmbdriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cmbdriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbdriver.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdriver.FormattingEnabled = true;
            this.cmbdriver.Items.AddRange(new object[] {
            "With Driver",
            "W/O Driver"});
            this.cmbdriver.Location = new System.Drawing.Point(518, 49);
            this.cmbdriver.Name = "cmbdriver";
            this.cmbdriver.Size = new System.Drawing.Size(121, 22);
            this.cmbdriver.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(370, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 23);
            this.label7.TabIndex = 102;
            this.label7.Text = "Weight With Driver :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtvechile
            // 
            this.txtvechile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtvechile.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvechile.Location = new System.Drawing.Point(163, 44);
            this.txtvechile.Name = "txtvechile";
            this.txtvechile.ReadOnly = true;
            this.txtvechile.Size = new System.Drawing.Size(121, 22);
            this.txtvechile.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(26, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 79;
            this.label2.Text = "Vechile No. :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtdate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Location = new System.Drawing.Point(162, 16);
            this.txtdate.Name = "txtdate";
            this.txtdate.ReadOnly = true;
            this.txtdate.Size = new System.Drawing.Size(121, 22);
            this.txtdate.TabIndex = 90;
            this.txtdate.TabStop = false;
            // 
            // txttime
            // 
            this.txttime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txttime.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttime.Location = new System.Drawing.Point(518, 16);
            this.txttime.Name = "txttime";
            this.txttime.ReadOnly = true;
            this.txttime.Size = new System.Drawing.Size(121, 22);
            this.txttime.TabIndex = 91;
            // 
            // lbltime
            // 
            this.lbltime.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.Green;
            this.lbltime.Location = new System.Drawing.Point(435, 16);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(60, 23);
            this.lbltime.TabIndex = 75;
            this.lbltime.Text = "Time  :";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbldate
            // 
            this.lbldate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.Green;
            this.lbldate.Location = new System.Drawing.Point(26, 16);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(108, 23);
            this.lbldate.TabIndex = 71;
            this.lbldate.Text = "Date :";
            this.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(597, 614);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 102;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(163, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(463, 106);
            this.dataGridView1.TabIndex = 157;
            // 
            // Outword_FeedFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 636);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Outword_FeedFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outword_FeedFrm";
            this.Load += new System.EventHandler(this.Outword_FeedFrm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label richTextBox1;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblpartyid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtnetweight;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsecondweight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFirstWeight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtdiff;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txttotalbags;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtfeedweight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbpartyname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnget;
        private System.Windows.Forms.Label lblfirstweightID;
        private System.Windows.Forms.TextBox txtseconddate;
        private System.Windows.Forms.TextBox txtsecondtime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbentry;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbdriver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtvechile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}