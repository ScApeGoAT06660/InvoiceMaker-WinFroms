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
        public frmLogIn()
        {
            InitializeComponent();
            dataRepository = new DataRepository();
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
    }
}
