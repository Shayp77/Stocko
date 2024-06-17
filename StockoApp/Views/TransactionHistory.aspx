<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/NavBar.Master" AutoEventWireup="true" CodeBehind="TransactionHistory.aspx.cs" Inherits="StockoApp.Views.TransactionHistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>-- Transaction History --</h1>
 <hr />

 <div>
     <asp:GridView ID="HeaderUser" runat="server" AutoGenerateColumns="False">
         <Columns>
             <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
             <asp:BoundField DataField="UserID" HeaderText="User ID" SortExpression="UserID" />
             <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="TransactionDate" />
             <asp:TemplateField HeaderText="Action">
                 <ItemTemplate>
                     <asp:Button ID="TransactionDetailsButton" runat="server" Text="Transaction Details" CommandName="ViewDetails" CommandArgument='<%# Eval("TransactionID") %>' OnClick="TransactionDetailsButton_Click" />
                 </ItemTemplate>
             </asp:TemplateField>
         </Columns>
     </asp:GridView>
 </div>
</asp:Content>
