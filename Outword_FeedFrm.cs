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
    public partial class Outword_FeedFrm : Form
    {
        // Setup the port
        private SerialPort port = new SerialPort("COM1", 4800, Parity.None, 8, StopBits.One);

        int InsertID;

        public Outword_FeedFrm()
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

        public void load_PartyName()
        {
            this.cmbpartyname.Items.Clear();

            string selectSQL = null;
            selectSQL = "select Id,(select [Name] from Dealer where [Order].DealerID=Dealer.ID) as Deaer from [Order] where StatusID=0";


            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["OrderConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(selectSQL, cn);
            SqlDataReader rd = default(SqlDataReader);

            try
            {
                cn.Open();
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    this.cmbpartyname.Items.Add(rd.GetString(1).ToString());
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

            cmd.Parameters.AddWithValue("@ID", InsertID);
            cmd.Parameters.AddWithValue("@Date", this.txtdate.Text);
            cmd.Parameters.AddWithValue("@Time", this.txttime.Text);
            cmd.Parameters.AddWithValue("@LDate", this.txtseconddate.Text);
            cmd.Parameters.AddWithValue("@LTime", this.txtsecondtime.Text);
            cmd.Parameters.AddWithValue("@VechileNo", this.txtvechile.Text);
            cmd.Parameters.AddWithValue("@PartyID", int.Parse(this.lblpartyid.Text));
            cmd.Parameters.AddWithValue("@TotalBags", int.Parse(this.txttotalbags.Text));
            cmd.Parameters.AddWithValue("@FeedWeight", int.Parse(this.txtfeedweight.Text));
            cmd.Parameters.AddWithValue("@FirstWeight", int.Parse(txtFirstWeight.Text));
            cmd.Parameters.AddWithValue("@SecondWeight", int.Parse(this.txtsecondweight.Text));
            cmd.Parameters.AddWithValue("@NetWeight", int.Parse(this.txtnetweight.Text));
            cmd.Parameters.AddWithValue("@Diffrence", int.Parse(this.txtdiff.Text));
            cmd.Parameters.AddWithValue("@Driver", cmbdriver.Text);
            cmd.Parameters.AddWithValue("@Remarks", "REM");
          //  cmd.Parameters.AddWithValue("@CellNo", txtcellnumber.Text.Trim());


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
                cmd.Parameters.AddWithValue("@TotalBags", int.Parse(this.txttotalbags.Text));
                cmd.Parameters.AddWithValue("@FeedWeight", int.Parse(this.txtfeedweight.Text));
                cmd.Parameters.AddWithValue("@FirstWeight", int.Parse(txtFirstWeight.Text));
                cmd.Parameters.AddWithValue("@SecondWeight", int.Parse(this.txtsecondweight.Text));
                cmd.Parameters.AddWithValue("@NetWeight", int.Parse(this.txtnetweight.Text));
                cmd.Parameters.AddWithValue("@Diffrence", int.Parse(this.txtdiff.Text));
                cmd.Parameters.AddWithValue("@Driver", cmbdriver.Text);
                cmd.Parameters.AddWithValue("@Remarks", "REM");
              //  cmd.Parameters.AddWithValue("@CellNo", txtcellnumber.Text.Trim());

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
            txttotalbags.Text = "0";
            cmbdriver.SelectedIndex = -1;
            cmbdriver.SelectedIndex = -1;
            txtFirstWeight.Text = "0";
            txtsecondweight.Text = "0";
            txtnetweight.Text = "0";
            txtdate.Text = "";
            txttime.Clear();
            txtvechile.Text = "";


            cmbentry.Focus();


        }



        private void Outword_FeedFrm_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            port.Close();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.txtsecondtime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
