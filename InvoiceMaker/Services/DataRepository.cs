using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceMaker.Services
{
    internal class DataRepository
    {
        private readonly InvoiceMakerDBDataContext _context;

        public DataRepository(string connectionString)
        {
            _context = new InvoiceMakerDBDataContext(connectionString);
        }
















    }
}
