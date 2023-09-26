<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="PetStore.View.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
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
        input[type="checkbox"] {
          width: 100%;
          padding: 8px;
          border: 1px solid #ccc;
          border-radius: 4px;
          box-sizing: border-box;
          margin-bottom: 12px;
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

    <div class="contentClass">
        <h1 class="title">Login</h1>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emailTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="passwordTb" runat="server"></asp:TextBox>
        <br />
        <asp:CheckBox ID="rememberCb" runat="server" Text="Remember Me"/>
        <br />
        <asp:Label ID="errorMsg" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click"/>
    </div>
</asp:Content>
