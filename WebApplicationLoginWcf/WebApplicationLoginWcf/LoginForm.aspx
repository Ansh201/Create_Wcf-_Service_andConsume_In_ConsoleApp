<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="WebApplicationLoginWcf.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

   <head runat="server">
    <title></title>
    <style type="text/css">
        
        .auto-style2 {
           
            text-align:center;
            font-size:30px;
        }

        table {
        
            margin:auto;
            width:300px;
            border:5px black ridge;
        
        }
        .Link{
            text-align:center;
             

        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table cellpadding="4" cellspacing="4" style="background-color: lightcyan" >
                <tr>
                    <td style="text-align:center;font-size:25px;font-weight:bold" colspan="2">LOGIN</td>
                </tr>
                <tr>
                    <td class="auto-style2">USERNAME</td>
                    <td>
                        <asp:TextBox ID="UserTextBox" runat="server" Width="314px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="UserTextBox" Display="Dynamic" ErrorMessage="Please Enter Username" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">PASSWORD</td>
                    <td>
                        <asp:TextBox ID="PassTextBox" runat="server" Width="314px" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="PassTextBox" Display="Dynamic" ErrorMessage="Please Enter Password" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="LoginButton" runat="server" Text="Login" Width="88px" OnClick="LoginButton_Click" />
                    </td>
                </tr>
                <tr>  
            <td></td>  
            <td colspan="3">  
                <asp:Label ID="Label3" runat="server"></asp:Label></td>  
            <td></td>  
        </tr>  
                <tr>
                    <td class="Link" colspan="2">

                        <a href="Registration.aspx">Not Registerd yet ? Click Here </a>

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
