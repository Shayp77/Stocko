<%@ Page Title="" Language="C#" MasterPageFile="~/Layout/NavBar.Master" AutoEventWireup="true" CodeBehind="InsertItem.aspx.cs" Inherits="StockoApp.Views.InsertItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="insertitem" runat="server">
    <h1>-- Insert Item Page --</h1>
    <hr />
    <div class="bawahitem">
        <asp:Label ID="itemnamlbl" runat="server" Text="Item Name"></asp:Label>
        <asp:TextBox ID="itemnamtb" runat="server"></asp:TextBox>
    </div>

    <div class="bawahitem">
        <asp:Label ID="pricelbl" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="pricetb" runat="server"></asp:TextBox>
    </div>

    <div class="bawahitem">
        <asp:Label ID="typelbl" runat="server" Text="Type ID"></asp:Label>
        <asp:TextBox ID="typetb" runat="server"></asp:TextBox>
    </div>
        <hr />

        <div class="but">

        
    <div>
        <asp:Button ID="insertiteme" runat="server" Text="Insert" OnClick="insertiteme_Click" />
    </div>

    <div>
        <asp:Button ID="BackBtn" runat="server" Text="Back to Manage Item" OnClick="BackBtn_Click" />
    </div>
</div>
    <div>
        <asp:Label ID="ErrLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
    </div>
</div>
</asp:Content>
