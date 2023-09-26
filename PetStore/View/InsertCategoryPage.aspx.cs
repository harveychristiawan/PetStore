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
    public partial class InsertCategoryPage : System.Web.UI.Page
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

            }

        }

        protected void insertCategoryBtn_Click(object sender, EventArgs e)
        {
            String name = nameTb.Text;
            String imgPath = "";
            int imgSize = 0;
            String imgExt = "";
            String response = "";
            if (imageUpload.HasFile)
            {
                imgPath = Server.MapPath("~/Assets/Categories/") + imageUpload.FileName;
                imgSize = imageUpload.PostedFile.ContentLength;
                imgExt = System.IO.Path.GetExtension(imageUpload.FileName);
            }
            response = CategoryController.validateCategory(name, imgPath, imageUpload.HasFile, imgSize, imgExt);

            errorMsg.Text = response;


            if (response.Equals(""))
            {
                imageUpload.SaveAs(imgPath);
                CategoryController.doInsertCategory(name, "~/Assets/Categories/" + imageUpload.FileName);

            }
        }
    }
}