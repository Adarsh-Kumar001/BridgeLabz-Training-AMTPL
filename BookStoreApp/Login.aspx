<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BookStoreApp.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style>
        /* Simple styling to make the form look nice */
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .login-box {
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
            box-sizing: border-box; /* Ensures padding doesn't widen the box */
        }
        .btn-login {
            width: 100%;
            padding: 10px;
            background-color: #007bff;
            color: white;
            border: none;
            cursor: pointer;
            font-size: 16px;
        }
        .btn-login:hover {
            background-color: #0056b3;
        }
        .register-link {
            margin-top: 15px;
            display: block;
            font-size: 14px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-box">
            <h2>Login</h2>
            
            <div style="text-align:left;"><label>Username:</label></div>
            <asp:TextBox ID="txtUsername" runat="server" Placeholder="Enter Username" /> 

            <div style="text-align:left;"><label>Password:</label></div>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Enter Password" /> 
            
            <br /><br />

            <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="btnLogin_Click" CssClass="btn-login" /> 
            
            <br /><br />
            
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />

            <hr />

            <div class="register-link">
                Don't have an account? <br />
                <a href="Register.aspx" style="color: blue; text-decoration: none; font-weight: bold;">Create an Account</a>
            </div>
        </div>
    </form>
</body>
</html>