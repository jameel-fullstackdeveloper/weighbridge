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
    public partial class Inwardsfrm : Form
    {
        private SerialPort port = new SerialPort("COM1", 4800, Parity.None,8, StopBits.One);

        public Inwardsfrm()
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
        
        private void Inwardsfrm_Load(object sender, EventArgs e)
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
            txtdate.Text = DateTime.Today.Date.ToShortDateString();

            load_PartyName();
            load_ItemName();

            cmbdriver.SelectedIndex = 1;
            cmgkindbags.SelectedIndex = 0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.txttime.Text = DateTime.Now.ToLongTimeString();

        }

        private void txtvechile_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
                this.txtbilty.Focus();
        }

        private void txtbilty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.cmbpartyname.Focus();

        }

        private void cmbpartyname_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.cmbitemname.Focus();

        }

        private void cmbitemname_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtdesc.Focus();

        }

        private void txtbag_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.cmgkindbags.Focus();

        }

        private void cmgkindbags_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtfare.Focus();

        }

        private void txtpartyweight_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtfare.Focus();

        }

        private void txtfare_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.cmbdriver.Focus();

        }

        public void load_PartyName()
        {
            this.cmbpartyname.Items.Clear();

            string selectSQL = null;
            selectSQL = "Select ID,PartyName from InWordsParties order by PartyName";
            

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

        public void load_ItemName()
        {
            this.cmbitemname.Items.Clear();

            string selectSQL = null;
            selectSQL = "Select * from Items order by ItemName";


            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(selectSQL, cn);
            SqlDataReader rd = default(SqlDataReader);

            try
            {
                cn.Open();
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    this.cmbitemname.Items.Add(rd.GetString(1));
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

        public void Save()
        {
            int b = int.Parse(txtfirstweight.Text.ToString());

            string  insertSQL;
            insertSQL = "Insert into FirstWeight values(@Date,@Time,@VechileNo,@BiltyNo,@PartyID,@ItemID,@TotalBags,@KindsofBags,@Fare,@Driver,@PartyGross,@PartyTare,@PartyNet,@FirstWeight,@Remarks,@Description)";



            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(insertSQL, cn);

            try
            {
               

                cmd.Parameters.AddWithValue("@Date", this.txtdate.Text);
                cmd.Parameters.AddWithValue("@Time", this.txttime.Text);
                cmd.Parameters.AddWithValue("@VechileNo", this.txtvechile.Text.Trim());
                cmd.Parameters.AddWithValue("@BiltyNo", this.txtbilty.Text.Trim());
                cmd.Parameters.AddWithValue("@PartyID", int.Parse(this.lblpartyid.Text));
                cmd.Parameters.AddWithValue("@ItemID", int.Parse(this.lblitemid.Text));
                cmd.Parameters.AddWithValue("@TotalBags", int.Parse(this.txtbag.Text));
                cmd.Parameters.AddWithValue("@KindsofBags", this.cmgkindbags.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Fare", int.Parse(this.txtfare.Text));
                cmd.Parameters.AddWithValue("@Driver", this.cmbdriver.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PartyGross", int.Parse(this.txtpartyweight.Text));
                cmd.Parameters.AddWithValue("@PartyTare", int.Parse(txtpartytare.Text));
                cmd.Parameters.AddWithValue("@PartyNet", int.Parse(this.txtpartynet.Text));
                cmd.Parameters.AddWithValue("@FirstWeight", b);
                cmd.Parameters.AddWithValue("@Remarks", this.txtremarks.Text.Trim());
                cmd.Parameters.AddWithValue("@Description", this.txtdesc.Text.Trim());
                


                cn.Open();
                cmd.ExecuteNonQuery();
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

        public void Clear()
        {
            txtvechile.Text = "";
            txtbilty.Text = "";
            cmbpartyname.SelectedIndex = -1;
            cmbitemname.SelectedIndex=-1;
            txtbag.Text = "0";
            cmgkindbags.SelectedIndex = -1;
            txtfare.Text = "0";
            cmbdriver.SelectedIndex = -1;
            txtpartyweight.Text="0";
            txtpartytare.Text = "0";
            txtpartynet.Text = "0";
            txtvechile.Focus();
           

        }

        private void cmbdriver_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtpartyweight.Focus();
        }

        private void txtpartyweight_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtpartytare.Focus();
        }

        private void txtpartynet_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtremarks.Focus();
        }

        private void txtpartytare_KeyUp(object sender, KeyEventArgs e)
        {
            
            int fval;
            int lval;
            int finalval;

            fval = int.Parse(txtpartyweight.Text);

            if (txtpartytare.Text != "")
                lval = int.Parse(txtpartytare.Text);
            else
                lval = 0;

            finalval = fval - lval;

            txtpartynet.Text = finalval.ToString();

            if (e.KeyCode == Keys.Enter)
                this.txtpartynet.Focus();
        }

        private void txtpartyweight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtpartytare_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtpartynet_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtbag_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmdsave_Click(object sender, EventArgs e)
        {
            if (cmbpartyname.Text == "")
            {
                MessageBox.Show("Please Select the Party Name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbpartyname.Focus();
            }
            else if (cmbitemname.Text == "")
            {
                MessageBox.Show("Please Select the Item Name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbitemname.Focus();

            }
            else if (txtvechile.Text == "" || txtvechile.Text=="Nil")
            {
                MessageBox.Show("Please Enter the Vehcile Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtvechile.Focus();

            }

            else
            {

                DialogResult result1 = MessageBox.Show("Are you Sure to Save this?", "Verifying", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (result1.ToString() == "Yes")
                {
                    Save();
                    Clear();
                }

            }
        }

        private void cmbpartyname_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_PartyID();
        }

        public void load_PartyID()
        {
            this.lblpartyid.Text = "";

            string partyname;
            partyname = this.cmbpartyname.Text.Trim();


            string selectSQL = null;
            selectSQL = "Select * from InWordsParties where PartyName='" + partyname + "'";


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

        public void load_ItemID()
        {
            this.lblitemid.Text = "";

            string itemname;
            itemname = this.cmbitemname.Text.Trim();


            string selectSQL = null;
            selectSQL = "Select * from Items where ItemName='" + itemname + "'";


            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(selectSQL, cn);
            SqlDataReader rd = default(SqlDataReader);

            try
            {
                cn.Open();
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    this.lblitemid.Text = rd.GetValue(0).ToString();
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

        private void cmbitemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_ItemID();
        }

        private void txtremarks_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.cmdsave.Focus();
        }

        private void txtpartyweight_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpartytare_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnrec_Click(object sender, EventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            port.Close();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                txtfirstweight.Text = "";
                txtfirstweight.Text = richTextBox1.Text.Substring(0,7);
                cmdsave.Enabled = true;
            }

            catch (Exception f)
            {
                MessageBox.Show(f.Message.ToString());
            }

            finally
            {

            }
            
            //string a =richTextBox1.Text.Remove(6,6);
            //int b = System.Convert.ToInt32(a);
            //MessageBox.Show(b.ToString());

        }

        private void Inwardsfrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            port.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            port.Close();
        }

        private void txtdesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtdesc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.txtbag.Focus();
        }






    


    }


}
