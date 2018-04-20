using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace FinalProject
{
    public partial class Site1 : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["username"] != null) {

                profileNameLabel.Text = Session["Username"].ToString();

                if (Session["profilepic"] != null)
                {
                    Image1.ImageUrl = Session["profilepic"].ToString();
                }
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

        protected void buttonUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.PostedFile != null)
            {
                string fileExt = System.IO.Path.GetExtension(FileUpload1.FileName);

                if (fileExt == ".jpeg" || fileExt == ".jpg" || fileExt == ".png")
                {
                    FileUpload1.SaveAs(Server.MapPath("~/profilepics/") + FileUpload1.FileName);

                    SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
                    c.Open();
                    string updateQuery = "update UserTable set profilePic = '" + "~/profilepics/" + FileUpload1.FileName + "' where Username= '" + Session["Username"].ToString() + "'";
                    SqlCommand cmd = new SqlCommand(updateQuery, c);                
             
                    cmd.ExecuteNonQuery();
               
                    Session["profilepic"] = "~/profilepics/" + FileUpload1.FileName;
                    Response.Redirect("Home.aspx");
                    c.Close();
                }
            }
            else
            {
                Response.Write("Invalid picture file.");
            }
        }

        protected void ButtonSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("Search.aspx?searchString=" + TextSearch.Text);
        }
    }
}