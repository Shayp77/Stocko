<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/NavBar.Master" AutoEventWireup="true" CodeBehind="InsertType.aspx.cs" Inherits="StockoApp.Views.InsertType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="insertitem" runat="server">
     <h1>-- Insert Item Type Page --</h1>
     <hr />
     <div class="bawahitem">
         <asp:Label ID="ItemTypenamelbl" runat="server" Text="Item Type Name"></asp:Label>
         <asp:TextBox ID="itemtypenametb" runat="server"></asp:TextBox>
     </div>
     <div class="but">
         <asp:Button ID="itemtypeinser" runat="server" Text="Insert" OnClick="itemtypeinser_Click" />
     </div>
     <div>
         <asp:Label ID="ErrorLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
     </div>
 </div>
</asp:Content>
