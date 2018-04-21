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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack == false)
            {

                SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
                c.Open();
                string findFriends = "select friendusername, firstname, lastname, profilepic from UserTable, FriendTable where Uname='" + Session["username"].ToString() + "' and Username = friendusername and flag = 1";
                SqlCommand cmd = new SqlCommand(findFriends, c);

                SqlDataReader read = cmd.ExecuteReader();

                requestDataList.DataSource = read;
                requestDataList.DataBind();

                c.Close();
            }
        }

        protected void requestDataList_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if(e.CommandName == "accept")
            {
                DataListItem item = (DataListItem)(((Button)(e.CommandSource)).NamingContainer);
                string friendUserName = ((Label)item.FindControl("nameSearchLabel")).Text;

                SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
                c.Open();
                string updateQuery1 = "update FriendTable set flag = 2 where Uname= '" + Session["Username"].ToString() + "' and friendusername = '"+ friendUserName +"'";
                string updateQuery2 = "update FriendTable set flag = 2 where Uname= '" + friendUserName + "' and friendusername = '" + Session["Username"].ToString() + "'";

                SqlCommand cmd1 = new SqlCommand(updateQuery1, c);
                SqlCommand cmd2 = new SqlCommand(updateQuery2, c);

                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                Response.Redirect("FriendRequest.aspx");
            }
            else if(e.CommandName == "reject")
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

                Response.Redirect("FriendRequest.aspx");
            }
        }
        
    }
}