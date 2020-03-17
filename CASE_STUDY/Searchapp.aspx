<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="Searchapp.aspx.cs" Inherits="CASE_STUDY.Searchapp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table align="center">
        <tr>
            <td>UserSearch</td>
        </tr>
        <tr><td>Use any combination of fields below to search through all customers</td></tr>
        <tr>
            <td>FirstName</td>
            <td>LastName</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtFname" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>DOB</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox3" TextMode="Date" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>ApplicationID</td>
            
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtAppId" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Search" BackColor="#669900" class="BorderStyle" Height="35px" OnClick="Button1_Click" /></td>
        </tr>
      
    </table>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True"   PageSize="1" HorizontalAlign="Center" ></asp:GridView>








</asp:Content>
