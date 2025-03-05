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

            LoadUsers();
        }

        private void btnLogInAdd_Click(object sender, EventArgs e)
        {
            frmUser newUser = new frmUser();
            newUser.ShowDialog();

            LoadUsers();
        }

        private void btnLogInEdit_Click(object sender, EventArgs e)
        {
            frmUser newUser = new frmUser();
            newUser.ShowDialog();
        }

        private void LoadUsers()
        {
            List<string> sellers = dataRepository.ReturnUsersNameList();
            lbLogInUsers.DataSource = sellers;
        }

        private void btnLogInChoose_Click(object sender, EventArgs e)
        {
            if (lbLogInUsers.SelectedItem != null)
            {
                int selectedId = (int)lbLogInUsers.SelectedIndex + 1;

                GlobalState.SelectedSeller = dataRepository.ReturnSelectedUser(selectedId);
                GlobalState.isSetUp = true; 

                invoiceManagement.Show();
                this.Close();
            }
            else
            {
                Seller noSeller = new Seller();
                GlobalState.SelectedSeller = noSeller;

                invoiceManagement.Show();
                this.Close();
            }
        }
    }
}
