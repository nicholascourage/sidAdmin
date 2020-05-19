<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SidApplicationsStaffDetailsView.aspx.cs" Inherits="sidAdmin.SidApplicationsStaffDetailsView" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md">
            <asp:FormView ID="SidApplicationsStaffDetailsFormView" runat="server" RenderOuterTable="False" DataKeyNames="StaffID" OnItemDeleting="SidApplicationsStaffDetailsFormView_ItemDeleting">
                <ItemTemplate>

                    <p><%# Eval("StaffID") %></p>
                    <p><%# Eval("FirstName") %></p>
                    <p><%# Eval("LastName") %></p>
                    <p><%# Eval("Title") %></p>
                    <p><%# Eval("email") %></p>
                    <p><%# Eval("TelephoneWork") %></p>
                    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModalLong">
                        Delete
                    </button>
                    <div class="modal fade" id="exampleModalLong" tabindex="-1" role="dialog" aria-labelledby="exampleModalLongTitle" aria-hidden="true">
                        <div class="modal-dialog" role="document">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h5 class="modal-title" id="exampleModalLongTitle">Delete staff member from SID?</h5>
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                        <span aria-hidden="true">&times;</span>
                                    </button>
                                </div>
                                <div class="modal-body">
                                    Are you sure you want to delete this staff member?
                                </div>
                                <div class="modal-footer">
                                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                    <asp:LinkButton CssClass="btn btn-primary" ID="DeleteButton" Text="Delete" CommandName="Delete" runat="server" />
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:FormView>
        </div>
        <div class="col-md">
            <h2>Associated Applications:</h2>
            <asp:FormView ID="StaffAssociatedApplicationsFormView" runat="server" RenderOuterTable="False" DataKeyNames="ApplicationID" OnItemDeleting="StaffAssociatedApplicationsFormView_ItemDeleting">
                <ItemTemplate>
                    <p><%# Eval("ApplicationName") %></p>
                    <p><%# Eval("AccessTypeDescription") %></p>
                    <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModalLong">
                        Delete
                    </button>
                    <div class="modal fade" id="exampleModalLong" tabindex="-1" role="dialog" aria-labelledby="exampleModalLongTitle" aria-hidden="true">
                        <div class="modal-dialog" role="document">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h5 class="modal-title" id="exampleModalLongTitle">Delete staff member from SID?</h5>
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                        <span aria-hidden="true">&times;</span>
                                    </button>
                                </div>
                                <div class="modal-body">
                                    Are you sure you want to delete this staff member?
                                </div>
                                <div class="modal-footer">
                                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                    <asp:LinkButton CssClass="btn btn-primary" ID="DeleteButton" Text="Delete" CommandName="Delete" runat="server" />
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:FormView>
        </div>
    </div>
   
</asp:Content>
