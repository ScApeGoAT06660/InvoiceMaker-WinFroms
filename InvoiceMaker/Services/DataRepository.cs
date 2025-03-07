using InvoiceMaker.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
                    .FirstOrDefault(s => s.Id == sellerID.TraderID);

                var sellerInfo = db.Sellers.FirstOrDefault(s => s.Id == sellerID.Id);


                Seller seller = new Seller
                {
                    Id = sellerInfo.Id,
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

        public List<Invoice> ReturnAllInvoicesForUser(int id)
        {
            using (var db = new InvoiceMakerDBDataContext())
            {
                List<Invoice> invoicesList = new List<Invoice>();

                var invoices = db.Invoices
                    .Where(s => s.SellerId == id)
                    .ToList();

                foreach (var item in invoices)
                {
                    Invoice invoice = new Invoice
                    {
                        Id = item.Id,
                        Number = item.Number,
                        IssueDate = item.IssueDate,
                        SaleDate = item.SaleDate,
                        Place = item.Place,
                        SellerId = item.SellerId ?? 0,
                        BuyerId = item.BuyerId ?? 0,
                        BuyerType = item.BuyerType,
                        PaymentType = item.PaymentType,
                        PaymentDeadline = item.PaymentDeadline,
                        SellerSignature = item.SellerSignature,
                        BuyerSignature = item.BuyerSignature,
                        Notes = item.Notes,
                    };

                    var items = db.Items.Where(i => i.InvoiceId == item.Id).ToList();

                    List<Item> itemsList = new List<Item>();

                    foreach (var position in items) 
                    {
                        Item newItem = new Item 
                        {
                            InvoiceId = position.InvoiceId ?? 0,
                            Name = position.Name,
                            Quantity = position.Quantity,
                            Unit = position.Unit,
                            VAT = position.VAT,
                            Netto = position.Netto,
                            Brutto = position.Brutto
                        };

                    }

                    invoice.Items = itemsList;

                    invoicesList.Add(invoice);
                }

                return invoicesList;
            }
        }

        public Buyer ReturnSelectedBuyer(int id)
        {
            using (var db = new InvoiceMakerDBDataContext())
            {
                var traderInfo = db.Traders
                    .FirstOrDefault(s => s.Id == id);

                var buyerID = db.Buyers
                    .Where(t => t.TraderID == traderInfo.Id)
                    .FirstOrDefault();

                Buyer buyer = new Buyer
                {
                    Id = buyerID.Id,
                    Name = traderInfo.Name,
                    VATID = traderInfo.VATID,
                    StreetAndNo = traderInfo.StreetAndNo,
                    Postcode = traderInfo.Postcode,
                    City = traderInfo.City,
                };

                return buyer;
            }
        }

        public Buyer ReturnFreshlyAddedBuyer(string vatId)
        {
            using (var db = new InvoiceMakerDBDataContext())
            {
                var traderInfo = db.Traders
                    .FirstOrDefault(s => s.VATID == vatId);

                var buyerID = db.Buyers
                    .Where(t => t.TraderID == traderInfo.Id)
                    .FirstOrDefault();

                Buyer buyer = new Buyer
                {
                    Id = buyerID.Id,
                    Name = traderInfo.Name,
                    VATID = traderInfo.VATID,
                    StreetAndNo = traderInfo.StreetAndNo,
                    Postcode = traderInfo.Postcode,
                    City = traderInfo.City,
                };

                return buyer;
            }
        }

        public void SaveNewInvoice(Invoice invoice)
        {
            using (var db = new InvoiceMakerDBDataContext())
            {
                var newInvoice = new Invoices
                {
                    Number = invoice.Number,
                    IssueDate = invoice.IssueDate,
                    SaleDate = invoice.SaleDate,
                    Place = invoice.Place,
                    SellerId = invoice.SellerId,
                    BuyerId = GlobalState.SelectedBuyer.Id,
                    BuyerType = invoice.BuyerType,
                    PaymentType = invoice.PaymentType,
                    PaymentDeadline = invoice.PaymentDeadline,
                    SellerSignature = invoice.SellerSignature,
                    BuyerSignature = invoice.BuyerSignature,
                    Notes = invoice.Notes
                };

                db.Invoices.InsertOnSubmit(newInvoice);
                db.SubmitChanges();

                List<Item> items = invoice.Items;

                foreach (var item in items)
                {
                    var newItem = new Items
                    {
                        InvoiceId = newInvoice.Id,
                        Name = item.Name,
                        Quantity = item.Quantity,
                        Unit = item.Unit,
                        Netto = item.Netto,
                        VAT = item.VAT,
                        Brutto = item.Brutto
                    };

                    db.Items.InsertOnSubmit(newItem);
                }

                db.SubmitChanges();
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
