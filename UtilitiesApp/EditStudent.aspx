<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EditStudent.aspx.cs" Inherits="EditStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <header class="masthead bg-primary text-white text-center">
      <div class="container">

        <h1 runat="server" class="text-uppercase mb-0">Edit Student</h1>
      </div>
    </header>

    <div class="container">
        <asp:Label ID="Label1" runat="server" Text="Label">LastName: </asp:Label>
        <asp:TextBox ID="LastName" runat="server" CssClass="form-control"></asp:TextBox>
        </br>
        <asp:Label ID="Label2" runat="server" Text="Label">FirstMidName: </asp:Label>
        <asp:TextBox ID="FirstMidName" runat="server" CssClass="form-control"></asp:TextBox>
        </br>
        <asp:Label ID="Label3" runat="server" Text="Label">EnrollmentDate</asp:Label>
        <asp:TextBox ID="EnrollmentDate" runat="server" CssClass="form-control"></asp:TextBox>
        </br>
        <asp:Button ID="Save" runat="server" Text="Save" OnClick="Save_Click" />
    </div>
</asp:Content>

