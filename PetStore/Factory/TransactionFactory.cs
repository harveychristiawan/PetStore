using PetStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Factory
{
    public class TransactionFactory
    {
        public static TransactionHeader CreateTransactionHeader(Customer cust)
        {
            TransactionHeader th = new TransactionHeader();
            th.TransactionDate = DateTime.Now;
            th.Customer = cust;
            return th;
        }

        public static TransactionDetail CreateTransactionDetail(TransactionHeader th, Product product, int qty)
        {
            TransactionDetail td = new TransactionDetail();
            td.TransactionHeader = th;
            td.Product = product;
            td.Qty = qty;
            return td;
        }
    }
}