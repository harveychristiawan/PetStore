using PetStore.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Controller
{
    public class TransactionController
    {
        public static List<object> GetTransactionByCustomer(int customerId)
        {
            return TransactionHandler.GetTransactionByCustomer(customerId);
        }
    }
}