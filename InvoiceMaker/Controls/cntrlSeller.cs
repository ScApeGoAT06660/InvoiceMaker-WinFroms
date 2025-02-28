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

namespace InvoiceMaker.Controls
{
    public partial class cntrlSeller : UserControl
    {
        DataRepository dataRepository;
        public cntrlSeller()
        {
            InitializeComponent();
            dataRepository = new DataRepository();
        }

        public void SaveUser()
        {
            Seller seller = new Seller 
            { 
                Name = txtBuyerName.Text,
                VATID = txtVATID.Text,
                StreetAndNo = txtStreetAndNo.Text,
                Postcode = txtPostcode.Text,
                City = txtCity.Text,
                BankAccount = txtBankAccount.Text,
                Bank = txtBank.Text,
                SWIFT= txtSWIFT.Text
            };

            dataRepository.SaveNewUser(seller);
        }
    }
}
