<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="LoginRecruiter.aspx.cs" Inherits="ClientCandidate.WebForms.LoginRecruiter" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .con{
            width:500px;
            border: 2px solid red;
            margin:auto;
            padding:20px;
            margin-top:20px;
        }
        .inp{
            width:100%;
        }
        
    </style>
    <div class="alert alert-danger" role="alert" id="error">
            <h4><asp:Label ID="error_label" runat="server" Text="" CssClass="form-label"></asp:Label></h4>
    </div>
    <div class="card con">
        <div class="header">
            <h1 class="text-center">Log in</h1>
        </div>
        <div class="card-body">
            <asp:Label ID="label_email" CssClass="h4" runat="server" Text="Email : "></asp:Label>
            <asp:TextBox ID="textbox_email" runat="server" CssClass="form-control inp" Width="100%" />
            <asp:Label ID="label_password" CssClass="h4" runat="server" Text="Password : "></asp:Label>
            <asp:TextBox ID="textbox_password" CssClass="form-control inp" runat="server" TextMode="Password" Width="100%" />
            <br />
            <asp:Button ID="button_login" runat="server" CssClass="btn btn-primary" Text="Login" OnClick="button_login_Click" />
            <asp:HyperLink ID="hyperlink_cancel" CssClass="btn btn-danger" runat="server" NavigateUrl="~/WebForms/Welcome.aspx">Back</asp:HyperLink>
        </div>
        <p class="m-5">
            <asp:HyperLink ID="hyperlink_register" runat="server" NavigateUrl="~/WebForms/RegisterCandidate.aspx">Click Here to Register...</asp:HyperLink>
        </p>
    </div>
    <script>
        var err = document.getElementById("error");
        var label = document.getElementById("<%= error_label.ClientID %>")
        if (label.innerText == "") {
            err.style.display = "none";
        }
        else {
            err.style.display = "block";
            setTimeout(function () {
                err.style.display = "none";
            }, 5000);
        }
    </script>
</asp:Content>

