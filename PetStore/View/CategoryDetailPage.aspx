<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="CategoryDetailPage.aspx.cs" Inherits="PetStore.View.CategoryDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
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

        .label {
          font-weight: bold;
        }

        .imgWidth-250 {
          width: 250px;
        }

        .imgWidth-500 {
          width: 500px;
          margin-bottom: 20px;
        }

        .gridview {
          margin-top: 20px;
        }

        table {
          width: 100%;
          border-collapse: collapse;
          margin-bottom: 20px;
        }

        th, td {
          padding: 8px;
          text-align: left;
          border-bottom: 1px solid #ccc;
        }

        th {
          background-color: #f2f2f2;
        }

        .gridview button {
          background-color: #4CAF50;
          color: #fff;
          padding: 5px 10px;
          border: none;
          border-radius: 4px;
          cursor: pointer;
          font-size: 14px;
        }

        .gridview button:hover {
          background-color: #45a049;
        }

        .gridview a {
          color: #337ab7;
          text-decoration: none;
        }

        .gridview a:hover {
          text-decoration: underline;
        }

        /* Additional Styles for Improved Appearance */
        .insertButton {
          background-color: #337ab7;
          color: #fff;
          padding: 8px 16px;
          border: none;
          border-radius: 4px;
          font-size: 14px;
          text-decoration: none;
          display: inline-block;
          margin-bottom: 20px;
        }

        .insertButton:hover {
          background-color: #23527c;
        }

        .productDetailButton {
          background-color: #4CAF50;
          color: #fff;
          padding: 8px 16px;
          border: none;
          border-radius: 4px;
          font-size: 14px;
          text-decoration: none;
          display: inline-block;
        }

        .productDetailButton:hover {
          background-color: #45a049;
        }

    </style>
    <div class="contentClass">
        <h1 class="title">Category Detail</h1>
        <asp:Label ID="Label1" runat="server" CssClass="label">Category Name: </asp:Label>
        <asp:Label ID="nameLb" runat="server"></asp:Label>
        <br />
        <asp:Image ID="categoryImg" CssClass="imgWidth-250" runat="server" />
        <br />
        <% if (role == "A")
            { %>
        <asp:LinkButton ID="insertProductLink" runat="server" OnClick="insertProductLink_Click" CssClass="insertButton">Insert Product</asp:LinkButton>

        <asp:GridView ID="gvProduct" runat="server" AutoGenerateColumns="False" OnRowDeleting="gvProduct_RowDeleting" OnRowEditing="gvProduct_RowEditing" OnSelectedIndexChanged="gvProduct_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="ID" SortExpression="CategoryID" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Image ID="imgId" runat="server" HeaderText="Product Image" ImageUrl='<%#Eval("ProductImage")%>' CssClass="imgWidth-250" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" SortExpression="ProductID" />
                <asp:BoundField DataField="ProductPrice" HeaderText="Product Price" SortExpression="ProductID" />
                <asp:BoundField DataField="ProductDescription" HeaderText="Product Description" SortExpression="ProductID" />
                <asp:CommandField ButtonType="Button" ShowCancelButton="False" ShowDeleteButton="True" ShowSelectButton="True" ShowEditButton="True" SelectText="Product Detail" ControlStyle-CssClass="productDetailButton" />
            </Columns>
        </asp:GridView>
        <%}
            else
            { %>
        <asp:GridView ID="gvProduct2" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvProduct2_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="ID" SortExpression="CategoryID" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Image ID="imgId" runat="server" HeaderText="Product Image" ImageUrl='<%#Eval("ProductImage")%>' CssClass="imgWidth-250" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" SortExpression="ProductID" />
                <asp:BoundField DataField="ProductPrice" HeaderText="Product Price" SortExpression="ProductID" />
                <asp:BoundField DataField="ProductDescription" HeaderText="Product Description" SortExpression="ProductID" />
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" SelectText="Product Detail" ControlStyle-CssClass="productDetailButton" />
            </Columns>
        </asp:GridView>
        <%} %>
    </div>
</asp:Content>
