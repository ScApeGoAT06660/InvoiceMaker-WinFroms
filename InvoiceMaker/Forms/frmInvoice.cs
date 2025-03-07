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

namespace InvoiceMaker
{
    public partial class frmInvoice : Form
    {
        MRiFController mrifController;
        DataRepository dataRepository;

        int chosenSellerId;
        int chosenBuyerId;

        public frmInvoice()
        {
            InitializeComponent();
            mrifController = new MRiFController();
            chosenSellerId = GlobalState.SelectedSeller.Id;
            dataRepository = new DataRepository();

            cntrlSeller.SetUser(GlobalState.SelectedSeller);
            cntrlBuyer.invoice = this;
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
            cntrlItem item = new cntrlItem(flpItems, this);
            flpItems.Controls.Add(item);

            item.SetID(flpItems.Controls.Count.ToString());
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
                SellerId = chosenSellerId,
                BuyerId = chosenBuyerId,
                BuyerType = cntrlBuyer.ReturnBuyerType(),
                Items = ReturnItemList(),
                PaymentType = cbPaymentType.Text,
                PaymentDeadline = cbPaymentDeadline.Text,
                SellerSignature = txtSellerSignature.Text,
                BuyerSignature = txtBuyerSignature.Text,
                Notes = txtComment.Text,
            };

            dataRepository.SaveNewInvoice(newInvoice);
            this.Close();

        }

        public void ShowChosenBuyer(Buyer buyer)
        {
            GlobalState.SelectedBuyer = buyer;
            chosenBuyerId = buyer.Id;

            MessageBox.Show($"Wybrano kupującego: {buyer.Name}, ID: {buyer.Id}");
            MessageBox.Show($"chosenBuyerId teraz: {chosenBuyerId}");

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

    }

}
