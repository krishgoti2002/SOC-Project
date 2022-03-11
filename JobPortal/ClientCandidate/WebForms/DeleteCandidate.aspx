<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteCandidate.aspx.cs" Inherits="ClientCandidate.WebForms.DeleteCandidate" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <h2>Are you sure ?</h2>
        </div>
        <div class="row">
            <asp:Button ID="button_delete" CssClass="btn btn-danger" runat="server" Text="Delete" OnClick="button_delete_Click" />
            <asp:HyperLink ID="hyperlink_delete" CssClass="btn btn-primary" runat="server" NavigateUrl="~/WebForms/UpdateCandidate.aspx">Cancel</asp:HyperLink>
        </div>
    </div>
</asp:Content>