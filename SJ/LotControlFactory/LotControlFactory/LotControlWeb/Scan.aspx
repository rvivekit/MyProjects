﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Scan.aspx.cs" Inherits="LotControlWeb.Scan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Scan a Lot Barcode </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click"  />
        <br/><br/>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="100%" >
            <Columns>
                <asp:BoundField DataField="PurchaseOrderLin" HeaderText="Sno" />
                <asp:BoundField DataField="StockCode" HeaderText="Stock Code" />
                <asp:BoundField DataField="Description" HeaderText="Description" />   
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:BoundField DataField="UOM" HeaderText="UOM" />
                <asp:BoundField DataField="CostValue" HeaderText="Value" />
                <asp:BoundField DataField="Warehouse" HeaderText="Warehouse" />
                <asp:BoundField DataField="Lotnumber" HeaderText="Lot#" />
                <asp:BoundField DataField="Date" HeaderText="Date"  DataFormatString=" {0:d}"/>
              <%--  <asp:BoundField DataField="TrnQuantity" HeaderText="Quantity" />--%>
                <asp:BoundField DataField="GRNNumber" HeaderText="GRN Number" />
                <asp:BoundField DataField="PONumber" HeaderText="PO#" />
                <asp:BoundField DataField="Supplier" HeaderText="Supplier" />
                <asp:BoundField DataField="Sno"      HeaderText="Barcode" />

            </Columns>
            <EmptyDataTemplate>No Lots Found</EmptyDataTemplate>
        </asp:GridView>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Print" OnClick="Button2_Click" />
    </form>
</body>
</html>
