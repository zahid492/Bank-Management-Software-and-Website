<%@ Page Language="C#" AutoEventWireup="true" CodeFile="accountinfo.aspx.cs" Inherits="accountinfo" %>

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
        

          &nbsp;&nbsp;&nbsp;
          <br />
          <br />
          <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <asp:Login ID="Login1" runat="server" BorderStyle="Solid" 
              CreateUserText="Register as a new user" CreateUserUrl="~/signing.aspx" 
              Height="220px"  style="margin-top: 0px" 
              TitleText="Please login here......." Width="465px" BackColor="#F7F6F3" 
              BorderColor="#E6E2D8" BorderPadding="4" BorderWidth="1px" 
              DestinationPageUrl="~/myaccount.aspx" Font-Names="Verdana" Font-Size="Medium" 
              ForeColor="#333333" onloggedin="Login1_LoggedIn">
              <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
              <LayoutTemplate>
                  <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                      <tr>
                          <td>
                              <table cellpadding="0" style="height:220px;width:465px;">
                                  <tr>
                                      <td align="center" colspan="2">
                                          Please login here.......</td>
                                  </tr>
                                  <tr>
                                      <td align="right">
                                          <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
                                      </td>
                                      <td>
                                          <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                          <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                              ControlToValidate="UserName" ErrorMessage="User Name is required." 
                                              ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                      </td>
                                  </tr>
                                  <tr>
                                      <td align="right">
                                          <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                                      </td>
                                      <td>
                                          <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                          <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                                              ControlToValidate="Password" ErrorMessage="Password is required." 
                                              ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                      </td>
                                  </tr>
                                  <tr>
                                      <td colspan="2">
                                          <asp:CheckBox ID="RememberMe" runat="server" Text="Remember me next time." />
                                      </td>
                                  </tr>
                                  <tr>
                                      <td align="center" colspan="2" style="color:Red;">
                                          <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                      </td>
                                  </tr>
                                  <tr>
                                      <td align="right" colspan="2">
                                          <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" 
                                              ValidationGroup="Login1" />
                                      </td>
                                  </tr>
                                  <tr>
                                      <td colspan="2">
                                          <asp:HyperLink ID="CreateUserLink" runat="server" NavigateUrl="~/signing.aspx">Register as a new user</asp:HyperLink>
                                      </td>
                                  </tr>
                              </table>
                          </td>
                      </tr>
                  </table>
              </LayoutTemplate>
              <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" 
                  BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
              <TextBoxStyle Font-Size="0.8em" />
              <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" 
                  ForeColor="White" />
          </asp:Login>
&nbsp;<br />
          <br />
          <br />
        

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
