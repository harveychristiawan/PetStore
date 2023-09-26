<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="PetStore.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .gridview {
            width: 100%;
        }

        .gridview th,
        .gridview td {
            padding: 10px;
        }

        .banner {
            background-color: #f2f2f2;
            padding: 20px;
            margin-bottom: 20px;
            text-align: center;
        }

        .banner img{
            width:80%;
            height:400px;
        }

        .insert-button {
            display: inline-block;
            padding: 10px 20px;
            font-size: 16px;
            font-weight: bold;
            text-align: center;
            text-decoration: none;
            background-color: #4CAF50;
            color: #fff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        .insert-button:hover {
            background-color: #45a049;
        }

        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="contentClass">
        
        <div class="banner">
            <h2>Welcome to PetStore!</h2>
            <p>Find Your Pet Needs here.</p>
            <img src="../Assets/Categories/banner.png" alt="Deskripsi Gambar" />
            
        </div>
        <h1 class="title">Home</h1>
        <asp:Label ID="Label1" runat="server" Text="Label">Hello, </asp:Label>
        <asp:Label ID="userNameLb" runat="server" Text="Guest"></asp:Label>
        <br />

        <% if (role == "A") { %>
            <asp:LinkButton ID="insertCategoryLink" runat="server" OnClick="insertCategoryLink_Click" CssClass="insert-button">Insert Category</asp:LinkButton>
            <br />
            <div class="card">
                <h2>Categories</h2>
                <asp:GridView ID="gvCategory" runat="server" AutoGenerateColumns="False" OnRowDeleting="gvCategory_RowDeleting" OnRowEditing="gvCategory_RowEditing" OnSelectedIndexChanged="gvCategory_SelectedIndexChanged" CssClass="gridview">
                    <Columns>
                        <asp:BoundField DataField="CategoryID" HeaderText="ID" SortExpression="CategoryID" />
                        <asp:BoundField DataField="CategoryName" HeaderText="Category Name" SortExpression="CategoryName" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Image ID="imgId" runat="server" HeaderText="Category Image" ImageUrl='<%#Eval("CategoryImage")%>' CssClass="imgWidth-100" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" SelectText="Category Detail" ItemStyle-CssClass="command-button" />
                    </Columns>
                </asp:GridView>
            </div>
        <% } else { %>
            <br />
            <div class="card">
                <h2>Categories</h2>
                <asp:GridView ID="gvCategory2" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvCategory2_SelectedIndexChanged" CssClass="gridview">
                    <Columns>
                        <asp:BoundField DataField="CategoryID" HeaderText="ID" SortExpression="CategoryID" />
                        <asp:BoundField DataField="CategoryName" HeaderText="Category Name" SortExpression="CategoryName" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Image ID="Image1" runat="server" HeaderText="Category Image" ImageUrl='<%#Eval("CategoryImage")%>' CssClass="imgWidth-100" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ButtonType="Button" ShowSelectButton="True" SelectText="Category Detail" ItemStyle-CssClass="command-button" />
                    </Columns>
                </asp:GridView>
            </div>
        <% } %>
    </div>
</asp:Content>
