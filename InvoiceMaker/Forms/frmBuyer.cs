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
    public partial class frmBuyer : BaseForm
    {
        cntrlBuyer _cntrlBuyer;
        Buyer _buyer;

        public frmBuyer(Buyer buyer)
        {
            InitializeComponent();

            _cntrlBuyer = new cntrlBuyer(this);
            _cntrlBuyer.Location = new System.Drawing.Point(5, 0);
            this.Controls.Add(_cntrlBuyer);
            _cntrlBuyer.DisplayBuyer(buyer);

            _buyer = buyer;
        }

        public frmBuyer()
        {
            InitializeComponent();

            dataRepository = new DataRepository();

            _cntrlBuyer = new cntrlBuyer();
            _cntrlBuyer.Location = new System.Drawing.Point(5, 0);
            this.Controls.Add(_cntrlBuyer);

            btnSaveBuyer.Visible = true;
        }

        private void btnBuyerCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            Buyer editedBuyer = _cntrlBuyer.ReturnBuyer();
            editedBuyer.Id = _buyer.Id;

            dataRepository.SaveEditedBuyer(editedBuyer);
            this.Close();
        }

        private void btnSaveBuyer_Click(object sender, EventArgs e)
        {
            Buyer newBuyer = _cntrlBuyer.ReturnBuyer();

            dataRepository.SaveNewBuyer(newBuyer);
            this.Close();
        }
    }
}
