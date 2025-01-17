﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JarvisBusinessAccess;

public partial class MainChartProperties : System.Web.UI.Page
{
    JarvisBusinessAccess.DefaultBusinessAccess jbAccess = new DefaultBusinessAccess();
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["Username"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        if (!IsPostBack)
        {
            if (Request.QueryString["Sno"] == null)
            {
                Response.Redirect("MainChart.aspx");
            }
            else
            {
                DataTable result = jbAccess.GetChartValues(Request.QueryString["Sno"]);
                foreach (DataRow row in result.Rows)
                {
                    txtPrimaryHeader.Text = row["ChartPrimaryHeader"].ToString();
                    txtSecondaryHeader.Text = row["ChartSecondaryHeader"].ToString();
                    chkAllowMultipleSelection.Checked = Convert.ToBoolean(row["AllowMultipleSelection"].ToString());
                    chkExportImage.Checked = Convert.ToBoolean(row["ExportOptionsExporttoImage"].ToString());
                    chkPrint.Checked = Convert.ToBoolean(row["ExportOptionsAllowPrint"].ToString());
                    txtHeight.Text = row["Height"].ToString();
                    rblHeight.SelectedValue = row["HeightMode"].ToString();
                    chkInvertChart.Checked = Convert.ToBoolean(row["IsInverted"].ToString());
                    txtWidth.Text = row["Width"].ToString();
                    rblWidth.SelectedValue = row["WidthMode"].ToString();
                    ddlZoomMode.SelectedValue = row["ZoomMode"].ToString();
                    chkAxisMarkerEnabled.Checked = Convert.ToBoolean(row["AxisMarkersEnabled"].ToString());
                    ddlAxisMarkerMode.SelectedValue = row["AxisMarkersMode"].ToString();
                    txtAxisWidth.Text = row["AxisMarkersWidth"].ToString();
                    chkChartBound.Checked = Convert.ToBoolean(row["TooltipSettingsChartBound"].ToString());
                }

            }
        }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string insertedValue = jbAccess.UpdateMainChartConfiguration(txtPrimaryHeader.Text, txtSecondaryHeader.Text,
          chkAllowMultipleSelection.Checked, chkExportImage.Checked,
          chkPrint.Checked, Convert.ToInt16(txtHeight.Text), rblHeight.SelectedValue, chkInvertChart.Checked,
          Convert.ToInt16(txtWidth.Text), rblWidth.SelectedValue,
          Convert.ToInt16(ddlZoomMode.SelectedValue), chkAxisMarkerEnabled.Checked,
          Convert.ToInt16(ddlAxisMarkerMode.SelectedValue), Convert.ToInt16(txtAxisWidth.Text),
          chkChartBound.Checked, DateTime.Now, Request.QueryString["Sno"]);

        lblResult.Text = "* Update Successful";
    }
}