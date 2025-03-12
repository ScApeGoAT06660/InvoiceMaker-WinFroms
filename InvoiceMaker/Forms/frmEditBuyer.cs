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
    public partial class frmEditBuyer : Form
    {
        cntrlBuyer cntrlBuyer;
        Buyer _buyer;
        DataRepository dataRepository;
        frmBuyersList _frmBuyersList;

        public frmEditBuyer(frmBuyersList frmBuyersList,Buyer buyer)
        {
            InitializeComponent();

            dataRepository = new DataRepository();

            cntrlBuyer = new cntrlBuyer(this);
            cntrlBuyer.Location = new System.Drawing.Point(5, 0);
            this.Controls.Add(cntrlBuyer);

            cntrlBuyer.DisplayBuyer(buyer);

            _buyer = buyer;
            _frmBuyersList = frmBuyersList;
        }

        private void btnBuyerCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            Buyer editedBuyer = cntrlBuyer.ReturnBuyer();
            editedBuyer.Id = _buyer.Id;

            dataRepository.SaveEditedBuyer(editedBuyer);
            _frmBuyersList.LoadTradersData();
            this.Close();
        }
    }
}
