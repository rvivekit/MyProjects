﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TShirt.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>

                <asp:ImageField DataImageUrlField="Family">
                <ControlStyle  Width="100px"/>
                    
                </asp:ImageField>
                <asp:BoundField DataField="Description"  HeaderText="Description" />
                <asp:BoundField  DataField="Barcode" HeaderText="Barcode"  />
                <asp:BoundField  DataField="cnt"  HeaderText="QOH"/>
                <asp:BoundField DataField="SalesCount" HeaderText="Last Week Sales"  />
                
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
