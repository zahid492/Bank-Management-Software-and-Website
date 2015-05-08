<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Header.ascx.cs" Inherits="controls_Header" %>


  <div class="header">
    <div class="header_resize">
      <div class="logo">
        <h1><a href="Default.aspx">Green Rose Bank <span>Ltd.</span> <small> Secure Banking Transaction </small></a></h1>
      </div>

      <div class="searchform">
        <form id="formsearch" name="formsearch" method="post" action="#">
          <span>
          <input name="editbox_search" class="editbox_search" id="editbox_search" maxlength="80" value="Search our ste:" type="text" />
          </span>
          <input name="button_search" src="images/search.gif" class="button_search" type="image" />
        </form>
      </div>
      <div class="clr"></div>

      <div class="slider">
        <div id="coin-slider"> <a href="#"><img src="images/slide1.jpg" width="940" height="310" alt="" /> </a> <a href="#"><img src="images/slide2.jpg" width="940" height="310" alt="" /> </a> <a href="#"><img src="images/slide3.jpg" width="940" height="310" alt="" /> </a> </div>
        <div class="clr"></div>
      </div>
      <div class="clr"></div>

      <div class="menu_nav">
        <ul>
          <li class="active"><a href="Default.aspx"><span>Home Page</span></a></li>
          <li><a href="support.html"><span>Recent News</span></a></li>
          <li><a href="accountinfo.aspx"><span>Online Banking</span></a></li>
          <li><a href="blog.html"><span>Carrers </span></a></li>
          <li><a href="contactus.aspx"><span>Contact Us</span></a></li>

        </ul>
      </div>
      <div class="clr"></div>
    </div>
  </div>