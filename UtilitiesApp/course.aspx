<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="course.aspx.cs" Inherits="course" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <header class="masthead bg-primary text-white text-center">
      <div class="container">

        <h1 runat="server" class="text-uppercase mb-0">Courses List</h1>
      </div>
    </header>
        <div class="container">
            <asp:Table ID="Table2" runat="server" OnLoad="Table2_Load" Width="945px">
                <asp:TableRow runat="server" TableSection="TableHeader">
                    <asp:TableCell runat="server" Font-Bold="True">Title</asp:TableCell>
                    <asp:TableCell runat="server" Font-Bold="True">Credits</asp:TableCell>
                    <asp:TableCell runat="server"></asp:TableCell>
                </asp:TableRow>
            </asp:Table>

        </div>
    </div>
</asp:Content>

