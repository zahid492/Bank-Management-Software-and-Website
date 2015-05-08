<%@ Page Language="C#" AutoEventWireup="true" CodeFile="signing.aspx.cs" Inherits="signing" %>
<%@ Register src="controls/Header.ascx" tagname="Header" tagprefix="uc1" %>

<%@ Register src="controls/Headerfooter.ascx" tagname="Headerfooter" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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

          <h2>&nbsp;</h2>
         

          <div class="clr"></div>
       
          <div class="post_content">
          <h2><span>Put your account information so accurately,not it refresh your page concurrently</span></h2>
             <p>

             
                 <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" BackColor="#F7F6F3" 
                     BorderColor="#E6E2D8" BorderStyle="Solid" BorderWidth="1px" 
                     Font-Names="Times New Roman" Font-Size="Large" Height="293px" 
                     onnextbuttonclick="CreateUserWizard1_NextButtonClick" Width="377px" 
                     oncontinuebuttonclick="CreateUserWizard1_ContinueButtonClick" 
                     oncreateduser="CreateUserWizard1_CreatedUser" 
                     ContinueDestinationPageUrl="~/Default.aspx" style="margin-left: 0px">
                     <ContinueButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
                         BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                         ForeColor="#284775" />
                     <CreateUserButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
                         BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                         ForeColor="#284775" />
                     <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                     <WizardSteps>
                         <asp:WizardStep runat="server" Title="Verify  account">
                            
                                 <div class="style1">
                                     Account No:
                                     <asp:TextBox ID="accTextBox1" runat="server"></asp:TextBox>
                                     <br />
                                     <br />
                                     Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                     <asp:TextBox ID="nameTextBox2" runat="server"></asp:TextBox>
                                     <br />
                                     <br />
                                     Card Serial:&nbsp;&nbsp;
                                     <asp:TextBox ID="serialTextBox3" runat="server"></asp:TextBox>
                                     <br />
                                     <br />
                                     Pin No:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                     <asp:TextBox ID="pinTextBox4" runat="server"></asp:TextBox>
                                     <br />
                                     <asp:Label ID="Label1" runat="server" 
                                         Text="Wrong Information ,Check Your Info."></asp:Label>
                                     <br />
                                 </div>
                             
                         </asp:WizardStep>
                         <asp:CreateUserWizardStep runat="server" />
                         <asp:CompleteWizardStep runat="server" />
                     </WizardSteps>
                     <HeaderStyle BackColor="#5D7B9D" BorderStyle="Solid" Font-Bold="True" 
                         Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
                     <NavigationButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" 
                         BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
                         ForeColor="#284775" />
                     <SideBarButtonStyle BorderWidth="0px" Font-Names="Verdana" ForeColor="White" />
                     <SideBarStyle BackColor="#5D7B9D" BorderWidth="0px" Font-Size="0.9em" 
                         VerticalAlign="Top" />
                     <StepStyle BorderWidth="0px" />
                 </asp:CreateUserWizard>


</p>
            
        
          </div>
          <div class="clr"></div>
        </div>

      </div>
      <div class="sidebar">
        <div class="gadget">
          <h2 class="star"><span>Sidebarenu</span></h2>
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
      
          <div class="clr"></div>
          
        </div>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         
      </div>
      <div class="clr">
          <br />
        </div>
    
    </div>
  </div>

</div>

    <uc1:Headerfooter ID="Headerfooter1" runat="server" />
    </form>
</body>
</html>
