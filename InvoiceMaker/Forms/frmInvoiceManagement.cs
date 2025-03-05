using InvoiceMaker.Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceMaker
{
    public partial class frmInvoiceManagement : Form
    {
        public frmInvoiceManagement()
        {
            InitializeComponent();

            this.Hide();

            if(!GlobalState.isSetUp)
            {
                frmLogIn frmLogIn = new frmLogIn(this);
                frmLogIn.ShowDialog();
            }

        }

        private void btnManageAdd_Click(object sender, EventArgs e)
        {
            frmInvoice newInvoice = new frmInvoice();
            newInvoice.ShowDialog();
        }
    }
}
