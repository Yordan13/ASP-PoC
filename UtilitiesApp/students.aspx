<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="students.aspx.cs" Inherits="students" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">  
    <div class="container">
        <header class="masthead bg-primary text-white text-center">
      <div class="container">

        <h1 runat="server" class="text-uppercase mb-0">Students List</h1>
      </div>
    </header>
        <div class="container">
            
          <asp:Table ID="Table1" runat="server" Width="963px" OnLoad="Table1_Load" Height="27px">
              <asp:TableRow runat="server" TableSection="TableHeader">
                  <asp:TableCell runat="server" Font-Bold="True">LastName</asp:TableCell>
                  <asp:TableCell runat="server" Font-Bold="True">FirstMidName</asp:TableCell>
                  <asp:TableCell runat="server">EnrollmentDate</asp:TableCell>
                  <asp:TableCell runat="server"></asp:TableCell>
              </asp:TableRow>

          </asp:Table>
        </div>
    </div>
</asp:Content>

