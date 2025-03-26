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
        MRiFController _mrifController = new MRiFController();
        DataRepository _dataRepository = new DataRepository();

        public frmInvoice invoice;
        
        public cntrlBuyer()
        {
            InitializeComponent();
            rbBusinessType.Visible = false;
            rbPrivatePersonType.Visible = false;
        }

        public cntrlBuyer(frmBuyer frmEditBuyer)
        {
            InitializeComponent();

            rbBusinessType.Visible = false;
            rbPrivatePersonType.Visible = false;
            pbTraderListButton.Visible = false;
            btnGUS.Visible = false;
        }

        public void DisplayBuyer(Buyer buyer)
        {
            txtBuyerName.Text = buyer.Name;
            txtVATID.Text = buyer.VATID;
            txtStreetAndNo.Text = buyer.StreetAndNo;
            txtPostcode.Text = buyer.Postcode;
            txtCity.Text = buyer.City;
        }

        public Buyer ReturnBuyer()
        {
            return new Buyer
            {
                Name = txtBuyerName.Text,
                VATID = txtVATID.Text,
                StreetAndNo = txtStreetAndNo.Text,
                Postcode = txtPostcode.Text,
                City = txtCity.Text
            };
        }

        public string ReturnBuyerType()
        {
            if(rbBusinessType.Checked)
                return TraderTypes.Buyer.ToString();
            else 
                return TraderTypes.PrivatePerson.ToString();
        }

        private void rbPrivatePersonType_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrivatePersonType.Checked)
            {
                txtVATID.ReadOnly = true;
                txtVATID.Text = string.Empty;
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
                Buyer buyer = await _mrifController.TakeTraderInfo(nip);

                if (buyer != null)
                {
                   txtBuyerName.Text = buyer.Name;
                   txtVATID.Text = nip;
                   txtStreetAndNo.Text = buyer.StreetAndNo;
                   txtPostcode.Text = buyer.Postcode;
                   txtCity.Text = buyer.City;
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

            if (_dataRepository.CheckIfIsDeleted(nip))
            {
                DialogResult result = MessageBox.Show("Czy chcesz zapisać tego kontrahenta do bazy?", "Potwierdzenie", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _dataRepository.RestoreDeletedBuyer(nip);
                    return;
                }
            }

            CheckIfBuyerAlreadyExist();
        }

        private void pbTraderListButton_Click(object sender, EventArgs e)
        {
            frmBuyersList frmBuyersList = new frmBuyersList(invoice);
            frmBuyersList.ShowDialog();
        }

        private async void txtVATID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true;

                string nip = txtVATID.Text;

                if (string.IsNullOrWhiteSpace(nip))
                {
                    MessageBox.Show("Proszę podać numer NIP.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    Buyer buyer = await _mrifController.TakeTraderInfo(nip);

                    if (buyer != null)
                    {
                        txtBuyerName.Text = buyer.Name;
                        txtVATID.Text = nip;
                        txtStreetAndNo.Text = buyer.StreetAndNo;
                        txtPostcode.Text = buyer.Postcode;
                        txtCity.Text = buyer.City;
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
        }

        private void CheckIfBuyerAlreadyExist()
        {
            if (!_dataRepository.CheckIfVATIDExist(txtVATID.Text))
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

                    _dataRepository.SaveNewBuyer(buyer);
                    Buyer returnFreshlyAdded = _dataRepository.ReturnFreshlyAddedBuyer(buyer.VATID);

                    GlobalState.SelectedBuyer = returnFreshlyAdded;
                    MessageBox.Show(GlobalState.SelectedBuyer.Id.ToString());
                }
            }
        }
    }
}
