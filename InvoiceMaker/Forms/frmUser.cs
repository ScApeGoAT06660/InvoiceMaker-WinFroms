using InvoiceMaker.Controls;
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
        public frmUser()
        {
            InitializeComponent();
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
    }
}
