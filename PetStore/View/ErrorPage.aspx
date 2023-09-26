<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="PetStore.View.ErrorPage" %>

<!DOCTYPE html>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Error</title>
</head>
<body>
    <style>
        * {
            background-color: white;
        }

        h1 {
            color: black;
        }

        h5 {
            color: black;
        }

        .white-text {
            color: red;
        }

        .easter-egg {
            color: #660000;
        }
    </style>
    <h1>Oh no! It's a Forbidden Page</h1>
    <h5>You should not access this page because you are logged in with wrong role!</h5>
    
    <asp:HyperLink ID="loginLink" runat="server" NavigateUrl="~/View/LoginPage.aspx" CssClass="white-text">Please login with correct account!</asp:HyperLink>
    
</body>
</html>
