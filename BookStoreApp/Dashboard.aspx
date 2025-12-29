<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="BookStoreApp.Dashboard" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book Store Dashboard</title>
    <style>
        body { font-family: Arial, sans-serif; padding: 20px; background-color: #f4f4f4; }
        .container { background: white; padding: 20px; border-radius: 8px; box-shadow: 0 0 10px rgba(0,0,0,0.1); max-width: 900px; margin: auto; }
        .header { display: flex; justify-content: space-between; align-items: center; border-bottom: 2px solid #eee; padding-bottom: 10px; margin-bottom: 20px; }
        .form-group { margin-bottom: 15px; background: #e9ecef; padding: 15px; border-radius: 5px; }
        .form-group input { padding: 8px; margin-right: 5px; border: 1px solid #ccc; border-radius: 4px; }
        .btn { padding: 8px 15px; cursor: pointer; border: none; border-radius: 4px; color: white; }
        .btn-add { background-color: #28a745; }
        .btn-logout { background-color: #dc3545; }
        table { width: 100%; border-collapse: collapse; margin-top: 20px; }
        th, td { padding: 10px; border: 1px solid #ddd; text-align: left; }
        th { background-color: #333; color: white; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="header">
                <h1>Book Store Manager</h1>
                <div>
                    Welcome, <b><asp:Label ID="lblUser" runat="server"></asp:Label></b>
                    <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="btn btn-logout" OnClick="btnLogout_Click" />
                </div>
            </div>

            <div class="form-group">
                <h3>Add New Book</h3>
                <asp:TextBox ID="txtTitle" runat="server" Placeholder="Book Title"></asp:TextBox>
                <asp:TextBox ID="txtAuthor" runat="server" Placeholder="Author Name"></asp:TextBox>
                <asp:TextBox ID="txtPrice" runat="server" Placeholder="Price (e.g. 15.99)"></asp:TextBox>
                <asp:TextBox ID="txtStock" runat="server" Placeholder="Stock Qty" TextMode="Number"></asp:TextBox>
                <asp:Button ID="btnAdd" runat="server" Text="Add Book" CssClass="btn btn-add" OnClick="btnAdd_Click" />
                <br />
                <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            </div>

            <asp:GridView ID="gvBooks" runat="server" AutoGenerateColumns="False" DataKeyNames="BookId"
                OnRowEditing="gvBooks_RowEditing" 
                OnRowCancelingEdit="gvBooks_RowCancelingEdit"
                OnRowUpdating="gvBooks_RowUpdating" 
                OnRowDeleting="gvBooks_RowDeleting"
                CssClass="grid" Width="100%" CellPadding="10">
                
                <Columns>
                    <asp:BoundField DataField="BookId" HeaderText="ID" ReadOnly="True" />
                    <asp:BoundField DataField="Title" HeaderText="Title" />
                    <asp:BoundField DataField="Author" HeaderText="Author" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:BoundField DataField="Stock" HeaderText="Stock" />
                    
                    <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" 
                        ControlStyle-ForeColor="#007bff" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>