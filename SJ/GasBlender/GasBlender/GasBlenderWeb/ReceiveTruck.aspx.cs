﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using GBBusiness;
using System.Net;
using Label = System.Web.UI.WebControls.Label;

namespace GasBlenderWeb
{
    public partial class ReceiveTruck : System.Web.UI.Page
    {
        private GBBusiness.BusinessAccess _businessAccess = new BusinessAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Master != null)
                {
                    Label l1 = (Label)Master.FindControl("LV1");
                    l1.Text = "Receive Truck Load";
                    Label l2 = (Label)Master.FindControl("LV2");
                    l2.Text = "Receive Truck";
                    Label l3 = (Label)Master.FindControl("LV3");
                    l3.Text = "Home";
                    HtmlAnchor CurrentMenu;
                    CurrentMenu = (HtmlAnchor)Master.FindControl("Tab2");
                    CurrentMenu.Attributes.Add("class", "active");
                }
                BindData();
            }
        }

        public void BindData()
        {
            lblMessage.Text = "";
            txtPercentage.Text = "90";

            txtOnBoard1.Text = "0";
            txtOnBoard2.Text = "0";
            txtOnBoard3.Text = "0";
            txtOnBoard4.Text = "0";
            txtOnBoard5.Text = "0";

            txtSize1.Text = "0";
            txtSize2.Text = "0";
            txtSize3.Text = "0";
            txtSize4.Text = "0";
            txtSize5.Text = "0";

            txt90P1.Text = "0";
            txt90P2.Text = "0";
            txt90P3.Text = "0";
            txt90P4.Text = "0";
            txt90P5.Text = "0";


            txtReg1.Text = "0";
            txtReg2.Text = "0";
            txtReg3.Text = "0";
            txtReg4.Text = "0";
            txtReg5.Text = "0";

            txtSuper1.Text = "0";
            txtSuper2.Text = "0";
            txtSuper3.Text = "0";
            txtSuper4.Text = "0";
            txtSuper5.Text = "0";

            txtEthanol1.Text = "0";
            txtEthanol2.Text = "0";
            txtEthanol3.Text = "0";
            txtEthanol4.Text = "0";
            txtEthanol5.Text = "0";

            ddlLoadType.Items.Add(new ListItem("Normal Load", "1"));
            ddlLoadType.Items.Add(new ListItem("Partial Load", "2"));
            ddlLoadType.Items.Add(new ListItem("Split Load", "3"));
            ddlLoadType.Items.Add(new ListItem("Reload", "4"));

            ddlCarrier.DataSource =
                _businessAccess.GetCarrier().AsEnumerable().OrderBy(row => row["name"]).CopyToDataTable();
            ddlCarrier.DataTextField = "name";
            ddlCarrier.DataValueField = "carrierID";
            ddlCarrier.DataBind();

            ddlTrailerNumber.DataSource =
                _businessAccess.GetAllTrailer().AsEnumerable().OrderBy(row => row["trailerNumber"]).CopyToDataTable();
            ddlTrailerNumber.DataTextField = "trailerNumber";
            ddlTrailerNumber.DataValueField = "trailerID";
            ddlTrailerNumber.DataBind();

            ddlTractor.DataSource =
                _businessAccess.GetTractor().AsEnumerable().OrderBy(row => row["name"]).CopyToDataTable();
            ddlTractor.DataTextField = "name";
            ddlTractor.DataValueField = "tractorID";
            ddlTractor.DataBind();

            ddlDriver.DataSource =
                _businessAccess.GetDriver().AsEnumerable().OrderBy(row => row["name"]).CopyToDataTable();
            ddlDriver.DataTextField = "name";
            ddlDriver.DataValueField = "driverID";
            ddlDriver.DataBind();

            ddlGasType1.Items.Add(new ListItem("R", "1"));
            ddlGasType1.Items.Add(new ListItem("S", "2"));
            ddlGasType1.Items.Add(new ListItem("E", "3"));
            ddlGasType1.Items.Add(new ListItem("SP", "4"));
            ddlGasType1.Items.Add(new ListItem("RtoS", "5"));

            ddlGasType2.Items.Add(new ListItem("R", "1"));
            ddlGasType2.Items.Add(new ListItem("S", "2"));
            ddlGasType2.Items.Add(new ListItem("E", "3"));
            ddlGasType2.Items.Add(new ListItem("SP", "4"));
            ddlGasType2.Items.Add(new ListItem("RtoS", "5"));

            ddlGasType3.Items.Add(new ListItem("R", "1"));
            ddlGasType3.Items.Add(new ListItem("S", "2"));
            ddlGasType3.Items.Add(new ListItem("E", "3"));
            ddlGasType3.Items.Add(new ListItem("SP", "4"));
            ddlGasType3.Items.Add(new ListItem("RtoS", "5"));

            ddlGasType4.Items.Add(new ListItem("R", "1"));
            ddlGasType4.Items.Add(new ListItem("S", "2"));
            ddlGasType4.Items.Add(new ListItem("E", "3"));
            ddlGasType4.Items.Add(new ListItem("SP", "4"));
            ddlGasType4.Items.Add(new ListItem("RtoS", "5"));

            ddlGasType5.Items.Add(new ListItem("R", "1"));
            ddlGasType5.Items.Add(new ListItem("S", "2"));
            ddlGasType5.Items.Add(new ListItem("E", "3"));
            ddlGasType5.Items.Add(new ListItem("SP", "4"));
            ddlGasType5.Items.Add(new ListItem("RtoS", "5"));

            ddlDeliver1.DataSource =
                _businessAccess.GetLocation().AsEnumerable().OrderBy(row => row["locationName"]).CopyToDataTable();
            ddlDeliver1.DataTextField = "locationName";
            ddlDeliver1.DataValueField = "locationID";
            ddlDeliver1.DataBind();

            ddlDeliver2.DataSource =
              _businessAccess.GetLocation().AsEnumerable().OrderBy(row => row["locationName"]).CopyToDataTable();
            ddlDeliver2.DataTextField = "locationName";
            ddlDeliver2.DataValueField = "locationID";
            ddlDeliver2.DataBind();

            ddlDeliver3.DataSource =
              _businessAccess.GetLocation().AsEnumerable().OrderBy(row => row["locationName"]).CopyToDataTable();
            ddlDeliver3.DataTextField = "locationName";
            ddlDeliver3.DataValueField = "locationID";
            ddlDeliver3.DataBind();

            ddlDeliver4.DataSource =
              _businessAccess.GetLocation().AsEnumerable().OrderBy(row => row["locationName"]).CopyToDataTable();
            ddlDeliver4.DataTextField = "locationName";
            ddlDeliver4.DataValueField = "locationID";
            ddlDeliver4.DataBind();

            ddlDeliver5.DataSource =
              _businessAccess.GetLocation().AsEnumerable().OrderBy(row => row["locationName"]).CopyToDataTable();
            ddlDeliver5.DataTextField = "locationName";
            ddlDeliver5.DataValueField = "locationID";
            ddlDeliver5.DataBind();

            lblTotalLoad1.Text = "0";
            lblTotalLoad2.Text = "0";
            lblTotalLoad3.Text = "0";
            lblTotalLoad4.Text = "0";
            lblTotalLoad5.Text = "0";
            lblTotalRight1.Text = "0";
            lblTotalRight2.Text = "0";
            lblTotalRight3.Text = "0";
            lblFinalTotal.Text = "0";
            ////////////////////////////////////////////////////////////////////////////////
            for (int i = 1; i <= 12; i++)
            {
                ddlHourStart.Items.Add(i.ToString("D2"));
            }


            for (int i = 0; i < 60; i++)
            {
                ddlMinuteStart.Items.Add(i.ToString("D2"));

                ddlSecondStart.Items.Add(i.ToString("D2"));
            }

            ddlAMStart.Items.Add("AM"); ddlAMStart.Items.Add("PM");

            txtStartDate.Text = DateTime.Now.ToString("d");

            ddlHourStart.SelectedIndex = ddlHourStart.Items.IndexOf(new ListItem(DateTime.Now.ToString("hh")));

            ddlMinuteStart.SelectedIndex = ddlMinuteStart.Items.IndexOf(new ListItem(DateTime.Now.ToString("mm")));

            ddlSecondStart.SelectedIndex = ddlSecondStart.Items.IndexOf(new ListItem(DateTime.Now.ToString("ss")));

            ddlAMStart.SelectedIndex = ddlAMStart.Items.IndexOf(new ListItem(DateTime.Now.ToString("tt")));

        }


        protected void ddlTrailerNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadFix();
            DataTable dt = _businessAccess.GetCastedTruck().AsEnumerable()
                .Where(row => row["trailerID"].ToString() == ddlTrailerNumber.SelectedValue).CopyToDataTable();
            //   .OrderBy(row => row["trailerName"]).CopyToDataTable();
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    txtSize1.Text = dt.Rows[0]["compartment1Size"].ToString();
                    txtSize2.Text = dt.Rows[0]["compartment2Size"].ToString();
                    txtSize3.Text = dt.Rows[0]["compartment3Size"].ToString();
                    txtSize4.Text = dt.Rows[0]["compartment4Size"].ToString();
                    txtSize5.Text = dt.Rows[0]["compartment5Size"].ToString();
                    CalculateSize(1);
                    CalculateSize(2);
                    CalculateSize(3);
                    CalculateSize(4);
                    CalculateSize(5);

                    BlockEmptyContainers();

                    if (ddlLoadType.SelectedValue == "4")
                    {
                        txtOnBoard1.Enabled = false;
                        txtOnBoard2.Enabled = false;
                        txtOnBoard3.Enabled = false;
                        txtOnBoard4.Enabled = false;
                        txtOnBoard5.Enabled = false;
                    }
                    else
                    {
                        txtOnBoard1.Enabled = true;
                        txtOnBoard2.Enabled = true;
                        txtOnBoard3.Enabled = true;
                        txtOnBoard4.Enabled = true;
                        txtOnBoard5.Enabled = true;
                    }

                    LoadType(); OnlyBlockEmptyContainers();

                }
            }
            


        }

        private void BlockEmptyContainers()
        {
            if (txtSize1.Text == "0")
            {
                ddlGasType1.Enabled = false;
                txtSize1.Enabled = false;
                txtOnBoard1.Enabled = false;
                txt90P1.Enabled = false;
                txtReg1.Enabled = false;
                txtSuper1.Enabled = false;
                txtEthanol1.Enabled = false;
                ddlDeliver1.Enabled = false;
            }
            else
            {
                ddlGasType1.Enabled = true;
                txtSize1.Enabled = true;
                txtOnBoard1.Enabled = true;
                txt90P1.Enabled = true;
                txtReg1.Enabled = true;
                txtSuper1.Enabled = true;
                txtEthanol1.Enabled = true;
                ddlDeliver1.Enabled = true;
            }


            if (txtSize2.Text == "0")
            {
                ddlGasType2.Enabled = false;
                txtSize2.Enabled = false;
                txtOnBoard2.Enabled = false;
                txt90P2.Enabled = false;
                txtReg2.Enabled = false;
                txtSuper2.Enabled = false;
                txtEthanol2.Enabled = false;
                ddlDeliver2.Enabled = false;
            }
            else
            {
                ddlGasType2.Enabled = true;
                txtSize2.Enabled = true;
                txtOnBoard2.Enabled = true;
                txt90P2.Enabled = true;
                txtReg2.Enabled = true;
                txtSuper2.Enabled = true;
                txtEthanol2.Enabled = true;
                ddlDeliver2.Enabled = true;
            }
            if (txtSize3.Text == "0")
            {
                ddlGasType3.Enabled = false;
                txtSize3.Enabled = false;
                txtOnBoard3.Enabled = false;
                txt90P3.Enabled = false;
                txtReg3.Enabled = false;
                txtSuper3.Enabled = false;
                txtEthanol3.Enabled = false;
                ddlDeliver3.Enabled = false;
            }
            else
            {
                ddlGasType3.Enabled = true;
                txtSize3.Enabled = true;
                txtOnBoard3.Enabled = true;
                txt90P3.Enabled = true;
                txtReg3.Enabled = true;
                txtSuper3.Enabled = true;
                txtEthanol3.Enabled = true;
                ddlDeliver3.Enabled = true;
            }
            if (txtSize4.Text == "0")
            {
                ddlGasType4.Enabled = false;
                txtSize4.Enabled = false;
                txtOnBoard4.Enabled = false;
                txt90P4.Enabled = false;
                txtReg4.Enabled = false;
                txtSuper4.Enabled = false;
                txtEthanol4.Enabled = false;
                ddlDeliver4.Enabled = false;
            }
            else
            {
                ddlGasType4.Enabled = true;
                txtSize4.Enabled = true;
                txtOnBoard4.Enabled = true;
                txt90P4.Enabled = true;
                txtReg4.Enabled = true;
                txtSuper4.Enabled = true;
                txtEthanol4.Enabled = true;
                ddlDeliver4.Enabled = true;
            }
            if (txtSize5.Text == "0")
            {
                ddlGasType5.Enabled = false;
                txtSize5.Enabled = false;
                txtOnBoard5.Enabled = false;
                txt90P5.Enabled = false;
                txtReg5.Enabled = false;
                txtSuper5.Enabled = false;
                txtEthanol5.Enabled = false;
                ddlDeliver5.Enabled = false;
            }
            else
            {
                ddlGasType5.Enabled = true;
                txtSize5.Enabled = true;
                txtOnBoard5.Enabled = true;
                txt90P5.Enabled = true;
                txtReg5.Enabled = true;
                txtSuper5.Enabled = true;
                txtEthanol5.Enabled = true;
                ddlDeliver5.Enabled = true;
            }
        }

        private void OnlyBlockEmptyContainers()
        {
            if (txtSize1.Text == "0")
            {
                ddlGasType1.Enabled = false;
                txtSize1.Enabled = false;
                txtOnBoard1.Enabled = false;
                txt90P1.Enabled = false;
                txtReg1.Enabled = false;
                txtSuper1.Enabled = false;
                txtEthanol1.Enabled = false;
                ddlDeliver1.Enabled = false;
            }
            
            if (txtSize2.Text == "0")
            {
                ddlGasType2.Enabled = false;
                txtSize2.Enabled = false;
                txtOnBoard2.Enabled = false;
                txt90P2.Enabled = false;
                txtReg2.Enabled = false;
                txtSuper2.Enabled = false;
                txtEthanol2.Enabled = false;
                ddlDeliver2.Enabled = false;
            }
            if (txtSize3.Text == "0")
            {
                ddlGasType3.Enabled = false;
                txtSize3.Enabled = false;
                txtOnBoard3.Enabled = false;
                txt90P3.Enabled = false;
                txtReg3.Enabled = false;
                txtSuper3.Enabled = false;
                txtEthanol3.Enabled = false;
                ddlDeliver3.Enabled = false;
            }
            
            if (txtSize4.Text == "0")
            {
                ddlGasType4.Enabled = false;
                txtSize4.Enabled = false;
                txtOnBoard4.Enabled = false;
                txt90P4.Enabled = false;
                txtReg4.Enabled = false;
                txtSuper4.Enabled = false;
                txtEthanol4.Enabled = false;
                ddlDeliver4.Enabled = false;
            }
            if (txtSize5.Text == "0")
            {
                ddlGasType5.Enabled = false;
                txtSize5.Enabled = false;
                txtOnBoard5.Enabled = false;
                txt90P5.Enabled = false;
                txtReg5.Enabled = false;
                txtSuper5.Enabled = false;
                txtEthanol5.Enabled = false;
                ddlDeliver5.Enabled = false;
            }
            
        }

        public void CalculateSize(int compartmentID)
        {
            FixValues();


            switch (compartmentID)
            {
                case 1:
                    txt90P1.Text = ((int)((float.Parse(CheckValue(txtSize1.Text)) / 100) * float.Parse(CheckValue(txtPercentage.Text)))).ToString();
                    break;
                case 2:
                    txt90P2.Text = ((int)((float.Parse(CheckValue(txtSize2.Text)) / 100) * float.Parse(CheckValue(txtPercentage.Text)))).ToString();
                    break;
                case 3:
                    txt90P3.Text = ((int)((float.Parse(CheckValue(txtSize3.Text)) / 100) * float.Parse(CheckValue(txtPercentage.Text)))).ToString();
                    break;
                case 4:
                    txt90P4.Text = ((int)((float.Parse(CheckValue(txtSize4.Text)) / 100) * float.Parse(CheckValue(txtPercentage.Text)))).ToString();
                    break;
                case 5:
                    txt90P5.Text = ((int)((float.Parse(CheckValue(txtSize5.Text)) / 100) * float.Parse(CheckValue(txtPercentage.Text)))).ToString();
                    break;
            }
            GasType(compartmentID);
            CalculateTotals();
            ReloadFix();
        }

        protected void txtSize1_TextChanged(object sender, EventArgs e)
        {
            CalculateSize(1);
        }

        protected void txtSize2_TextChanged(object sender, EventArgs e)
        {
            CalculateSize(2);
        }

        protected void txtSize3_TextChanged(object sender, EventArgs e)
        {
            CalculateSize(3);
        }

        protected void txtSize4_TextChanged(object sender, EventArgs e)
        {
            CalculateSize(4);
        }

        protected void txtSize5_TextChanged(object sender, EventArgs e)
        {
            CalculateSize(5);
        }

        public string CheckValue(string Value)
        {
            string Result = "0";
            try
            {
                Result = (float.Parse(Value)).ToString(CultureInfo.InvariantCulture);
                return Result;
            }
            catch (Exception)
            {
                return Result;
            }
        }

        protected void ddlGasType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateSize(1);

        }

        protected void ddlGasType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateSize(2);
        }

        protected void ddlGasType3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateSize(3);
        }

        protected void ddlGasType4_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateSize(4);
        }

        protected void ddlGasType5_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateSize(5);
        }

        public void GasType(int compartmentID)
        {
            FixValues();
            if (ddlGasType1.SelectedValue == "1" && compartmentID == 1)
            {
                //  txtReg1.Text = (float.Parse(txt90P1.Text) - float.Parse(txtOnBoard1.Text)).ToString();
                //  txtEthanol1.Text = (float.Parse(txtSize1.Text) - float.Parse(txt90P1.Text)).ToString();
                //  txtSuper1.Text = "0";
                //  lblTotalLoad1.Text = ((int)float.Parse(txtSize1.Text)).ToString();
                txtReg1.Text = "0";
                txtSuper1.Text = "0";
                txtEthanol1.Text = ((int)((float.Parse(txtOnBoard1.Text) / 100) * 0.5)).ToString();

            }

            if (ddlGasType2.SelectedValue == "1" && compartmentID == 2)
            {
                //txtReg2.Text = (float.Parse(txt90P2.Text) - float.Parse(txtOnBoard2.Text)).ToString();
                //txtEthanol2.Text = ((int)(float.Parse(txtSize2.Text) - float.Parse(txt90P2.Text))).ToString();
                //txtSuper2.Text = "0";
                //lblTotalLoad2.Text = ((int)float.Parse(txtSize2.Text)).ToString();
                txtReg2.Text = "0";
                txtSuper2.Text = "0";
                txtEthanol2.Text = ((int)((float.Parse(txtOnBoard2.Text) / 100) * 0.5)).ToString();
            }
            if (ddlGasType3.SelectedValue == "1" && compartmentID == 3)
            {
                //txtReg3.Text = (float.Parse(txt90P3.Text) - float.Parse(txtOnBoard3.Text)).ToString();
                //txtEthanol3.Text = ((int)(float.Parse(txtSize3.Text) - float.Parse(txt90P3.Text))).ToString();
                //txtSuper3.Text = "0";
                //lblTotalLoad3.Text = ((int)float.Parse(txtSize3.Text)).ToString();

                txtReg3.Text = "0";
                txtSuper3.Text = "0";
                txtEthanol3.Text = ((int)((float.Parse(txtOnBoard3.Text) / 100) * 0.5)).ToString();
            }
            if (ddlGasType4.SelectedValue == "1" && compartmentID == 4)
            {
                //txtReg4.Text = (float.Parse(txt90P4.Text) - float.Parse(txtOnBoard4.Text)).ToString();
                //txtEthanol4.Text = ((int)(float.Parse(txtSize4.Text) - float.Parse(txt90P4.Text))).ToString();
                //txtSuper4.Text = "0";
                //lblTotalLoad4.Text = ((int)float.Parse(txtSize4.Text)).ToString();
                txtReg4.Text = "0";
                txtSuper4.Text = "0";
                txtEthanol4.Text = ((int)((float.Parse(txtOnBoard4.Text) / 100) * 0.5)).ToString();
            }
            if (ddlGasType5.SelectedValue == "1" && compartmentID == 5)
            {
                //txtReg5.Text = (float.Parse(txt90P5.Text) - float.Parse(txtOnBoard5.Text)).ToString();
                //txtEthanol5.Text = ((int)(float.Parse(txtSize5.Text) - float.Parse(txt90P5.Text))).ToString();
                //txtSuper5.Text = "0";
                //lblTotalLoad5.Text = ((int)float.Parse(txtSize5.Text)).ToString();
                txtReg5.Text = "0";
                txtSuper5.Text = "0";
                txtEthanol5.Text = ((int)((float.Parse(txtOnBoard5.Text) / 100) * 0.5)).ToString();
            }

            ////////////////////////////////////////////////////////////////////////////////////////////

            if (ddlGasType1.SelectedValue == "2" && compartmentID == 1)
            {
                //txtReg1.Text = (float.Parse(txt90P1.Text) / 2).ToString();
                //txtSuper1.Text = ((int)(float.Parse(txtReg1.Text) - float.Parse(txtOnBoard1.Text))).ToString();
                //txtEthanol1.Text = ((int)(float.Parse(txtSize1.Text) - float.Parse(txt90P1.Text))).ToString();
                //lblTotalLoad1.Text = ((int)float.Parse(txtSize5.Text)).ToString();
                txtReg1.Text = "0";
                txtSuper1.Text = "0";
                txtEthanol1.Text = ((int)((float.Parse(txtOnBoard1.Text) / 100) * 0.5)).ToString();
            }

            if (ddlGasType2.SelectedValue == "2" && compartmentID == 2)
            {
                //txtReg2.Text = (float.Parse(txt90P2.Text) / 2).ToString();
                //txtSuper2.Text = ((int)(float.Parse(txtReg2.Text) - float.Parse(txtOnBoard2.Text))).ToString();
                //txtEthanol2.Text = ((int)(float.Parse(txtSize2.Text) - float.Parse(txt90P2.Text))).ToString();
                //lblTotalLoad2.Text = ((int)float.Parse(txtSize2.Text)).ToString();
                txtReg2.Text = "0";
                txtSuper2.Text = "0";
                txtEthanol2.Text = ((int)((float.Parse(txtOnBoard2.Text) / 100) * 0.5)).ToString();
            }
            if (ddlGasType3.SelectedValue == "2" && compartmentID == 3)
            {
                //txtReg3.Text = (float.Parse(txt90P3.Text) / 2).ToString();
                //txtSuper3.Text = ((int)(float.Parse(txtReg3.Text) - float.Parse(txtOnBoard3.Text))).ToString();
                //txtEthanol3.Text = ((int)(float.Parse(txtSize3.Text) - float.Parse(txt90P3.Text))).ToString();
                //lblTotalLoad3.Text = ((int)float.Parse(txtSize3.Text)).ToString();
                txtReg3.Text = "0";
                txtSuper3.Text = "0";
                txtEthanol3.Text = ((int)((float.Parse(txtOnBoard3.Text) / 100) * 0.5)).ToString();
            }
            if (ddlGasType4.SelectedValue == "2" && compartmentID == 4)
            {
                //txtReg4.Text = (float.Parse(txt90P4.Text) / 2).ToString();
                //txtSuper4.Text = ((int)(float.Parse(txtReg4.Text) - float.Parse(txtOnBoard4.Text))).ToString();
                //txtEthanol4.Text = ((int)(float.Parse(txtSize4.Text) - float.Parse(txt90P4.Text))).ToString();
                //lblTotalLoad4.Text = ((int)float.Parse(txtSize4.Text)).ToString();
                txtReg4.Text = "0";
                txtSuper4.Text = "0";
                txtEthanol4.Text = ((int)((float.Parse(txtOnBoard4.Text) / 100) * 0.5)).ToString();
            }
            if (ddlGasType5.SelectedValue == "2" && compartmentID == 5)
            {
                //txtReg5.Text = (float.Parse(txt90P5.Text) / 2).ToString();
                //txtSuper5.Text = ((int)(float.Parse(txtReg5.Text) - float.Parse(txtOnBoard5.Text))).ToString();
                //txtEthanol5.Text = ((int)(float.Parse(txtSize5.Text) - float.Parse(txt90P5.Text))).ToString();
                //lblTotalLoad5.Text = ((int)float.Parse(txtSize5.Text)).ToString();
                txtReg5.Text = "0";
                txtSuper5.Text = "0";
                txtEthanol5.Text = ((int)((float.Parse(txtOnBoard5.Text) / 100) * 0.5)).ToString();
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            if (ddlGasType1.SelectedValue == "3" && compartmentID == 1)
            {
                //txtReg1.Text = "0";
                //txtSuper1.Text = "0";
                //txtEthanol1.Text = ((int)(float.Parse(txtOnBoard1.Text) * -1)).ToString();
                //lblTotalLoad1.Text = "0";
                txtReg1.Text = "0";
                txtSuper1.Text = "0";
                txtEthanol1.Text = "0";

            }

            if (ddlGasType2.SelectedValue == "3" && compartmentID == 2)
            {
                //txtReg2.Text = "0";
                //txtSuper2.Text = "0";
                //txtEthanol2.Text = ((int)(float.Parse(txtOnBoard2.Text) * -1)).ToString();
                //lblTotalLoad1.Text = "0";
                txtReg2.Text = "0";
                txtSuper2.Text = "0";
                txtEthanol2.Text = "0";

            }
            if (ddlGasType3.SelectedValue == "3" && compartmentID == 3)
            {
                //txtReg3.Text = "0";
                //txtSuper3.Text = "0";
                //txtEthanol3.Text = ((int)(float.Parse(txtOnBoard3.Text) * -1)).ToString();
                //lblTotalLoad1.Text = "0";
                txtReg3.Text = "0";
                txtSuper3.Text = "0";
                txtEthanol3.Text = "0";

            }
            if (ddlGasType4.SelectedValue == "3" && compartmentID == 4)
            {
                //txtReg4.Text = "0";
                //txtSuper4.Text = "0";
                //txtEthanol4.Text = ((int)(float.Parse(txtOnBoard4.Text) * -1)).ToString();
                //lblTotalLoad1.Text = "0";
                txtReg4.Text = "0";
                txtSuper4.Text = "0";
                txtEthanol4.Text = "0";

            }
            if (ddlGasType5.SelectedValue == "3" && compartmentID == 5)
            {
                //txtReg5.Text = "0";
                //txtSuper5.Text = "0";
                //txtEthanol5.Text = ((int)(float.Parse(txtOnBoard5.Text) * -1)).ToString();
                //lblTotalLoad1.Text = "0";

                txtReg5.Text = "0";
                txtSuper5.Text = "0";
                txtEthanol5.Text = "0";

            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            if (ddlGasType1.SelectedValue == "4" && compartmentID == 1)
            {
                //txtReg1.Text = "0";
                //txtSuper1.Text = "0";
                //txtEthanol1.Text = ((int)(float.Parse(txtOnBoard1.Text) / 10)).ToString();
                //lblTotalLoad1.Text = ((int)(float.Parse(txtOnBoard1.Text) + float.Parse(txtEthanol1.Text))).ToString();
                txtReg1.Text = "0";
                txtSuper1.Text = "0";
                txtEthanol1.Text = ((int)((float.Parse(txtOnBoard1.Text) / 100) * 0.5)).ToString();
                //txtEthanol1.Text = ((int)(((float.Parse(txtOnBoard1.Text) + float.Parse(txtSuper1.Text)) / 100) * 0.5)).ToString();

            }

            if (ddlGasType2.SelectedValue == "4" && compartmentID == 2)
            {
                //txtReg2.Text = "0";
                //txtSuper2.Text = "0";
                //txtEthanol2.Text = ((int)(float.Parse(txtOnBoard2.Text) / 10)).ToString();
                //lblTotalLoad2.Text = ((int)(float.Parse(txtOnBoard2.Text) + float.Parse(txtEthanol2.Text))).ToString();
                txtReg2.Text = "0";
                txtSuper2.Text = "0";
                txtEthanol2.Text = ((int)((float.Parse(txtOnBoard2.Text) / 100) * 0.5)).ToString();

            }
            if (ddlGasType3.SelectedValue == "4" && compartmentID == 3)
            {
                //txtReg3.Text = "0";
                //txtSuper3.Text = "0";
                //txtEthanol3.Text = ((int)(float.Parse(txtOnBoard3.Text) / 10)).ToString();
                //lblTotalLoad3.Text = ((int)(float.Parse(txtOnBoard3.Text) + float.Parse(txtEthanol3.Text))).ToString();
                txtReg3.Text = "0";
                txtSuper3.Text = "0";
                txtEthanol3.Text = ((int)((float.Parse(txtOnBoard3.Text) / 100) * 0.5)).ToString();
            }
            if (ddlGasType4.SelectedValue == "4" && compartmentID == 4)
            {
                //txtReg4.Text = "0";
                //txtSuper4.Text = "0";
                //txtEthanol4.Text = ((int)(float.Parse(txtOnBoard4.Text) / 10)).ToString();
                //lblTotalLoad4.Text = ((int)(float.Parse(txtOnBoard4.Text) + float.Parse(txtEthanol4.Text))).ToString();
                txtReg4.Text = "0";
                txtSuper4.Text = "0";
                txtEthanol4.Text = ((int)((float.Parse(txtOnBoard4.Text) / 100) * 0.5)).ToString();
            }
            if (ddlGasType5.SelectedValue == "4" && compartmentID == 5)
            {
                //txtReg5.Text = "0";
                //txtSuper5.Text = "0";
                //txtEthanol5.Text = ((int)(float.Parse(txtOnBoard5.Text) / 10)).ToString();
                //lblTotalLoad5.Text = ((int)(float.Parse(txtOnBoard5.Text) + float.Parse(txtEthanol5.Text))).ToString();
                txtReg5.Text = "0";
                txtSuper5.Text = "0";
                txtEthanol5.Text = ((int)((float.Parse(txtOnBoard5.Text) / 100) * 0.5)).ToString();
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            if (ddlGasType1.SelectedValue == "5" && compartmentID == 1)
            {
                txtReg1.Text = ((int)((float.Parse(txt90P1.Text) / 2) - float.Parse(txtOnBoard1.Text))).ToString();
                txtSuper1.Text = ((int)((float.Parse(txt90P1.Text) / 2))).ToString();
                txtEthanol1.Text = ((int)(float.Parse(txtSize1.Text) / 10)).ToString();
                lblTotalLoad1.Text = ((int)float.Parse(txtSize1.Text)).ToString();
            }

            if (ddlGasType2.SelectedValue == "5" && compartmentID == 2)
            {
                txtReg2.Text = ((int)((float.Parse(txt90P2.Text) / 2) - float.Parse(txtOnBoard2.Text))).ToString();
                txtSuper2.Text = ((int)((float.Parse(txt90P2.Text) / 2))).ToString();
                txtEthanol2.Text = ((int)(float.Parse(txtSize2.Text) / 10)).ToString();
                lblTotalLoad2.Text = ((int)float.Parse(txtSize2.Text)).ToString();
            }
            if (ddlGasType3.SelectedValue == "5" && compartmentID == 3)
            {
                txtReg3.Text = ((int)((float.Parse(txt90P3.Text) / 2) - float.Parse(txtOnBoard3.Text))).ToString();
                txtSuper3.Text = ((int)((float.Parse(txt90P3.Text) / 2))).ToString();
                txtEthanol3.Text = ((int)(float.Parse(txtSize3.Text) / 10)).ToString();
                lblTotalLoad3.Text = ((int)float.Parse(txtSize3.Text)).ToString();
            }
            if (ddlGasType4.SelectedValue == "5" && compartmentID == 4)
            {
                txtReg4.Text = ((int)((float.Parse(txt90P4.Text) / 2) - float.Parse(txtOnBoard4.Text))).ToString();
                txtSuper4.Text = ((int)((float.Parse(txt90P4.Text) / 2))).ToString();
                txtEthanol4.Text = ((int)(float.Parse(txtSize4.Text) / 10)).ToString();
                lblTotalLoad4.Text = ((int)float.Parse(txtSize4.Text)).ToString();
            }
            if (ddlGasType5.SelectedValue == "5" && compartmentID == 5)
            {
                txtReg5.Text = ((int)((float.Parse(txt90P5.Text) / 2) - float.Parse(txtOnBoard5.Text))).ToString();
                txtSuper5.Text = ((int)((float.Parse(txt90P5.Text) / 2))).ToString();
                txtEthanol5.Text = ((int)(float.Parse(txtSize5.Text) / 10)).ToString();
                lblTotalLoad5.Text = ((int)float.Parse(txtSize5.Text)).ToString();
            }



        }

        public void CalculateTotals()
        {




            lblTotalRight1.Text = ((int)(float.Parse(txtReg1.Text) + float.Parse(txtReg2.Text) + float.Parse(txtReg3.Text) +
                                  float.Parse(txtReg4.Text) + float.Parse(txtReg5.Text))).ToString();
            lblTotalRight2.Text = ((int)(float.Parse(txtSuper1.Text) + float.Parse(txtSuper2.Text) + float.Parse(txtSuper3.Text) +
                         float.Parse(txtSuper4.Text) + float.Parse(txtSuper5.Text))).ToString();
            lblTotalRight3.Text = ((int)(float.Parse(txtEthanol1.Text) + float.Parse(txtEthanol2.Text) + float.Parse(txtEthanol3.Text) +
                      float.Parse(txtEthanol4.Text) + float.Parse(txtEthanol5.Text))).ToString();

            lblTotalLoad1.Text = ((int)(float.Parse(txtOnBoard1.Text) + float.Parse(txtReg1.Text) + float.Parse(txtSuper1.Text) + float.Parse(txtEthanol1.Text))).ToString();
            lblTotalLoad2.Text = ((int)(float.Parse(txtOnBoard2.Text) + float.Parse(txtReg2.Text) + float.Parse(txtSuper2.Text) + float.Parse(txtEthanol2.Text))).ToString();
            lblTotalLoad3.Text = ((int)(float.Parse(txtOnBoard3.Text) + float.Parse(txtReg3.Text) + float.Parse(txtSuper3.Text) + float.Parse(txtEthanol3.Text))).ToString();
            lblTotalLoad4.Text = ((int)(float.Parse(txtOnBoard4.Text) + float.Parse(txtReg4.Text) + float.Parse(txtSuper4.Text) + float.Parse(txtEthanol4.Text))).ToString();
            lblTotalLoad5.Text = ((int)(float.Parse(txtOnBoard5.Text) + float.Parse(txtReg5.Text) + float.Parse(txtSuper5.Text) + float.Parse(txtEthanol5.Text))).ToString();

            lblFinalTotal.Text = ((int)(float.Parse(lblTotalLoad1.Text) + float.Parse(lblTotalLoad2.Text) + float.Parse(lblTotalLoad3.Text)
               + float.Parse(lblTotalLoad4.Text) + float.Parse(lblTotalLoad5.Text))).ToString();

            if (int.Parse(lblTotalRight1.Text) < 0)
            {
                lblTotalRight1Info.Text = "To Regular Stock";
                lblTotalRight1Info.ForeColor = Color.Red;
                lblTotalRight1.ForeColor = Color.Red;
            }
            else
            {
                lblTotalRight1Info.Text = "From Regular Stock";
                lblTotalRight1Info.ForeColor = Color.Black;
                lblTotalRight1.ForeColor = Color.Black;
            }

            if (int.Parse(lblTotalRight2.Text) < 0)
            {
                lblTotalRight2Info.Text = "To Super Stock";
                lblTotalRight2Info.ForeColor = Color.Red;
                lblTotalRight2.ForeColor = Color.Red;
            }
            else
            {
                lblTotalRight2Info.Text = "From Super Stock";
                lblTotalRight2Info.ForeColor = Color.Black;
                lblTotalRight2.ForeColor = Color.Black;
            }


            if (int.Parse(lblTotalRight3.Text) < 0)
            {
                lblTotalRight3Info.Text = "To Ethanol Stock";
                lblTotalRight3Info.ForeColor = Color.Red;
                lblTotalRight3.ForeColor = Color.Red;
            }
            else
            {
                lblTotalRight3Info.Text = "From Ethanol Stock";
                lblTotalRight3Info.ForeColor = Color.Black;
                lblTotalRight3.ForeColor = Color.Black;
            }



        }

        public void FixValues()
        {

            txtPercentage.Text = CheckValue(txtPercentage.Text);

            txtOnBoard1.Text = CheckValue(txtOnBoard1.Text);
            txtOnBoard2.Text = CheckValue(txtOnBoard2.Text);
            txtOnBoard3.Text = CheckValue(txtOnBoard3.Text);
            txtOnBoard4.Text = CheckValue(txtOnBoard4.Text);
            txtOnBoard5.Text = CheckValue(txtOnBoard5.Text);

            txtSize1.Text = CheckValue(txtSize1.Text);
            txtSize2.Text = CheckValue(txtSize2.Text);
            txtSize3.Text = CheckValue(txtSize3.Text);
            txtSize4.Text = CheckValue(txtSize4.Text);
            txtSize5.Text = CheckValue(txtSize5.Text);

            txt90P1.Text = CheckValue(txt90P1.Text);
            txt90P2.Text = CheckValue(txt90P2.Text);
            txt90P3.Text = CheckValue(txt90P3.Text);
            txt90P4.Text = CheckValue(txt90P4.Text);
            txt90P5.Text = CheckValue(txt90P5.Text);

            txtReg1.Text = CheckValue(txtReg1.Text);
            txtReg2.Text = CheckValue(txtReg2.Text);
            txtReg3.Text = CheckValue(txtReg3.Text);
            txtReg4.Text = CheckValue(txtReg4.Text);
            txtReg5.Text = CheckValue(txtReg5.Text);

            txtSuper1.Text = CheckValue(txtSuper1.Text);
            txtSuper2.Text = CheckValue(txtSuper2.Text);
            txtSuper3.Text = CheckValue(txtSuper3.Text);
            txtSuper4.Text = CheckValue(txtSuper4.Text);
            txtSuper5.Text = CheckValue(txtSuper5.Text);

            txtEthanol1.Text = CheckValue(txtEthanol1.Text);
            txtEthanol2.Text = CheckValue(txtEthanol2.Text);
            txtEthanol3.Text = CheckValue(txtEthanol3.Text);
            txtEthanol4.Text = CheckValue(txtEthanol4.Text);
            txtEthanol5.Text = CheckValue(txtEthanol5.Text);

            lblFinalTotal.Text = CheckValue(lblFinalTotal.Text);

            lblTotalLoad1.Text = CheckValue(lblTotalLoad1.Text);
            lblTotalLoad2.Text = CheckValue(lblTotalLoad2.Text);
            lblTotalLoad3.Text = CheckValue(lblTotalLoad3.Text);
            lblTotalLoad4.Text = CheckValue(lblTotalLoad4.Text);
            lblTotalLoad5.Text = CheckValue(lblTotalLoad5.Text);

            lblTotalRight1.Text = CheckValue(lblTotalRight1.Text);
            lblTotalRight2.Text = CheckValue(lblTotalRight2.Text);
            lblTotalRight3.Text = CheckValue(lblTotalRight3.Text);
            lblMessage.Text = "";

        }

        protected void txtPercentage_TextChanged(object sender, EventArgs e)
        {
            CalculateSize(1);
            CalculateSize(2);
            CalculateSize(3);
            CalculateSize(4);
            CalculateSize(5);
        }

        protected void txtOnBoard1_TextChanged(object sender, EventArgs e)
        {
            CalculateSize(1);
        }

        protected void txtOnBoard2_TextChanged(object sender, EventArgs e)
        {
            CalculateSize(2);
        }

        protected void txtOnBoard3_TextChanged(object sender, EventArgs e)
        {
            CalculateSize(3);
        }

        protected void txtOnBoard4_TextChanged(object sender, EventArgs e)
        {
            CalculateSize(4);
        }

        protected void txtOnBoard5_TextChanged(object sender, EventArgs e)
        {
            CalculateSize(5);
        }

        protected void txtReg1_TextChanged(object sender, EventArgs e)
        {
            if (ddlGasType1.SelectedValue == "1")
            {
                txtEthanol1.Text =
                    ((int)(((float.Parse(txtOnBoard1.Text) + float.Parse(txtReg1.Text)) / 100) * 0.5)).ToString();
            }
            CalculateTotals();
        }

        protected void txtReg2_TextChanged(object sender, EventArgs e)
        {
            if (ddlGasType2.SelectedValue == "1")
            {
                txtEthanol2.Text =
                    ((int)(((float.Parse(txtOnBoard2.Text) + float.Parse(txtReg2.Text)) / 100) * 0.5)).ToString();
            }
            CalculateTotals();
        }

        protected void txtReg3_TextChanged(object sender, EventArgs e)
        {
            if (ddlGasType3.SelectedValue == "1")
            {
                txtEthanol3.Text =
                    ((int)(((float.Parse(txtOnBoard3.Text) + float.Parse(txtReg3.Text)) / 100) * 0.5)).ToString();
            }
            CalculateTotals();
        }

        protected void txtReg4_TextChanged(object sender, EventArgs e)
        {
            if (ddlGasType4.SelectedValue == "1")
            {
                txtEthanol4.Text =
                    ((int)(((float.Parse(txtOnBoard4.Text) + float.Parse(txtReg4.Text)) / 100) * 0.5)).ToString();
            }
            CalculateTotals();
        }

        protected void txtReg5_TextChanged(object sender, EventArgs e)
        {
            if (ddlGasType5.SelectedValue == "1")
            {
                txtEthanol5.Text =
                    ((int)(((float.Parse(txtOnBoard5.Text) + float.Parse(txtReg5.Text)) / 100) * 0.5)).ToString();
            }
            CalculateTotals();
        }

        protected void txtSuper1_TextChanged(object sender, EventArgs e)
        {
            if (ddlGasType1.SelectedValue == "4")
            {
                txtEthanol1.Text =
                    ((int)(((float.Parse(txtOnBoard1.Text) + float.Parse(txtSuper1.Text)) / 100) * 0.5)).ToString();
            }
            CalculateTotals();
        }

        protected void txtSuper2_TextChanged(object sender, EventArgs e)
        {
            if (ddlGasType2.SelectedValue == "4")
            {
                txtEthanol2.Text =
                    ((int)(((float.Parse(txtOnBoard2.Text) + float.Parse(txtSuper2.Text)) / 100) * 0.5)).ToString();
            }
            CalculateTotals();
        }

        protected void txtSuper3_TextChanged(object sender, EventArgs e)
        {
            if (ddlGasType3.SelectedValue == "4")
            {
                txtEthanol3.Text =
                    ((int)(((float.Parse(txtOnBoard3.Text) + float.Parse(txtSuper3.Text)) / 100) * 0.5)).ToString();
            }
            CalculateTotals();
        }

        protected void txtSuper4_TextChanged(object sender, EventArgs e)
        {
            if (ddlGasType4.SelectedValue == "4")
            {
                txtEthanol4.Text =
                    ((int)(((float.Parse(txtOnBoard4.Text) + float.Parse(txtSuper4.Text)) / 100) * 0.5)).ToString();
            }

            CalculateTotals();
        }

        protected void txtSuper5_TextChanged(object sender, EventArgs e)
        {
            if (ddlGasType5.SelectedValue == "4")
            {
                txtEthanol5.Text =
                    ((int)(((float.Parse(txtOnBoard5.Text) + float.Parse(txtSuper5.Text)) / 100) * 0.5)).ToString();
            }

            CalculateTotals();
        }

        protected void txtEthanol1_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        protected void txtEthanol2_TextChanged(object sender, EventArgs e)
        {

            CalculateTotals();
        }

        protected void txtEthanol3_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        protected void txtEthanol4_TextChanged(object sender, EventArgs e)
        {

            CalculateTotals();
        }

        protected void txtEthanol5_TextChanged(object sender, EventArgs e)
        {

            CalculateTotals();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            if (txtRefNo.Text != "")
            {
                string strLoadID = "";
                DataTable dt = _businessAccess.ReceiveTruckLoad(ddlCarrier.SelectedValue, txtRefNo.Text,
                    ddlLoadType.SelectedItem.Text, ddlTrailerNumber.SelectedValue,
                    ddlGasType1.SelectedItem.Text, txtOnBoard1.Text, ddlGasType2.SelectedItem.Text, txtOnBoard2.Text,
                    ddlGasType3.SelectedItem.Text, txtOnBoard3.Text,
                    ddlGasType4.SelectedItem.Text, txtOnBoard4.Text, ddlGasType5.SelectedItem.Text, txtOnBoard5.Text,
                    lblTotalRight1.Text, lblTotalRight2.Text, lblTotalRight3.Text,
                    ddlDeliver1.SelectedValue, ddlDeliver2.SelectedValue, ddlDeliver3.SelectedValue,
                    ddlDeliver4.SelectedValue, ddlDeliver5.SelectedValue,
                    ddlDriver.SelectedItem.Text, ddlTractor.SelectedItem.Text, "", Convert.ToDateTime(txtStartDate.Text + " " + ddlHourStart.SelectedValue + ":" + ddlMinuteStart.SelectedValue + ":" + ddlSecondStart.SelectedValue + " " + ddlAMStart.SelectedValue).ToString("yyyy-MM-dd hh:mm:ss"));
                if (dt != null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        strLoadID = dt.Rows[0][0].ToString();
                        if (lblTotalLoad1.Text != "0")
                        {
                            _businessAccess.InsertLineData(strLoadID, ddlGasType1.SelectedItem.Text, txtOnBoard1.Text,
                                ddlDeliver1.SelectedValue,
                                txtReg1.Text, txtSuper1.Text, txtEthanol1.Text, "1", "f", "");
                        }
                        if (lblTotalLoad2.Text != "0")
                        {
                            _businessAccess.InsertLineData(strLoadID, ddlGasType2.SelectedItem.Text, txtOnBoard2.Text,
                                ddlDeliver2.SelectedValue,
                                txtReg2.Text, txtSuper2.Text, txtEthanol2.Text, "2", "f", "");
                        }
                        if (lblTotalLoad3.Text != "0")
                        {
                            _businessAccess.InsertLineData(strLoadID, ddlGasType3.SelectedItem.Text, txtOnBoard3.Text,
                                ddlDeliver3.SelectedValue,
                                txtReg3.Text, txtSuper3.Text, txtEthanol3.Text, "3", "f", "");
                        }
                        if (lblTotalLoad4.Text != "0")
                        {
                            _businessAccess.InsertLineData(strLoadID, ddlGasType4.SelectedItem.Text, txtOnBoard4.Text,
                                ddlDeliver4.SelectedValue,
                                txtReg4.Text, txtSuper4.Text, txtEthanol4.Text, "4", "f", "");
                        }
                        if (lblTotalLoad5.Text != "0")
                        {
                            _businessAccess.InsertLineData(strLoadID, ddlGasType5.SelectedItem.Text, txtOnBoard5.Text,
                                ddlDeliver5.SelectedValue,
                                txtReg5.Text, txtSuper5.Text, txtEthanol5.Text, "5", "f", "");
                            _businessAccess.UpdateSetupTable(lblTotalRight1.Text, lblTotalRight2.Text,
                                lblTotalRight3.Text);
                        }

                        lnkLink.Visible = true;
                        lnkLink.PostBackUrl = "BOLReport.aspx?ID=" + strLoadID;
                        btnSave.Enabled = false;
                        _businessAccess.InsertLog(Session["ID"].ToString(),
                  System.Reflection.MethodBase.GetCurrentMethod().Name, this.Page.ToString(), DateTime.Now);
                        lblMessage.Text = "Save Successful";
                        int intId = 100;

                        string strPopup = "<script language='javascript' ID='script1'>"

                        // Passing intId to popup window.
                        + "window.open('BOLReport.aspx?ID=" + strLoadID

                        + "','Report')"

                        + "</script>";

                        ScriptManager.RegisterStartupScript((Page)HttpContext.Current.Handler, typeof(Page), "Script1", strPopup, false);


                        //  Response.Redirect("Default.aspx");



                    }
                }
            }
            else
            {
                lblMessage.Text = "* Check Reference Number";
            }
        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

            Response.Redirect("ReceiveTruck.aspx");
        }

        protected void ddlDeliver1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList ddl = new DropDownList();
            ddl = (DropDownList)sender;
            ChangeValues(ddl.SelectedIndex);
        }

        public void ChangeValues(int SelectedIndex)
        {
            ddlDeliver1.SelectedIndex = SelectedIndex;
            ddlDeliver2.SelectedIndex = SelectedIndex;
            ddlDeliver3.SelectedIndex = SelectedIndex;
            ddlDeliver4.SelectedIndex = SelectedIndex;
            ddlDeliver5.SelectedIndex = SelectedIndex;
        }

        protected void ddlLoadType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlLoadType.SelectedValue == "4")
            {
                txtOnBoard1.Enabled = false;
                txtOnBoard2.Enabled = false;
                txtOnBoard3.Enabled = false;
                txtOnBoard4.Enabled = false;
                txtOnBoard5.Enabled = false;
            }
            else
            {
                txtOnBoard1.Enabled = true;
                txtOnBoard2.Enabled = true;
                txtOnBoard3.Enabled = true;
                txtOnBoard4.Enabled = true;
                txtOnBoard5.Enabled = true;
            }

                ReloadFix();
            
        }


        public void ReloadFix()
        {
 
                    txtReg1.Enabled = true;
                    txtReg2.Enabled = true;
                    txtReg3.Enabled = true;
                    txtReg4.Enabled = true;  
                    txtReg5.Enabled = true;
                    txtSuper1.Enabled = true;
                    txtSuper2.Enabled = true;
                    txtSuper3.Enabled = true;
                    txtSuper4.Enabled = true;
                    txtSuper5.Enabled = true;
                    

                    LoadType();
            OnlyBlockEmptyContainers();

            }

        private void LoadType()
        {
            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType1.SelectedValue == "1")
            {
                txtReg1.Enabled = true;
                txtSuper1.Enabled = false;
            }
            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType1.SelectedValue == "2")
            {
                txtReg1.Enabled = false;
                txtSuper1.Enabled = true;
            }
            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType1.SelectedValue == "4")
            {
                txtReg1.Enabled = false;
                txtSuper1.Enabled = true;
            }
            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType1.SelectedValue == "5")
            {
                txtReg1.Enabled = true;
                txtSuper1.Enabled = false;
            }

            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType2.SelectedValue == "1")
            {
                txtReg2.Enabled = true;
                txtSuper2.Enabled = false;
            }
            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType2.SelectedValue == "2")
            {
                txtReg2.Enabled = false;
                txtSuper2.Enabled = true;
            }
            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType2.SelectedValue == "4")
            {
                txtReg2.Enabled = false;
                txtSuper2.Enabled = true;
            }
            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType2.SelectedValue == "5")
            {
                txtReg2.Enabled = true;
                txtSuper2.Enabled = false;
            }

            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType3.SelectedValue == "1")
            {
                txtReg3.Enabled = true;
                txtSuper3.Enabled = false;
            }
            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType3.SelectedValue == "2")
            {
                txtReg3.Enabled = false;
                txtSuper3.Enabled = true;
            }
            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType3.SelectedValue == "4")
            {
                txtReg3.Enabled = false;
                txtSuper3.Enabled = true;
            }
            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType3.SelectedValue == "5")
            {
                txtReg3.Enabled = true;
                txtSuper3.Enabled = false;
            }

            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType4.SelectedValue == "1")
            {
                txtReg4.Enabled = true;
                txtSuper4.Enabled = false;
            }
            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType4.SelectedValue == "2")
            {
                txtReg4.Enabled = false;
                txtSuper4.Enabled = true;
            }
            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType4.SelectedValue == "4")
            {
                txtReg4.Enabled = false;
                txtSuper4.Enabled = true;
            }
            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType4.SelectedValue == "5")
            {
                txtReg4.Enabled = true;
                txtSuper4.Enabled = false;
            }

            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType5.SelectedValue == "1")
            {
                txtReg5.Enabled = true;
                txtSuper5.Enabled = false;
            }
            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType5.SelectedValue == "2")
            {
                txtReg5.Enabled = false;
                txtSuper5.Enabled = true;
            }
            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType5.SelectedValue == "4")
            {
                txtReg5.Enabled = false;
                txtSuper5.Enabled = true;
            }
            if ((ddlLoadType.SelectedValue == "4" || ddlLoadType.SelectedValue == "1") && ddlGasType5.SelectedValue == "5")
            {
                txtReg5.Enabled = true;
                txtSuper5.Enabled = false;
            }
        }
    }

    }
