<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/NavBar.Master" AutoEventWireup="true" CodeBehind="UpdateItemPage.aspx.cs" Inherits="StockoApp.Views.UpdateItemPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="insertitem" runat="server">
     <h1>-- Update Item Page --</h1>
     <h2><%=Request.QueryString["id"]%></h2>
     <hr />
     <div class="bawahitem">
         <asp:Label ID="ItemNameLBL" runat="server" Text="Item Name"></asp:Label>
         <asp:TextBox ID="ItemNameTB" runat="server"></asp:TextBox>
     </div>
     <div class="bawahitem">
         <asp:Label ID="ItemPriceLBL" runat="server" Text="Item Price"></asp:Label>
         <asp:TextBox ID="ItemPriceTB" runat="server"></asp:TextBox>
     </div>
     <div class="bawahitem">
         <asp:Label ID="ItemTypeLBL" runat="server" Text="Item Type ID"></asp:Label>
         <asp:TextBox ID="ItemTypeTB" runat="server"></asp:TextBox>
     </div>
     <div class="but">
         <asp:Button ID="updateitem" runat="server" Text="Update" OnClick="updateitem_Click"/>
     </div>
     <div>
         <asp:Label ID="ErrorLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
     </div>
 </div>
</asp:Content>
