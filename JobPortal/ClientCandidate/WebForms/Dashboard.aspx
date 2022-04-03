<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Dashboard.aspx.cs" Inherits="ClientCandidate.WebForms.Dashboard" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
           <h1><b>
               <asp:Label ID="label_name" runat="server" Text=""></asp:Label></b></h1>
           <p>
               <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" BorderStyle="None" OnClick="Button1_Click" Text="Create Job" />
           </p>
           <p>
               
           </p>
           <p>
               <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" Height="85px" Width="1002px" >
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
                   <EditRowStyle BackColor="#7C6F57" />
                   <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                   <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                   <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                   <RowStyle BackColor="#E3EAEB" />
                   <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                   <SortedAscendingCellStyle BackColor="#F8FAFA" />
                   <SortedAscendingHeaderStyle BackColor="#246B61" />
                   <SortedDescendingCellStyle BackColor="#D4DFE1" />
                   <SortedDescendingHeaderStyle BackColor="#15524A" />
               </asp:GridView>
           </p>

</asp:Content>

