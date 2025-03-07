using InvoiceMaker.Controls;
using InvoiceMaker.Domains;
using InvoiceMaker.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceMaker.Forms
{
    public partial class frmUser : Form
    {
        DataRepository dataRepository;
        public frmUser()
        {
            InitializeComponent();
        }

        public frmUser(Seller seller)
        {
            InitializeComponent();
            dataRepository = new DataRepository();
            CompleteTheTextFields(seller);
        }

        private void btnSellerSave_Click(object sender, EventArgs e)
        {
            cntrlSeller.SaveUser();
            this.Close();

        }

        private void btnSellerCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CompleteTheTextFields(Seller seller)
        {
            cntrlSeller.SetUser(seller);
            btnSaveEdit.Visible = true;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            Seller sellerToEdit = cntrlSeller.ReturnSeller();
            dataRepository.SaveEditedUser(sellerToEdit);
            this.Close();
        }
    }
}

