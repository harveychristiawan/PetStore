<%@ Page Title="" Language="C#" MasterPageFile="~/View/NavBar.Master" AutoEventWireup="true" CodeBehind="UpdateProfilePage.aspx.cs" Inherits="PetStore.View.UpdateProfilePage" %>
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
            margin-bottom: 10px;
        }

        .label {
            display: block;
            font-weight: bold;
            margin-bottom: 5px;
        }

        .textbox {
            width: 100%;
            padding: 5px;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }

        .radio-group {
            margin-top: 5px;
        }

        .error-msg {
            color: red;
            margin-top: 10px;
        }

        .button {
            margin-top: 20px;
            width: 100%;
            padding: 10px;
            background-color: #4CAF50;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            font-size: 16px;
        }

        .button:hover {
            background-color: #45a049;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <div class="contentClass">
        <h1 class="title">Update Profile</h1>
        <div class="form-group">
            <label class="label" for="nameTb">Name</label>
            <asp:TextBox ID="nameTb" runat="server" CssClass="textbox"></asp:TextBox>
        </div>
        <div class="form-group">
            <label class="label" for="emailTb">Email</label>
            <asp:TextBox ID="emailTb" runat="server" CssClass="textbox"></asp:TextBox>
        </div>
        <div class="form-group">
            <label class="label">Gender</label>
            <asp:RadioButtonList ID="genderRb" runat="server" CssClass="radio-group">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div class="form-group">
            <label class="label" for="addressTb">Address</label>
            <asp:TextBox ID="addressTb" runat="server" CssClass="textbox"></asp:TextBox>
        </div>
        <div class="form-group">
            <label class="label" for="passwordTb">Password</label>
            <asp:TextBox ID="passwordTb" runat="server" TextMode="Password" CssClass="textbox"></asp:TextBox>
        </div>
        <asp:Label ID="errorMsg" runat="server" CssClass="error-msg" Text=""></asp:Label>
        <br />
        <asp:Button ID="updateProfileBtn" runat="server" Text="Update Profile" CssClass="button" OnClick="updateProfileBtn_Click"/>
    </div>
</asp:Content>
