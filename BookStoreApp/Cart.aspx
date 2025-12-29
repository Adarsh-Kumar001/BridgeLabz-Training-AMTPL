<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="BookStoreApp.Cart" %>
<!DOCTYPE html>
<html>
<head runat="server"><title>Shopping Cart</title></head>
<body>
    <form id="form1" runat="server">
        <div style="padding:20px;">
            <h2>Your Shopping Cart</h2>
            <a href="Store.aspx">Back to Store</a>
            <hr />
            
            <asp:GridView ID="gvCart" runat="server" AutoGenerateColumns="False" CellPadding="10">
                <Columns>
                    <asp:BoundField DataField="Title" HeaderText="Book" />
                    <asp:BoundField DataField="Price" HeaderText="Price" DataFormatString="{0:C}" />
                    <asp:BoundField DataField="Quantity" HeaderText="Qty" />
                </Columns>
            </asp:GridView>
            <br />
            <h3>Total: <asp:Label ID="lblTotal" runat="server" Text="$0.00"></asp:Label></h3>
            <asp:Button ID="btnCheckout" runat="server" Text="Place Order" OnClick="btnCheckout_Click" BackColor="Green" ForeColor="White" />
            <br /><asp:Label ID="lblMsg" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>