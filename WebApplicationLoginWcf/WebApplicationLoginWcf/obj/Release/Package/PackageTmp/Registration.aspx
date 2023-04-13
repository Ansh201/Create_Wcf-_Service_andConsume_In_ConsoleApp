<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="WebApplicationLoginWcf.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
        .auto-style2 {
            width: 119px;
        }
        table {
             margin:auto;
             width:300px;
             border:5px blue ridge;
                 
        
        }
        .auto-style3 {
            width: 948px;
        }
        .auto-style4 {
            width: 119px;
            height: 44px;
        }
        .auto-style5 {
            width: 948px;
            height: 44px;
        }
        .link {
        text-align:center;
        
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellpadding="3" cellspacing="3"  style="background-color: orange">
                <tr>
                    <td  style="text-align:center;font-size:25px; font-weight:bold" colspan="2">SIGNUP FORM</td>
                </tr>
                <tr>
                    <td colspan="2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">FIRST NAME</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="FirstNameTextBox" runat="server" Width="192px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Display="Dynamic" ErrorMessage="Please Enter Name" ForeColor="Red" SetFocusOnError="True" ControlToValidate="FirstNameTextBox">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">LAST NAME</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="LastNameTextBox" runat="server" Width="192px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Display="Dynamic" ErrorMessage="PleaseEnterLast Name" ForeColor="Red" SetFocusOnError="True" ControlToValidate="LastNameTextBox">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">GENDER</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="198px">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator InitialValue="Select"  ID="RequiredFieldValidator8" runat="server" Display="Dynamic" ErrorMessage="Please Select Gender" ForeColor="Red" SetFocusOnError="True" ControlToValidate="DropDownList1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">EMAIL</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="EmailTextBox" runat="server" Width="188px"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" ErrorMessage="Please Enter Valid Email" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="EmailTextBox">*</asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="Dynamic" ErrorMessage="Please Enter Email" ForeColor="Red" SetFocusOnError="True" ControlToValidate="EmailTextBox">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">ADDRESS</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="AddressTextBox" runat="server" Width="190px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Display="Dynamic" ErrorMessage="Please Enter Address" ForeColor="Red" SetFocusOnError="True" ControlToValidate="AddressTextBox">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">USERNAME</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="UserNameTextBox" runat="server" Width="190px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Display="Dynamic" ErrorMessage="Please Enter Username" ForeColor="Red" SetFocusOnError="True" ControlToValidate="UserNameTextBox">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">PASSWORD</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="PasswordTextBox" runat="server" Width="190px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Display="Dynamic" ErrorMessage="Please Enter Password" ForeColor="Red" SetFocusOnError="True" ControlToValidate="PasswordTextBox">*</asp:RequiredFieldValidator>
                    &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="PasswordTextBox" Display="Dynamic" ErrorMessage="Please Enter Strong Password Containing Ucase ,Lcase , number and special Character" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^.*(?=.{8,})(?=.*[\d])(?=.*[\W]).*$">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">CONFIRM<br />
                        PASSWORD</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="ConfirmPasswordTextBox" runat="server" Width="190px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" Display="Dynamic" ErrorMessage="Please Re-Enter Pass" ForeColor="Red" SetFocusOnError="True" ControlToValidate="ConfirmPasswordTextBox">*</asp:RequiredFieldValidator>
                    &nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="PasswordTextBox" ControlToValidate="ConfirmPasswordTextBox" Display="Dynamic" ErrorMessage="Password Mismatched" ForeColor="Red">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5">
                        <asp:Button ID="Button1" runat="server" Height="30px" Text="SIGNUP" Width="101px" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="link" colspan="2">&nbsp;
                        <a  href="LoginForm.aspx">Go To Login Form</a>

                    </td>
                </tr>
            </table>
        </div>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" BackColor="Yellow" BorderColor="Red" BorderStyle="Solid" />
    </form>

</body>
</html>
