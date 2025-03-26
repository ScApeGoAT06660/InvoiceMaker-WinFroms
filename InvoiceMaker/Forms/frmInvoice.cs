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
using System.Diagnostics;
using System.Runtime.CompilerServices;
using InvoiceMaker.Forms;

namespace InvoiceMaker
{
    public partial class frmInvoice : BaseForm
    {
        int _chosenSellerId;
        int _chosenBuyerId;
        Invoice _invoiceToEdit;
        frmInvoiceManagement _frmInvoiceManagement;
        PDFSharpController _pdfSharpController;

        public frmInvoice()
        {
            InitializeComponent();
            
            _chosenSellerId = GlobalState.SelectedSeller.Id;
            cntrlSeller.SetUser(GlobalState.SelectedSeller);

            dtpIssueDate.Value = DateTime.Now;
            dtpSaleDate.Value = DateTime.Now;

            txtInvoiceNo.Text = dataRepository.ReturnNewInvoiceNumber();

            cntrlBuyer.invoice = this;
        }

        public frmInvoice(Invoice invoiceToEdit, frmInvoiceManagement frmInvoiceManagement)
        {
            InitializeComponent();

            _chosenSellerId = GlobalState.SelectedSeller.Id;
            cntrlSeller.SetUser(GlobalState.SelectedSeller);

            _chosenBuyerId = invoiceToEdit.BuyerId;
            GlobalState.SelectedBuyer = dataRepository.ReturnBuyerFromExistingInvoice(_chosenBuyerId);

            cntrlBuyer.invoice = this;

            btnEditInvoice.Visible = true;

            LoadSelectedInvoice(invoiceToEdit);
            _invoiceToEdit = invoiceToEdit;

            _frmInvoiceManagement = frmInvoiceManagement;
        }
        public Invoice ReturnInvoice()
        {
            Invoice editedInvoice = new Invoice
            {
                Number = txtInvoiceNo.Text,
                IssueDate = dtpIssueDate.Value,
                SaleDate = dtpSaleDate.Value,
                Place = txtPlace.Text,
                SellerId = _chosenSellerId,
                BuyerId = _chosenBuyerId,
                BuyerType = cntrlBuyer.ReturnBuyerType(),
                Items = ReturnItemList(),
                PaymentType = cbPaymentType.Text,
                PaymentDeadline = cbPaymentDeadline.Text,
                SellerSignature = txtSellerSignature.Text,
                BuyerSignature = txtBuyerSignature.Text,
                Notes = txtComment.Text,
            };

            return editedInvoice;
        }

        public void ShowChosenBuyer(Buyer buyer)
        {
            GlobalState.SelectedBuyer = buyer;
            _chosenBuyerId = buyer.Id;

            cntrlBuyer.DisplayBuyer(buyer);
        }

        public List<Item> ReturnItemList()
        {
            List<cntrlItem> listOfControls = flpItems.Controls.OfType<cntrlItem>().ToList();
            List<Item> items = new List<Item>();

            foreach (cntrlItem item in listOfControls)
            {
                items.Add(item.CreateNewItem());
            }

            return items;
        }

        public void SetSummary()
        {
            decimal[] summary = new decimal[3];

            if (flpItems == null || flpItems.Controls == null)
            {
                MessageBox.Show("Brak elementów w kontenerze.");
                return;
            }

            List<cntrlItem> itemsList = flpItems.Controls.OfType<cntrlItem>().ToList();

            foreach (cntrlItem item in itemsList)
            {
                decimal[] returnedSummary = item.ReturnSummary();

                if (returnedSummary == null || returnedSummary.Length < 3)
                {
                    MessageBox.Show("Błąd: ReturnSummary() zwróciło nieprawidłowe dane.");
                    continue;
                }

                summary[0] += returnedSummary[0];
                summary[1] += returnedSummary[1];
                summary[2] += returnedSummary[2];
            }

            txtNettoSummary.Text = summary[0].ToString("0.00");
            txtVATSummary.Text = summary[1].ToString("0.00");
            txtBruttoSummary.Text = summary[2].ToString("0.00");
        }

