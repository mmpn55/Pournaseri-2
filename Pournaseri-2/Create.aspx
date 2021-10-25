<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Pournaseri_2.Create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <br /><br />
    <asp:Label ID="Label1" runat="server" Text="کد سازمانی"></asp:Label>
    <asp:TextBox ID="TxtID" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label2" runat="server" Text="نام کارمند"></asp:Label>
    <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label3" runat="server" Text="حقوق ساعتی"></asp:Label>
    <asp:TextBox ID="TxtSalary" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ذخیره" />

</body>
</html>
