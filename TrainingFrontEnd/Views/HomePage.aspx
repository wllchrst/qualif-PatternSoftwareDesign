<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainLayout.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="TrainingFrontEnd.Views.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Home Page</h1>
    <asp:Label ID="Log" runat="server" Text=""></asp:Label>
    <asp:GridView ID="SongsGridView" runat="server" AutoGenerateColumns="false" OnRowDeleting="SongsGridView_RowDeleting" OnRowCommand="SongsGridView_RowCommand" OnRowEditing="SongsGridView_RowEditing">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Song ID" SortExpression="Id"></asp:BoundField>
            <asp:BoundField DataField="SongName" HeaderText="Song Name" SortExpression="SongName"></asp:BoundField>
            <asp:BoundField DataField="Price" HeaderText="Song Price" SortExpression="Price"></asp:BoundField>

            <asp:TemplateField HeaderText="Actions" Visible="false">
                <ItemTemplate>
                    <asp:Button runat="server" Text="Edit" ID="EditButton" CommandName="Edit" UseSubmitBehavior="false"/>
                    <asp:Button runat="server" Text="Delete" ID="DeleteButton" UseSubmitBehavior="false" CommandName="Delete"/>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Actions" Visible="false">
                <ItemTemplate>
                    <asp:Button runat="server" Text="Buy" ID="BuyButton" UseSubmitBehavior="false" CommandName="Buy"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Label ID="CreateContainer" runat="server" Text="">
        <div>
            <h1>Create Song</h1>
        </div>
        <div>
            <asp:Label ID="SongNameLabel" runat="server" Text="Song Name"></asp:Label>
            <asp:TextBox ID="SongNameTextBox" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Song Price"></asp:Label>
            <asp:TextBox ID="PriceTextBox" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" OnClick="Button1_Click1" runat="server" Text="Button" />
    </asp:Label>

    <asp:Label ID="ManageUsers" runat="server" Text="">
        <div>
            <h1>Manage Users</h1>
        </div>
        <asp:GridView ID="UserGridView" runat="server" AutoGenerateColumns="false" OnRowDeleting="UserGridView_RowDeleting" OnRowEditing="UserGridView_RowEditing">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="User ID" SortExpression="Id"></asp:BoundField>
                <asp:BoundField DataField="Email" HeaderText="User Email" SortExpression="Email"></asp:BoundField>
                <asp:BoundField DataField="Password" HeaderText="User Password" SortExpression="Password"></asp:BoundField>
                <asp:BoundField DataField="Role" HeaderText="User Role" SortExpression="Role"></asp:BoundField>

                <asp:TemplateField HeaderText="Actions" Visible="false">
                    <ItemTemplate>
                        <asp:Button runat="server" Text="Change Role" ID="ChangeRoleButton" CommandName="Edit" UseSubmitBehavior="false"/>
                        <asp:Button runat="server" Text="Delete User" ID="DeleteUserButton" UseSubmitBehavior="false" CommandName="Delete"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </asp:Label>
</asp:Content>
