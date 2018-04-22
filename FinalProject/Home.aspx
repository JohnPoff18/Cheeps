<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FinalProject.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" > 

    <div class="button">
        <asp:TextBox ID="CheepBox" runat="server" Height="74px" Width="562px" style="margin-left: 0px" placeholder="Cheep what's on your mind..." ></asp:TextBox><br />
    </div>
    <div class="button">
    <asp:Button ID="CheepButton" runat="server" Text="Cheep" OnClick="CheepButton_Click"/>
    </div>
    <div>
    <tr>
            <td>
                <asp:DataList ID="liveFeedDataList" runat="server" Width="100%" >
                    <ItemStyle CssClass="grid" />
                    <ItemTemplate>

                        <table class="tbl" style="border-bottom-style: solid; border-bottom-width:thin; border-bottom-color:#808080;">
                            <tr>
                                <td class="style8" rowspan="4">

                                    <asp:Image ID="imageLabel" runat="server" Height="73px" Width="63px" ImageUrl='<%#Eval("profilePic") %>'/>
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
            </td>
        </tr>
      </div>
      
      <asp:ObjectDataSource ID="CheepsDataSource" runat="server" TypeName="FinalProject.CheepDataAccess" SelectMethod="getCheeps"></asp:ObjectDataSource>
  
</asp:Content>


