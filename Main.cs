using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WeightSoftware
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckMdiChildren(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == form.GetType())
                {
                    frm.Focus();
                    return;
                }
            }

            form.MdiParent = this;
            form.Show();
        }

       

        
        private void inwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InwordsReports form = new InwordsReports();
            CheckMdiChildren(form);
            
            //ReportViewer f =new ReportViewer();
            //f.crystalReportViewer1.ReportSource="D:\\WeightSoftware\\WeightSoftware\\InwardsPrint.rpt";
            //f.WindowState = FormWindowState.Maximized;
            //f.Show();
            //f.MdiParent = this;

        }


        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void firstWeightToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Inward_FirstWeight form = new Inward_FirstWeight();
            CheckMdiChildren(form);

        }

        private void secondWeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inward_SecondWeight form = new Inward_SecondWeight();
            CheckMdiChildren(form);
        }

        private void firstWeightToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Outword_FirstWeight form = new Outword_FirstWeight();
            CheckMdiChildren(form);
        }

        private void secondWeightToolStripMenuItem2_Click(object sender, EventArgs e)
        {

           

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintInvoice form = new PrintInvoice();
            form.lblHeading.Text = "INWARDS INVOICE PRINT";
            CheckMdiChildren(form);





        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintInvoice form = new PrintInvoice();
            form.lblHeading.Text = "OUTWARDS INVOICE PRINT";
            CheckMdiChildren(form);
        }

        private void eXitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inwardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InwardManualyFrm form = new InwardManualyFrm();
            CheckMdiChildren(form);
        }

        private void ourWardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutwordManaualFrm form = new OutwordManaualFrm();
            CheckMdiChildren(form);
        }

        private void newTestingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Outword_FeedFrm form = new Outword_FeedFrm();
            CheckMdiChildren(form);
        }

        private void iNWORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
        

            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            

        }

        private void fIRSTWEIGHTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inward_FirstWeight form = new Inward_FirstWeight();
            CheckMdiChildren(form);

        }

        private void sECONDWEIGHTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inward_SecondWeight form = new Inward_SecondWeight();
            CheckMdiChildren(form);
        }

        private void dELIVERYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DC form = new DC();
            CheckMdiChildren(form);
        }

        private void fIRSTWEIGHTToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Outword_FirstWeight form = new Outword_FirstWeight();
            CheckMdiChildren(form);
        }

        private void sECONDWEIGHTToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Outward_SecondWeight form = new Outward_SecondWeight();
            CheckMdiChildren(form);

        }

        private void vIEWINWARDSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewInwards form = new ViewInwards();
            CheckMdiChildren(form);

        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReportViewer f = new ReportViewer();
            f.crystalReportViewer1.ReportSource = "D:\\WeightSoftware\\WeightSoftware\\NEW\\InwardsPrint.rpt";
            f.WindowState = FormWindowState.Maximized;
            f.Show();

           // myReport form = new myReport();
           // CheckMdiChildren(form);
          
        }

        private void viewOutWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewOutwards form = new ViewOutwards();
            CheckMdiChildren(form);
        }

        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //ReportViewer f = new ReportViewer();
            //f.crystalReportViewer1.ReportSource = "D:\\WeightSoftware\\WeightSoftware\\NEW\\OutWardsPrint.rpt";
            //f.WindowState = FormWindowState.Maximized;
           // f.Show();
        }

        private void oUTWARDSToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dELIVERYCHALLANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DC form = new DC();
            CheckMdiChildren(form);
        }

        private void oUTWARDSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void otherChallanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DC_others form = new DC_others();
            CheckMdiChildren(form);
        }

        private void feedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Outward_SecondWeight form = new Outward_SecondWeight();
            CheckMdiChildren(form);
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Outward_Others form = new Outward_Others();
            CheckMdiChildren(form);
        }

        private void purchaseReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleReturnSecondWeight form = new SaleReturnSecondWeight();
            CheckMdiChildren(form);
        }

        private void pURCHASERETURNToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void saleReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleReturnFirstWeight form = new SaleReturnFirstWeight();
            CheckMdiChildren(form);
        }

    }
}
