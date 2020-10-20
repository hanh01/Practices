<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateMember.aspx.cs" Inherits="GolfClub.CreateMember" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
        <div>
            Name:
            <input id="Text1" type="text" /><br />
            Gender:<asp:DropDownList ID="DropDownList1" runat="server">
                 <%--<asp:ListItem Selected="True" Text="--Select--"></asp:ListItem>--%>
                <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                <asp:ListItem Text="Report" Value="Report"></asp:ListItem>
                <asp:ListItem Text="System" Value="System"></asp:ListItem>
                <asp:ListItem Text="Reminder" Value="Reminder"></asp:ListItem>
            </asp:DropDownList>
            <br />
            Membership Fee:
            <input id="Text2" type="text" /><br />
            <input id="Submit1" type="submit" value="submit" /></div>
    </form>
</body>
</html>
