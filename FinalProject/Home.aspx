<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="FinalProject.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 

    <div class="button">
        <asp:TextBox ID="CheepBox" runat="server" Height="74px" Width="562px" style="margin-left: 0px" Text="Cheep what's on your mind..."></asp:TextBox><br />
    </div>
    <div class="button">
    <asp:Button ID="CheepButton" runat="server" Text="Cheep" BorderWidth:10px OnClick="CheepButton_Click"/>
    </div>
    <div>
    <asp:ListView ID="ListViewCheeps" runat="server" DataSourceID ="CheepsDataSource" class="livefeed">
        <LayoutTemplate>
            <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
        </LayoutTemplate>
        
                            
        <ItemTemplate>
            <div id="livefeed" runat="server" class="livefeed">
                <center><asp:Image ID="Livefeedimage" runat="server" Height="50px" Width="50px" ImageUrl="/Images/Default.png"/><br />
                
                <%#Eval("Username") %> : 
                <%#Eval("Cheep") %><br />
                <%#Eval("Date") %><br /></center>
               
            </div>
         </ItemTemplate>
                        
      </asp:ListView>
      </div>
      
      <asp:ObjectDataSource ID="CheepsDataSource" runat="server" TypeName="FinalProject.CheepDataAccess" SelectMethod="getCheeps"></asp:ObjectDataSource>
  
</asp:Content>


