﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Returns.aspx.cs" Inherits="SJDealStore.Returns" %>

<!DOCTYPE html>

<html >
<head runat="server">
 <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="shortcut icon" href="favicon.ico" type="image/x-icon" />
<link rel="apple-touch-icon" href="apple-touch-icon.png" />
<link rel="apple-touch-icon" sizes="57x57" href="apple-touch-icon-57x57.png" />
<link rel="apple-touch-icon" sizes="72x72" href="apple-touch-icon-72x72.png" />
<link rel="apple-touch-icon" sizes="76x76" href="apple-touch-icon-76x76.png" />
<link rel="apple-touch-icon" sizes="114x114" href="apple-touch-icon-114x114.png" />
<link rel="apple-touch-icon" sizes="120x120" href="apple-touch-icon-120x120.png" />
<link rel="apple-touch-icon" sizes="144x144" href="apple-touch-icon-144x144.png" />
<link rel="apple-touch-icon" sizes="152x152" href="apple-touch-icon-152x152.png" />
<link rel="apple-touch-icon" sizes="180x180" href="apple-touch-icon-180x180.png" />

    <title>Returns</title>

    <!-- Bootstrap core CSS -->
    <link href="../dist/css/bootstrap.min.css" rel="stylesheet">

    <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
    <link href="../assets/css/ie10-viewport-bug-workaround.css" rel="stylesheet">

    <!-- Custom styles for this template -->
    <link href="sticky-footer-navbar.css" rel="stylesheet">

    <!-- Just for debugging purposes. Don't actually copy these 2 lines! -->
    <!--[if lt IE 9]><script src="../../assets/js/ie8-responsive-file-warning.js"></script><![endif]-->
    <script src="../assets/js/ie-emulation-modes-warning.js"></script>

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
  </head>
<body>
    <form id="form1" runat="server">
    

    <!-- Fixed navbar -->
    <nav class="navbar navbar-default navbar-fixed-top">
      <div class="container">
        <div class="navbar-header">
          <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </button>
          <a class="navbar-brand" href="#">Smokin Joe Deal Store</a>
        </div>
        <div id="navbar" class="collapse navbar-collapse">
          <ul class="nav navbar-nav">
            <li class="active"><a href="Home.aspx">Home</a></li>
           
            <li class="Operations">
              <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Operations <span class="caret"></span></a>
              <ul class="dropdown-menu">
                <li><a href="#"></a></li>
                <li><a href="Returns.aspx">Returns</a></li>
                <li><a href="Sales.aspx">Sales</a></li>
              
              </ul>
            </li>
          </ul>
        </div><!--/.nav-collapse -->
      </div>
    </nav>
        <br/>
    <!-- Begin page content -->
    <div class="container">
      <div class="page-header">
       
      </div>
      
        
        <div class="panel panel-primary">
            <div class="panel-heading">
              <h3 class="panel-title">Operations - Returns</h3>
            </div>
            <div class="panel-body">
              Scan UPC Number : 
                
                        
        <br/><br/>
        <asp:TextBox ID="TextBox1" runat="server" type="text" class="form-control" placeholder="Type or scan UPC number"     OnTextChanged="TextBox1_TextChanged"   AutoPostBack="true"></asp:TextBox>
                <br />
                <strong>UPC:
                <asp:Label ID="lblUPC" runat="server" Text=""></asp:Label>
                <br />
                SKU:
                <asp:Label ID="lblSKU" runat="server" Text=""></asp:Label>
                <br />
                Description:
                <asp:Label ID="lblDesc" runat="server" Text=""></asp:Label>
                <br />
              
                Price:
                <asp:Label ID="lblPrice" runat="server" Text=""></asp:Label>
                </strong>
                <br />
                <br />  Scan RFID Number : 
      <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" placeholder="Type or scan RFID number"  Width="100%" AutoPostBack="true"></asp:TextBox>
             
                <br/>
                <br/>
              <center>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 </center>     <br/>
                <asp:Label ID="lblWarning" runat="server" Text=""></asp:Label>
                  <asp:ListBox ID="ListBox1" runat="server" Visible="False"></asp:ListBox>
            </div>
          </div>
    </div>

    <footer class="footer">
      <div class="container">
        <p class="text-muted">Smokin Joes - 2015</p>
      </div>
    </footer>


    <!-- Bootstrap core JavaScript
    ================================================== -->
    <!-- Placed at the end of the document so the pages load faster -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script>window.jQuery || document.write('<script src="../../assets/js/vendor/jquery.min.js"><\/script>')</script>
    <script src="../dist/js/bootstrap.min.js"></script>
    <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
    <script src="../assets/js/ie10-viewport-bug-workaround.js"></script>

    </form>
</body>
</html>