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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
                c.Open();
                string checkuser = "select count(*) from UserTable where Username='"+usernameText.Text+"'";
                SqlCommand com = new SqlCommand(checkuser, c);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());

                if(temp == 1)
                {
                    Response.Write("User Already Exists");
                }

                c.Close();
            }
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
                c.Open();
                string insert = "insert into UserTable (Username, Firstname, Lastname, Email, Password, Gender) values (@uname, @fname, @lname, @email, @password, @gender)";
                SqlCommand com = new SqlCommand(insert, c);
         

                com.Parameters.AddWithValue("uname", usernameText.Text);
                com.Parameters.AddWithValue("fname", firstnameText.Text);
                com.Parameters.AddWithValue("lname", lastnameText.Text);
                com.Parameters.AddWithValue("email", emailText.Text);
                com.Parameters.AddWithValue("password", passwordText.Text);
                com.Parameters.AddWithValue("gender", genderList.SelectedItem.ToString());

                com.ExecuteNonQuery();

                Response.Write("Registration is Succesful");
                Response.Redirect("ManageData.aspx");
                c.Close();
            }
            catch (Exception ex) {
                Response.Write("Error:" + ex.ToString());
            }
        }

    }
}