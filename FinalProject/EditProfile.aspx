<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="FinalProject.EditProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center; padding:5px; font-size:large">
        <asp:Label ID="MessageLabel" runat="server" Text="Fill out the fields you wish to change. Any left blank will not be changed."></asp:Label>
    </div>
    <table style="width: 100%; height:20%; font-size: large; padding-top: 1%">
        <tr>
            <td>
                <div style="float: right; padding-right:10px">
                    <asp:Label ID="FirstNameTextLabel" runat="server" Text="First Name:"></asp:Label>
                </div>
                
            </td>
            <td>
                <div style="float: left; padding-left:10px">
                    <asp:TextBox ID="FirstNameTextBox" runat="server"></asp:TextBox>
                </div>
                
            </td>
        </tr>

        <tr>
            <td>
                <div style="float: right; padding-right:10px">
                    <asp:Label ID="LastNameTextLabel" runat="server" Text="Last Name:"></asp:Label>
                </div>
                
            </td>
            <td>
                <div style="float: left; padding-left:10px">
                    <asp:TextBox ID="LastNameTextBox" runat="server"></asp:TextBox>
                </div>
                
            </td>
        </tr>
        
        <tr>
            <td>
                <div style="float: right; padding-right:10px">
                    <asp:Label ID="EmailTextLabel" runat="server" Text="Email:"></asp:Label>
                </div>
                
            </td>
            <td>
                <div style="float: left; padding-left:10px">
                    <asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox>
                </div>
                
            </td>
        </tr>

        <tr>
            <td>
                <div style="float: right; padding-right:10px">
                    <asp:Label ID="GenderTextLabel" runat="server" Text="Gender:"></asp:Label>
                </div>
                
            </td>
            <td>
                <div style="float: left; padding-left:10px">
                    <asp:DropDownList ID="genderList" runat="server">
                        <asp:ListItem>Select Gender</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                    </asp:DropDownList>
                </div>
                
            </td>
        </tr>
        
    </table>
    <div style="text-align: center">
        <asp:Button ID="EditProfileSubmitButton" runat="server" Text="Submit" OnClick="EditProfileSubmitButton_Click"/>
        <asp:Button ID="EditProfileCancelButton" runat="server" Text="Cancel" OnClick="EditProfileCancelButton_Click"/>
    </div>
</asp:Content>
