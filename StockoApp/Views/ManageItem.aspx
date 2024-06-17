<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/NavBar.Master" AutoEventWireup="true" CodeBehind="ManageItem.aspx.cs" Inherits="StockoApp.Views.ManageItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>-- Manage Items Page --</h1>
 <hr />


<h2>Items Table</h2>
<div>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing">
        <Columns>
            <asp:BoundField DataField="ItemID" HeaderText="ID" SortExpression="ItemID"  />
            <asp:BoundField DataField="ItemName" HeaderText="Name" SortExpression="ItemName" />
            <asp:BoundField DataField="ItemPrice" HeaderText="Price" SortExpression="ItemPrice" />
            <asp:BoundField DataField="ItemType.ItemTypeID" HeaderText="Type" SortExpression="ItemTypeID" />

            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</div>

<h2>Types Table</h2>
<div>
    <asp:GridView ID="Type" runat="server" AutoGenerateColumns="False" OnRowDeleting="Type_RowDeleting" OnRowEditing="Type_RowEditing">
        <Columns>
            <asp:BoundField DataField="ItemTypeID" HeaderText="ID" SortExpression="ItemTypeID" />
            <asp:BoundField DataField="TypeName" HeaderText="Name" SortExpression="TypeName" />
            <asp:TemplateField HeaderText="Action">
                <ItemTemplate>
                    <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</div>

    <hr />
    <div class="but">

    
<div>
    <asp:Button ID="iteminsert" runat="server" Text="Insert Item" onclick="iteminsert_Click"/>
</div>

<div>
    <asp:Button ID="typeinsert" runat="server" Text="Insert Item Type" onclick="typeinsert_Click"/>
</div>
        </div>

</asp:Content>
