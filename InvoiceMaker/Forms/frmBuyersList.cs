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
    public partial class frmBuyersList : Form
    {
        DataRepository dataRepository;
        frmInvoice _invoice;

        public frmBuyersList(frmInvoice invoice)
        {
            InitializeComponent();
            dataRepository = new DataRepository();
            _invoice = invoice;

            LoadTradersData();
        }

        public frmBuyersList()
        {
            InitializeComponent();
            dataRepository = new DataRepository();

            LoadTradersData();
        }

        public void LoadTradersData()
        {
            List<Buyer> buyers = dataRepository.ReturnAllBuyers();

            dgwBuyersList.DataSource = buyers;
        }

        private void btnBuyersSelect_Click(object sender, EventArgs e)
        {
            if (dgwBuyersList.CurrentRow != null)
            {
                int selectedId = Convert.ToInt32(dgwBuyersList.CurrentRow.Cells["Id"].Value);
                Buyer selectedBuyer = dataRepository.ReturnSelectedBuyer(selectedId);
                GlobalState.SelectedBuyer = selectedBuyer;

                _invoice.ShowChosenBuyer(selectedBuyer);

                this.Close();
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

                frmEditBuyer frmEditBuyer = new frmEditBuyer(this, selectedBuyer);
                frmEditBuyer.ShowDialog();
            }
            else
            {
                MessageBox.Show("Zaznacz lub kliknij dwa razy na wybranego kontrahenta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Zaznacz lub kliknij dwa razy na wybranego kontrahenta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
