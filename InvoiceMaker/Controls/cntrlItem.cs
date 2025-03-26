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
        public string childCount;

        FlowLayoutPanel _flpItems;
        frmInvoice _invoice;
        
        public cntrlItem(FlowLayoutPanel flpItems, frmInvoice invoice)
        {
            InitializeComponent();
            _flpItems = flpItems;
            _invoice = invoice;
        }

        public void SetID(string id)
        {
            txtID.Text = id;
        }

        public Item CreateNewItem()
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Nazwa produktu nie może być pusta.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtItemName.Focus();
                return null;
            }

            if (string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                MessageBox.Show("Jednostka miary nie może być pusta.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnit.Focus();
                return null;
            }

            if (string.IsNullOrWhiteSpace(cbVAT.Text))
            {
                MessageBox.Show("Wybierz stawkę VAT.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbVAT.Focus();
                return null;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Ilość musi być liczbą całkowitą większą od 0.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return null;
            }

            if (!decimal.TryParse(txtNetto.Text, out decimal netto) || netto <= 0)
            {
                MessageBox.Show("Cena netto musi być liczbą większą od 0.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNetto.Focus();
                return null;
            }

            if (!decimal.TryParse(txtBrutto.Text, out decimal brutto) || brutto <= 0)
            {
                MessageBox.Show("Cena brutto musi być liczbą większą od 0.", "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBrutto.Focus();
                return null;
            }

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

        private void pbTrashButton_Click(object sender, EventArgs e)
        {
            _flpItems.Controls.Remove(this);
            RefreshIDList();
            _invoice.RemoveDeletedItemValue(ReturnSummary());
            this.Dispose();
        }

        private void RefreshIDList()
        {
            List<cntrlItem> itemsList = _flpItems.Controls.OfType<cntrlItem>().ToList();

            for (int i = 0; i < itemsList.Count; i++) 
            {
                itemsList[i].txtID.Text = (i + 1).ToString();
            }
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

        private void txtBrutto_TextChanged(object sender, EventArgs e)
        {
            _invoice.SetSummary();
        }
    }
}
