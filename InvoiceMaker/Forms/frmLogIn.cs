using InvoiceMaker.Domains;
using InvoiceMaker.Forms;
using InvoiceMaker.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace InvoiceMaker
{
    public partial class frmLogIn : BaseForm
    {
        frmInvoiceManagement _invoiceManagement;

        public frmLogIn(frmInvoiceManagement invoiceManagement)
        {
            InitializeComponent();

            _invoiceManagement = invoiceManagement;

            LoadTradersData();
        }

        public void LoadTradersData()
        {
            List<Seller> sellers = dataRepository.ReturnUsersList();

            dgwLogInUsers.Columns.Clear();
            dgwLogInUsers.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Name = "Id",
                Width = 40
            };

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Nazwa",
                Name = "Name",
                Width = 200
            };

            DataGridViewTextBoxColumn vatColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "VatId",
                HeaderText = "NIP",
                Name = "VatId",
                Width = 80
            };

            dgwLogInUsers.Columns.Add(idColumn);
            dgwLogInUsers.Columns.Add(nameColumn);
            dgwLogInUsers.Columns.Add(vatColumn);

            dgwLogInUsers.DataSource = sellers;
        }

        private void btnLogInAdd_Click(object sender, EventArgs e)
        {
            frmUser newUser = new frmUser();
            newUser.ShowDialog();

            LoadTradersData();
        }

        private void btnLogInEdit_Click(object sender, EventArgs e)
        {
            if (dgwLogInUsers.CurrentRow != null)
            {
                int selectedId = Convert.ToInt32(dgwLogInUsers.CurrentRow.Cells["Id"].Value);

                Seller sellerToEdit = dataRepository.ReturnSelectedUser(selectedId);

                frmUser newUser = new frmUser(sellerToEdit, selectedId);
                newUser.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nie wybrano użytkownika do edycji.");
            }
        }

        private void btnLogInChoose_Click(object sender, EventArgs e)
        {
            if (dgwLogInUsers.CurrentRow != null)
            {
                int selectedId = Convert.ToInt32(dgwLogInUsers.CurrentRow.Cells["Id"].Value);

                GlobalState.SelectedSeller = dataRepository.ReturnSelectedUser(selectedId);
                GlobalState.isSetUp = true;

                string sellerFolderPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "Faktury",
                    selectedId.ToString()
                );

                if (!Directory.Exists(sellerFolderPath))
                {
                    Directory.CreateDirectory(sellerFolderPath);
                }

                GlobalState.InvoicesFolderPath = sellerFolderPath;

                _invoiceManagement.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wybierz użytkownika.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnLogInDelete_Click(object sender, EventArgs e)
        {
            if (dgwLogInUsers.CurrentRow != null)
            {
                int selectedId = Convert.ToInt32(dgwLogInUsers.CurrentRow.Cells["Id"].Value);
                dataRepository.DeleteSelectedSeller(selectedId);
                LoadTradersData();
            }
            else
            {
                MessageBox.Show("Nie wybrano użytkownika do usunięcia.");
            }
        }

        private void frmLogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!GlobalState.isSetUp)
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Czy na pewno chcesz zamknąć aplikację?",
                                             "Potwierdzenie zamknięcia",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
