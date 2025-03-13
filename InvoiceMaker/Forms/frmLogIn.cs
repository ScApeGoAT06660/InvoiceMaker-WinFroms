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
using System.Xml.Serialization;

namespace InvoiceMaker
{
    public partial class frmLogIn : Form
    {
        DataRepository dataRepository;
        frmInvoiceManagement invoiceManagement;

        public frmLogIn(frmInvoiceManagement invoiceManagement)
        {
            InitializeComponent();

            dataRepository = new DataRepository();
            this.invoiceManagement = invoiceManagement;

            LoadTradersData();
        }

        private void btnLogInAdd_Click(object sender, EventArgs e)
        {
            frmUser newUser = new frmUser();
            newUser.ShowDialog();

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


        private void btnLogInEdit_Click(object sender, EventArgs e)
        {

            if (dgwLogInUsers.CurrentRow != null)
            {
                int selectedId = Convert.ToInt32(dgwLogInUsers.CurrentRow.Cells["Id"].Value);

                Seller sellerToEdit = dataRepository.ReturnSelectedUser(selectedId);

                frmUser newUser = new frmUser(sellerToEdit, selectedId);
                newUser.ShowDialog();
            }
        }

        private void btnLogInChoose_Click(object sender, EventArgs e)
        {

            if (dgwLogInUsers.CurrentRow != null)
            {
                int selectedId = Convert.ToInt32(dgwLogInUsers.CurrentRow.Cells["Id"].Value);

                GlobalState.SelectedSeller = dataRepository.ReturnSelectedUser(selectedId);
                GlobalState.isSetUp = true;

                invoiceManagement.Show();
                this.Close();
            }
            else
            {
                Seller noSeller = new Seller();
                GlobalState.SelectedSeller = noSeller;
                GlobalState.isSetUp = true;

                invoiceManagement.Show();
                this.Close();
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
        }
    }
}
