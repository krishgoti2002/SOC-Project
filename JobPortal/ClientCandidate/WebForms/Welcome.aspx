<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Welcome.aspx.cs" Inherits="ClientCandidate.WebForms.Welcome" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
            <br />
            <br />
            <marquee> <label style="color:red">welcome to the online Job portal........</label></marquee><br />
            <br />
        </div>
        <h1 class="display-1"><asp:Label ID="Label1" runat="server" Text="Online Job portal"></asp:Label></h1>
        <br />
        <br />
        <br />

        <ul>
            <li>This application can be used by both Recruiter and Candidate</li>
            <li>Using this application Candidate can find the job.</li>
            <li>Using this application Recruiter can also hire candidates as per their requirement </li>
        </ul>
        <br />
        <br />
        <br />
        <br />
        <div class="container w-50 m-auto">
            <div class="row">
                    <asp:HyperLink ID="hyperlink_candidate" CssClass="mr-1 btn btn-primary " runat="server" Text="Candidate" NavigateUrl="~/WebForms/LoginCandidate.aspx" />
                    <asp:HyperLink ID="hyperlink_recruiter" CssClass="ml-1 btn btn-info" runat="server" Text="Recruiter"/>
                    
            </div>
        </div>

  </asp:Content>