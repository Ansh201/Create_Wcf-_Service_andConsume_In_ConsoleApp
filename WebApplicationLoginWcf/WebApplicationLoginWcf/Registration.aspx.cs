using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationLoginWcf.RegistrationServiceReference;


namespace WebApplicationLoginWcf
{
    public partial class Registration : System.Web.UI.Page
    {
        RegistrationServiceReference.Service1Client serviceClient = new RegistrationServiceReference.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserReg userInformation = new UserReg();
            

            userInformation.FirstName = FirstNameTextBox.Text;
            userInformation.LastName = LastNameTextBox.Text;
            userInformation.Gender = DropDownList1.SelectedValue;
            userInformation.Email = EmailTextBox.Text;
            userInformation.Address = AddressTextBox.Text;
            userInformation.UserName = UserNameTextBox.Text;
            userInformation.Password = PasswordTextBox.Text;
            userInformation.ConfirmPassword = ConfirmPasswordTextBox.Text;

            // Call the RegisterUserDetails method of the service
            bool result = serviceClient.RegisterUserDetails(userInformation);

            // Show a success message if the registration was successful
            if (result)
            {
                Response.Write("Registration successful!");
            }
            else
            {
                Response.Write("Registration failed.");


            }
        }
    }
}