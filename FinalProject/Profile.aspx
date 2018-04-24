<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="FinalProject.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <table style="width: 100%; height:20%; font-size: large; padding-top: 1%">
        <tr>
            <td>
                <div style="float: right; padding-right:10px">
                    <asp:Label ID="UsernameTextLabel" runat="server" Text="Username:"></asp:Label>
                </div>
                
            </td>
            <td>
                <div style="float: left; padding-left:10px">
                    <asp:Label ID="UsernameLabel" runat="server" Text="Example Username"></asp:Label>
                </div>
                
            </td>
        </tr>
        <tr>
            <td>
                <div style="float: right; padding-right:10px">
                    <asp:Label ID="NameTextLabel" runat="server" Text="Full Name:"></asp:Label>
                </div>
                
            </td>
            <td>
                <div style="float: left; padding-left:10px">
                    <asp:Label ID="NameLabel" runat="server" Text="Example Name"></asp:Label>
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
                    <asp:Label ID="EmailLabel" runat="server" Text="example@domain.com"></asp:Label>
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
                    <asp:Label ID="GenderLabel" runat="server" Text="Example Gender"></asp:Label>
                </div>
                
            </td>
        </tr>
        
    </table>
    <br />
    <div style="text-align: center">
        <asp:Button ID="EditProfileButton" runat="server" Text="Edit Profile" OnClick="EditProfileButton_Click" />
    </div>

    <div style="text-align: center; font-size: x-large; padding-top: 5%; padding-bottom: 2%">
        <asp:Label ID="MyCheepsTextLabel" runat="server" Text="My Recent Cheeps"></asp:Label>
    </div>
    <asp:DataList ID="liveFeedDataList" runat="server" Width="100%" >
                    <ItemStyle CssClass="grid" />
                    <ItemTemplate>

                        <table class="tbl" style="border-bottom-style: solid; border-bottom-width:thin; border-bottom-color:#808080;">
                            <tr>
                                <td class="style8" rowspan="4">

                                    <asp:Image ID="imageLabel" runat="server" Height="75px" Width="75px" ImageUrl='<%#Eval("profilePic") %>'/>
                                </td>
                                <td>
                                    
                                    <asp:Label ID="nameLiveLabel" runat="server" Font-Bold="true" ForeColor="#000000" Text='<%# Eval("uname") %>'></asp:Label>
                               
                                </td>                              
                            </tr>
                            
                            <tr>
                                 <td>
                                     <asp:Label ID="cheepLabel"  runat="server" Text='<%# Eval("cheep") %>'></asp:Label>
                                </td>
                                
                            </tr>
                            <tr>
                                
                                <td>
                                     <asp:Label ID="Label2" style="font-size:10px"  runat="server" Text='<%# Eval("date") %>'></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>

                </asp:DataList>
        
</asp:Content>
