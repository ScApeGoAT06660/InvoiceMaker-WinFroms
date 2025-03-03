using InvoiceMaker.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using InvoiceMaker.Services;
using InvoiceMaker.Domains;

namespace InvoiceMaker
{
    public partial class frmInvoice : Form
    {
        MRiFController mrifController;

        public frmInvoice()
        {
            InitializeComponent();
            mrifController = new MRiFController();
            cntrlSeller.SetUser(GlobalState.SelectedSeller);
        }

        private void frmInvoice_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                flpMainContainer.Size = new System.Drawing.Size(887, 1100);
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            cntrlItem item = new cntrlItem(flpItems);
            flpItems.Controls.Add(item);
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cntrlBuyer_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Invoice newInvoice = new Invoice
            {
                Number = txtInvoiceNo.Text,
                IssueDate = DateTime.Now,
                SaleDate = DateTime.Now,
                Place = txtPlace.Text,
                //uzu
                PaymentType = cbPaymentType.Text,
                PaymentDeadline = cbPaymentDeadline.Text,
                SellerSignature = txtSellerSignature.Text,
                BuyerSignature = txtSellerSignature.Text,
                Notes = txtComment.Text,
            };
        }
    }
}
