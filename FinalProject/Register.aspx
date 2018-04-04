<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FinalProject.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    .content {
    max-width: 1100px;
    margin: auto;
    }
        .auto-style7 {
            width: 164px;
        }
        .auto-style9 {
            width: 164px;
            color: #FFFFFF;
        }
        .auto-style10 {
            width: 500px;
        }
    </style>
    </head>
<body>
    <div class="content">
    <form id="form1" runat="server">
        <table style="background-color:seagreen" class="content">
            <tr style="width:1100px; height:80px" >
                <td style="width:700px">
                    <div style="text-align:center">
                    <asp:Label ID="title" runat="server" Font-Bold="True" Font-Names="Brush Script MT" Font-Size="35pt" Text="Welcome to Cheeps!" ForeColor="White"></asp:Label>
                    </div>
                </td>
                <td style="width:150px">
                     <div style="text-align:left">
                     <asp:Label ID="UsernameRegister" runat="server" Text="Username" Font-Names="Cambria" ForeColor="White"></asp:Label>
                     </div>
                     <div style="text-align:left">
                     <asp:TextBox ID="NameLoginBox" runat="server" Width="155px"></asp:TextBox>
                     </div>
                </td>
                <td style="width:150px">
           
                     <div style="text-align:left">
                     <asp:Label ID="PasswordRegister" runat="server" Text="Password" Font-Names="Cambria" ForeColor="White"></asp:Label>
                     </div>
                     <div style="text-align:left">
                     <asp:TextBox ID="PasswordLoginBox" runat="server" Width="155px"></asp:TextBox>
                     </div>
                </td>
                <td style="width:200px" >
                    <div style="height:22px"> </div>
                    <asp:Button ID="LoginButton" runat="server" Text="Log In" BackColor="#009999" BorderColor="Black" Font-Names="Cambria" ForeColor="White" Width="65px" />
                </td>
            </tr>
        </table>
        <table style="background-color:lightseagreen; width:1100px; height:800px; margin-right: 0px;">
            <tr style="width:1100px; height:800px" >
                <td class="auto-style10">
                <div style="width:500px; height:100px"></div>
                <div style="width:500px; height:600px">
                    <asp:Image ID="Image1" runat="server" Height="500px" Width="550px" src="Images/social-media.png"/>
                    </div>
                <div style="width:500px; height:100px; text-align:center">
                    <asp:Label ID="Label1" runat="server" Font-Names="Brush Script MT" Font-Size="20pt" Text="Share, Comment, and Stay Connected with Cheeps...."></asp:Label>
                    </div>
                </td>
               
                <td style="vertical-align:top">

                    <div style="height:200px; text-align:center; margin-left: 0px;">

                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Create an Account!" Font-Names="Gill Sans Ultra Bold Condensed" Font-Size="30pt" ForeColor="White"></asp:Label>

                    </div>
                    <table style="width:550px; height: 420px">
                        <tr>
                            <td style="font-family:Georgia; font-size:medium; text-align:right" class="auto-style9">Username:</td>
                            <td style="width:180px">
                                <asp:TextBox ID="usernameText" runat="server" Width="180px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="usernameValidator" runat="server" ErrorMessage="Username is required" ControlToValidate="usernameText" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </td>
                        </tr>
                        <tr>
                            <td style="font-family:Georgia; font-size:medium; text-align:right" class="auto-style9">First Name:</td>
                            <td style="width:180px">
                                <asp:TextBox ID="firstnameText" runat="server" Width="180px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="firstnameValidator" runat="server" ErrorMessage="First name is required" ControlToValidate="firstnameText" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </td>
                        </tr>
                        <tr>
                            <td style="font-family:Georgia; font-size:medium; text-align:right" class="auto-style9">Last Name:</td>
                            <td style="width:180px">
                                <asp:TextBox ID="lastnameText" runat="server" Width="180px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="lastnameValidator" runat="server" ErrorMessage="Last name is required" ControlToValidate="lastnameText" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </td>
                        </tr>
                        <tr>
                            <td style="font-family:Georgia; font-size:medium; text-align:right" class="auto-style9">E-mail:</td>
                            <td style="width:180px">
                                <asp:TextBox ID="emailText" runat="server" Width="180px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="emailValidator" runat="server" ErrorMessage="E-mail is required" ControlToValidate="emailText" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                <br />
                                <asp:RegularExpressionValidator ID="emailRegex" runat="server" ErrorMessage="Enter a valid e-mail" ForeColor="#FF3300" ControlToValidate="emailText" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                </td>
                        </tr>
                        <tr>
                            <td style="font-family:Georgia; font-size:medium; text-align:right" class="auto-style9">Password:</td>
                            <td style="width:180px">
                                <asp:TextBox ID="passwordText" runat="server" Width="180px" TextMode="Password"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="passwordValidator" runat="server" ErrorMessage="Password is required" ControlToValidate="passwordText" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                </td>
                        </tr>
                        <tr>
                            <td style="font-family:Georgia; font-size:medium; text-align:right" class="auto-style9">Confirm Password:</td>
                            <td style="width:180px">
                                <asp:TextBox ID="compasswordText" runat="server" Width="180px" TextMode="Password"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="confirmationValidator" runat="server" ErrorMessage="Confirmation is required" ControlToValidate="compasswordText" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                                <br />
                                <asp:CompareValidator ID="compareValidator" runat="server" ControlToCompare="passwordText" ControlToValidate="compasswordText" ErrorMessage="Password must match" ForeColor="#FF3300"></asp:CompareValidator>
                                </td>
                        </tr>
                         <tr>
                            <td style="font-family:Georgia; font-size:medium; text-align:right" class="auto-style9">Gender:</td>
                            <td style="width:180px">
                                <asp:DropDownList ID="genderList" runat="server" Width="180px">
                                    <asp:ListItem>Select Gender</asp:ListItem>
                                    <asp:ListItem>Female</asp:ListItem>
                                    <asp:ListItem>Male</asp:ListItem>
                                </asp:DropDownList>
                             </td>
                            <td>
                                <asp:RequiredFieldValidator ID="genderValidator" runat="server" ControlToValidate="genderList" ErrorMessage="Select a gender" ForeColor="#FF3300" InitialValue="Select Gneder"></asp:RequiredFieldValidator>
                             </td>
                        </tr>
                         <tr>
                            <td class="auto-style7" ></td>
                            <td >
                                <asp:Button ID="RegisterButton" runat="server" Text="Register" BackColor="#009999" ForeColor="White" OnClick="RegisterButton_Click" />
                             </td>
                            
                        </tr>
                    </table>
                    
                </td>
            </tr>
        </table>
    </form>
    </div>
</body>
</html>


