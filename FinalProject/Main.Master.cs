using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["username"] != null) {

                profileNameLabel.Text = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
            }
            else
            {
                Response.Redirect("Register.aspx");
            }


        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Response.Redirect("Register.aspx");
        }

        protected void DetailsView2_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {

        }
    }
}