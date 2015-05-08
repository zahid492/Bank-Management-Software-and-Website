<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

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

          <h2><span>Greenrose Bank Ltd.</span> </h2>
         

          <div class="clr"></div>
          <div class="img"><img src="images/img1.jpg" width="650" height="196" alt="" class="fl" /></div>
          <div class="post_content">
             <p>Green Rose Bank has been launched by a group of successful entrepreneurs with recognized standing in the society. The management of the Bank consists of a team led by senior bankers with decades of experience in national and international markets. The senior management team is ably supported by a group of professionals many of whom have exposure in the international market.

. It again repeated the performance by acquiring the Bangladesh operations of Muslim Commercial Bank Ltd. (MCB).

In the year 2013 the Bank again came to the limelight with oversubscription of the Initial Public Offering of the shares of the Bank, which was a record (55 times) in our capital market's history and its shares commands respectable premium.

The asset and liability growth has been remarkable. Green Rose Bank has been actively participating in the local money market as well as foreign currency market without exposing the Bank to vulnerable positions. The Bank's investment in Treasury Bills and other securities went up noticeably opening up opportunities for enhancing income in the context of a regime of gradual interest rate decline.


</p>
            <p><strong> Green Rose Bank limited started its service with a vision to serve people with modern and innovative banking products and services at affordable charge. Being parallel to the cutting edge technology the Bank is offering online banking with added delivery channels like ATM, Tele-banking, SMS and Net Banking. And as part of the bank's commitment to provide all modern and value added banking service in keeping with the very best standard in a globalize world.
           
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
           
                </strong></p>


        
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
        <div class="gadget">
          <h2 class="star">&nbsp;<span>Login Panel</span></h2>
          <asp:Login ID="Login1" runat="server" CreateUserText="Register as a new User" 
              CreateUserUrl="~/signing.aspx" DestinationPageUrl="~/myaccount.aspx" 
              onloggedin="Login1_LoggedIn" BackColor="#EFF3FB" BorderColor="#B5C7DE" 
              BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
              Font-Size="Medium" ForeColor="#333333" Height="184px" Width="228px" 
                style="margin-left: 0px; margin-top: 0px" UserNameLabelText="User ID:">
              <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
              <LoginButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" 
                  BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" 
                  ForeColor="#284E98" />
              <TextBoxStyle Font-Size="0.8em" />
              <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="0.9em" 
                  ForeColor="White" />
          </asp:Login>
           
          <div class="clr"></div>
          
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
