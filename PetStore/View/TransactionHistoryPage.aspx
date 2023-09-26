<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="TransactionHistoryPage.aspx.cs" Inherits="PetStore.View.TransactionHistoryPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .contentClass {
            margin: 50px auto;
            width: 800px;
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

        .gridview {
            width: 100%;
            border-collapse: collapse;
        }

        .gridview th,
        .gridview td {
            padding: 8px;
            border-bottom: 1px solid #ddd;
            text-align: left;
        }

        .gridview th {
            background-color: #f2f2f2;
        }

        .gridview tr:hover {
            background-color: #f5f5f5;
        }

        .product-img {
            width: 250px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="contentClass">
        <h1 class="title">Transaction History</h1>
        <asp:GridView ID="gvTransaction" runat="server" CssClass="gridview" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="ArtistID" />
                <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="ArtistName" />
                <asp:BoundField DataField="CustomerName" HeaderText="Customer Name" SortExpression="ArtistName" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Image ID="productImg" runat="server" HeaderText="Product Image" ImageUrl='<%#Eval("ProductImage")%>' CssClass="product-img" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" SortExpression="ProductName" />
                <asp:BoundField DataField="Qty" HeaderText="Quantity" SortExpression="Qty" />
                <asp:BoundField DataField="ProductPrice" HeaderText="Product Price" SortExpression="ProductPrice" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
