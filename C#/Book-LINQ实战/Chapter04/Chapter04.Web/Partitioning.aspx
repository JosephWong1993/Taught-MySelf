<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Partitioning.aspx.cs" Inherits="Chapter04.Web.Partitioning" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Complete results</h1>
            <asp:GridView ID="GridViewComplete" runat="server" />

            <h1>Partial results</h1>

            Start:
            <asp:DropDownList ID="ddlStart" runat="server"
                AutoPostBack="true" CausesValidation="true"
                OnSelectedIndexChanged="DdlStart_SelectedIndexChanged">
            </asp:DropDownList>
            End:
            <asp:DropDownList ID="ddlEnd" runat="server"
                AutoPostBack="true" CausesValidation="true"
                OnSelectedIndexChanged="DdlStart_SelectedIndexChanged">
            </asp:DropDownList>

            <asp:CompareValidator ID="CompareValidator1" runat="server"
                ControlToValidate="ddlStart" ControlToCompare="ddlEnd"
                ErrorMessage="The second index must be higer than the first ont"
                Operator="LessThanEqual" Type="Integer">
            </asp:CompareValidator>

            <br />
            <asp:GridView ID="GridViewPartial" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
