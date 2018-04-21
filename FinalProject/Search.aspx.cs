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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                string firstname;
                string lastname;

                ViewState["searchString"] = Request.QueryString["searchString"].ToString();
                searchLabel.Text = "'" + ViewState["searchString"].ToString() + "'";

                string[] fullname = ViewState["searchString"].ToString().Split(' ');
                if (fullname.Length == 2)
                {
                    firstname = fullname[0].ToLower();
                    lastname = fullname[1].ToLower();

                    SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
                    c.Open();
                    string findUser = "select username, firstname, lastname, profilepic from UserTable where LOWER(Firstname)='" + firstname + "' and LOWER(Lastname)='" + lastname + "' and Username!='" + Session["username"] + "'";
                    SqlCommand cmd = new SqlCommand(findUser, c);

                    SqlDataReader read = cmd.ExecuteReader();

                    searchDataList.DataSource = read;
                    searchDataList.DataBind();
                }
            }
        }

        protected void searchDataList_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "add")
            {
                try
                {
                    DataListItem item = (DataListItem)(((Button)(e.CommandSource)).NamingContainer);
                    string friendUserName = ((Label)item.FindControl("nameSearchLabel")).Text;

                    SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
                    c.Open();
                    string insert1 = "insert into FriendTable (Uname, friendUserName, flag) values (@uname1, @fusername1, @friendflag1)";
                    string insert2 = "insert into FriendTable (Uname, friendUserName, flag) values (@uname2, @fusername2, @friendflag2)";
                    SqlCommand cmd1 = new SqlCommand(insert1, c);
                    SqlCommand cmd2 = new SqlCommand(insert2, c);

                    cmd1.Parameters.AddWithValue("uname1", Session["username"].ToString());
                    cmd1.Parameters.AddWithValue("fusername1", friendUserName);
                    cmd1.Parameters.AddWithValue("friendflag1", 0);

                    cmd2.Parameters.AddWithValue("uname2", friendUserName);
                    cmd2.Parameters.AddWithValue("fusername2", Session["username"].ToString());
                    cmd2.Parameters.AddWithValue("friendflag2", 1);

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                    Response.Write("Request Sent");
                    
                }
                catch (Exception ex)
                {
                    if (ex.GetType() == typeof(SqlException))
                    {
                        if (ex.Message.Contains("PRIMARY KEY"))
                        {
                            Response.Write("Friend Request already sent!");
                        }
                    }
                    else
                    {
                        throw ex;
                    }
                }
            }
        }


    }
}