<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Step2a.aspx.cs" Inherits="Chapter04.Web.Step2a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Book" DataField="Title" />
                    <asp:BoundField HeaderText="Price" DataField="Price" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
