using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO.Ports;
using System.Threading;

namespace WeightSoftware
{
    public partial class OutWardsSecondWeight : Form
    {
        // Setup the port
        private SerialPort port = new SerialPort("COM1", 4800, Parity.None, 8, StopBits.One);

        int InsertID;

        public OutWardsSecondWeight()
        {
            InitializeComponent();
            port.DtrEnable = true;
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(DoUpdate));
        }

        private void DoUpdate(object s, EventArgs e)
        {
            Thread.Sleep(35);
            string data = port.ReadExisting() + port.ReadExisting();
            try
            {
                richTextBox1.Text = data.Trim().Remove(0, 3);

            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message.ToString());
            }
            


        }

        private void txtbag01_KeyUp(object sender, KeyEventArgs e)
        {
            int fval;
            int lval;
            int thval;
            int finalval;


            if (txtbag01.Text != "")
                fval = int.Parse(txtbag01.Text);
            else
                fval = 0;

            if (txtbag02.Text != "")
                lval = int.Parse(txtbag02.Text);
            else
                lval = 0;

            if (txtbag03.Text != "")
                thval = int.Parse(txtbag03.Text);
            else
                thval = 0;

            finalval = fval + lval + thval;

            txttotalbags.Text = finalval.ToString();


            if (e.KeyCode == Keys.Enter)
                this.txtbag02.Focus();

        }

        private void txtbag02_KeyUp(object sender, KeyEventArgs e)
        {
            int fval;
            int lval;
            int thval;
            int finalval;

            fval = int.Parse(txtbag01.Text);

            if (txtbag02.Text != "")
                lval = int.Parse(txtbag02.Text);
            else
                lval = 0;

            if (txtbag03.Text != "")
                thval = int.Parse(txtbag03.Text);
            else
                thval = 0;

            finalval = fval + lval + thval;

            txttotalbags.Text = finalval.ToString();

            if (e.KeyCode == Keys.Enter)
                this.txtbag03.Focus();

        }

        private void txtbag03_KeyUp(object sender, KeyEventArgs e)
        {
            int fval;
            int lval;
            int thval;
            int finalval;

            fval = int.Parse(txtbag01.Text);

            if (txtbag02.Text != "")
                lval = int.Parse(txtbag02.Text);
            else
                lval = 0;

            if (txtbag03.Text != "")
                thval = int.Parse(txtbag03.Text);
            else
                thval = 0;

            finalval = fval + lval + thval;

            txttotalbags.Text = finalval.ToString();

            if (e.KeyCode == Keys.Enter)
                this.button1.Focus();

        }

        private void txttotalbags_TextChanged(object sender, EventArgs e)
        {
            int tbags = int.Parse(txttotalbags.Text);
            int tweight = tbags * 50;

            txtfeedweight.Text = tweight.ToString();
        }

        public void load_PartyName()
        {
            this.cmbpartyname.Items.Clear();

            string selectSQL = null;
            selectSQL = "Select ID,PartyName from OutWordsParties order by ID";


            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(selectSQL, cn);
            SqlDataReader rd = default(SqlDataReader);

            try
            {
                cn.Open();
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    this.cmbpartyname.Items.Add(rd.GetString(1));
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }


        }

        private void OutWardsSecondWeight_Load(object sender, EventArgs e)
        {
            if (port.IsOpen == false)
                try
                {
                    port.Open();
                }

                catch (Exception oex)
                {
                    MessageBox.Show(oex.ToString());
                }

            timer1.Start();
            txtseconddate.Text = DateTime.Today.Date.ToShortDateString();

            load_Vechile();
            load_PartyName();

            cmbentry.Focus();

        }

        public void load_Vechile()
        {
            this.cmbentry.Items.Clear();

            string selectSQL = null;
            selectSQL = "Select * from OutWardsFirstWeight order by ID";


            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(selectSQL, cn);
            SqlDataReader rd = default(SqlDataReader);

            try
            {
                cn.Open();
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    this.cmbentry.Items.Add(rd.GetValue(3));
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }


        }

        public void load_FirstWeightID()
        {
            this.lblfirstweightID.Text = "";

            string weight;
            weight = this.cmbentry.Text.Trim();


            string selectSQL = null;
            selectSQL = "Select * from OutWardsFirstWeight where VechileNo='" + weight + "'";

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(selectSQL, cn);
            SqlDataReader rd = default(SqlDataReader);

            try
            {
                cn.Open();
                rd = cmd.ExecuteReader();
                

                while (rd.Read())
                {
                    this.lblfirstweightID.Text = rd.GetValue(0).ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }


        }
        
        public void load_Entry()
        {
            int id = int.Parse(this.lblfirstweightID.Text);
            string selectSQL = null;
            selectSQL = "Select * from OutWardsFirstWeight where ID=" + id + "";


            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(selectSQL, cn);
            SqlDataReader rd = default(SqlDataReader);

            try
            {
                cn.Open();
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    txtFirstWeight.Text = rd.GetValue(4).ToString();
                    txtdate.Text = rd.GetValue(1).ToString();
                    txttime.Text = rd.GetValue(2).ToString();
                    txtvechile.Text = rd.GetValue(3).ToString();
                    cmbdriver.Text = rd.GetValue(5).ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }


        }

        private void cmbentry_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_FirstWeightID();
            load_Entry();
            button1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.txtsecondtime.Text = DateTime.Now.ToLongTimeString();

        }

        private void btnget_Click(object sender, EventArgs e)
        {
            try
            {
                string a = richTextBox1.Text.Substring(0, 7);
                int b = System.Convert.ToInt32(a);

                txtsecondweight.Text = b.ToString();

                int fval = int.Parse(txtFirstWeight.Text);
                int secval = int.Parse(txtsecondweight.Text);
                int res = secval - fval;


                int feedval = int.Parse(txtfeedweight.Text);

                txtnetweight.Text = res.ToString();

                int diff = res - feedval;

                txtdiff.Text = diff.ToString();

                if (diff > 0)
                {
                    txtdiff.BackColor = Color.Red;
                    txtdiff.ForeColor = Color.White;
                }
                else
                {
                    txtdiff.BackColor = Color.White;
                    txtdiff.ForeColor = Color.Black;

                }

            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message.ToString());

            }

            finally
            {

            }






        }

        private void cmbpartyname_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.cmbitemname.Focus();
        }

        private void cmbitemname_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtfarmername.Focus();
        }

        private void txtfarmername_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtcity.Focus();
        }

        private void txtDCno_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtfare.Focus();
        }

        private void txtcity_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtDCno.Focus();
        }

        private void txtfare_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtbag01.Focus();
        }

        private void txtfare_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtbag01_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtbag02_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtbag03_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
              if (cmbentry.Text == "")
            {
                MessageBox.Show("Please Select the Vechile","Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbentry.Focus();

            }
            else if (cmbpartyname.Text == "")
            {
                MessageBox.Show("Please Select the Party Name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbpartyname.Focus();
            }
            else if (cmbitemname.Text == "")
            {
                MessageBox.Show("Please Select the Item Name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbitemname.Focus();

            }
            else if (txtfarmername.Text == "")
            {
                MessageBox.Show("Please Enter Farmer Name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfarmername.Focus();

            }

              else if (txtDCno.Text == "")
            {
                MessageBox.Show("Please Enter D.C Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDCno.Focus();

            }

                  
            else if (txtcity.Text == "")
            {
                MessageBox.Show("Please Enter City Name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcity.Focus();

            }
              else if (txtsecondweight.Text == "0")
              {
                  MessageBox.Show("Please Enter Second Weight Name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  txtsecondweight.Focus();

              }


            else{

            DialogResult result1 = MessageBox.Show("Are you Sure to Save this?", "Verifying", MessageBoxButtons.YesNo);

            if (result1.ToString() == "Yes")
            {
                Save();
                Delete();
                load_Vechile();
                button1.Enabled = false;

                Print();
                Clear();

                ReportViewer f = new ReportViewer();
                f.crystalReportViewer1.ReportSource = "D:\\WeightSoftware\\WeightSoftware\\OutWardsPrint.rpt";
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }



    }

        public void DeletePrePrint()
        {
            string delSQL;
            delSQL = "Delete from OutWardsPrint";

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(delSQL, cn);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public void Print()
        {
            DeletePrePrint();

            string insertSQL;
            insertSQL = "Insert into OutWardsPrint values(@ID,@Date,@Time,@LDate,@Ltime,@VechileNo,@PartyID,@Item,@FarmerName,@City,@DCNo,@Fare,@Bag01,@Bag02,@Bag03,@TotalBags,@FeedWeight,@FirstWeight,@SecondWeight,@NetWeight,@Diffrence,@Driver,@Remarks,@CellNo)";


            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(insertSQL, cn);

            cmd.Parameters.AddWithValue("@ID",InsertID);
            cmd.Parameters.AddWithValue("@Date", this.txtdate.Text);
            cmd.Parameters.AddWithValue("@Time", this.txttime.Text);
            cmd.Parameters.AddWithValue("@LDate", this.txtseconddate.Text);
            cmd.Parameters.AddWithValue("@LTime", this.txtsecondtime.Text);
            cmd.Parameters.AddWithValue("@VechileNo", this.txtvechile.Text);
            cmd.Parameters.AddWithValue("@PartyID", int.Parse(this.lblpartyid.Text));
            cmd.Parameters.AddWithValue("@Item", cmbitemname.Text);
            cmd.Parameters.AddWithValue("@FarmerName", txtfarmername.Text);
            cmd.Parameters.AddWithValue("@City", txtcity.Text);
            cmd.Parameters.AddWithValue("@DCNo", txtDCno.Text);
            cmd.Parameters.AddWithValue("@Fare", int.Parse(this.txtfare.Text));
            cmd.Parameters.AddWithValue("@Bag01", int.Parse(this.txtbag01.Text));
            cmd.Parameters.AddWithValue("@Bag02", int.Parse(this.txtbag02.Text));
            cmd.Parameters.AddWithValue("@Bag03", int.Parse(this.txtbag03.Text));
            cmd.Parameters.AddWithValue("@TotalBags", int.Parse(this.txttotalbags.Text));
            cmd.Parameters.AddWithValue("@FeedWeight", int.Parse(this.txtfeedweight.Text));
            cmd.Parameters.AddWithValue("@FirstWeight", int.Parse(txtFirstWeight.Text));
            cmd.Parameters.AddWithValue("@SecondWeight", int.Parse(this.txtsecondweight.Text));
            cmd.Parameters.AddWithValue("@NetWeight", int.Parse(this.txtnetweight.Text));
            cmd.Parameters.AddWithValue("@Diffrence", int.Parse(this.txtdiff.Text));
            cmd.Parameters.AddWithValue("@Driver", cmbdriver.Text);
            cmd.Parameters.AddWithValue("@Remarks", "REM");
            cmd.Parameters.AddWithValue("@CellNo", txtcellnumber.Text.Trim());

            
            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Record Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }


        }
                        
        public void Save()
        {

            string insertSQL;
            insertSQL = "Insert into OutWardsFinalWeight values(@Date,@Time,@LDate,@Ltime,@VechileNo,@PartyID,@Item,@FarmerName,@City,@DCNo,@Fare,@Bag01,@Bag02,@Bag03,@TotalBags,@FeedWeight,@FirstWeight,@SecondWeight,@NetWeight,@Diffrence,@Driver,@Remarks,@CellNo)";


            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(insertSQL, cn);

            
            try
            {
               

                cmd.Parameters.AddWithValue("@Date", this.txtdate.Text);
                cmd.Parameters.AddWithValue("@Time", this.txttime.Text);
                cmd.Parameters.AddWithValue("@LDate", this.txtseconddate.Text);
                cmd.Parameters.AddWithValue("@LTime", this.txtsecondtime.Text);
                cmd.Parameters.AddWithValue("@VechileNo", this.txtvechile.Text.Trim());
                cmd.Parameters.AddWithValue("@PartyID", int.Parse(this.lblpartyid.Text));
                cmd.Parameters.AddWithValue("@Item", cmbitemname.Text);
                cmd.Parameters.AddWithValue("@FarmerName", txtfarmername.Text);
                cmd.Parameters.AddWithValue("@City", txtcity.Text);
                cmd.Parameters.AddWithValue("@DCNo", txtDCno.Text);
                cmd.Parameters.AddWithValue("@Fare", int.Parse(this.txtfare.Text));
                cmd.Parameters.AddWithValue("@Bag01", int.Parse(this.txtbag01.Text));
                cmd.Parameters.AddWithValue("@Bag02", int.Parse(this.txtbag02.Text));
                cmd.Parameters.AddWithValue("@Bag03", int.Parse(this.txtbag03.Text));
                cmd.Parameters.AddWithValue("@TotalBags", int.Parse(this.txttotalbags.Text));
                cmd.Parameters.AddWithValue("@FeedWeight", int.Parse(this.txtfeedweight.Text));
                cmd.Parameters.AddWithValue("@FirstWeight", int.Parse(txtFirstWeight.Text));
                cmd.Parameters.AddWithValue("@SecondWeight", int.Parse(this.txtsecondweight.Text));
                cmd.Parameters.AddWithValue("@NetWeight", int.Parse(this.txtnetweight.Text));
                cmd.Parameters.AddWithValue("@Diffrence", int.Parse(this.txtdiff.Text));
                cmd.Parameters.AddWithValue("@Driver", cmbdriver.Text);
                cmd.Parameters.AddWithValue("@Remarks", "REM");
                cmd.Parameters.AddWithValue("@CellNo", txtcellnumber.Text.Trim());

                cn.Open();
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT @@IDENTITY";

                // Get the last inserted id.
                InsertID = Convert.ToInt32(cmd.ExecuteScalar());

                cmd.Dispose();
                cmd = null;

                MessageBox.Show("Record Saved Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }


        }

        public void load_PartyID()
        {
            this.lblpartyid.Text = "";

            string partyname;
            partyname = this.cmbpartyname.Text.Trim();


            string selectSQL = null;
            selectSQL = "Select * from OutWordsParties where PartyName='" + partyname + "'";


            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(selectSQL, cn);
            SqlDataReader rd = default(SqlDataReader);

            try
            {
                cn.Open();
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    this.lblpartyid.Text = rd.GetValue(0).ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }


        }

        public void Delete()
        {
            int id = int.Parse(this.lblfirstweightID.Text);
            string delSQL;
            delSQL = "Delete from OutWardsFirstWeight where ID=" + id + "";


            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(delSQL, cn);

            try
            {
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }


        }

        public void Clear()
        {
            txtvechile.Text = "";
            txtbag01.Text = "0";
            txtbag02.Text = "0";
            txtbag03.Text = "0";
            txttotalbags.Text = "0";
            cmbdriver.SelectedIndex = -1;
            cmbitemname.SelectedIndex = -1;
            cmbpartyname.SelectedIndex = -1;
            txtfarmername.Text="";
            txtcity.Text = "";
            txtfare.Text = "0";
            cmbdriver.SelectedIndex = -1;
            txtFirstWeight.Text = "0";
            txtsecondweight.Text = "0";
            txtnetweight.Text = "0";
            txtdate.Text = "";
            txttime.Clear();
            txtDCno.Text = "";
            txtvechile.Text="";


            cmbentry.Focus();


        }

        private void cmbpartyname_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_PartyID();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            port.Close();
            this.Close();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

    }


}
