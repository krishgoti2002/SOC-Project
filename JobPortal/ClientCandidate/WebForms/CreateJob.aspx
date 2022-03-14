<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"  CodeBehind="CreateJob.aspx.cs" Inherits="ClientCandidate.WebForms.CreateJob" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
            <h2>
                Create Job</h2>
    <hr />
    <table>
        <tr>
            <td>
                <asp:Label ID="label_name" CssClass="h4" runat="server" Text="Title:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textbox_title" CssClass="form-control" runat="server" Width="408px" CausesValidation="True"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="required_field_validator_name" runat="server" ControlToValidate="textbox_title" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="label_email" CssClass="h4" runat="server" Text="Email : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textbox_email" CssClass="form-control" runat="server" Width="408px" CausesValidation="True" TextMode="Email"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="required_field_validator_email" runat="server" ControlToValidate="textbox_email" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="label_mobile" CssClass="h4" runat="server" Text="Mobile No : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textbox_mobile" runat="server" CssClass="form-control" Width="408px" CausesValidation="True" MaxLength="10" TextMode="Number"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="required_field_validator_mobile" runat="server" ControlToValidate="textbox_mobile" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="label_collage_name" CssClass="h4" runat="server" Text="Company Name : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textbox_company_name" runat="server" CssClass="form-control" Width="408px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="textbox_company_name" ForeColor="#CC3300">*</asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="label_dob" CssClass="h4" runat="server" Text="Deadline: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textbox_deadline" runat="server" CssClass="form-control" Width="408px" CausesValidation="True" TextMode="Date"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="required_field_validator_dob" runat="server" ControlToValidate="textbox_deadline" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="label_dob0" CssClass="h4" runat="server" Text="Description: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="description" runat="server" CssClass="form-control" Width="408px" CausesValidation="True" TextMode="MultiLine"></asp:TextBox>
 
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="description" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
    
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="label_dob1" CssClass="h4" runat="server" Text="City: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textbox_city" CssClass="form-control" runat="server" Width="408px" CausesValidation="True"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="textbox_city" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        </tr>
        <tr>
            <td>
                <asp:Label ID="label_dob2" CssClass="h4" runat="server" Text="State: "></asp:Label>
            </td>
           <td>
                <asp:TextBox ID="textbox_state" CssClass="form-control" runat="server" Width="408px" CausesValidation="True"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="textbox_state" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        </tr>
        <tr>
            <td>
                <asp:Label ID="label_dob3" CssClass="h4" runat="server" Text="Required Experience: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textbox_exp" CssClass="form-control" runat="server" Width="408px" CausesValidation="True"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="textbox_exp" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Button ID="button_register" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="button_register_Click" />
                <asp:HyperLink ID="hyperlink_back" CssClass="btn btn-danger" runat="server" NavigateUrl="~/WebForms/Dashboard.aspx">Cancel</asp:HyperLink>
            </td>
        </tr>

    </table>
              

</asp:Content>
