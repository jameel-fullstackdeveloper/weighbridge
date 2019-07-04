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
    public partial class PrintInvoice : Form
    {
        public PrintInvoice()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.lblHeading.Text == "INWARDS INVOICE PRINT")
            {

                if (txtid.Text == "")
                {
                    MessageBox.Show("Enter the ID", "SONA FEEDS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Print();
                  
                }

            }

            else
            {
                PrintOUTWARDS();
               

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

            string SelectSQL;
            SelectSQL = "Select * from FinalWeight where ID=" + int.Parse(txtid.Text.Trim()) + "";

            string insertSQL;
            insertSQL = "Insert into InWardPrint values(@ID,@Date,@Time,@LDate,@Ltime,@VechileNo,@BiltyNo,@PartyID,@ItemID,@TotalBags,@KindsofBags,@Fare,@Driver,@PartyGross,@PartyTare,@PartyNet,@FirstWeight,@SecondWeight,@NetWeight,@Remarks,@Description,@Manually)";
            
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
                       cmd.Parameters.AddWithValue("@Remarks", "DUPLICATE COPY");
                        //cmd.Parameters.AddWithValue("@Remarks", "FIRST COPY");
                        cmd.Parameters.AddWithValue("@Description", rd.GetValue(20).ToString());
                        cmd.Parameters.AddWithValue("@Manually", rd.GetValue(21).ToString());
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

            ReportViewer f = new ReportViewer();
            f.crystalReportViewer1.ReportSource = "D:\\WeightSoftware\\WeightSoftware\\InwardsPrint.rpt";
            f.WindowState = FormWindowState.Maximized;
            f.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void DeletePrePrintOUTWARDS()
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

        public void PrintOUTWARDS()
        {

            DeletePrePrintOUTWARDS();

            string SelectSQL;
            SelectSQL = "Select * from OutWardsFinalWeight where ID=" + int.Parse(txtid.Text.Trim()) + "";


            string insertSQL;
            insertSQL = "Insert into OutWardsPrint values(@ID,@Date,@Time,@LDate,@Ltime,@VechileNo,@PartyID,@Item,@FarmerName,@City,@DCNo,@Fare,@Bag01,@Bag02,@Bag03,@TotalBags,@FeedWeight,@FirstWeight,@SecondWeight,@NetWeight,@Diffrence,@Driver,@Remarks,@CellNo)";


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
                        cmd.Parameters.AddWithValue("@PartyID", int.Parse(rd.GetValue(6).ToString()));
                        cmd.Parameters.AddWithValue("@Item", rd.GetValue(7).ToString());
                        cmd.Parameters.AddWithValue("@FarmerName", rd.GetValue(8).ToString());
                        cmd.Parameters.AddWithValue("@City", rd.GetValue(9).ToString());
                        cmd.Parameters.AddWithValue("@DCNo", rd.GetValue(10).ToString());
                        cmd.Parameters.AddWithValue("@Fare", int.Parse(rd.GetValue(11).ToString()));
                        cmd.Parameters.AddWithValue("@Bag01", int.Parse(rd.GetValue(12).ToString()));
                        cmd.Parameters.AddWithValue("@Bag02", int.Parse(rd.GetValue(13).ToString()));
                        cmd.Parameters.AddWithValue("@Bag03", int.Parse(rd.GetValue(14).ToString()));
                        cmd.Parameters.AddWithValue("@TotalBags", int.Parse(rd.GetValue(15).ToString()));
                        cmd.Parameters.AddWithValue("@FeedWeight", int.Parse(rd.GetValue(16).ToString()));
                        cmd.Parameters.AddWithValue("@FirstWeight", int.Parse(rd.GetValue(17).ToString()));
                        cmd.Parameters.AddWithValue("@SecondWeight", int.Parse(rd.GetValue(18).ToString()));
                        cmd.Parameters.AddWithValue("@NetWeight", int.Parse(rd.GetValue(19).ToString()));
                        cmd.Parameters.AddWithValue("@Diffrence", int.Parse(rd.GetValue(20).ToString()));
                        cmd.Parameters.AddWithValue("@Driver", rd.GetValue(21).ToString());
                        cmd.Parameters.AddWithValue("@Remarks", rd.GetValue(22).ToString());
                        cmd.Parameters.AddWithValue("@CellNo", rd.GetValue(23).ToString());

                        

                    }
                }
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message.ToString());

            }

            finally
            {
                cn.Close();
            }

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


            ReportViewer f = new ReportViewer();
            f.crystalReportViewer1.ReportSource = "D:\\WeightSoftware\\WeightSoftware\\OutWardsPrint.rpt";
            f.WindowState = FormWindowState.Maximized;
            f.Show();



        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
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

        private void PrintInvoice_Load(object sender, EventArgs e)
        {

        }


    }
}
