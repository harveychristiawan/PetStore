using PetStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Repository
{
    public class DatabaseSingleton
    {
        private static PetDatabaseEntities db = null;
        private DatabaseSingleton()
        {

        }

        public static PetDatabaseEntities GetInstance()
        {
            if (db == null)
            {
                db = new PetDatabaseEntities();
            }
            return db;
        }
    }
}