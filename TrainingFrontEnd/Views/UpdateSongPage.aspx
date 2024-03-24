<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateSongPage.aspx.cs" Inherits="TrainingFrontEnd.Views.UpdateSongPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Update Song Page</h1>
        </div>
        <div>
            <asp:Label ID="SongNameLabel" runat="server" Text="Song Name"></asp:Label>
            <asp:TextBox ID="SongNameTextBox" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Song Price"></asp:Label>
            <asp:TextBox ID="PriceTextBox" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="UpdateButton" runat="server" Text="Update Song!!" OnClick="UpdateButton_Click"/>
    </form>
</body>
</html>
