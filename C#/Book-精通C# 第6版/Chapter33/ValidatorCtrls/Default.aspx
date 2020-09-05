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
            <asp:Label runat="server">Required Field</asp:Label>
            <br />
            <asp:TextBox ID="txtRequiredField" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="ReguiredFieldValidator1"
                runat="server" ControlToValidate="txtRequiredField"
                ErrorMessage="Oops! Need to enter data."
                InitialValue="Please enter your name" Display="None">
            </asp:RequiredFieldValidator>
            <br />

            <asp:Label runat="server">Range 0-100</asp:Label>
            <br />
            <asp:TextBox ID="txtRange" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1"
                runat="server" ControlToValidate="txtRange"
                ErrorMessage="Please enter value between 0 and 100."
                MaximumValue="100" MinimumValue="0" Type="Integer" Display="None">
            </asp:RangeValidator>
            <br />

            <asp:Label runat="server">Enter your US SSN</asp:Label>
            <br />
            <asp:TextBox ID="txtRegExp" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                runat="server" ControlToValidate="txtRegExp"
                ErrorMessage="Please enter a valid US SSN."
                ValidationExpression="\d{3}-\d{2}-d{4}" Display="None">
            </asp:RegularExpressionValidator>
            <br />

            <asp:Label runat="server">Value < 20</asp:Label>
            <br />
            <asp:TextBox ID="txtComparison" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server"
                ControlToValidate="txtComparison"
                ErrorMessage="Enter a value less than 20." Operator="LessThan"
                ValueToCompare="20" Type="Integer" Display="None">
            </asp:CompareValidator>
            <br />

            <asp:Button ID="btnPostback" runat="server" Text="Post back" OnClick="btnPostback_Click" />
            <br />
            <asp:Label ID="lblValidationComplete" runat="server"></asp:Label>
            <asp:ValidationSummary ID="ValidationSummary1"
                runat="server" Width="353px"
                HeaderText="Here are the things you must correct."
                ShowMessageBox="true" ShowSummary="false" />
        </div>
    </form>
</body>
</html>
