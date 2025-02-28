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
    }
}
