<%@ Page Language="C#" AutoEventWireup="true" CodeFile="inbox.aspx.cs" Inherits="inbox" %>

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

          <h2><span>Inbox</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    )<asp:LinkButton ID="LinkButton1" runat="server" 
                  onclick="LinkButton1_Click">Logout</asp:LinkButton>
            </h2>
         

       
         
          <div class="post_content" style="text-align: justify">
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


      <div class="inbox">
      
      
      
      
      
      
          <br />
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
              CellPadding="4" EnableModelValidation="True" ForeColor="#333333" 
              GridLines="None" Height="182px" 
              onpageindexchanging="GridView1_PageIndexChanging" PageSize="5" 
              Width="676px" EmptyDataText="There is no message for you.">
                    <AlternatingRowStyle BackColor="White" BorderStyle="None" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="Large" 
                        ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:GridView>
      
      
      
      
      
      
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
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</div>
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
