<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="StockoApp.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" type="text/css" href="~/Styles/navbar.css"/>

</head>
<body>
    <form id="form1" runat="server">
             <h1>Register Page</h1>
     <div class="bawahitem">
         <asp:Label ID="usernameLabel" runat="server" Text="Username: " />
         <asp:TextBox ID="usernameRegister" runat="server" Placeholder="Type your username"/>
     </div>
      <div class="bawahitem">
         <asp:Label ID="emailLabel" runat="server" Text="Email: " />
         <asp:TextBox ID="emailRegister" runat="server" Placeholder="Type your email"/>
     </div>
     <div class="bawahitem">
         <asp:Label ID="passwordLabel" runat="server" Text="Password: " />
         <asp:TextBox ID="passwordRegister" runat="server" Placeholder="Create your password" TextMode="Password" />
     </div>
     <div class="bawahitem">
         <asp:Label ID="confirmPasswordLabel" runat="server" Text="Confirm Password: " />
         <asp:TextBox ID="confirmPasswordRegister" runat="server" Placeholder="Confirm your Password" TextMode="Password" />
     </div>
     <div>
         <asp:Calendar ID="dobCalendar" runat="server"></asp:Calendar>
     </div>
     <div class="but">
         <asp:Button ID="SubmitRegister" runat="server" Text="Submit" OnClick="SubmitRegister_Click" />
     </div>

     <div>
         <asp:LinkButton ID="LoginPageButton" runat="server" Text="Already have an account? Login here!" OnClick="LoginPageButton_Click" />
     </div>
     <div>
         <asp:Label ID="registerError" runat="server" Text=""></asp:Label>
     </div>
 </form>
</body>
</html>
