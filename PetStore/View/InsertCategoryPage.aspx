<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="InsertCategoryPage.aspx.cs" Inherits="PetStore.View.InsertCategoryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="contentClass">
        <h1 class="title">Insert Category</h1>
        <asp:Label ID="Label1" runat="server" Text="Category Name"></asp:Label>
        <asp:TextBox ID="nameTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Image"></asp:Label>
        <asp:FileUpload ID="imageUpload" runat="server" Width="217px" />
        <br />
        <asp:Label ID="errorMsg" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="insertCategoryBtn" runat="server" Text="Insert Category" OnClick="insertCategoryBtn_Click"/>
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

        input[type="text"] {
          width: 100%;
          padding: 8px;
          border: 1px solid #ccc;
          border-radius: 4px;
          box-sizing: border-box;
          margin-bottom: 12px;
        }

        input[type="file"] {
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
</asp:Content>
