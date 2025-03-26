using InvoiceMaker.Controls;
using InvoiceMaker.Domains;
using InvoiceMaker.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceMaker.Forms
{
    public partial class frmUser : BaseForm
    {
        int _sellerToEditID;
        string _tempLogoPath = null;

        public frmUser()
        {
            InitializeComponent();
        }

        public frmUser(Seller seller, int sellerToEditID)
        {
            InitializeComponent();

            CompleteTheTextFields(seller);
            _sellerToEditID = sellerToEditID;
        }

        private void btnSellerSave_Click(object sender, EventArgs e)
        {
            Seller seller = cntrlSeller.ReturnSeller();
            int newSellerId = dataRepository.SaveNewUser(seller);

            SaveLogoImage(_tempLogoPath, newSellerId);

            this.Close();
        }

        private void SaveLogoImage(string path, int sellerID)
        {
            if (!string.IsNullOrEmpty(_tempLogoPath))
            {
                string sellerFolder = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "Faktury",
                    sellerID.ToString()
                );

                if (!Directory.Exists(sellerFolder))
                    Directory.CreateDirectory(sellerFolder);

                File.Copy(_tempLogoPath, Path.Combine(sellerFolder, "logo.jpg"), true);
            }
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
            dataRepository.SaveEditedUser(sellerToEdit, _sellerToEditID);

            SaveLogoImage(_tempLogoPath, _sellerToEditID);

            this.Close();
        }

        private void btnChooseLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki JPG (*.jpg)|*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _tempLogoPath = openFileDialog.FileName;
                MessageBox.Show("Logo wybrane pomyślnie.");
            }
        }
    }
}

