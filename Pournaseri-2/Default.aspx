<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Pournaseri_2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <p>
        <br />
    </p>
    <h1>
        <a href="Create.aspx">Create Page</a></h1>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LoadData" Width="144px" />
    </p>
    <p>
        <asp:ListBox ID="StudentListBox" runat="server" AutoPostBack="True" Height="91px" OnSelectedIndexChanged="StudentListBox_SelectedIndexChanged2" Width="95px" ></asp:ListBox>
    </p>

</asp:Content>
