using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceMaker.Domains
{
    public static class GlobalState
    {
        public static Seller SelectedSeller { get; set; }
        public static Buyer SelectedBuyer { get; set; }
        public static bool isSetUp { get; set; }
    }
}
