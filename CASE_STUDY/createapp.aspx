<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="createapp.aspx.cs" Inherits="CASE_STUDY.createapp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
  
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>
    .BorderStyle{
    border-radius:10px;}
        </style>
    <table align="center">
        <tr>
            <td>Create Application</td>
            <td></td>
            <td></td>
            <td colspan="3" style="color: #FF0000">*RequiredField</td>
        </tr>
        <tr>
            <td>Household member</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="*" ForeColor="Red"></asp:Label>Firstname</td>
            <td>
                M.I</td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="*" ForeColor="Red"></asp:Label>Lastname</td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Label">Suffix</asp:Label></td>
            </tr>
      
        <tr>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox></td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True">
                    <asp:ListItem Value="-1">Select</asp:ListItem>
                    <asp:ListItem>Mr</asp:ListItem>
                    <asp:ListItem>Mrs</asp:ListItem>
                    <asp:ListItem>Miss</asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td>  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="First Name cannot be blank" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>  </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="*" ForeColor="Red"></asp:Label>Date of Birth(mm/dd/yyyy)</td>
        <td>
            <asp:Label ID="Label6" runat="server" Text="*" ForeColor="Red"></asp:Label>Gender</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox4" TextMode="Date" runat="server"></asp:TextBox></td>
            <td>
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
            <td></td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Add Member" BackColor="#669900" class="BorderStyle" Height="35px" OnClick="Button1_Click" /></td>
        </tr>
       
        <tr>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Save and Exit" BackColor="#669900" class="BorderStyle" Height="33px" OnClick="Button2_Click1"  /></td>
        </tr>
        
        </table>
    
    
   




</asp:Content>
