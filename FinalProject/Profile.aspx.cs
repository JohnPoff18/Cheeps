using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalProject
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UsernameLabel.Text = Session["username"].ToString();
            NameLabel.Text = Session["firstname"].ToString() + " " + Session["lastname"].ToString();
            EmailLabel.Text = Session["email"].ToString();
            GenderLabel.Text = Session["gender"].ToString();

            SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
            string findUser = "SELECT DISTINCT TOP(20) c.Uname, c.Cheep, c.Date, profilePic FROM[CHEEPS] as c, [USERTABLE] WHERE c.Uname = Username AND c.Uname = '" + Session["Username"] + "' ORDER BY Date DESC";
            c.Open();

            SqlCommand cmd = new SqlCommand(findUser, c);

            SqlDataReader read = cmd.ExecuteReader();

            liveFeedDataList.DataSource = read;
            liveFeedDataList.DataBind();

        }

        protected void EditProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditProfile.aspx");
        }
    }
}