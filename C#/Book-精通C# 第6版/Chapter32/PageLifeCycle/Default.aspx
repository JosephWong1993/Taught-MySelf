<%@ Page Language="C#" AutoEventWireup="false" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnPostBack" runat="server" Text="PostBack" OnClick="btnPostBack_Click" />
            <asp:Button ID="btnTriggerError" runat="server" Text="TriggerError" OnClick="btnTriggerError_Click" />
        </div>
    </form>
</body>
</html>
