using InvoiceMaker.Controls;
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

namespace InvoiceMaker.Forms
{
    public partial class frmBuyersList : BaseForm
    {
        frmInvoice _invoice;

        public frmBuyersList(frmInvoice invoice)
        {
            InitializeComponent();

            _invoice = invoice;

            LoadTradersData();
        }

        public frmBuyersList()
        {
            InitializeComponent();

            btnBuyersSelect.Visible = false;

            LoadTradersData();
        }

        public void LoadTradersData()
        {
            List<Buyer> buyers = dataRepository.ReturnAllBuyers();

            dgwBuyersList.Columns.Clear();
            dgwBuyersList.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "ID",
                Name = "Id",
                Width = 40
            };

            DataGridViewTextBoxColumn name = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Nazwa",
                Name = "Name",
                Width = 200
            };

            DataGridViewTextBoxColumn vatID = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "VATID",
                HeaderText = "NIP",
                Name = "VATID",
                Width = 100
            };

            DataGridViewTextBoxColumn streetAndNo = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StreetAndNo",
                HeaderText = "Ulica",
                Name = "StreetAndNo",
                Width = 200
            };

            DataGridViewTextBoxColumn postcode = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Postcode",
                HeaderText = "Kod",
                Name = "Postcode",
                Width = 80
            };

            DataGridViewTextBoxColumn city = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "City",
                HeaderText = "Miasto",
                Name = "City",
                Width = 150
            };

            dgwBuyersList.Columns.Add(idColumn);
            dgwBuyersList.Columns.Add(name);
            dgwBuyersList.Columns.Add(vatID);
            dgwBuyersList.Columns.Add(streetAndNo);
            dgwBuyersList.Columns.Add(postcode);
            dgwBuyersList.Columns.Add(city);

            dgwBuyersList.DataSource = buyers;
        }

        private void btnBuyersSelect_Click(object sender, EventArgs e)
        {
            if (dgwBuyersList.CurrentRow != null)
            {
                if(_invoice != null)
                {
                    int selectedId = Convert.ToInt32(dgwBuyersList.CurrentRow.Cells["Id"].Value);
                    Buyer selectedBuyer = dataRepository.ReturnSelectedBuyer(selectedId);
                    GlobalState.SelectedBuyer = selectedBuyer;

                    _invoice.ShowChosenBuyer(selectedBuyer);

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Zaznacz lub kliknij dwa razy na wybranego kontrahenta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgwBuyersList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                int selectedId = Convert.ToInt32(dgwBuyersList.Rows[e.RowIndex].Cells["Id"].Value);

                Buyer selectedBuyer = dataRepository.ReturnSelectedBuyer(selectedId);
                GlobalState.SelectedBuyer = selectedBuyer;

                _invoice.ShowChosenBuyer(selectedBuyer);

                this.Close();
            }
        }

        private void btnBuyersEdit_Click(object sender, EventArgs e)
        {
            if (dgwBuyersList.CurrentRow != null)
            {
                int selectedId = Convert.ToInt32(dgwBuyersList.CurrentRow.Cells["Id"].Value);
                Buyer selectedBuyer = dataRepository.ReturnSelectedBuyer(selectedId);

                frmBuyer frmEditBuyer = new frmBuyer(selectedBuyer);
                frmEditBuyer.ShowDialog();

                LoadTradersData();
            }
            else
            {
                MessageBox.Show("Zaznacz kontrahenta do edycji.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuyersDelete_Click(object sender, EventArgs e)
        {
            if (dgwBuyersList.CurrentRow != null)
            {
                int selectedId = Convert.ToInt32(dgwBuyersList.CurrentRow.Cells["Id"].Value);
                dataRepository.DeleteSelectedBuyer(selectedId);

                LoadTradersData();
            }
            else
            {
                MessageBox.Show("Zaznacz kontrahenta do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnAddBuyer_Click(object sender, EventArgs e)
        {
            frmBuyer frmBuyer = new frmBuyer();
            frmBuyer.ShowDialog();

            LoadTradersData();
        }
    }
}
