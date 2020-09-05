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
            <asp:Button ID="btnGetBrowserStatus" runat="server" Text="GetBrowserStatus" OnClick="btnGetBrowserStatus_Click" />
            <asp:Button ID="btnHttpResponse" runat="server" Text="HttpResponse" OnClick="btnHttpResponse_Click"/>
            <asp:Button ID="btnWasteTime" runat="server" Text="WasteTime" OnClick="btnWasteTime_Click" />
            <asp:Label ID="lblOutput" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
