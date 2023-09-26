<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="PetStore.View.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .contentClass {
            max-width: 800px;
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

        .imgWidth-250 {
            width: 250px;
        }

        .gridview {
            margin-bottom: 20px;
        }

        .gridview table {
            width: 100%;
            border-collapse: collapse;
        }

        .gridview th,
        .gridview td {
            padding: 8px;
            text-align: left;
        }

        .gridview th {
            background-color: #f2f2f2;
        }

        .gridview tr:nth-child(even) {
            background-color: #dddddd;
        }

        .btn {
            background-color: #4CAF50;
            color: #fff;
            padding: 8px 16px;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            font-size: 14px;
        }

        .btn:hover {
            background-color: #45a049;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="contentClass">
        <h1 class="title">Cart</h1>
        <asp:GridView ID="gvCart" runat="server" CssClass="gridview" AutoGenerateColumns="False" OnRowDeleting="gvCart_RowDeleting">
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="Product ID" SortExpression="ProductID" />
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" SortExpression="ProductName" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Image ID="productImage" runat="server" HeaderText="Product Image" ImageUrl='<%#Eval("ProductImage")%>' CssClass="imgWidth-250" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Qty" HeaderText="Quantity" SortExpression="Qty" />
                <asp:BoundField DataField="ProductPrice" HeaderText="Product Price" SortExpression="ProductPrice" />

                <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />

            </Columns>
        </asp:GridView>
        <asp:Button ID="checkoutBtn" runat="server" CssClass="btn" Text="Checkout" OnClick="checkoutBtn_Click" />
    </div>
</asp:Content>
