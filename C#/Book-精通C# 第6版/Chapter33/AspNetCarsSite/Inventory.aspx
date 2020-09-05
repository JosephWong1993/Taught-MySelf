<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Inventory.aspx.cs" Inherits="InventoryPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <label>Here is our current Inventory!</label>
    <asp:gridview id="GridView1" runat="server" autogeneratecolumns="False" datakeynames="CarID" datasourceid="SqlDataSource1" emptydatatext="没有可显示的数据记录。" AllowPaging="True" AllowSorting="True">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="CarID" HeaderText="CarID" ReadOnly="True" SortExpression="CarID" />
            <asp:BoundField DataField="Make" HeaderText="Make" SortExpression="Make" />
            <asp:BoundField DataField="Color" HeaderText="Color" SortExpression="Color" />
            <asp:BoundField DataField="PetName" HeaderText="PetName" SortExpression="PetName" />
        </Columns>
    </asp:gridview>
    <asp:sqldatasource id="SqlDataSource1" runat="server"
        connectionstring="<%$ ConnectionStrings:AutoLotConnectionString1 %>"
        deletecommand="DELETE FROM [Inventory] WHERE [CarID] = @CarID"
        insertcommand="INSERT INTO [Inventory] ([CarID], [Make], [Color], [PetName]) VALUES (@CarID, @Make, @Color, @PetName)"
        providername="<%$ ConnectionStrings:AutoLotConnectionString1.ProviderName %>"
        selectcommand="SELECT [CarID], [Make], [Color], [PetName] FROM [Inventory]"
        updatecommand="UPDATE [Inventory] SET [Make] = @Make, [Color] = @Color, [PetName] = @PetName WHERE [CarID] = @CarID">
    <DeleteParameters>
        <asp:Parameter Name="CarID" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="CarID" Type="Int32" />
        <asp:Parameter Name="Make" Type="String" />
        <asp:Parameter Name="Color" Type="String" />
        <asp:Parameter Name="PetName" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="Make" Type="String" />
        <asp:Parameter Name="Color" Type="String" />
        <asp:Parameter Name="PetName" Type="String" />
        <asp:Parameter Name="CarID" Type="Int32" />
    </UpdateParameters>
    </asp:sqldatasource>
</asp:Content>




