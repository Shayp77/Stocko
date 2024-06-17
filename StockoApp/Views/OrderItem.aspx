<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/NavBar.Master" AutoEventWireup="true" CodeBehind="OrderItem.aspx.cs" Inherits="StockoApp.Views.OrderItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:GridView ID="ItemGV" AutoGenerateColumns="false" runat="server" OnRowCommand="ItemGV_RowCommand" DataKeyNames="ItemID">
    <Columns>
        <asp:BoundField DataField="ItemID" HeaderText="ItemID" SortExpression="ItemID"></asp:BoundField>
        <asp:BoundField DataField="ItemName" HeaderText="ItemName" SortExpression="ItemName"></asp:BoundField>
        <asp:BoundField DataField="ItemPrice" HeaderText="ItemPrice" SortExpression="ItemPrice"></asp:BoundField>
        <asp:BoundField DataField="ItemType.TypeName" HeaderText="ItemType" SortExpression="ItemType.TypeName"></asp:BoundField>
        <asp:TemplateField HeaderText="Quantity">
            <ItemTemplate>
                <asp:TextBox ID="QuantityTextBox" runat="server"></asp:TextBox>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Actions">
            <ItemTemplate>
                <asp:Button ID="btnOrder" runat="server" Text="Order" CommandName="Order" CommandArgument='<%# Container.DataItemIndex %>' />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
    <asp:Button ID="CheckoutButton" runat="server" Text="Checkout" OnClick="CheckoutButton_Click" />

    <asp:Button ID="cleartransaction" runat="server" Text="Clear carts" OnClick="cleartransaction_Click" />
</asp:Content>
