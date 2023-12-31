﻿using PetStore.Controller;
using PetStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetStore.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        public String role = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer cust = (Customer)Session["customer"];

            if (cust != null || Request.Cookies["customer_cookie"] != null)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            String email = emailTb.Text;
            String password = passwordTb.Text;
            bool isRemember = rememberCb.Checked;
            String response = CustomerController.validateLoginCustomer(email, password);
            errorMsg.Text = response;

            if (response.Equals(""))
            {
                Customer c = CustomerController.doLogin(email, password);
                Session["customer"] = c;

                if (isRemember)
                {
                    HttpCookie cookie = new HttpCookie("customer_cookie");
                    cookie.Value = c.CustomerID.ToString();
                    cookie.Expires = DateTime.Now.AddHours(10);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("~/View/HomePage.aspx");
            }

        }
    }
}