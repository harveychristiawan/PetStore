using PetStore.Factory;
using PetStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Repository
{
    public class TransactionRepository
    {
        private static PetDatabaseEntities db = DatabaseSingleton.GetInstance();


        // add data
        public static TransactionHeader CreateTransactionHeader(Customer cust)
        {
            TransactionHeader th = TransactionFactory.CreateTransactionHeader(cust);
            db.TransactionHeaders.Add(th);
            db.SaveChanges();
            return th;
        }

        public static void CreateTransactionDetail(TransactionHeader th, Product product, int qty)
        {
            TransactionDetail td = TransactionFactory.CreateTransactionDetail(th, product, qty);
            td.TransactionID = th.TransactionID;
            td.ProductID = product.ProductID;
            db.TransactionDetails.Add(td);
            db.SaveChanges();
        }


        // show data by customer
        // transaction id, transaction date, customer name, product picture, product name, product qty, product price
        public static List<object> GetTransactionByCustomer(int customerId)
        {
            var result = (from th in db.TransactionHeaders
                          join td in db.TransactionDetails on th.TransactionID equals td.TransactionID
                          join c in db.Customers on th.CustomerID equals c.CustomerID
                          join al in db.Products on td.ProductID equals al.ProductID
                          where th.CustomerID == customerId
                          select new { th.TransactionID, th.TransactionDate, c.CustomerName, al.ProductImage, al.ProductName, td.Qty, al.ProductPrice }).ToList();
            return result.Cast<object>().ToList();

        }

        public static List<TransactionHeader> GetAllTransaction()
        {
            return db.TransactionHeaders.ToList();
        }
    }
}