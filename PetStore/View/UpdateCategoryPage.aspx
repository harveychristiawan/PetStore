<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="UpdateCategoryPage.aspx.cs" Inherits="PetStore.View.UpdateCategoryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .contentClass {
            margin: 50px auto;
            width: 400px;
            padding: 20px;
            background-color: #f7f7f7;
            border: 1px solid #ddd;
            border-radius: 5px;
        }

        .title {
            text-align: center;
            color: #333;
            font-size: 24px;
            margin-bottom: 20px;
        }

        .form-group {
            margin-bottom: 15px;
        }

        .label {
            display: block;
            font-weight: bold;
            margin-bottom: 5px;
        }

        .textbox {
            width: 100%;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }

        .error-msg {
            color: red;
            margin-top: 10px;
        }

        .button {
            display: block;
            width: 100%;
            padding: 10px;
            background-color: #4CAF50;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            font-size: 16px;
            text-align: center;
        }

        .button:hover {
            background-color: #45a049;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="contentClass">
        <h1 class="title">Update Category</h1>
        <div class="form-group">
            <label class="label" for="nameTb">Name</label>
            <asp:TextBox ID="nameTb" runat="server" CssClass="textbox"></asp:TextBox>
        </div>
        <div class="form-group">
            <label class="label" for="imageUpload">Image</label>
            <asp:FileUpload ID="imageUpload" runat="server" CssClass="textbox" />
        </div>
        <asp:Label ID="errorMsg" runat="server" CssClass="error-msg" Text=""></asp:Label>
        <asp:Button ID="updateCategoryBtn" runat="server" Text="Update Category" CssClass="button" OnClick="updateCategoryBtn_Click" />
    </div>
</asp:Content>
