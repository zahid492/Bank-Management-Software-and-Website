﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class accountinfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void Login1_LoggedIn(object sender, EventArgs e)
    {
        Session["myvar"] = Login1.UserName;
    }
}