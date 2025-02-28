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


namespace InvoiceMaker.Controls
{
    public partial class cntrlBuyer : UserControl
    {
        MRiFController mrifController;

        public cntrlBuyer()
        {
            InitializeComponent();

            mrifController = new MRiFController();
        }

        private void rbPrivatePersonType_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrivatePersonType.Checked)
            {
                txtVATID.ReadOnly = true;
                txtVATID.Text = string.Empty;

                //zaznacz typ na private person
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
                Trader trader = await mrifController.TakeTraderInfo(nip);

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

        }
    }
}
