<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainLayout.Master" AutoEventWireup="true" CodeBehind="SongsPage.aspx.cs" Inherits="TrainingFrontEnd.Views.SongsPage" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Transaction Page</h1>
    <asp:GridView ID="UserTransactionGridView" runat="server" Visible="false"></asp:GridView>
    <asp:GridView ID="TransactionGridView" runat="server" Visible="false"></asp:GridView>
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" />
</asp:Content>
