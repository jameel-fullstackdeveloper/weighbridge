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
    public partial class OutwordManaualFrm : Form
    {
        public OutwordManaualFrm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.txtsecondtime.Text = DateTime.Now.ToLongTimeString();

        }

        private void OutwordManaualFrm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            txtsecondtime.Text = DateTime.Today.Date.ToShortDateString();

            load_PartyName();
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

        private void cmbpartyname_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_PartyID();
        }

        private void txttotalbags_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtsecondweight_TextChanged(object sender, EventArgs e)
        {
            int firstweight;
            int secondweight;
            int netweight;

            if (txtsecondweight.Text != "" && txtFirstWeight.Text != "")
            {
                firstweight = int.Parse(txtFirstWeight.Text);
                secondweight = int.Parse(txtsecondweight.Text);
                netweight = firstweight - secondweight;

                txtnetweight.Text = netweight.ToString();



                txtsecondweight.Text = secondweight.ToString();

                int fval = int.Parse(txtFirstWeight.Text);
                int secval = int.Parse(txtsecondweight.Text);
                int res = secval - fval;


                int feedval = int.Parse(txtfeedweight.Text);

                txtnetweight.Text = res.ToString();

                int diff = res - feedval;

                txtdiff.Text = diff.ToString();


            }
            else
            {
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtvechile.Text == "")
            {
                MessageBox.Show("Please Enter the Vechile", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtvechile.Focus();

            }
            else if (cmbdriver.Text == "")
            {
                MessageBox.Show("Please Select the Driver Weight Option", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbdriver.Focus();
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

            else if (txttotalbags.Text == "")
            {
                MessageBox.Show("Please Enter Total Bags", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txttotalbags.Focus();

            }


            else if (txtcity.Text == "")
            {
                MessageBox.Show("Please Enter City Name", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcity.Focus();

            }
            else if (txtsecondweight.Text == "0")
            {
                MessageBox.Show("Please Enter Second Weight", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsecondweight.Focus();

            }

            else if (txtnetweight.Text == "0")
            {
                MessageBox.Show("Please Enter Final Weight", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsecondweight.Focus();

            }


            else
            {

                DialogResult result1 = MessageBox.Show("Are you Sure to Save this?", "Verifying", MessageBoxButtons.YesNo);

                if (result1.ToString() == "Yes")
                {
                    Save();
                    Clear();
                }
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
                cmd.Parameters.AddWithValue("@Time", this.txtsecondtime.Text);
                cmd.Parameters.AddWithValue("@LDate", this.txtdate.Text);
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
            txtfarmername.Text = "";
            txtcity.Text = "";
            txtfare.Text = "0";
            cmbdriver.SelectedIndex = -1;
            txtFirstWeight.Text = "0";
            txtsecondweight.Text = "0";
            txtnetweight.Text = "0";
            txtdate.Text = "";
            txtDCno.Text = "";
            txtvechile.Text = "";


            txtvechile.Focus();


        }

    }
}
