<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Store.aspx.cs" Inherits="BookStoreApp.Store" %>
<!DOCTYPE html>
<html>
<head runat="server"><title>Book Store</title></head>
<body>
    <form id="form1" runat="server">
        <div style="padding:20px;">
            <h2>Browse Books</h2>
            <a href="Cart.aspx">View Cart</a> | <a href="MyOrders.aspx">My Orders</a> | <a href="Login.aspx">Logout</a>
            <hr />
            <asp:Label ID="lblMsg" runat="server" ForeColor="Green"></asp:Label>
            
            <asp:GridView ID="gvBooks" runat="server" AutoGenerateColumns="False" DataKeyNames="BookId" OnRowCommand="gvBooks_RowCommand" CellPadding="10">
                <Columns>
                    <asp:BoundField DataField="Title" HeaderText="Title" />
                    <asp:BoundField DataField="Author" HeaderText="Author" />
                    <asp:BoundField DataField="Price" HeaderText="Price" DataFormatString="{0:C}" />
                    <asp:TemplateField HeaderText="Action">
                        <ItemTemplate>
                            <asp:Button runat="server" Text="Add to Cart" CommandName="AddToCart" CommandArgument='<%# Eval("BookId") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>