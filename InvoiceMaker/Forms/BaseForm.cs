using InvoiceMaker.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceMaker.Forms
{
    public class BaseForm : Form
    {
        public DataRepository dataRepository;
        public BaseForm()
        {
            this.Icon = new Icon("Resources\\logo.ico");

            dataRepository = new DataRepository();
        }
    }
}
