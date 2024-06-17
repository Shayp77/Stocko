<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/NavBar.Master" AutoEventWireup="true" CodeBehind="UpdateItemType.aspx.cs" Inherits="StockoApp.Views.UpdateItemType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="insertitem" runat="server">
    <h1>-- Update Item Type Page --</h1>
    <h2><%=Request.QueryString["id"]%></h2>
    <hr />
    <div class="bawahitem">
        <asp:Label ID="ItemTypeNameLBl" runat="server" Text="Item Type Name"></asp:Label>
        <asp:TextBox ID="ItemTypeNameTB" runat="server"></asp:TextBox>
    </div>
    <div class="but">
        <asp:Button ID="updateitem" runat="server" Text="Update" OnClick="updateitem_Click"/>
    </div>
    <div>
        <asp:Label ID="ErrorLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
    </div>
</div>
</asp:Content>
