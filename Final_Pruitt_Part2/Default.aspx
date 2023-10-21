<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Final_Pruitt_Part2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Campus Inventory Web Application"></asp:Label>
            <br />
            <br />
            Go To Building Info
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Building.aspx">Building</asp:HyperLink>
            <br />
            <br />
            Go To Equipment Info
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Equipment.aspx">Equipment</asp:HyperLink>
            <br />
            <br />
            Go To Employee Info
            <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Employee.aspx">Employee</asp:HyperLink>
        </div>
    </form>
</body>
</html>
