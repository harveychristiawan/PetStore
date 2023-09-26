using PetStore.Model;
using PetStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Handler
{
    public class TransactionHandler
    {
        public static List<object> GetTransactionByCustomer(int customerId)
        {
            return TransactionRepository.GetTransactionByCustomer(customerId);
        }

        public static List<TransactionHeader> GetAllTransaction()
        {
            return TransactionRepository.GetAllTransaction();
        }
    }
}