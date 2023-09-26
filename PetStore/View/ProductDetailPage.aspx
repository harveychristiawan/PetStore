<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="ProductDetailPage.aspx.cs" Inherits="PetStore.View.ProductDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
        }

        .contentClass {
            max-width: 800px;
            margin: 0 auto;
            padding: 20px;
            background-color: #fff;
            border-radius: 5px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
        }

        .title {
            text-align: center;
            color: #333;
            font-size: 24px;
            margin-bottom: 20px;
        }

        .label {
            font-weight: bold;
        }

        .imgWidth-500 {
            display: block;
            margin: 0 auto;
            max-width: 100%;
            height: auto;
            margin-bottom: 20px;
            border-radius: 5px;
            box-shadow: 0 2px 5px rgba(0, 0, 0, 0.1);
        }

        .form-group {
            margin-bottom: 20px;
        }

        .form-group label {
            display: block;
            font-weight: bold;
            margin-bottom: 5px;
        }

        .form-group input[type="text"],
        .form-group input[type="number"] {
            width: 100%;
            padding: 8px;
            border: 1px solid #ccc;
            border-radius: 4px;
        }

        .errorMsg {
            color: red;
            margin-top: 5px;
        }

        .btn {
            background-color: #4CAF50;
            color: #fff;
            padding: 8px 16px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            font-size: 14px;
            transition: background-color 0.3s ease;
        }

        .btn:hover {
            background-color: #45a049;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="contentClass">
        <h1 class="title">Product Detail</h1>
        <div class="form-group">
            <label class="label" for="nameLb">Product Name:</label>
            <asp:Label ID="nameLb" runat="server" Text="Label"></asp:Label>
        </div>

        <asp:Image ID="ProductImg" runat="server" CssClass="imgWidth-500" />

        <div class="form-group">
            <label class="label" for="descLb">Product Description:</label>
            <asp:Label ID="descLb" runat="server" Text="Label"></asp:Label>
        </div>

        <div class="form-group">
            <label class="label" for="priceLb">Product Price:</label>
            <asp:Label ID="priceLb" runat="server" Text="Label"></asp:Label>
        </div>

        <div class="form-group">
            <label class="label" for="stockLb">Product Stock:</label>
            <asp:Label ID="stockLb" runat="server" Text="Label"></asp:Label>
        </div>

        <% if (role == "C")
            { %>
        <h1 class="title">Add to Cart</h1>
        <div class="form-group">
            <label class="label" for="qtyTb">Quantity:</label>
            <asp:TextBox ID="qtyTb" runat="server"></asp:TextBox>
        </div>
        <asp:Label ID="errorMsg" runat="server" Text="" CssClass="errorMsg"></asp:Label>
        <div class="form-group">
            <asp:Button ID="addCartBtn" runat="server" Text="Add to Cart" OnClick="addCartBtn_Click" CssClass="btn" />
        </div>
        <% } %>
    </div>
</asp:Content>
