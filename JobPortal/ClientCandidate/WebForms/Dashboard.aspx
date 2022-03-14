<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Dashboard.aspx.cs" Inherits="ClientCandidate.WebForms.Dashboard" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
           <h1><b>Welcome Yash Kundalia</b></h1>
           <p>
               <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" BorderStyle="None" OnClick="Button1_Click" Text="Create Job" />
           </p>
           <p>
               
           </p>
           <p>
               <asp:GridView ID="GridView1" runat="server" CellPadding="10" ForeColor="#333333" GridLines="None" >
                   <Columns>
                       <asp:TemplateField>
                           <ItemTemplate>
                                 <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Delete </asp:LinkButton>
                           </ItemTemplate>
                       </asp:TemplateField>
                       <asp:TemplateField>
                           <ItemTemplate>
                                 <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Edit </asp:LinkButton>
                           </ItemTemplate>
                       </asp:TemplateField>
                   </Columns>
  
                   <AlternatingRowStyle BackColor="White" />
                   <EditRowStyle BackColor="#2461BF" />
                   <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                   <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                   <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                   <RowStyle BackColor="#EFF3FB" />
                   <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                   <SortedAscendingCellStyle BackColor="#F5F7FB" />
                   <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                   <SortedDescendingCellStyle BackColor="#E9EBEF" />
                   <SortedDescendingHeaderStyle BackColor="#4870BE" />
               </asp:GridView>
           </p>

</asp:Content>

