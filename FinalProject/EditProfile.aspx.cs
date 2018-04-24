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
    public partial class EditProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EditProfileSubmitButton_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString);
            c.Open();
            SqlCommand com;
            string update;

            if (FirstNameTextBox.Text != "")
            {
                update = "update UserTable set Firstname = @fname where Username = '" + Session["Username"] + "'";
                com = new SqlCommand(update, c);
                com.Parameters.AddWithValue("fname", FirstNameTextBox.Text);
                com.ExecuteNonQuery();
                Session["firstname"] = FirstNameTextBox.Text;
            }

            if (LastNameTextBox.Text != "")
            {
                update = "update UserTable set Lastname = @lname where Username = '" + Session["Username"] + "'";
                com = new SqlCommand(update, c);
                com.Parameters.AddWithValue("lname", LastNameTextBox.Text);
                com.ExecuteNonQuery();
                Session["lastname"] = LastNameTextBox.Text;
            }

            if (EmailTextBox.Text != "")
            {
                update = "update UserTable set Email = @email where Username = '" + Session["Username"] + "'";
                com = new SqlCommand(update, c);
                com.Parameters.AddWithValue("email", EmailTextBox.Text);
                com.ExecuteNonQuery();
                Session["email"] = EmailTextBox.Text;
            }

            if (genderList.SelectedIndex != 0)
            {
                update = "update UserTable set Gender = @gender where Username = '" + Session["Username"] + "'";
                com = new SqlCommand(update, c);
                com.Parameters.AddWithValue("gender", genderList.SelectedIndex.ToString());
                com.ExecuteNonQuery();
                Session["gender"] = genderList.SelectedIndex.ToString();
            }
            c.Close();
            Response.Redirect("Profile.aspx");
        }

        protected void EditProfileCancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}