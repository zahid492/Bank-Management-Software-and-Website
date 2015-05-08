<%@ Page Language="C#" AutoEventWireup="true" CodeFile="emicalculator.aspx.cs" Inherits="emicalculator" %>

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
</head>
<body>
    <form id="form1" runat="server">
   <div class="main">



       <uc1:Header ID="Header1" runat="server" />
  <div class="content">
    <div class="content_resize">
      <div class="mainbar">
        <div class="article">

          <h2><span>EMI Calculator</span> </h2>
         

          <div class="clr"></div>
        
            <div class="post_content_emicalculator">



    
             
           
        


        
                <br />
                <br />
                How much Loan do you need :<asp:TextBox ID="amountTextBox1" runat="server"></asp:TextBox>
&nbsp; Tk.<br />
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Tenor:<asp:TextBox ID="monthTextBox2" runat="server"></asp:TextBox>
&nbsp;Month<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Rate of Interest:<asp:TextBox ID="interestTextBox3" runat="server"></asp:TextBox>
&nbsp; %<br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                  Text="Calculate EMI" ToolTip="Calculate" />
              &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="resteButton2" runat="server" onclick="resteButton2_Click" 
                    Text="Reset" />
              <br />
&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
              Your monthly installment is the :<asp:TextBox ID="monthlyamountTextBox4" 
                  runat="server"></asp:TextBox>
&nbsp; Tk only<br />
              <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
              Your total installment is the :<asp:TextBox ID="totalamountTextBox5" 
                  runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp; Tk only</div>
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
       
           
       
          
    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <br />
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
