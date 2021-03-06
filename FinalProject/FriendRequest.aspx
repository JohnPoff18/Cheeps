﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="FriendRequest.aspx.cs" Inherits="FinalProject.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table class="tbl">
        <tr>
            <td class="tblSearch"> 
               Friend Requests 
            </td>
        </tr>
        <tr>
            <td> &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="requestDataList" runat="server" Width="100%" onitemcommand="requestDataList_ItemCommand">
                    <ItemStyle CssClass="grid" />
                    <ItemTemplate>

                        <table class="tbl" style="border-bottom-style: solid; border-bottom-width:thin; border-bottom-color:#808080;">
                            <tr>
                                <td class="style8" rowspan="3">

                                    <asp:Image ID="userSearchImage" runat="server" Height="73px" Width="63px" ImageUrl='<%#Eval("profilepic") %>'/>
                                </td>
                                <td>
                                    Username:
                                    <asp:Label ID="nameSearchLabel" runat="server" Font-Bold="true" ForeColor="#000000" Text='<%# Eval("friendusername") %>'></asp:Label>
                               
                                </td>                              
                            </tr>
                            <tr>
                                <td style="text-align:right">
                                    <asp:Button ID="acceptButton" runat="server" Text="Accept" BackColor="#0066FF" BorderColor="Black" ForeColor="White" CommandName="accept" />
                                    <asp:Button ID="Button1" runat="server" Text="Reject" BackColor="#0066FF" BorderColor="Black" ForeColor="White" CommandName="reject"/>
                                </td>                           
                            </tr>
                            <tr>
                                 <td>
                                     Full Name:
                                     <asp:Label ID="fullnameLabel" Font-Bold="true" runat="server" Text='<%# Eval("firstname") + " " + Eval("lastname") %>'></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>

                </asp:DataList>
            </td>
        </tr>
         <tr>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
