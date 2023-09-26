<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="PetStore.View.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="contentClass">
        <h1 class="title">Register</h1>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emailTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Gender"></asp:Label>
        <asp:RadioButtonList ID="genderRb" runat="server">
            <asp:ListItem Value="Male">Male</asp:ListItem>
            <asp:ListItem Value="Female">Female</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="addressTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="passwordTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="errorMsg" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click"/>
    </div>

    <style>
        .contentClass {
          max-width: 400px;
          margin: 0 auto;
          padding: 20px;
          background-color: #f2f2f2;
          border: 1px solid #ccc;
          border-radius: 5px;
        }

        .title {
          text-align: center;
          color: #333;
          font-size: 24px;
          margin-bottom: 20px;
        }

        label {
          display: block;
          margin-bottom: 8px;
          font-weight: bold;
        }

        input[type="text"],
        input[type="email"],
        input[type="password"],
        select {
          width: 100%;
          padding: 8px;
          border: 1px solid #ccc;
          border-radius: 4px;
          box-sizing: border-box;
          margin-bottom: 12px;
        }

        input[type="radio"] {
          margin-right: 8px;
        }

        button {
          background-color: #4CAF50;
          color: #fff;
          padding: 10px 20px;
          border: none;
          border-radius: 4px;
          cursor: pointer;
          font-size: 16px;
        }

        button:hover {
          background-color: #45a049;
        }

        .errorMsg {
          color: red;
          margin-bottom: 12px;
        }

        /* Optional: Add styles to enhance the form layout */
        form {
          margin-bottom: 20px;
        }

        form > div {
          margin-bottom: 12px;
        }

    </style>
</asp:Content>
