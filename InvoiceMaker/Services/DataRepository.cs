using InvoiceMaker.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceMaker.Services
{
    public class DataRepository
    {
        public void SaveNewUser(Seller seller)
        {
            using (var db = new InvoiceMakerDBDataContext())
            {
                var trader = new Traders
                {
                    Name = seller.Name,
                    VATID = seller.VATID,
                    StreetAndNo = seller.StreetAndNo,
                    Postcode = seller.Postcode,
                    City = seller.City,
                    TraderType = TraderTypes.Seller.ToString(),
                 
                };

                db.Traders.InsertOnSubmit(trader);
                db.SubmitChanges(); 

                
                var newSeller = new Sellers
                {
                    Id = trader.Id, 
                    BankAccount = seller.BankAccount,
                    Bank = seller.Bank,
                    SWIFT = seller.SWIFT
                };

                db.Sellers.InsertOnSubmit(newSeller);
                db.SubmitChanges();
            }
        }

        public List<string> ReturnUsersNameList()
        {
            using (var db = new InvoiceMakerDBDataContext())
            {
                var sellers = db.Traders
                    .Where(v => v.TraderType == TraderTypes.Seller.ToString())
                    .Select(v => v.Name)
                    .ToList();

                return sellers;
            }
        }
    }
}

public enum TraderTypes
{
    Seller,
    Buyer,
    PrivatePerson
}
