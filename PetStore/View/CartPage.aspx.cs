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
    public partial class CartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["customer"] != null || Request.Cookies["customer_cookie"] != null)
                {
                    Customer c = (Customer)Session["customer"];
                    // cuma bisa diakses customer
                    if (!c.CustomerRole.Equals("C"))
                    {
                        Response.Redirect("~/View/ErrorPage.aspx");
                    }

                }
                else
                {
                    Response.Redirect("~/View/ErrorPage.aspx");
                }

                Customer cust = new Customer();
                List<object> carts = new List<object>();
                if (Session["customer"] == null)
                {
                    int id = int.Parse(Request.Cookies["customer_cookie"].Value);
                    cust = CustomerController.GetCustomerById(id);
                    Session["customer"] = cust;
                }
                else
                {
                    cust = (Customer)Session["customer"];
                }
                carts = CartController.GetAllCartByCustomerId(cust.CustomerID);
                gvCart.DataSource = carts;
                gvCart.DataBind();
            }
        }

        protected void gvCart_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }



        protected void checkoutBtn_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            if (Session["customer"] == null)
            {
                int id = int.Parse(Request.Cookies["customer_cookie"].Value);
                cust = CustomerController.GetCustomerById(id);
                Session["customer"] = cust;
            }
            else
            {
                cust = (Customer)Session["customer"];
            }
            CartController.CheckOut(cust.CustomerID);
            Response.Redirect("~/View/HomePage.aspx");
        }

        protected void gvCart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Customer cust = new Customer();
            if (Session["customer"] == null)
            {
                int id = int.Parse(Request.Cookies["customer_cookie"].Value);
                cust = CustomerController.GetCustomerById(id);
                Session["customer"] = cust;
            }
            else
            {
                cust = (Customer)Session["customer"];
            }
            GridViewRow row = gvCart.Rows[e.RowIndex];
            int productId = int.Parse(row.Cells[0].Text);

            CartController.RemoveOneCart(cust.CustomerID, productId);

            Response.Redirect("~/View/CartPage.aspx");

        }
    }
}