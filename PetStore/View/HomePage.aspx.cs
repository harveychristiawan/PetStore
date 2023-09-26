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
    public partial class HomePage : System.Web.UI.Page
    {
        public String role = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Customer cust;
                if (Session["customer"] == null)
                {
                    if (Request.Cookies["customer_cookie"] != null)
                    {
                        int id = int.Parse(Request.Cookies["customer_cookie"].Value);
                        cust = CustomerController.GetCustomerById(id);
                        Session["customer"] = cust;
                        userNameLb.Text = cust.CustomerName;
                        role = cust.CustomerRole;
                    }
                }
                else
                {
                    cust = (Customer)Session["customer"];
                    userNameLb.Text = cust.CustomerName;
                    role = cust.CustomerRole;
                }
                gvCategory.DataSource = CategoryController.GetAllCategory();
                gvCategory.DataBind();

                gvCategory2.DataSource = CategoryController.GetAllCategory();
                gvCategory2.DataBind();
            }
        }

        protected void gvCategory_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = gvCategory.Rows[e.NewEditIndex];
            int id = int.Parse(row.Cells[0].Text);
            Response.Redirect("~/View/UpdateCategoryPage.aspx?ID=" + id);
        }

        protected void gvCategory_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = gvCategory.Rows[e.RowIndex];
            int id = int.Parse(row.Cells[0].Text);
            CategoryController.RemoveCategory(id);
            Response.Redirect("~/View/HomePage.aspx");
        }

        protected void gvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gvCategory.SelectedIndex;
            int id = int.Parse(gvCategory.Rows[index].Cells[0].Text);
            Response.Redirect("~/View/CategoryDetailPage.aspx?ID=" + id);


        }

        protected void insertCategoryLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertCategoryPage.aspx");
        }

        protected void gvCategory2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gvCategory2.SelectedIndex;
            int id = int.Parse(gvCategory2.Rows[index].Cells[0].Text);
            Response.Redirect("~/View/CategoryDetailPage.aspx?ID=" + id);
        }
    }
}