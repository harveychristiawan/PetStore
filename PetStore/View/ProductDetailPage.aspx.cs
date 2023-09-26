using PetStore.Controller;
using PetStore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PetStore.View
{

    public partial class ProductDetailPage : System.Web.UI.Page
    {
        public String role = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Customer cust = (Customer)Session["customer"];

                if (cust != null)
                {
                    role = cust.CustomerRole;
                }

                int productId = int.Parse(Request["ID"].ToString());
                Product product = ProductController.GetProductById(productId);
                nameLb.Text = product.ProductName;
                String imgPath = product.ProductImage;
                if (!string.IsNullOrEmpty(imgPath))
                {
                    ProductImg.ImageUrl = ResolveUrl(imgPath);
                }
                descLb.Text = product.ProductDescription;
                priceLb.Text = product.ProductPrice.ToString();
                stockLb.Text = product.ProductStock.ToString();
            }
        }

        protected void addCartBtn_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(Request["ID"].ToString());
            Product product = ProductController.GetProductById(productId);
            int productStock = product.ProductStock;

            String qtyText = qtyTb.Text;
            int qty = -1;
            if (string.IsNullOrEmpty(qtyText))
            {
                qty = -1;
            }
            else
            {
                qty = int.Parse(qtyText);
            }
            String response = CartController.validateCart(qty, productStock);

            errorMsg.Text = response;

            if (response.Equals(""))
            {
                // add to cart
                // cari customer yg sedang log in
                Customer cust;
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

                CartController.AddItemToCart(cust, product, qty);
                Page.Response.Redirect(Page.Request.Url.ToString(), true);
            }
        }
    }
}