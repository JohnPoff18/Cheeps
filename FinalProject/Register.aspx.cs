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
        {/*
            if (IsPostBack)
            {
                SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
                c.Open();
                string checkuser = "select count(*) from UserTable where Username='"+usernameText.Text+"'";
                SqlCommand com = new SqlCommand(checkuser, c);
                int temp = Convert.ToInt32(com.ExecuteScalar().ToString());

                if(temp > 0)
                {
                    Response.Write("User Already Exists");
                }

                c.Close();
            }*/
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

                Response.Write("Registration was succesful. Proceed to Login");          
                c.Close();
            }
            catch (Exception ex) {
                if (ex.GetType() == typeof(SqlException))
                {
                    if (ex.Message.Contains("PRIMARY KEY"))
                    {
                        Response.Write("Username already exists!");
                    }
                }
                else
                {
                    throw ex;
                }
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
            c.Open();
            string checkuser = "select count(*) from UserTable where Username='" + NameLoginBox.Text + "'";
            SqlCommand com = new SqlCommand(checkuser, c);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            c.Close();
            if (temp == 1)
            {
                c.Open();
                string checkPassword = "select password from UserTable where Username='" + NameLoginBox.Text + "'";
                string getAttr = "select firstname, lastname, profilepic, email, gender from UserTable where Username='" + NameLoginBox.Text + "'";
                SqlCommand passwordCom = new SqlCommand(checkPassword, c);
                SqlCommand attrCom = new SqlCommand(getAttr, c);
                string password = passwordCom.ExecuteScalar().ToString().Replace(" ","");

                if (password == PasswordLoginBox.Text)
                {

                    using (SqlDataReader read = attrCom.ExecuteReader()) {

                        while (read.Read()) {
                            Session["firstname"] = read["Firstname"].ToString();
                            Session["lastname"] = read["Lastname"].ToString();
                            Session["profilepic"] = read["profilePic"].ToString();
                            Session["email"] = read["email"].ToString();
                            Session["gender"] = read["gender"].ToString();

                        }
                    }

                    Session["username"] = NameLoginBox.Text;
                    Response.Redirect("Home.aspx");


                }
                else
                {

                    Response.Write("Incorrect Password");
                }
            }
            else {

                Response.Write("Incorrect Username");
            }
           
        }
    }
}