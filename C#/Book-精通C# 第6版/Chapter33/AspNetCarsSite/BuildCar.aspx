<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="BuildCar.aspx.cs" Inherits="BuildCardPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <label>Use this Wizard to build your Dream Car</label>
    <asp:wizard id="carWizard" runat="server" activestepindex="3" OnFinishButtonClick="carWizard_FinishButtonClick">
        <WizardSteps>
            <asp:WizardStep ID="WizardStep1" runat="server" Title="Pick Your Model">
                <asp:TextBox ID="txtCarModel" runat="server"></asp:TextBox>
            </asp:WizardStep>
            <asp:WizardStep ID="WizardStep2" runat="server" Title="Pick Your Color">
                <asp:ListBox ID="ListBoxColors" runat="server" Width="237px">
                    <asp:ListItem>Purple</asp:ListItem>
                    <asp:ListItem>Green</asp:ListItem>
                    <asp:ListItem>Red</asp:ListItem>
                    <asp:ListItem>Yellow</asp:ListItem>
                    <asp:ListItem>Pea Soup Green</asp:ListItem>
                    <asp:ListItem>Black</asp:ListItem>
                    <asp:ListItem>Lime Green</asp:ListItem>
                </asp:ListBox>
            </asp:WizardStep>
            <asp:WizardStep runat="server" Title="Name Your Car">
                <asp:TextBox ID="txtCarPetName" runat="server"></asp:TextBox>
            </asp:WizardStep>
            <asp:WizardStep runat="server" Title="Deivery Date">
                <asp:Calendar ID="carCalendar" runat="server"></asp:Calendar>
            </asp:WizardStep>
        </WizardSteps>
    </asp:wizard>
    <asp:label runat="server" id="lblOrder"></asp:label>
</asp:Content>

