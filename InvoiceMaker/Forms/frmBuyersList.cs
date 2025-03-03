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
    }
}
