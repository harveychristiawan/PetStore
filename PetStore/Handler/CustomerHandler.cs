﻿using PetStore.Model;
using PetStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetStore.Handler
{
    public class CustomerHandler
    {
        public static void CreateCustomer(String name, String email, String gender, String address, String password, String role)
        {
            CustomerRepository.CreateCustomer(name, email, gender, address, password, role);
        }

        public static Customer Login(String email, String password)
        {
            return CustomerRepository.Login(email, password);
        }

        public static bool UpdateCustomer(int id, String name, String email, String gender, String address, String password)
        {
            return CustomerRepository.UpdateCustomer(id, name, email, gender, address, password);
        }

        public static bool CheckEmailUnique(String email)
        {
            return CustomerRepository.CheckEmailUnique(email);
        }

        public static Customer GetCustomerById(int id)
        {
            return CustomerRepository.GetCustomerById(id);
        }
    }
}