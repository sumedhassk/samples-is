﻿using System;
using System.Web.UI;

namespace sample
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.rpIFrame.Attributes.Add("src", "SLOManagerIFrame.aspx");
        }
    }
}