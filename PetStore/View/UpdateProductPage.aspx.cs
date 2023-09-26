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
    public partial class UpdateProductPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["customer"] != null || Request.Cookies["customer_cookie"] != null)
                {
                    Customer c = (Customer)Session["customer"];
                    // cuma bisa diakses admin
                    if (!c.CustomerRole.Equals("A"))
                    {
                        Response.Redirect("~/View/ErrorPage.aspx");
                    }

                }
                else
                {
                    Response.Redirect("~/View/ErrorPage.aspx");
                }
                int id = int.Parse(Request["ID"].ToString());
                Product product = ProductController.GetProductById(id);
                nameTb.Text = product.ProductName;
                descriptionTb.Text = product.ProductDescription;
                priceTb.Text = product.ProductPrice.ToString();
                stockTb.Text = product.ProductStock.ToString();
            }
        }

        protected void updateProductBtn_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(Request["ID"].ToString());
            String name = nameTb.Text;
            String desc = descriptionTb.Text;
            String priceText = priceTb.Text;
            String stockText = stockTb.Text;

            int price = 0, stock = 0;
            if (!priceText.Equals("")) price = int.Parse(priceText);
            if (!stockText.Equals("")) stock = int.Parse(stockText);

            String imgPath = "";
            int imgSize = 0;
            String imgExt = "";
            String response = "";
            if (imageUpload.HasFile)
            {
                imgPath = Server.MapPath("~/Assets/Products/") + imageUpload.FileName;
                imgSize = imageUpload.PostedFile.ContentLength;
                imgExt = System.IO.Path.GetExtension(imageUpload.FileName);
            }
            response = ProductController.validateProduct(name, desc, price, stock, imgPath, imageUpload.HasFile, imgSize, imgExt);

            errorMsg.Text = response;


            if (response.Equals(""))
            {
                imageUpload.SaveAs(imgPath);
                ProductController.doUpdateProduct(productId, name, desc, price, stock, "~/Assets/Products/" + imageUpload.FileName);
                Product product = ProductController.GetProductById(productId);
                Response.Redirect("~/View/ArtistDetailPage.aspx?ID=" + product.CategoryID);
            }

        }
    }
}