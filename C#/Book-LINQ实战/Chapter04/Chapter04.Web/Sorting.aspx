<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sorting.aspx.cs" Inherits="Chapter04.Web.Sorting" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GeidView1" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField HeaderText="Publisher" DataField="Publisher" />
                    <asp:BoundField HeaderText="Price" DataField="Price" />
                    <asp:BoundField HeaderText="Book" DataField="Title" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
