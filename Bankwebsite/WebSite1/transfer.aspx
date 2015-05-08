<%@ Page Language="C#" AutoEventWireup="true" CodeFile="transfer.aspx.cs" Inherits="statement" %>

<%@ Register src="controls/Header.ascx" tagname="Header" tagprefix="uc1" %>

<%@ Register src="controls/Headerfooter.ascx" tagname="Headerfooter" tagprefix="uc2" %>



<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <title>Greenrose Bank Ltd.</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link href="css/style.css" rel="stylesheet" type="text/css" />
<link rel="stylesheet" type="text/css" href="css/coin-slider.css" />
<script type="text/javascript" src="js/cufon-yui.js"></script>
<script type="text/javascript" src="js/cufon-titillium-600.js"></script>
<script type="text/javascript" src="js/jquery-1.4.2.min.js"></script>
<script type="text/javascript" src="js/script.js"></script>
<script type="text/javascript" src="js/coin-slider.min.js"></script>
    <style type="text/css">
        .style1
        {
            text-align: center;
            height: 440px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
   <div class="main">



       <uc1:Header ID="Header1" runat="server" />
  <div class="content">
    <div class="content_resize">
      <div class="mainbar">
        <div class="article">

          <h2><span>Money Transfer</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="namelabel" runat="server" Text="abel" Visible="False"></asp:Label>
              (<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    )<asp:LinkButton ID="LinkButton1" runat="server" 
                  onclick="LinkButton1_Click">Logout</asp:LinkButton>
                    </h2>
         

       
         
          <div class="post_content" style="text-align: center">
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <br />
            <div class="menu_myaccount">
        <ul>
          <li class="active_myaccount"><a href="myaccount.aspx"><span>My Account</span></a></li>
          <li><a href=""><span>Mobile Banking</span></a></li>
          <li><a href="transfer.aspx"><span>Transfer</span></a></li>
          <li><a href="inbox.aspx"><span>Inbox </span></a></li>
       

        </ul>
      </div>




              <div class="style1">
                  <br />
              &nbsp;Please give your&nbsp; information so carefully, it is highly prohibted
              <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                  Transfer Account No :<asp:TextBox ID="accTextBox1" runat="server" 
                      AutoPostBack="True" ontextchanged="accTextBox1_TextChanged" ></asp:TextBox>
              <br />
              <br />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                  Name:<asp:TextBox ID="nameTextBox2" runat="server" ReadOnly="True" ></asp:TextBox>
                  <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                  Your Balance:&nbsp;
                  <asp:TextBox ID="balanceTextBox3" runat="server" Enabled="False" 
                      Font-Bold="False" Font-Size="Small"></asp:TextBox>
                  <br />
&nbsp;&nbsp;&nbsp;&nbsp;
                  <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                  Tranfer amount:
                  <asp:TextBox ID="amountTextBox4" runat="server"></asp:TextBox>
&nbsp;***Below 20000s<br />
                  <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                  Card serial No:<asp:TextBox ID="cardserialTextBox5" runat="server"></asp:TextBox>
                  <br />
                  <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                  Pin No:<asp:TextBox ID="pinTextBox6" runat="server" TextMode="Password"></asp:TextBox>
              <br />
              <br />
              <br />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                  *<asp:Label ID="balancelabel" runat="server" Font-Bold="True" 
                      Font-Size="Medium" ForeColor="Blue" Text="Balance Succesfully Transfer......."></asp:Label>
                  <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" 
                      ForeColor="#CC0000" Text="Wrong information provided"></asp:Label>
              <br />
                  <br />
                  <asp:Button ID="Button1" runat="server" Text="Transfer" 
                      onclick="Button1_Click" />
                  <br />
                  <br />
                  <br />
                  <br />
                  <br />
                  <br />
                  <br />
                  <br />
              <br />
              <br />
              <br />
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;              <br />
            


        
              </div>
            


        
          </div>
          <div class="clr"></div>
        </div>

      </div>
      <div class="sidebar">
        <div class="gadget">
          <h2 class="star"><span>Sidebar</span> Menu</h2>
          <div class="clr"></div>
          <ul class="sb_menu">
                    <li><a href="#">Home</a></li>

            <li><a href="accountinfo.aspx">Account Info </a></li>
            <li><a href="#">Loan</a></li>
            <li><a href="#">Branch/ATM location</a></li>
            <li><a href="#">Archives</a></li>
            <li><a href="emicalculator.aspx">EMI Calculator</a></li>
            <li><a href="#">Interest Rate</a></li>
       
          </ul>

        </div>
       </div>
      <div class="clr">
          <br />
        </div>
    
    </div>
  </div>

</div>

    <uc2:Headerfooter ID="Headerfooter1" runat="server" />

    </form>
</body>
</html>
