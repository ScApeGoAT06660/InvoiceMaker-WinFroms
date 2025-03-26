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
    public partial class frmInvoiceManagement : BaseForm
    {   
        PDFSharpController _pdfSharpController;

        List<Invoice> allInvoices = new List<Invoice>();
        List<Invoice> filteredInvoices = new List<Invoice>();

        public frmInvoiceManagement()
        {
            InitializeComponent();

            this.Hide();

            frmLogIn frmLogIn = new frmLogIn(this);
            frmLogIn.ShowDialog();

            if(GlobalState.isSetUp)
                LoadInvoices();
        }

        public void LoadInvoices()
        {
            allInvoices = dataRepository.ReturnAllInvoicesForUser(GlobalState.SelectedSeller.Id);
            filteredInvoices = new List<Invoice>(allInvoices);

            dgwInvoices.Columns.Clear();
            dgwInvoices.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Name = "Id",
                Width = 40
            };

            DataGridViewTextBoxColumn number = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Number",
                HeaderText = "Numer",
                Name = "Number",
                Width = 100
            };

            DataGridViewTextBoxColumn issueDate = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IssueDate",
                HeaderText = "Data wystawienia",
                Name = "IssueDate",
                Width = 80
            };

            DataGridViewTextBoxColumn saleDate = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SaleDate",
                HeaderText = "Data sprzedaży",
                Name = "SaleDate",
                Width = 80
            };

            DataGridViewTextBoxColumn buyerId = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "BuyerId",
                HeaderText = "Id kupującego",
                Name = "BuyerId",
                Width = 80
            };

            dgwInvoices.Columns.Add(idColumn);
            dgwInvoices.Columns.Add(number);
            dgwInvoices.Columns.Add(issueDate);
            dgwInvoices.Columns.Add(saleDate);
            dgwInvoices.Columns.Add(buyerId);

            dgwInvoices.DataSource = filteredInvoices;
        }

        private void SortData()
        {
            if (allInvoices == null || allInvoices.Count == 0) return;

            string selectedSort = cbSortOptions.SelectedItem?.ToString() ?? "";

            switch (selectedSort)
            {
                case "data wystawienia":
                    filteredInvoices = allInvoices.OrderBy(x => x.IssueDate).ToList();
                    break;
                case "data sprzedaży":
                    filteredInvoices = allInvoices.OrderBy(x => x.SaleDate).ToList();
                    break;
                case "kontrahent":
                    filteredInvoices = allInvoices.OrderBy(x => x.BuyerId).ToList();
                    break;
                case "numer":
                    filteredInvoices = allInvoices.OrderBy(x => x.Number).ToList();
                    break;
                case "id":
                    filteredInvoices = allInvoices.OrderBy(x => x.Id).ToList();
                    break;
                default:
                    filteredInvoices = new List<Invoice>(allInvoices);
                    break;
            }

            dgwInvoices.DataSource = null;
            dgwInvoices.DataSource = filteredInvoices;
        }

        private void btnManageAdd_Click(object sender, EventArgs e)
        {
            frmInvoice newInvoice = new frmInvoice();
            newInvoice.ShowDialog();

            LoadInvoices();
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
                MessageBox.Show("Zaznacz fakturę do edycji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private void btnManageDelete_Click(object sender, EventArgs e)
        {
            if (dgwInvoices.CurrentRow != null)
            {
                int selectedId = Convert.ToInt32(dgwInvoices.CurrentRow.Cells["Id"].Value);
                Invoice invoicePDFToDelete = dataRepository.ReturnSelectedInvoice(selectedId);

                _pdfSharpController = new PDFSharpController(invoicePDFToDelete);
                _pdfSharpController.DeleteInvoice();

                dataRepository.DeleteSelectedInvoice(selectedId);

                LoadInvoices();
            }
            else
            {
                MessageBox.Show("Zaznacz fakturę do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnManageBuyers_Click(object sender, EventArgs e)
        {
            frmBuyersList list = new frmBuyersList();
            list.ShowDialog();  
        }

        private void btnSwitchUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            GlobalState.isSetUp = false;

            frmLogIn frmLogIn = new frmLogIn(this);
            frmLogIn.ShowDialog();

            if (GlobalState.isSetUp)
                LoadInvoices();
        }

        private void cbSortOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortData();
        }
    }
}
