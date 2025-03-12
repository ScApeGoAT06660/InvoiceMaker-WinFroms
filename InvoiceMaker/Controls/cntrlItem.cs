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
        frmInvoice _invoice;
        public string childCount;
    
        public cntrlItem(FlowLayoutPanel flpItems, frmInvoice invoice)
        {
            InitializeComponent();
            _flpItems = flpItems;
            _invoice = invoice;
        }

        private void pbTrashButton_Click(object sender, EventArgs e)
        {
            _flpItems.Controls.Remove(this);
            RefreshIDList();
            _invoice.RemoveDeletedItemValue(ReturnSummary());
            this.Dispose();
        }

        public void SetID(string id)
        {
            txtID.Text = id;
        }

        private void RefreshIDList()
        {
            List<cntrlItem> itemsList = _flpItems.Controls.OfType<cntrlItem>().ToList();

            for (int i = 0; i < itemsList.Count; i++) 
            {
                itemsList[i].txtID.Text = (i + 1).ToString();
            }
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

        public void LoadItem(Item item)
        {
            txtID.Text = item.Position;
            txtItemName.Text = item.Name;
            txtQuantity.Text = item.Quantity.ToString();
            txtUnit.Text = item.Unit;
            txtNetto.Text = item.Netto.ToString("0.00");
            cbVAT.Text = item.VAT;
            txtBrutto.Text = item.Brutto.ToString("0.00");
        }

        private void cbVAT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtNetto.Text, out decimal netto))
            {
                MessageBox.Show("Podaj poprawną wartość netto.");
                return;
            }

            if (cbVAT.SelectedItem == null)
            {
                MessageBox.Show("Wybierz wartość VAT.");
                return;
            }

            string vatText = cbVAT.SelectedItem.ToString().Trim().ToLower(); 

            if (decimal.TryParse(vatText, out decimal vatRate))
            {
                decimal brutto = netto * (1 + vatRate / 100);
                txtBrutto.Text = brutto.ToString("0.00");
            }
            else if (vatText == "np" || vatText == "zw")
            {
                txtBrutto.Text = netto.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Niepoprawna wartość VAT. Podaj liczbę, 'np' lub 'zw'.");
            }
        }


        public decimal[] ReturnSummary()
        {
            decimal[] nvb = new decimal[3];

            string vatText = cbVAT.Text.Trim().ToLower();

            if (decimal.TryParse(txtNetto.Text, out decimal netto) && decimal.TryParse(txtBrutto.Text, out decimal brutto))
            {
                if (decimal.TryParse(vatText, out decimal vatRate))
                {
                    nvb[0] = netto;
                    nvb[1] = brutto - netto;
                    nvb[2] = brutto;
                }
                else if (vatText == "np" || vatText == "zw")
                {
                    nvb[0] = netto;
                    nvb[1] = 0;
                    nvb[2] = netto;
                }
                else
                {
                    MessageBox.Show("Niepoprawna wartość VAT. Podaj liczbę, 'np' lub 'zw'.");
                    return new decimal[] { 0, 0, 0 };
                }

                return nvb;
            }
            else
            {
                MessageBox.Show("Podaj poprawne wartości netto i brutto.");
                return new decimal[] { 0, 0, 0 };
            }
        }

        private void txtBrutto_TextChanged(object sender, EventArgs e)
        {
            _invoice.SetSummary();
        }

        private void txtNetto_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
