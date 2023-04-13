using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WebApplicationLoginWcf.LoginServiceReference;
using WebApplicationLoginWcf.RegistrationServiceReference;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebApplicationLoginWcf.LoginServiceReference.Service1Client obj = new WebApplicationLoginWcf.LoginServiceReference.Service1Client();


            WebApplicationLoginWcf.RegistrationServiceReference.Service1Client obj1 = new WebApplicationLoginWcf.RegistrationServiceReference.Service1Client();


            WebApplicationLoginWcf.LoginServiceReference.UserDetails userInfo = new WebApplicationLoginWcf.LoginServiceReference.UserDetails();
            userInfo.UserName = "Ansh";
            userInfo.Password = "Ansh@123";
            var msg = obj.LoginUserDetails(userInfo);


            {
                Console.WriteLine("Employee Name = " + msg.ElementAt(0) + "      Employee Id = " + msg.ElementAt(1));

                //For registration

                WebApplicationLoginWcf.RegistrationServiceReference.UserReg userInformation = new WebApplicationLoginWcf.RegistrationServiceReference.UserReg();

                userInformation.FirstName = "Ansh";
                userInformation.LastName = "Patel";
                userInformation.Gender = "Male";
                userInformation.Email = "patel@gmail.com";
                userInformation.Address = "Varanasi ";
                userInformation.UserName = "Ansh201";
                userInformation.Password = "Ansh@123";
                userInformation.ConfirmPassword = "Ansh@123";

                bool result = obj1.RegisterUserDetails(userInformation);

                if (result)
                {
                    Console.WriteLine("Registration successful!");
                }
                else
                {
                    Console.WriteLine("Registration failed.");
                }

                // Close the client objects
                obj.Close();
                obj1.Close();

                Console.ReadLine();
            }
        }
    }
}
//        {   // Create an instance of the proxy class
//            WebApplicationLoginWcf.LoginServiceReference.Service1Client service = new WebApplicationLoginWcf.LoginServiceReference.Service1Client();

//            try
//            {
//                // Create a UserDetails object
//                UserDetails userInfo = new UserDetails();
//        userInfo.UserName = "username";
//                userInfo.Password = "password";

//                // Call the LoginUserDetails method
//                List<string> msg = service.LoginUserDetails(userInfo).ToList();

//                if (msg != null && msg.Count >= 2)
//                {
//                    Console.WriteLine("Login Successful");
//                    Console.WriteLine("Employee Name = " + msg.ElementAt(0) + "      Employee Id = " + msg.ElementAt(1));
//                }
//                else
//                {
//                    throw new Exception("Invalid response from service.");
//}
//            }
//            catch (Exception ex)
//            {
//    Console.WriteLine("Login failed");
//    Console.WriteLine("Error: " + ex.ToString());
//}

//// Close the connection to the service
//service.Close();

//Console.ReadLine();
//        }
//    }
//}



//            WebApplicationLoginWcf.LoginServiceReference.Service1Client service = new WebApplicationLoginWcf.LoginServiceReference.Service1Client();

//            // Create a UserDetails object
//            UserDetails userInfo = new UserDetails();

//            // Call the LoginUserDetails metho
//            List<string> result = service.LoginUserDetails(userInfo);

//            // Print the result to the console
//            foreach (string s in result)
//            {
//                Console.WriteLine(s);
//            }

//            // Close the connection to the service
//            service.Close();
//        }
//    }
//}


//WebApplicationLoginWcf.LoginServiceReference.Service1Client client = new WebApplicationLoginWcf.LoginServiceReference.Service1Client();
//// call the LoginUserDetails operation
//List<string> result1 = client.LoginUserDetails(userInfo).ToList();
//Console.WriteLine(result1);

//// call the RegisterUserDetails operation
//bool result2= client.RegisterUserDetails(userInformation);
//Console.WriteLine(result2);

//client.Close();  




//        WebApplicationLoginWcf.LoginServiceReference.Service1Client client = new WebApplicationLoginWcf.LoginServiceReference.Service1Client();


//        WebApplicationLoginWcf.LoginServiceReference.UserInfo userInfo = new WebApplicationLoginWcf.LoginServiceReference.UserInfo();
//        userInfo.Username = "username";
//        userInfo.Password = "password";

//        // call the LoginUserDetails operation
//        List<string> result1 = client.LoginUserDetails(userInfo).ToList();
//        Console.WriteLine(result1);

//        // define userInformation
//        WebApplicationLoginWcf.LoginServiceReference.UserInformation userInformation = new WebApplicationLoginWcf.LoginServiceReference.UserInformation();
//        userInformation.Username = "username";
//        userInformation.Password = "password";
//        userInformation.Email = "email@example.com";

//        // call the RegisterUserDetails operation
//        bool result2 = client.RegisterUserDetails(userInformation);
//        Console.WriteLine(result2);

//        client.Close();

//    }
//}
//}
