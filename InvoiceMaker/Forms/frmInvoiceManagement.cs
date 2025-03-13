using InvoiceMaker.Domains;
using InvoiceMaker.Forms;
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

        public void LoadInvoices()
        {
            List<Invoice> invoices = dataRepository.ReturnAllInvoicesForUser(GlobalState.SelectedSeller.Id);
            dgwInvoices.DataSource = invoices;
        }

        private void btnManageAdd_Click(object sender, EventArgs e)
        {
            frmInvoice newInvoice = new frmInvoice();
            newInvoice.ShowDialog();
        }

        private void btnManageEdit_Click(object sender, EventArgs e)
        {
            if (dgwInvoices.CurrentRow != null)
            {
                int selectedId = Convert.ToInt32(dgwInvoices.CurrentRow.Cells["Id"].Value);
                Invoice invoice = dataRepository.ReturnSelectedInvoice(selectedId);

                frmInvoice newInvoice = new frmInvoice(invoice, this);
                newInvoice.ShowDialog();

            }
            else
            {
                MessageBox.Show("Zaznacz lub kliknij dwa razy na wybranego kontrahenta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private void btnManageDelete_Click(object sender, EventArgs e)
        {
            if (dgwInvoices.CurrentRow != null)
            {
                int selectedId = Convert.ToInt32(dgwInvoices.CurrentRow.Cells["Id"].Value);
                dataRepository.DeleteSelectedInvoice(selectedId);
                LoadInvoices();

            }
            else
            {
                MessageBox.Show("Zaznacz lub kliknij dwa razy na wybranego kontrahenta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnManageBuyers_Click(object sender, EventArgs e)
        {
            frmBuyersList list = new frmBuyersList();
            list.ShowDialog();  
        }
    }
}
