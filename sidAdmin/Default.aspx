<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="sidAdmin.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 
    <div class="jumbotron">
        <h1>SID Admin</h1>
        <p class="lead">Built with ASP.NET Web Forms for managing and administering SID</p>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="card-deck">
                <div class="card text-center">
                    <div class="card-body">
                        <h5 class="card-title">Applications Using SID:</h5>
                        <p class="h2-responsive teal-text">
                            <asp:Label ID="Label2" runat="server" Text="Label" />
                        </p>
                        <a href="SidApplications.aspx" class="btn btn-primary pull-right hvr-icon-forward">See All Applications <i class="fa fa-arrow-right hvr-icon"></i></a>
                    </div>
                    <div class="card-footer">
                        <small class="text-muted">Last updated 3 mins ago</small>
                    </div>
                </div>
                <div class="card text-center">
                    <div class="card-body">
                        <h5 class="card-title">Staff Using SID Applications:</h5>
                        <p class="h2-responsive teal-text">
                            <asp:Label ID="Label1" runat="server" Text="Label" />
                        </p>
                        <a href="SidApplicationsStaff.aspx" class="btn btn-primary pull-right hvr-icon-forward">See All Applications <i class="fa fa-arrow-right hvr-icon"></i></a>
                    </div>
                    <div class="card-footer">
                        <small class="text-muted">Last updated 3 mins ago</small>
                    </div>
                </div>
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title">Panel title</h5>
                        <p class="card-text ">This is a wider card with supporting text below as a natural lead-in to additional content. This card has even longer content than the first to show that equal height action.</p>
                    </div>
                    <div class="card-footer">
                        <small class="text-muted">Last updated 3 mins ago</small>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
