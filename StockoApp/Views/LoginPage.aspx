<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="StockoApp.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" type="text/css" href="~/Styles/navbar.css"/>

</head>
<body>
    <form id="form1" runat="server">
<h1>Login Page</h1>
<div class="bawahitem">
    <asp:Label ID="usernameLabel" runat="server" Text="Username: " />
    <asp:TextBox ID="usernameLogin" runat="server" Placeholder="Type your username"/>
</div>
<div class="bawahitem">
    <asp:Label ID="passwordLabel" runat="server" Text="Password: " />
    <asp:TextBox ID="passwordLogin" runat="server" Placeholder="Type your password" TextMode="Password"/>
</div>
<div>
    <asp:CheckBox ID="rememberMeLogin" runat="server" Text="Remember Me" />
</div>
<div class="but">
    <asp:Button ID="SubmitLogin" runat="server" Text="Login" OnClick="SubmitLogin_Click" />
</div>
<div>
    <asp:LinkButton ID="RegisterPageButton" runat="server" Text="Don't have an account? Register here!" OnClick="RegisterPageButton_Click" />
</div>
<div>
    <asp:Label ID="errorLabel" runat="server" Text="" />
</div>
    </form>
</body>
</html>
