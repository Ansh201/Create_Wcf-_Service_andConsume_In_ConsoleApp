using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationLoginWcf.LoginServiceReference;

namespace WebApplicationLoginWcf
{
    public partial class LoginForm : System.Web.UI.Page
    {
        LoginServiceReference.Service1Client obj = new LoginServiceReference.Service1Client();
        protected void Page_Load(object sender, EventArgs e)
        {

        }






        protected void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                UserDetails userInfo = new UserDetails();
                userInfo.UserName = UserTextBox.Text;
                userInfo.Password = PassTextBox.Text;
                List<string> msg = obj.LoginUserDetails(userInfo).ToList();

                if (msg != null && msg.Count >= 2)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert('Login Successful')</script>");
                    Label3.Text = "Employee Name = " + msg.ElementAt(0) +  "      Employee Id = " + msg.ElementAt(1);

                }
                else
                {
                    throw new Exception("Invalid response from service.");
                }
            }
            catch (Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script> alert('Login failed')</script>");
                Label3.Text = "Wrong Id Or Password";
                Console.WriteLine("Error: " + ex.ToString());
            }
        }
    }
}

