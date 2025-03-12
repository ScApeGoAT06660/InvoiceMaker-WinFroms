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

        public void SaveEditedUser(Seller editedSeller, int sellerToEditID)
        {
            using (var db = new InvoiceMakerDBDataContext())
            {
                var sellerId = db.Sellers.FirstOrDefault(s => s.Id == sellerToEditID);

                var sellerToEdit = db.Traders
                    .FirstOrDefault(s => s.Id == sellerId.TraderID);

                var sellerInfo = db.Sellers.FirstOrDefault(s => s.Id == sellerId.Id);

                if (sellerInfo != null) 
                {
                    sellerToEdit.Name = editedSeller.Name;
                    sellerToEdit.VATID = editedSeller.VATID;
                    sellerToEdit.StreetAndNo = editedSeller.StreetAndNo;
                    sellerToEdit.Postcode = editedSeller.Postcode;
                    sellerToEdit.City = editedSeller.City;

                    sellerInfo.BankAccount = editedSeller.BankAccount;
                    sellerInfo.Bank = editedSeller.Bank;
                    sellerInfo.SWIFT = editedSeller.SWIFT;

                    db.SubmitChanges();
                }
            }
        }

        public bool IsUserAlreadyExist (int id)
        {
            using (var db = new InvoiceMakerDBDataContext())
            {
                bool exists = db.Sellers.Any(t => t.Id == id);

                if (exists)
                    return true;
                else
                    return false;
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

        public void SaveEditedBuyer(Buyer editedBuyer)
        {
            using (var db = new InvoiceMakerDBDataContext())
            {
                var buyerId = db.Buyers.FirstOrDefault(s => s.Id == editedBuyer.Id);

                var buyerToEdit = db.Traders
                    .FirstOrDefault(s => s.Id == buyerId.TraderID);


                if (buyerToEdit != null)
                {
                    buyerToEdit.Name = editedBuyer.Name;
                    buyerToEdit.VATID = editedBuyer.VATID;
                    buyerToEdit.StreetAndNo = editedBuyer.StreetAndNo;
                    buyerToEdit.Postcode = editedBuyer.Postcode;
                    buyerToEdit.City = editedBuyer.City;

                    db.SubmitChanges();
                }
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

        public Invoice ReturnSelectedInvoice(int id)
        {
            using (var db = new InvoiceMakerDBDataContext())
            {
                var item = db.Invoices.FirstOrDefault(i => i.Id == id);

                if (item == null)
                    return null;

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
                    Notes = item.Notes
                };

                var items = db.Items.Where(i => i.InvoiceId == item.Id).ToList();

                List<Item> itemsList = new List<Item>();

                foreach (var position in items)
                {
                    itemsList.Add(new Item
                    {
                        InvoiceId = position.InvoiceId ?? 0,
                        Name = position.Name,
                        Quantity = position.Quantity,
                        Unit = position.Unit,
                        VAT = position.VAT,
                        Netto = position.Netto,
                        Brutto = position.Brutto
                    });
                }

                invoice.Items = itemsList;

                return invoice;
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

        public Buyer ReturnBuyerFromExistingInvoice(int id)
        {
            using (var db = new InvoiceMakerDBDataContext())
            {
                var buyerInfo = db.Buyers
                    .FirstOrDefault(s => s.Id == id);

                var traderInfo = db.Traders
                    .Where(t => t.Id == buyerInfo.TraderID)
                    .FirstOrDefault();

                Buyer buyer = new Buyer
                {
                    Id = buyerInfo.TraderID,
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

        public void SaveEditedInvoice(Invoice editedInvoice)
        {
            using (var db = new InvoiceMakerDBDataContext())
            {
                var existingInvoice = db.Invoices.FirstOrDefault(i => i.Id == editedInvoice.Id);

                if (existingInvoice != null)
                {
                    existingInvoice.Number = editedInvoice.Number;
                    existingInvoice.IssueDate = editedInvoice.IssueDate;
                    existingInvoice.SaleDate = editedInvoice.SaleDate;
                    existingInvoice.Place = editedInvoice.Place;
                    existingInvoice.SellerId = editedInvoice.SellerId;
                    existingInvoice.BuyerId = GlobalState.SelectedBuyer.Id;
                    existingInvoice.BuyerType = editedInvoice.BuyerType;
                    existingInvoice.PaymentType = editedInvoice.PaymentType;
                    existingInvoice.PaymentDeadline = editedInvoice.PaymentDeadline;
                    existingInvoice.SellerSignature = editedInvoice.SellerSignature;
                    existingInvoice.BuyerSignature = editedInvoice.BuyerSignature;
                    existingInvoice.Notes = editedInvoice.Notes;


                    var existingItems = db.Items.Where(it => it.InvoiceId == existingInvoice.Id).ToList();

                    foreach (var item in existingItems)
                    {
                        if (!editedInvoice.Items.Any(it => it.Id == item.Id))
                        {
                            db.Items.DeleteOnSubmit(item);
                        }
                    }

                    foreach (var editedItem in editedInvoice.Items)
                    {
                        var existingItem = existingItems.FirstOrDefault(it => it.Id == editedItem.Id);

                        if (existingItem != null)
                        {
                            existingItem.Name = editedItem.Name;
                            existingItem.Quantity = editedItem.Quantity;
                            existingItem.Unit = editedItem.Unit;
                            existingItem.Netto = editedItem.Netto;
                            existingItem.VAT = editedItem.VAT;
                            existingItem.Brutto = editedItem.Brutto;
                        }
                        else
                        {
                            var newItem = new Items
                            {
                                InvoiceId = existingInvoice.Id,
                                Name = editedItem.Name,
                                Quantity = editedItem.Quantity,
                                Unit = editedItem.Unit,
                                Netto = editedItem.Netto,
                                VAT = editedItem.VAT,
                                Brutto = editedItem.Brutto
                            };

                            db.Items.InsertOnSubmit(newItem);
                        }
                    }

                    db.SubmitChanges();
                }
                else
                {
                    throw new Exception("Nie znaleziono faktury do edycji.");
                }
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
