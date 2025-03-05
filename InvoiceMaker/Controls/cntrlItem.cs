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

namespace InvoiceMaker.Controls
{
    public partial class cntrlItem : UserControl
    {
        FlowLayoutPanel _flpItems;
        public string childCount;

        public cntrlItem(FlowLayoutPanel flpItems)
        {
            InitializeComponent();
            _flpItems = flpItems;
        }

        private void pbTrashButton_Click(object sender, EventArgs e)
        {
            _flpItems.Controls.Remove(this);
            this.Dispose();
        }

        public void SetID(string id)
        {
            txtID.Text = id;
        }

        public Item CreateNewItem()
        {
            Item item = new Item
            {
                Position = txtID.Text,
                Name = txtItemName.Text,
                Quantity = Convert.ToInt32(txtQuantity.Text),
                Unit = txtUnit.Text,
                VAT = cbVAT.Text,
                Netto = Convert.ToDecimal(txtNetto.Text),
                Brutto = Convert.ToDecimal(txtBrutto.Text)
            };

            return item;
        }
    }
}
