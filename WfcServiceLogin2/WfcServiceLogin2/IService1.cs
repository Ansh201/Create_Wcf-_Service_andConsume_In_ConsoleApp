using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WfcServiceLogin2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.  
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<string> LoginUserDetails(UserDetails userInfo);


        [OperationContract]
        bool RegisterUserDetails(UserReg userInformation);
    }
    // TODO: Add your service operations here  
}
[DataContract]
public class UserDetails
{ public UserDetails()
    {

        UserName = string.Empty;
        Password = string.Empty;
    }
    [DataMember]
    public string UserName { get; set; }
    [DataMember]
    public string Password { get; set; }
}








// Use a data contract as illustrated in the sample below to add composite types to service operations.  
[DataContract]
public class UserReg
{
    public UserReg()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Gender = string.Empty;
        Email = string.Empty;
        Address = string.Empty;
        UserName = string.Empty;
        Password = string.Empty;
        ConfirmPassword = string.Empty;
    }
    [DataMember]
    public string FirstName { get; set; }
    [DataMember]
    public string LastName { get; set; }
    [DataMember]
    public string Gender { get; set; }
    [DataMember]
    public string Email { get; set; }
    [DataMember]
    public string Address { get; set; }
    [DataMember]
    public string UserName { get; set; }
    [DataMember]
    public string Password { get; set; }
    [DataMember]
    public string ConfirmPassword { get; set; }
}