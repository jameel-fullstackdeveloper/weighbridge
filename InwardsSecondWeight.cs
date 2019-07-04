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
    public partial class InwardsSecondWeight : Form
    {
        // Setup the port
        private SerialPort port = new SerialPort("COM1", 4800, Parity.None, 8, StopBits.One);

        public int InsertID;

        public InwardsSecondWeight()
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
        
        private void InwardsSecondWeight_Load(object sender, EventArgs e)
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
         
         
        }

   
        public void load_Vechile()
        {
            this.cmbentry.Items.Clear();

            string selectSQL = null;
            selectSQL = "Select * from FirstWeight order by ID desc";


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

        public void load_Entry()
        {
            int id = int.Parse(this.lblfirstweightID.Text);
            string selectSQL = null;
            selectSQL = "Select * from FirstWeight where ID=" + id + "";


            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(selectSQL, cn);
            SqlDataReader rd = default(SqlDataReader);

            try
            {
                cn.Open();
                rd = cmd.ExecuteReader();


                while (rd.Read())
                {
                    txtFirstWeight.Text = rd.GetValue(14).ToString();
                    txtdate.Text = rd.GetValue(1).ToString();
                    txttime.Text = rd.GetValue(2).ToString();
                    txtvechile.Text = rd.GetValue(3).ToString();
                    txtbilty.Text = rd.GetValue(4).ToString();

                    int partyid = int.Parse(rd.GetValue(5).ToString());
                    int itemid = int.Parse(rd.GetValue(6).ToString());

                    lblpartyid.Text = partyid.ToString();
                    lblitemid.Text = itemid.ToString();

                    txtbag.Text = rd.GetValue(7).ToString();
                    cmgkindbags.Text = rd.GetValue(8).ToString();
                    txtfare.Text = rd.GetValue(9).ToString();
                    cmbdriver.Text = rd.GetValue(10).ToString();

                    txtpartyweight.Text = rd.GetValue(11).ToString();
                    txtpartytare.Text = rd.GetValue(12).ToString();
                    txtpartynet.Text = rd.GetValue(13).ToString();

                   // cmbpartyname.SelectedIndex = partyid - 1;
                    //cmbitemname.SelectedIndex = itemid - 1;
                    txtdesc.Text = rd.GetValue(16).ToString();

                    cmbpartyname.Text = "";
                    cmbitemname.Text = "";
                    load_ComboParty(partyid);
                    load_ComboItem(itemid);



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


        public void load_ComboParty(int id)
        {
            string selectSQL = null;
            selectSQL = "Select * from InWordsParties where ID=" + id + "";

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(selectSQL, cn);
            SqlDataReader rd = default(SqlDataReader);
           

            try
            {
                cn.Open();
                rd = cmd.ExecuteReader();


                while (rd.Read())
                {
                    string partyname = rd.GetValue(1).ToString();
                    cmbpartyname.SelectedText = partyname;
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

        public void load_ComboItem(int id)
        {
            string selectSQL = null;
            selectSQL = "Select * from Items where ID=" + id + "";

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(selectSQL, cn);
            SqlDataReader rd = default(SqlDataReader);


            try
            {
                cn.Open();
                rd = cmd.ExecuteReader();


                while (rd.Read())
                {
                    string itemname = rd.GetValue(1).ToString();
                    cmbitemname.Text = itemname;
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
            
            int b = int.Parse(txtsecondweight.Text.ToString());

            string insertSQL;
            insertSQL = "Insert into FinalWeight values(@Date,@Time,@LDate,@Ltime,@VechileNo,@BiltyNo,@PartyID,@ItemID,@TotalBags,@KindsofBags,@Fare,@Driver,@PartyGross,@PartyTare,@PartyNet,@FirstWeight,@SecondWeight,@NetWeight,@Remarks,@Description,@Manually)";


            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(insertSQL, cn);
            
            try
            {
                cmd.Parameters.AddWithValue("@Date", this.txtdate.Text);
                cmd.Parameters.AddWithValue("@Time", this.txttime.Text);
                cmd.Parameters.AddWithValue("@LDate", this.txtseconddate.Text);
                cmd.Parameters.AddWithValue("@LTime", this.txtsecondtime.Text);
                cmd.Parameters.AddWithValue("@VechileNo", this.txtvechile.Text.Trim());
                cmd.Parameters.AddWithValue("@BiltyNo", this.txtbilty.Text);
                cmd.Parameters.AddWithValue("@PartyID", int.Parse(this.lblpartyid.Text));
                cmd.Parameters.AddWithValue("@ItemID", int.Parse(this.lblitemid.Text));
                cmd.Parameters.AddWithValue("@TotalBags", int.Parse(this.txtbag.Text));
                cmd.Parameters.AddWithValue("@KindsofBags", this.cmgkindbags.Text);
                cmd.Parameters.AddWithValue("@Fare", int.Parse(this.txtfare.Text));
                cmd.Parameters.AddWithValue("@Driver", this.cmbdriver.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@PartyGross", int.Parse(this.txtpartyweight.Text));
                cmd.Parameters.AddWithValue("@PartyTare", int.Parse(txtpartytare.Text));
                cmd.Parameters.AddWithValue("@PartyNet", int.Parse(this.txtpartynet.Text));
                cmd.Parameters.AddWithValue("@FirstWeight", int.Parse(this.txtFirstWeight.Text));
                cmd.Parameters.AddWithValue("@SecondWeight", int.Parse(this.txtsecondweight.Text));
                cmd.Parameters.AddWithValue("@NetWeight", int.Parse(this.txtnetweight.Text));
                cmd.Parameters.AddWithValue("@Remarks", "FIRST COPY");
                cmd.Parameters.AddWithValue("@Description", txtdesc.Text);
                cmd.Parameters.AddWithValue("@Manually", "Nil");
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

        public void Delete()
        {
            int id = int.Parse(this.lblfirstweightID.Text);
            string delSQL;
            delSQL = "Delete from FirstWeight where ID=" + id +"";


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
            txtsecondweight.Text = "";
            txtnetweight.Text = "";
            txtFirstWeight.Text = "";
            txtdate.Text = "";
            txttime.Text = "";
            txtvechile.Text = "";
            txtbilty.Text = "";
       
            txtbag.Text = "0";
            cmgkindbags.SelectedIndex = -1;
            txtfare.Text = "0";
            cmbdriver.SelectedIndex = -1;
            txtpartyweight.Text = "0";
            txtpartytare.Text = "0";
            txtpartynet.Text = "0";
            cmbentry.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.txtsecondtime.Text = DateTime.Now.ToLongTimeString();
        }

        public void load_FirstWeightID()
        {
            this.lblfirstweightID.Text = "";

            string weight;
            weight = this.cmbentry.Text.Trim();


            string selectSQL = null;
            selectSQL = "Select * from FirstWeight where VechileNo='" + weight + "'";


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

        private void cmbentry_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_FirstWeightID();
            load_Entry();
            txtsecondweight.Text = "0";
            txtnetweight.Text = "0";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnget_Click(object sender, EventArgs e)
        {
            txtsecondweight.Text = richTextBox1.Text;
            int fval=int.Parse(txtFirstWeight.Text);
            int sval=int.Parse(txtsecondweight.Text);

            int finalval = fval - sval;

            txtnetweight.Text = finalval.ToString();

            button1.Enabled = true;

            int partynet = int.Parse(txtpartynet.Text);
            int diff = partynet - finalval;

            txtdiff.Text = diff.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you Sure to Save this?","Verifying",MessageBoxButtons.YesNo);

            if (result1.ToString() == "Yes")
            {
                Save();
                Delete();
                load_Vechile();
                button1.Enabled=false;

                Print();
                Clear();

                ReportViewer f = new ReportViewer();
                f.crystalReportViewer1.ReportSource = "D:\\WeightSoftware\\WeightSoftware\\InwardsPrint.rpt";
                f.WindowState = FormWindowState.Maximized;
                f.Show();




            }


        }

        public void DeletePrePrint()
        {
            string delSQL;
            delSQL = "Delete from InWardPrint";
            
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
            insertSQL = "Insert into InWardPrint values(@ID,@Date,@Time,@LDate,@Ltime,@VechileNo,@BiltyNo,@PartyID,@ItemID,@TotalBags,@KindsofBags,@Fare,@Driver,@PartyGross,@PartyTare,@PartyNet,@FirstWeight,@SecondWeight,@NetWeight,@Remarks,@Description,@Manually)";


            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(insertSQL, cn);

            cmd.Parameters.AddWithValue("@ID", InsertID);
            cmd.Parameters.AddWithValue("@Date", this.txtdate.Text);
            cmd.Parameters.AddWithValue("@Time", this.txttime.Text);
            cmd.Parameters.AddWithValue("@LDate", this.txtseconddate.Text);
            cmd.Parameters.AddWithValue("@LTime", this.txtsecondtime.Text);
            cmd.Parameters.AddWithValue("@VechileNo", this.txtvechile.Text);
            cmd.Parameters.AddWithValue("@BiltyNo", this.txtbilty.Text);
            cmd.Parameters.AddWithValue("@PartyID", int.Parse(this.lblpartyid.Text));
            cmd.Parameters.AddWithValue("@ItemID", int.Parse(this.lblitemid.Text));
            cmd.Parameters.AddWithValue("@TotalBags", int.Parse(this.txtbag.Text));
            cmd.Parameters.AddWithValue("@KindsofBags", this.cmgkindbags.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Fare", int.Parse(this.txtfare.Text));
            cmd.Parameters.AddWithValue("@Driver", this.cmbdriver.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@PartyGross", int.Parse(this.txtpartyweight.Text));
            cmd.Parameters.AddWithValue("@PartyTare", int.Parse(txtpartytare.Text));
            cmd.Parameters.AddWithValue("@PartyNet", int.Parse(this.txtpartynet.Text));
            cmd.Parameters.AddWithValue("@FirstWeight", int.Parse(this.txtFirstWeight.Text));
            cmd.Parameters.AddWithValue("@SecondWeight", int.Parse(this.txtsecondweight.Text));
            cmd.Parameters.AddWithValue("@NetWeight", int.Parse(this.txtnetweight.Text));
            cmd.Parameters.AddWithValue("@Remarks", "FIRST COPY");
            cmd.Parameters.AddWithValue("@Description", txtdesc.Text);
            cmd.Parameters.AddWithValue("@Manually", "");

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

        private void button3_Click(object sender, EventArgs e)
        {
            port.Close();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                string a = richTextBox1.Text.Substring(0, 7);
                int b = System.Convert.ToInt32(a);

                txtsecondweight.Text = b.ToString();


                int fval = int.Parse(txtFirstWeight.Text);
                int lval = int.Parse(txtsecondweight.Text);
                int finalval = fval - lval;

                txtnetweight.Text = finalval.ToString();

                int partynet = int.Parse(txtpartynet.Text);
                int finaldiff = partynet - finalval;

                txtdiff.Text = finaldiff.ToString();

                button1.Enabled = true;

            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message.ToString());
            }
            finally
            {

            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtdiff_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
