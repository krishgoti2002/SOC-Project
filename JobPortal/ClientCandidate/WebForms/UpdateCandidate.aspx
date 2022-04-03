<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="UpdateCandidate.aspx.cs" Inherits="ClientCandidate.WebForms.UpdateCandidate" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
    </style>
    <div class="alert alert-success" role="alert" id="error">
        <h4><asp:Label ID="message_label" runat="server" Text="" CssClass="form-label"></asp:Label></h4>
    </div>
    <h2>
        <asp:Label ID="label_update" runat="server" Text="Update"></asp:Label></h2>
    <hr />
    <table>
        <tr>
            <td>
                <asp:Label ID="label_name" CssClass="h4" runat="server" Text="Name : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textbox_name" CssClass="form-control" runat="server" Width="408px" CausesValidation="True" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="required_field_validator_name" runat="server" ControlToValidate="textbox_name" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="label_email" CssClass="h4" runat="server" Text="Email : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textbox_email" CssClass="form-control" runat="server" Width="408px" CausesValidation="True" TextMode="Email" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="required_field_validator_email" runat="server" ControlToValidate="textbox_email" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="label_password" CssClass="h4" runat="server" Text="Password : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textbox_password" CssClass="form-control" runat="server" Width="408px" CausesValidation="True" TextMode="Password" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="required_field_validator_password" runat="server" ControlToValidate="textbox_password" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="label_mobile" CssClass="h4" runat="server" Text="Mobile No : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textbox_mobile" runat="server" CssClass="form-control" Width="408px" CausesValidation="True" MaxLength="10" TextMode="Number" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="required_field_validator_mobile" runat="server" ControlToValidate="textbox_mobile" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="label_collage_name" CssClass="h4" runat="server" Text="Collage Name : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textbox_collage_name" runat="server" CssClass="form-control" Width="408px" ReadOnly="True"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="label_gender" CssClass="h4" runat="server" Text="Gender : "></asp:Label>
            </td>
            <td>

                <asp:RadioButtonList ID="radio_button_gender" runat="server" CausesValidation="True" CellPadding="3" CellSpacing="3" Enabled="False" RepeatDirection="Horizontal">
                    <asp:ListItem Value="male">Male</asp:ListItem>
                    <asp:ListItem Value="female">Female</asp:ListItem>
                </asp:RadioButtonList>

            </td>
            <td>
                <asp:RequiredFieldValidator ID="required_field_validator_gender" runat="server" ControlToValidate="radio_button_gender" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="label_dob" CssClass="h4" runat="server" Text="Date of Birth : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textbox_dob" runat="server" CssClass="form-control" Width="408px" CausesValidation="True" TextMode="DateTime" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="required_field_validator_dob" runat="server" ControlToValidate="textbox_dob" ForeColor="#CC3300">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="label_skills" CssClass="h4" runat="server" Text="Enter your skill : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textbox_skills" runat="server" CssClass="form-control" Width="408px" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="button_add_skills" runat="server" CssClass="btn btn-info" Text="Add" OnClick="button_add_skills_Click" CausesValidation="False" Enabled="False" />
            </td>
        </tr>
        <tr>
            <td colspan="1">
                <asp:ListBox ID="listbox_skills" runat="server" CssClass="form-control" Height="71px" Width="242px"></asp:ListBox>
            </td>
            <td colspan="2">
                <asp:Button ID="button_clear_skills" runat="server" CssClass="btn btn-warning" Text="Delete" OnClick="button_clear_skills_Click" CausesValidation="False" Enabled="False" />
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="label_prefered_location" CssClass="h4" runat="server" Text="Enter your Prefered location : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textbox_prefered_location" CssClass="form-control" runat="server" Width="408px" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="button_add_prefered_location" CssClass="btn btn-info" runat="server" Text="Add" OnClick="button_add_prefered_location_Click" CausesValidation="False" Enabled="False" />
            </td>
        </tr>
        <tr>
            <td colspan="1">
                <asp:ListBox ID="listbox_prefered_location" runat="server" CssClass="form-control" Height="70px" Width="236px"></asp:ListBox>
            </td>
            <td colspan="2">
                <asp:Button ID="button_clear_location" CssClass="btn btn-warning" runat="server" Text="Delete" OnClick="button_clear_location_Click" CausesValidation="False" Enabled="False" />
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="label_experience" CssClass="h4" runat="server" Text="Enter your Experience : "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textbox_experience" runat="server" CssClass="form-control" Width="408px" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="button_add_experience" CssClass="btn btn-info" runat="server" Text="Add" OnClick="button_add_experience_Click" CausesValidation="False" Enabled="False" />
            </td>
        </tr>
        <tr>
            <td colspan="1">
                <asp:ListBox ID="listbox_experience" CssClass="form-control" runat="server" Height="70px" Width="230px"></asp:ListBox>
            </td>
            <td colspan="2">
                <asp:Button ID="button_clear_experience" CssClass="btn btn-warning" runat="server" Text="Delete" OnClick="button_clear_experience_Click" CausesValidation="False" Enabled="False" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Button ID="button_edit" CssClass="btn btn-primary" runat="server" Text="Edit" CausesValidation="False" OnClick="button_edit_Click"/>
                <asp:Button ID="button_update" CssClass="btn btn-success" runat="server" Text="Update" OnClick="button_update_Click" />
                <asp:HyperLink ID="hyperlink_delete" CssClass="btn btn-danger" runat="server" NavigateUrl="~/WebForms/DeleteCandidate.aspx">Delete Account</asp:HyperLink>
                <asp:HyperLink ID="hyperlink_back" CssClass="btn btn-info" runat="server" NavigateUrl="~/WebForms/Home.aspx">Back</asp:HyperLink>
            </td>
        </tr>

    </table>
    <script>
        var err = document.getElementById("error");
        var label = document.getElementById("<%= message_label.ClientID %>")
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
