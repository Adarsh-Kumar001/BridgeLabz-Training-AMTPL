<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BookStoreApp.Register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    <style>
        /* Shared styling for consistency */
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .register-box {
            background-color: white;
            padding: 30px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
            width: 300px;
            text-align: center;
        }
        input[type="text"], input[type="password"] {
            width: 100%;
            padding: 10px;
            margin: 10px 0;
            box-sizing: border-box;
        }
        .btn-register {
            width: 100%;
            padding: 10px;
            background-color: #28a745; /* Green for Register */
            color: white;
            border: none;
            cursor: pointer;
            font-size: 16px;
        }
        .btn-register:hover {
            background-color: #218838;
        }
        .login-link {
            margin-top: 15px;
            display: block;
            font-size: 14px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="register-box">
            <h2>Create Account</h2>

            <div style="text-align:left;"><label>Username:</label></div>
            <asp:TextBox ID="txtUser" runat="server" Placeholder="Choose a Username" />

            <div style="text-align:left;"><label>Password:</label></div>
            <asp:TextBox ID="txtPass" runat="server" TextMode="Password" Placeholder="Choose a Password" />

            <br /><br />

            <asp:Button Text="Register" runat="server" OnClick="RegisterUser" CssClass="btn-register" />

            <br /><br />
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red" />

            <hr />

            <div class="login-link">
                Already have an account? <br />
                <a href="Login.aspx" style="color: blue; text-decoration: none; font-weight: bold;">Login Here</a>
            </div>
        </div>
    </form>
</body>
</html>