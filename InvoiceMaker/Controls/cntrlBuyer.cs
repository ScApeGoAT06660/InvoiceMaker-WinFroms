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

using System.IO;
using System.Xml;
using InvoiceMaker.GusApiService;
using InvoiceMaker.Services;
using static System.Net.Mime.MediaTypeNames;
using InvoiceMaker.Domains;
using InvoiceMaker.Forms;


namespace InvoiceMaker.Controls
{
    public partial class cntrlBuyer : UserControl
    {
        MRiFController mrifController;
        DataRepository dataRepository;
        public frmInvoice invoice;
        
        public cntrlBuyer()
        {
            InitializeComponent();

            mrifController = new MRiFController();
            dataRepository = new DataRepository();
        }

        public cntrlBuyer(frmInvoice invoice)
        {
            InitializeComponent();

            mrifController = new MRiFController();
            dataRepository = new DataRepository();
        }

        private void rbPrivatePersonType_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrivatePersonType.Checked)
            {
                txtVATID.ReadOnly = true;
                txtVATID.Text = string.Empty;

                //zaznacz typ na private person
            }
            else
            {
                rbBusinessType.Checked = true;
                txtVATID.ReadOnly = false;
            }
        }

        private async void btnGUS_Click(object sender, EventArgs e)
        {
            string nip = txtVATID.Text;

            if (string.IsNullOrWhiteSpace(nip))
            {
                MessageBox.Show("Proszę podać numer NIP.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Traders trader = await mrifController.TakeTraderInfo("1130093176");

                if (trader != null)
                {
                   txtBuyerName.Text = trader.Name;
                   txtVATID.Text = nip;
                   txtStreetAndNo.Text = trader.StreetAndNo;
                   txtPostcode.Text = trader.Postcode;
                   txtCity.Text = trader.City;
                }
                else
                {
                    MessageBox.Show("Nie znaleziono firmy o podanym NIP.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CheckIfBuyerAlreadyExist();
        }

        private void pbTraderListButton_Click(object sender, EventArgs e)
        {
            frmBuyersList frmBuyersList = new frmBuyersList(invoice);
            frmBuyersList.ShowDialog();
        }

        private void txtVATID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true;

                CheckIfBuyerAlreadyExist();
            }
        }

        private void CheckIfBuyerAlreadyExist()
        {
            if (!dataRepository.CheckIfVATIDExist(txtVATID.Text))
            {
                DialogResult result = MessageBox.Show("Czy chcesz zapisać tego kontreahenta do bazy?", "Potwierdzenie", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Buyer buyer = new Buyer
                    {
                        Name = txtBuyerName.Text,
                        VATID = txtVATID.Text,
                        StreetAndNo = txtStreetAndNo.Text,
                        Postcode = txtPostcode.Text,
                        City = txtCity.Text
                    };

                    dataRepository.SaveNewBuyer(buyer);
                }
            }
        }

        public void DisplayBuyer(Buyer buyer)
        {
            txtBuyerName.Text = buyer.Name;
            txtVATID.Text = buyer.VATID;
            txtStreetAndNo.Text = buyer.StreetAndNo;
            txtPostcode.Text = buyer.Postcode;
            txtCity.Text = buyer.City;
        }
    }
}
