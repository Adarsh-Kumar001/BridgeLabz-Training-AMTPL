<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyOrders.aspx.cs" Inherits="BookStoreApp.MyOrders" %>
<!DOCTYPE html>
<html>
<head runat="server"><title>Order History</title></head>
<body>
    <form id="form1" runat="server">
        <div style="padding:20px;">
            <h2>My Orders</h2>
            <a href="Store.aspx">Back to Store</a>
            <hr />
            <asp:GridView ID="gvOrders" runat="server" AutoGenerateColumns="False" CellPadding="10">
                <Columns>
                    <asp:BoundField DataField="OrderId" HeaderText="Order ID" />
                    <asp:BoundField DataField="OrderDate" HeaderText="Date" />
                    <asp:BoundField DataField="TotalAmount" HeaderText="Total" DataFormatString="{0:C}" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>