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

namespace WeightSoftware
{
    public partial class InwordsReports : Form
    {
        public InwordsReports()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void load_PartyName()
        {
            this.cmbpartyname.Items.Clear();

            string selectSQL = null;
            selectSQL = "Select ID,PartyName from InWordsParties order by ID";


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
            selectSQL = "Select * from Items order by ID";


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

        private void InwordsReports_Load(object sender, EventArgs e)
        {
            load_PartyName();

            load_ItemName();
        }

        private void btnsingdate_Click(object sender, EventArgs e)
        {
            if (txtsingleDate.Text == "")
            {
                MessageBox.Show("Enter Date", "SONA FEEDS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DateTime dt = Convert.ToDateTime(txtsingleDate.Text);
                Print(dt);
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

        public void Print(DateTime dt)
        {
            DeletePrePrint();

            string SelectSQL;
            SelectSQL = "Select * from FinalWeight where Date='04-Jul-2011 12:00:00 AM'";

            string insertSQL;
            insertSQL = "Insert into InWardPrint values(@ID,@Date,@Time,@LDate,@Ltime,@VechileNo,@BiltyNo,@PartyID,@ItemID,@TotalBags,@KindsofBags,@Fare,@Driver,@PartyGross,@PartyTare,@PartyNet,@FirstWeight,@SecondWeight,@NetWeight,@Remarks)";

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd1 = new SqlCommand(SelectSQL, cn);
            SqlCommand cmd = new SqlCommand(insertSQL, cn);

            SqlDataReader rd = default(SqlDataReader);

            try
            {
                cn.Open();
                rd = cmd1.ExecuteReader();


                if (!rd.HasRows)
                {
                    MessageBox.Show("Record not Found", "SONA FEEDS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    rd.Close();
                    return;
                }
                else
                {

                    while (rd.Read())
                    {
                        cmd.Parameters.AddWithValue("@ID", int.Parse(rd.GetValue(0).ToString()));
                        cmd.Parameters.AddWithValue("@Date", rd.GetDateTime(1).ToShortDateString());
                        cmd.Parameters.AddWithValue("@Time", rd.GetValue(2).ToString());
                        cmd.Parameters.AddWithValue("@LDate", rd.GetValue(3).ToString());
                        cmd.Parameters.AddWithValue("@LTime", rd.GetValue(4).ToString());
                        cmd.Parameters.AddWithValue("@VechileNo", rd.GetValue(5).ToString());
                        cmd.Parameters.AddWithValue("@BiltyNo", rd.GetValue(6).ToString());
                        cmd.Parameters.AddWithValue("@PartyID", int.Parse(rd.GetValue(7).ToString()));
                        cmd.Parameters.AddWithValue("@ItemID", int.Parse(rd.GetValue(8).ToString()));
                        cmd.Parameters.AddWithValue("@TotalBags", int.Parse(rd.GetValue(9).ToString()));
                        cmd.Parameters.AddWithValue("@KindsofBags", rd.GetValue(10).ToString());
                        cmd.Parameters.AddWithValue("@Fare", int.Parse(rd.GetValue(11).ToString()));
                        cmd.Parameters.AddWithValue("@Driver", rd.GetValue(12).ToString());
                        cmd.Parameters.AddWithValue("@PartyGross", int.Parse(rd.GetValue(13).ToString()));
                        cmd.Parameters.AddWithValue("@PartyTare", int.Parse(rd.GetValue(14).ToString()));
                        cmd.Parameters.AddWithValue("@PartyNet", int.Parse(rd.GetValue(15).ToString()));
                        cmd.Parameters.AddWithValue("@FirstWeight", int.Parse(rd.GetValue(16).ToString()));
                        cmd.Parameters.AddWithValue("@SecondWeight", int.Parse(rd.GetValue(17).ToString()));
                        cmd.Parameters.AddWithValue("@NetWeight", int.Parse(rd.GetValue(18).ToString()));
                        cmd.Parameters.AddWithValue("@Remarks", "REM");

                    }

                   
                }

            }

            catch (Exception y)
            {
                MessageBox.Show(y.Message.ToString());
            }

            finally
            {
                cn.Close();
            }


            try
            {
               // cn.Open();
              //  cmd.ExecuteNonQuery();
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

            //ReportViewer f = new ReportViewer();
            //f.crystalReportViewer1.ReportSource = "D:\\WeightSoftware\\WeightSoftware\\InwardsPrint.rpt";
            //f.WindowState = FormWindowState.Maximized;
            //f.Show();


        }

       

    }
}
