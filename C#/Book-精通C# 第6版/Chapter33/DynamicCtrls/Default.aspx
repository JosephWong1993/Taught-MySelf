<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <hr />
            <h1>Dynamic Controls</h1>
            <asp:Label ID="lblTextBoxText" runat="server"></asp:Label>
            <hr />
        </div>

        <%-- Panel有三个包含控件 --%>
        <asp:Panel ID="myPanel" runat="server" Width="200px"
            BorderColor="Black" BorderStyle="Solid">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"></asp:Button><br />
            <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
        </asp:Panel>
        <br />
        <asp:Button ID="btnClearPanel" runat="server" Text="ClearPanel" OnClick="btnClearPanel_Click" /><br />
        <asp:Button ID="btnAddWidgets" runat="server" Text="AddWidgets" OnClick="btnAddWidgets_Click" /><br />
        <asp:Label ID="lblControlInfo" runat="server"></asp:Label><br />
        <asp:Button ID="btnGetTextData" runat="server" Text="GetTextData" OnClick="btnGetTextData_Click" /><br />
        <asp:Label ID="lblTextBoxData" runat="server"></asp:Label>
    </form>
</body>
</html>
