using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace WfcServiceLogin2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.  
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.  
    public class Service1 : IService1
    {

        public List<string> LoginUserDetails(UserDetails userInfo)
        {
            List<string> usr = new List<string>();
            try
            {
                if (userInfo != null)
                {
                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-7E3RUQC\\SQLEXPRESS01;Initial Catalog=WCF_LOGIN;Integrated Security=SSPI;");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from  EmployeeTbl where UserName=@UserName COLLATE SQL_LATIN1_GENERAL_CP1_CS_AS and Password=@Password COLLATE SQL_LATIN1_GENERAL_CP1_CS_AS", con);
                    cmd.Parameters.AddWithValue("@UserName", userInfo.UserName);
                    cmd.Parameters.AddWithValue("@Password", userInfo.Password);

                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read() == true)
                    {
                        usr.Add(dr[0].ToString());
                        usr.Add(dr[1].ToString());
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                // Log the error or display a message
                Console.WriteLine(ex.Message);
            }
            return usr; ;


        }

        public bool RegisterUserDetails(UserReg userInformation)
        {
            bool result = false;

            // Check if the password and confirm password match
            if (userInformation.Password == userInformation.ConfirmPassword)
            {

                SqlConnection con = new SqlConnection("Data Source=DESKTOP-7E3RUQC\\SQLEXPRESS01;Initial Catalog=WCF_LOGIN;Integrated Security=SSPI;");
                
                string query = "INSERT INTO EmployeeTbl(FirstName, LastName, Gender, Email, Address, Username, Password) " +
                                         "VALUES (@FirstName, @LastName, @Gender, @Email, @Address, @Username, @Password)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FirstName", userInformation.FirstName);
                cmd.Parameters.AddWithValue("@LastName", userInformation.LastName);
                cmd.Parameters.AddWithValue("@Gender", userInformation.Gender);
                cmd.Parameters.AddWithValue("@Email", userInformation.Email);
                cmd.Parameters.AddWithValue("@Address", userInformation.Address);
                cmd.Parameters.AddWithValue("@Username", userInformation.UserName);
                cmd.Parameters.AddWithValue("@Password", userInformation.Password);
                // Open the connection, execute the command, and close the connection
                con.Open();
                int a = cmd.ExecuteNonQuery();
                con.Close();

                // If the insert was successful, set the result to true
                if (a > 0)
                {
                    result = true;
                }
            }


            return result;
        }
    }

   


}


    



