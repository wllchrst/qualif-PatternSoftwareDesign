<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="TrainingFrontEnd.Views.RegisterPage" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Register Page</h1>
        <div>
            <asp:Label ID="EmailLabel" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="Email" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="PasswordLabel" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Label ID="InfoLabel" runat="server" Text=""></asp:Label>
        <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click"/>
        <asp:LinkButton ID="LoginLink" OnClick="LoginLink_Click" runat="server">Already have an account?</asp:LinkButton>
    </form>
</body>
</html>
