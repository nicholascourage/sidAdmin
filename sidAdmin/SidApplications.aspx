<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SidApplications.aspx.cs" Inherits="sidAdmin.SidApplications" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="datatable table table-striped" GridLines="None">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="ApplicationID" DataNavigateUrlFormatString="SidApplicationsDetailsView?ApplicationID={0}" HeaderText="ApplicationName" SortExpression="ApplicationName" DataTextField="ApplicationName" ControlStyle-CssClass="blue-text" />
            <asp:BoundField DataField="ApplicationDescription" HeaderText="ApplicationDescription" SortExpression="ApplicationDescription" />
            <asp:BoundField DataField="ApplicationLocation" HeaderText="ApplicationLocation" SortExpression="ApplicationLocation" />           
        </Columns>
    </asp:GridView>
</asp:Content>
