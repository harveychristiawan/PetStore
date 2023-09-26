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
    public partial class CategoryDetailPage : System.Web.UI.Page
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

                int id = int.Parse(Request["ID"].ToString());
                Category Category = CategoryController.GetCategoryById(id);
                nameLb.Text = Category.CategoryName;
                String imgPath = Category.CategoryImage;
                if (!string.IsNullOrEmpty(imgPath))
                {
                    categoryImg.ImageUrl = ResolveUrl(imgPath);
                }

                gvProduct.DataSource = ProductController.GetProductByCategoryId(id);
                gvProduct.DataBind();
                gvProduct2.DataSource = ProductController.GetProductByCategoryId(id);
                gvProduct2.DataBind();
            }
        }

        protected void gvProduct_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvProduct.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[0].Text);
            ProductController.RemoveProduct(id);
            int CategoryId = int.Parse(Request["ID"].ToString());
            Response.Redirect("~/View/CategoryDetailPage.aspx?ID=" + CategoryId);
        }

        protected void gvProduct_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = gvProduct.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[0].Text);
            Response.Redirect("~/View/UpdateProductPage.aspx?ID=" + id);
        }

        protected void gvProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = gvProduct.SelectedIndex;
            int id = int.Parse(gvProduct.Rows[index].Cells[0].Text);
            Response.Redirect("~/View/ProductDetailPage.aspx?ID=" + id);
        }

        protected void insertProductLink_Click(object sender, EventArgs e)
        {
            int CategoryId = int.Parse(Request["ID"].ToString());
            Response.Redirect("~/View/InsertProductPage.aspx?ID=" + CategoryId);
        }

        protected void gvProduct2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gvProduct2.SelectedIndex;
            int id = int.Parse(gvProduct2.Rows[index].Cells[0].Text);
            Response.Redirect("~/View/ProductDetailPage.aspx?ID=" + id);
        }
    }
}