using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceMaker.Domains
{
    internal class PrivatePerson:Buyer
    {
        public string PESEL {  get; set; }

        public override string VATID
        {
            get => PESEL;
            set => PESEL = value;
        }
    }
}
