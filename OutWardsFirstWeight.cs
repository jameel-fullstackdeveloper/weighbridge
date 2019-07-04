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
    public partial class OutWardsFirstWeight : Form
    {
        // Setup the port
        private SerialPort port = new SerialPort("COM1", 4800, Parity.None, 8, StopBits.One);

        public OutWardsFirstWeight()
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

        private void OutWardsFirstWeight_Load(object sender, EventArgs e)
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.txttime.Text = DateTime.Now.ToLongTimeString();
        }

        private void cmdsave_Click(object sender, EventArgs e)
        {
            if (txtvechile.Text == "" || txtvechile.Text=="Nil")
            {
                MessageBox.Show("Please Enter the Vechile Number", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtvechile.Focus();
            }
            else if (cmbdriver.Text == "")
            {
                MessageBox.Show("Please Select the Driver Option", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbdriver.Focus();

            }
            else
            {
                Save();
                Clear();

            }
        }


        public void Save()
        {
            int b = int.Parse(txtweight.Text.ToString());

            string insertSQL;
            insertSQL = "Insert into OutWardsFirstWeight values(@Date,@Time,@VechileNo,@FirstWeight,@Driver)";


            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString.ToString());
            SqlCommand cmd = new SqlCommand(insertSQL, cn);

            cmd.Parameters.AddWithValue("@Date", this.txtdate.Text);
            cmd.Parameters.AddWithValue("@Time", this.txttime.Text);
            cmd.Parameters.AddWithValue("@VechileNo", this.txtvechile.Text.Trim());
            cmd.Parameters.AddWithValue("@FirstWeight", b);
            cmd.Parameters.AddWithValue("@Driver", this.cmbdriver.Text);

            try
            {
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
            cmbdriver.SelectedIndex = -1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            port.Close();
            this.Close();

        }

        private void btnget_Click(object sender, EventArgs e)
        {
            try
            {
                txtweight.Text = "";
                txtweight.Text = richTextBox1.Text.Substring(0, 7);
                cmdsave.Enabled = true;
            }
            catch (Exception h)
            {
                MessageBox.Show(h.Message.ToString());
            }

            finally
            {

            }
        }

        private void txtvechile_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode==Keys.Enter)
                this.cmbdriver.Focus();
        
        }

     
    }
}
