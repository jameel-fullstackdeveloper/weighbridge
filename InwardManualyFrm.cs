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
    public partial class InwardManualyFrm : Form
    {
        public InwardManualyFrm()
        {
            InitializeComponent();
        }

        private void InwardManualyFrm_Load(object sender, EventArgs e)
        {

            timer1.Start();
            txtdate.Text = DateTime.Today.Date.ToShortDateString();


            load_PartyName();
            load_ItemName();
            cmgkindbags.SelectedIndex = 0;
            cmbdriver.SelectedIndex = 0;

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtvechile.Text == "" || txtvechile.Text == "Nil")
            {
                MessageBox.Show("Please Enter Vechile Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtvechile.Focus();
            }
            else if (txtbilty.Text == "")
            {
                MessageBox.Show("Please Enter Bilty Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbilty.Focus();
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
            else if (txtvechile.Text == "" || txtvechile.Text == "Nil")
            {
                MessageBox.Show("Please Enter the Vehcile Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtvechile.Focus();

            }

            else
            {

                DialogResult result1 = MessageBox.Show("Are you Sure to Save this?", "Verifying", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result1.ToString() == "Yes")
                {
                    Save();
                   Clear();
                }

            }
        }

        private void txtsecondweight_TextChanged(object sender, EventArgs e)
        {
            int firstweight;
            int secondweight;
            int netweight;

            if (txtsecondweight.Text != "" && txtFirstWeight.Text!="")
            {
                firstweight = int.Parse(txtFirstWeight.Text);
                secondweight = int.Parse(txtsecondweight.Text);
                netweight = firstweight - secondweight;

                txtnetweight.Text = netweight.ToString();
            }
            else
            {
            }

        }

        private void txtFirstWeight_TextChanged(object sender, EventArgs e)
        {
            int firstweight;
            int secondweight;
            int netweight;

            if (txtFirstWeight.Text != "" && txtsecondweight.Text != "")
            {

                firstweight = int.Parse(txtFirstWeight.Text);
                secondweight = int.Parse(txtsecondweight.Text);
                netweight = firstweight - secondweight;

                txtnetweight.Text = netweight.ToString();
            }
            else
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFirstWeight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtsecondweight_KeyPress(object sender, KeyPressEventArgs e)
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

        public void Save()
        {
            
            string insertSQL;
            insertSQL = "Insert into FinalWeight values(@Date,@Time,@LDate,@LTime,@VechileNo,@BiltyNo,@PartyID,@ItemID,@TotalBags,@KindsofBags,@Fare,@Driver,@PartyGross,@PartyTare,@PartyNet,@FirstWeight,@SecondWeight,@NetWeight,@Remarks,@Description,@Manually)";



            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(insertSQL, cn);

            try
            {


                cmd.Parameters.AddWithValue("@Date", this.txtdate.Text);
                cmd.Parameters.AddWithValue("@Time", this.txttime.Text);
                cmd.Parameters.AddWithValue("@LDate", this.txtdate.Text);
                cmd.Parameters.AddWithValue("@LTime", this.txttime.Text);
                cmd.Parameters.AddWithValue("@VechileNo", this.txtvechile.Text.Trim());
                cmd.Parameters.AddWithValue("@BiltyNo", this.txtbilty.Text.Trim());
                cmd.Parameters.AddWithValue("@PartyID", int.Parse(this.lblpartyid.Text));
                cmd.Parameters.AddWithValue("@ItemID", int.Parse(this.lblitemid.Text));
                cmd.Parameters.AddWithValue("@TotalBags", int.Parse(this.txtbag.Text));
                cmd.Parameters.AddWithValue("@KindsofBags", this.cmgkindbags.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Fare", int.Parse(this.txtfare.Text));
                cmd.Parameters.AddWithValue("@Driver", this.cmbdriver.SelectedItem.ToString());

                cmd.Parameters.AddWithValue("@PartyGross", 0);
                cmd.Parameters.AddWithValue("@PartyTare", 0);
                cmd.Parameters.AddWithValue("@PartyNet", 0);

                cmd.Parameters.AddWithValue("@FirstWeight", int.Parse(txtFirstWeight.Text));
                cmd.Parameters.AddWithValue("@SecondWeight", int.Parse(txtsecondweight.Text));
                cmd.Parameters.AddWithValue("@NetWeight", int.Parse(txtnetweight.Text));
                cmd.Parameters.AddWithValue("@Remarks", "FIRST COPY");
                cmd.Parameters.AddWithValue("@Description", this.txtdesc.Text.Trim());
                cmd.Parameters.AddWithValue("@Manually", "Manual Entry");
                

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
            txtbilty.Text = "Nil";
            cmbpartyname.SelectedIndex = -1;
            cmbitemname.SelectedIndex = -1;
            txtbag.Text = "0";
            cmgkindbags.SelectedIndex = 0;
            txtfare.Text = "0";
            cmbdriver.SelectedIndex = 0;
            txtFirstWeight.Text="0";
            txtsecondweight.Text = "0";
            txtnetweight.Text="0";
            txtdesc.Text = "";
            txtvechile.Focus();


        }

        private void lblpartyid_Click(object sender, EventArgs e)
        {

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

        private void cmbpartyname_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_PartyID();
        }

        private void cmbitemname_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_ItemID();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.txttime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
