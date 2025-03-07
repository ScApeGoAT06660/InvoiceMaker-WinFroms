using InvoiceMaker.Domains;
using InvoiceMaker.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceMaker
{
    public partial class frmInvoiceManagement : Form
    {
        DataRepository dataRepository;
        public frmInvoiceManagement()
        {
            InitializeComponent();
            dataRepository = new DataRepository();
            this.Hide();

            if(!GlobalState.isSetUp)
            {
                frmLogIn frmLogIn = new frmLogIn(this);
                frmLogIn.ShowDialog();
                LoadInvoices();
            }
        }

        private void LoadInvoices()
        {
            List<Invoice> invoices = dataRepository.ReturnAllInvoicesForUser(GlobalState.SelectedSeller.Id);
            dgwInvoices.DataSource = invoices;
        }

        private void btnManageAdd_Click(object sender, EventArgs e)
        {
            frmInvoice newInvoice = new frmInvoice();
            newInvoice.ShowDialog();
        }
    }
}
