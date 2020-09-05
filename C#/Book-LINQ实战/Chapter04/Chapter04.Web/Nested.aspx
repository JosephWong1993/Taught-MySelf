<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Nested.aspx.cs" Inherits="Chapter04.Web.Nested" %>

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
                    <asp:BoundField HeaderText="Publisher" DataField="Publisher" />
                    <asp:TemplateField HeaderText="Books">
                        <ItemTemplate>
                            <asp:BulletedList ID="BulletedList1" runat="server"
                                DataSource='<%# Eval("Books") %>'
                                DataValueField="Title" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