        public void RemoveDeletedItemValue(decimal[] numbersToDelete)
        {
            decimal[] summary = new decimal[3];

            decimal.TryParse(txtNettoSummary.Text, out summary[0]);
            decimal.TryParse(txtVATSummary.Text, out summary[1]);
            decimal.TryParse(txtBruttoSummary.Text, out summary[2]);

            summary[0] -= numbersToDelete[0];
            summary[1] -= numbersToDelete[1];
            summary[2] -= numbersToDelete[2];

            txtNettoSummary.Text = summary[0].ToString("0.00");
            txtVATSummary.Text = summary[1].ToString("0.00");
            txtBruttoSummary.Text = summary[2].ToString("0.00");
        }

        private void frmInvoice_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                flpMainContainer.Size = new System.Drawing.Size(887, 1100);
            }
        }

        private void LoadSelectedInvoice(Invoice invoiceToLoad)
        {
            Buyer buyer = dataRepository.ReturnBuyerFromExistingInvoice(invoiceToLoad.BuyerId);

            txtInvoiceNo.Text = invoiceToLoad.Number;
            dtpIssueDate.Value = invoiceToLoad.IssueDate;
            dtpSaleDate.Value = invoiceToLoad.SaleDate;
            txtPlace.Text = invoiceToLoad.Place;
            cntrlBuyer.DisplayBuyer(buyer);
            LoadItems(invoiceToLoad.Items);
            cbPaymentType.Text = invoiceToLoad.PaymentType;
            cbPaymentDeadline.Text = invoiceToLoad.PaymentDeadline;
            txtSellerSignature.Text = invoiceToLoad.SellerSignature;
            txtBuyerSignature.Text = invoiceToLoad.BuyerSignature;
            txtComment.Text = invoiceToLoad.Notes;
        }

        private void LoadItems(List<Item> items)
        {
            foreach (Item position in items) 
            {
                cntrlItem item = new cntrlItem(flpItems, this);
                item.LoadItem(position);
                flpItems.Controls.Add(item);

                item.SetID(flpItems.Controls.Count.ToString());
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            cntrlItem item = new cntrlItem(flpItems, this);
            flpItems.Controls.Add(item);

            item.SetID(flpItems.Controls.Count.ToString());
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(GlobalState.SelectedBuyer != null)
                _chosenBuyerId = GlobalState.SelectedBuyer.Id;

            if (string.IsNullOrWhiteSpace(txtInvoiceNo.Text))
            {
                MessageBox.Show("Numer faktury nie może być pusty.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInvoiceNo.Focus();
                return;
            }

            if (_chosenSellerId == 0)
            {
                MessageBox.Show("Wybierz sprzedawcę. Musi być zapisany w bazie danych.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_chosenBuyerId == 0)
            {
                MessageBox.Show("Wybierz nabywcę. Musi być zapisany w bazie danych.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var itemList = ReturnItemList();
            if (itemList == null || !itemList.Any(item => item != null))
            {
                MessageBox.Show("Faktura musi zawierać przynajmniej jeden prawidłowy przedmiot.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Invoice newInvoice = new Invoice
            {
                Number = txtInvoiceNo.Text,
                IssueDate = dtpIssueDate.Value,
                SaleDate = dtpSaleDate.Value,
                Place = txtPlace.Text,
                SellerId = _chosenSellerId,
                BuyerId = _chosenBuyerId,
                BuyerType = cntrlBuyer.ReturnBuyerType(),
                Items = ReturnItemList(),
                PaymentType = cbPaymentType.Text,
                PaymentDeadline = cbPaymentDeadline.Text,
                SellerSignature = txtSellerSignature.Text,
                BuyerSignature = txtBuyerSignature.Text,
                Notes = txtComment.Text,
            };


            _pdfSharpController = new PDFSharpController(newInvoice, GlobalState.SelectedSeller, GlobalState.SelectedBuyer);
            _pdfSharpController.GenerateInvoicePdf();

            dataRepository.SaveNewInvoice(newInvoice);

            this.Close();
        }

        private void btnEditInvoice_Click(object sender, EventArgs e)
        {
            Invoice editedInvoice = ReturnInvoice();
            editedInvoice.Id = _invoiceToEdit.Id;

            _pdfSharpController =  new PDFSharpController(editedInvoice, GlobalState.SelectedSeller, GlobalState.SelectedBuyer);
            _pdfSharpController.EditInvoice();

            dataRepository.SaveEditedInvoice(editedInvoice);
            _frmInvoiceManagement.LoadInvoices();

            this.Close();
        }
    }
}
