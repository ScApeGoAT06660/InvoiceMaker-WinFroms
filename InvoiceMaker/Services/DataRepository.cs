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
                    TraderID = trader.Id, 
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

        public Seller ReturnSelectedUser(int id)
        {
            using (var db = new InvoiceMakerDBDataContext())
            {
                var sellerID = db.Sellers.FirstOrDefault(s => s.Id == id);

                var traderInfo = db.Traders
                    .FirstOrDefault(s => s.Id == sellerID.Id);

                var sellerInfo = db.Sellers.FirstOrDefault(s => s.Id == sellerID.Id);


                Seller seller = new Seller
                {
                    Id = traderInfo.Id,
                    Name = traderInfo.Name,
                    VATID = traderInfo.VATID,
                    StreetAndNo = traderInfo.StreetAndNo,
                    Postcode = traderInfo.Postcode,
                    City = traderInfo.City,
                    BankAccount = sellerInfo.BankAccount,
                    Bank = sellerInfo.Bank,
                    SWIFT = sellerInfo.SWIFT
                };

                return seller;
            }
        }

        public bool CheckIfVATIDExist(string nipToCheck)
        {
            using (var db = new InvoiceMakerDBDataContext())
            {
                bool exists = db.Traders.Any(t => t.VATID == nipToCheck);

                if (exists)
                    return true;
                else
                    return false;
            }
        }

        public void SaveNewBuyer(Buyer buyer)
        {
            using (var db = new InvoiceMakerDBDataContext())
            {
                var trader = new Traders
                {
                    Name = buyer.Name,
                    VATID = buyer.VATID,
                    StreetAndNo = buyer.StreetAndNo,
                    Postcode = buyer.Postcode,
                    City = buyer.City,
                    TraderType = TraderTypes.Buyer.ToString()
                };

                db.Traders.InsertOnSubmit(trader);
                db.SubmitChanges();

                var newBuyer = new Buyers
                {
                    TraderID = trader.Id
                };

                db.Buyers.InsertOnSubmit(newBuyer);
                db.SubmitChanges();
            }
        }

        public List<Buyer> ReturnAllBuyers()
        {
            using (var db = new InvoiceMakerDBDataContext())
            {
                List<Buyer> buyerList = new List<Buyer>();

                var buyers = db.Traders
                                .Where(v => v.TraderType == TraderTypes.Buyer.ToString())
                                .ToList();
                var buyersID = db.Buyers.ToList();


                foreach (var buyer in buyers)
                { 
                    Buyer buyerItem = new Buyer
                    {
                        Id = buyer.Id,
                        Name = buyer.Name,
                        VATID = buyer.VATID,
                        StreetAndNo = buyer.StreetAndNo,
                        Postcode = buyer.Postcode,
                        City = buyer.City
                    };

                    buyerList.Add(buyerItem);
                }

                foreach (var buyer in buyers)
                {
                    buyer.Id += 1;
                }

                return buyerList;
            }
        }

        public Buyer ReturnSelectedBuyer(int id)
        {
            using (var db = new InvoiceMakerDBDataContext())
            {
                var buyerID = db.Buyers.FirstOrDefault(s => s.Id == id);

                var traderInfo = db.Traders
                    .FirstOrDefault(s => s.Id == buyerID.Id);

                Buyer buyer = new Buyer
                {
                    Id = traderInfo.Id,
                    Name = traderInfo.Name,
                    VATID = traderInfo.VATID,
                    StreetAndNo = traderInfo.StreetAndNo,
                    Postcode = traderInfo.Postcode,
                    City = traderInfo.City,
                };

                return buyer;
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
