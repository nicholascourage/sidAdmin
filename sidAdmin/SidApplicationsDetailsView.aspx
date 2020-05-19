<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SidApplicationsDetailsView.aspx.cs" Inherits="sidAdmin.SidApplicationDetailsView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="FormView1" runat="server" RenderOuterTable="False" DataKeyNames="ApplicationID" OnItemDeleting="FormView1_ItemDeleting" OnItemUpdating="FormView1_ItemUpdating" OnModeChanging="FormView1_ModeChanging">
        <ItemTemplate>
            <div class="card text-center">
                <div class="card-header">
                    <ul class="nav nav-tabs card-header-tabs">
                        <li class="nav-item">
                            <a class="nav-link active" href="#">Application</a>
                        </li>
                        <li class="nav-item">
                            <asp:LinkButton ID="EditButton" Text="Edit" CommandName="Edit" RunAt="server" CssClass="nav-link"/>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">Add New Application</a>
                        </li>
                    </ul>
                </div>
                <div class="card-body">
                    <h5 class="card-title"><%# Eval("ApplicationName") %></h5>
                    <p class="card-text"><%# Eval("ApplicationDescription") %></p>
                    <p class="card-text">Location: <%# Eval("ApplicationLocation") %></p>
                    <p class="card-text">Application ID: <%# Eval("ApplicationID") %></p>
                    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModalLong">
                        Delete
                    </button>
                </div>
            </div>


            <div class="modal fade" id="exampleModalLong" tabindex="-1" role="dialog" aria-labelledby="exampleModalLongTitle" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLongTitle">Delete application from SID?</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            Are you sure you want to delete the application?
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                            <asp:LinkButton CssClass="btn btn-primary" ID="DeleteButton" Text="Delete" CommandName="Delete" runat="server" />
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
        <EditItemTemplate>
            <div class="card text-center">
                <div class="card-header">
                    <ul class="nav nav-tabs card-header-tabs">
                        <li class="nav-item">
                            <asp:HyperLink runat="server" NavigateUrl='<%# "SidApplicationsDetailsView?ApplicationID=" + Request.QueryString["ApplicationID"] %>' Text="Application" CssClass="nav-link" />

                        </li>
                        <li class="nav-item">
                            <a class="nav-link active" href="#">Edit</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">Add New Application</a>
                        </li>
                    </ul>
                </div>
                <div class="card-body">
                    <asp:TextBox ID="ApplicationName" Text='<%# Bind("ApplicationName") %>' RunAt="Server" CssClass="form-control ml-auto mr-auto text-center edit-heading" />
                    <p class="card-text"><%# Eval("ApplicationDescription") %></p>
                    <p class="card-text">Location: <%# Eval("ApplicationLocation") %></p>
                    <p class="card-text">Application ID: <%# Eval("ApplicationID") %></p>
                    <asp:LinkButton ID="UpdateButton" Text="Update" CommandName="Update" RunAt="server" CssClass="btn btn-primary"/>
                </div>
            </div>
        </EditItemTemplate>
    </asp:FormView>

</asp:Content>
