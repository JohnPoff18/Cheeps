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

        }
    }
}