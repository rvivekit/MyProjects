﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using GasBlenderWeb;
using GBBusiness;

namespace GasBlenderWeb
{
    public partial class HomeBOL : System.Web.UI.Page
    {
        BusinessAccess _businessAccess = new BusinessAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Master != null)
            {
                Label l1 = (Label)Master.FindControl("LV1");
                l1.Text = "BOL";
                Label l2 = (Label)Master.FindControl("LV2");
                l2.Text = "BOL";
                Label l3 = (Label)Master.FindControl("LV3");
                l3.Text = "Home";
                HtmlAnchor CurrentMenu;
                CurrentMenu = (HtmlAnchor)Master.FindControl("Tab3");
                CurrentMenu.Attributes.Add("class", "active");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoadBOLHome.aspx");
                _businessAccess.InsertLog(Session["ID"].ToString(),
                      System.Reflection.MethodBase.GetCurrentMethod().Name, this.Page.ToString(), DateTime.Now);
                
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteBOLHome.aspx");
            _businessAccess.InsertLog(Session["ID"].ToString(),
                  System.Reflection.MethodBase.GetCurrentMethod().Name, this.Page.ToString(), DateTime.Now);
                
        }
    }
}