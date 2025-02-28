using InvoiceMaker.Forms;
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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogInAdd_Click(object sender, EventArgs e)
        {
            frmUser newUser = new frmUser();
            newUser.ShowDialog();
        }

        private void btnLogInEdit_Click(object sender, EventArgs e)
        {
            frmUser newUser = new frmUser();
            newUser.ShowDialog();
        }
    }
}
