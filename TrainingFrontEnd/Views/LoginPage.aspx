<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="TrainingFrontEnd.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Login Page</h1>
        <div>
            <asp:Label ID="EmailLabel" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:CheckBox ID="RememberMeCheck" runat="server" />
        </div>
        <asp:Label ID="ErrorLabel" runat="server" Text=""></asp:Label>
        <asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click"/>
        <asp:LinkButton ID="RegisterPageLink" runat="server" OnClick="RegisterPageLink_Click">Dont have an account? Register!!!!</asp:LinkButton>
    </form>
</body>
</html>