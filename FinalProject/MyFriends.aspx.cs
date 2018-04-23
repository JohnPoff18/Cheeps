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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

                SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
                c.Open();
                string findFriends = "select friendusername, firstname, lastname, profilepic from UserTable, FriendTable where Uname='" + Session["username"].ToString() + "' and Username = friendusername and flag = 2";
                SqlCommand cmd = new SqlCommand(findFriends, c);

                SqlDataReader read = cmd.ExecuteReader();

                friendsDataList.DataSource = read;
                friendsDataList.DataBind();

                c.Close();
            } 
        }

        protected void friendsDataList_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "unfriend")
            {
                DataListItem item = (DataListItem)(((Button)(e.CommandSource)).NamingContainer);
                string friendUserName = ((Label)item.FindControl("nameSearchLabel")).Text;

                SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
                c.Open();
                string deleteQuery1 = "delete from FriendTable where Uname='" + Session["Username"].ToString() + "' and friendusername = '" + friendUserName + "'";
                string deleteQuery2 = "delete from FriendTable where Uname='" + friendUserName + "' and friendusername = '" + Session["Username"].ToString() + "'";

                SqlCommand cmd1 = new SqlCommand(deleteQuery1, c);
                SqlCommand cmd2 = new SqlCommand(deleteQuery2, c);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                Response.Redirect("MyFriends.aspx");
            }
        }
    }
}