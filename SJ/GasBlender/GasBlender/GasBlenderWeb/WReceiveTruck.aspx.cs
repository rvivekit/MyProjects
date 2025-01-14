﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GBBusiness;
using System.Net;

namespace GasBlenderWeb
{
    public partial class WReceiveTruck : System.Web.UI.Page
    {
        private GBBusiness.BusinessAccess _businessAccess = new BusinessAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        public void BindData()
        {
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
        }


        protected void ddlTrailerNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                    CalculateSize();
                }
            }


        }

        public void CalculateSize()
        {
            FixValues();
            txt90P1.Text = ((int)((float.Parse(CheckValue(txtSize1.Text)) / 100) * float.Parse(CheckValue(txtPercentage.Text)))).ToString();
            txt90P2.Text = ((int)((float.Parse(CheckValue(txtSize2.Text)) / 100) * float.Parse(CheckValue(txtPercentage.Text)))).ToString();
            txt90P3.Text = ((int)((float.Parse(CheckValue(txtSize3.Text)) / 100) * float.Parse(CheckValue(txtPercentage.Text)))).ToString();
            txt90P4.Text = ((int)((float.Parse(CheckValue(txtSize4.Text)) / 100) * float.Parse(CheckValue(txtPercentage.Text)))).ToString();
            txt90P5.Text = ((int)((float.Parse(CheckValue(txtSize5.Text)) / 100) * float.Parse(CheckValue(txtPercentage.Text)))).ToString();
            GasType();
            CalculateTotals();
        }

        protected void txtSize1_TextChanged(object sender, EventArgs e)
        {
            CalculateSize();
        }

        protected void txtSize2_TextChanged(object sender, EventArgs e)
        {
            CalculateSize();
        }

        protected void txtSize3_TextChanged(object sender, EventArgs e)
        {
            CalculateSize();
        }

        protected void txtSize4_TextChanged(object sender, EventArgs e)
        {
            CalculateSize();
        }

        protected void txtSize5_TextChanged(object sender, EventArgs e)
        {
            CalculateSize();
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
            CalculateSize();
        }

        protected void ddlGasType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateSize();
        }

        protected void ddlGasType3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateSize();
        }

        protected void ddlGasType4_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateSize();
        }

        protected void ddlGasType5_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateSize();
        }

        public void GasType()
        {
            FixValues();
            if (ddlGasType1.SelectedValue == "1")
            {
                txtReg1.Text = (float.Parse(txt90P1.Text) - float.Parse(txtOnBoard1.Text)).ToString();
                txtEthanol1.Text = (float.Parse(txtSize1.Text) - float.Parse(txt90P1.Text)).ToString();
                txtSuper1.Text = "0";
                lblTotalLoad1.Text = ((int)float.Parse(txtSize1.Text)).ToString();

            }

            if (ddlGasType2.SelectedValue == "1")
            {
                txtReg2.Text = (float.Parse(txt90P2.Text) - float.Parse(txtOnBoard2.Text)).ToString();
                txtEthanol2.Text = ((int)(float.Parse(txtSize2.Text) - float.Parse(txt90P2.Text))).ToString();
                txtSuper2.Text = "0";
                lblTotalLoad2.Text = ((int)float.Parse(txtSize2.Text)).ToString();
            }
            if (ddlGasType3.SelectedValue == "1")
            {
                txtReg3.Text = (float.Parse(txt90P3.Text) - float.Parse(txtOnBoard3.Text)).ToString();
                txtEthanol3.Text  = ((int)(float.Parse(txtSize3.Text) - float.Parse(txt90P3.Text))).ToString();
                txtSuper3.Text = "0";
                lblTotalLoad3.Text = ((int)float.Parse(txtSize3.Text)).ToString();
            }
            if (ddlGasType4.SelectedValue == "1")
            {
                txtReg4.Text = (float.Parse(txt90P4.Text) - float.Parse(txtOnBoard4.Text)).ToString();
                txtEthanol4.Text = ((int)(float.Parse(txtSize4.Text) - float.Parse(txt90P4.Text))).ToString();
                txtSuper4.Text = "0";
                lblTotalLoad4.Text = ((int)float.Parse(txtSize4.Text)).ToString();
            }
            if (ddlGasType5.SelectedValue == "1")
            {
                txtReg5.Text = (float.Parse(txt90P5.Text) - float.Parse(txtOnBoard5.Text)).ToString();
                txtEthanol5.Text = ((int)(float.Parse(txtSize5.Text) - float.Parse(txt90P5.Text))).ToString();
                txtSuper5.Text = "0";
                lblTotalLoad5.Text = ((int)float.Parse(txtSize5.Text)).ToString();
            }

            ////////////////////////////////////////////////////////////////////////////////////////////

            if (ddlGasType1.SelectedValue == "2")
            {
                txtReg1.Text = (float.Parse(txt90P1.Text)/2).ToString();
                txtSuper1.Text = ((int)(float.Parse(txtReg1.Text) - float.Parse(txtOnBoard1.Text))).ToString();
                txtEthanol1.Text = ((int)(float.Parse(txtSize1.Text) - float.Parse(txt90P1.Text))).ToString();
                lblTotalLoad1.Text = ((int)float.Parse(txtSize5.Text)).ToString();
            }

            if (ddlGasType2.SelectedValue == "2")
            {
                txtReg2.Text = (float.Parse(txt90P2.Text) / 2).ToString();
                txtSuper2.Text = ((int)(float.Parse(txtReg2.Text) - float.Parse(txtOnBoard2.Text))).ToString();
                txtEthanol2.Text = ((int)(float.Parse(txtSize2.Text) - float.Parse(txt90P2.Text))).ToString();
                lblTotalLoad2.Text = ((int)float.Parse(txtSize2.Text)).ToString();
            }
            if (ddlGasType3.SelectedValue == "2")
            {
                txtReg3.Text = (float.Parse(txt90P3.Text) / 2).ToString();
                txtSuper3.Text = ((int)(float.Parse(txtReg3.Text) - float.Parse(txtOnBoard3.Text))).ToString();
                txtEthanol3.Text = ((int)(float.Parse(txtSize3.Text) - float.Parse(txt90P3.Text))).ToString();
                lblTotalLoad3.Text = ((int)float.Parse(txtSize3.Text)).ToString();
            }
            if (ddlGasType4.SelectedValue == "2")
            {
                txtReg4.Text = (float.Parse(txt90P4.Text) / 2).ToString();
                txtSuper4.Text = ((int)(float.Parse(txtReg4.Text) - float.Parse(txtOnBoard4.Text))).ToString();
                txtEthanol4.Text = ((int)(float.Parse(txtSize4.Text) - float.Parse(txt90P4.Text))).ToString();
                lblTotalLoad4.Text = ((int)float.Parse(txtSize4.Text)).ToString();
            }
            if (ddlGasType5.SelectedValue == "2")
            {
                txtReg5.Text = (float.Parse(txt90P5.Text) / 2).ToString();
                txtSuper5.Text = ((int)(float.Parse(txtReg5.Text) - float.Parse(txtOnBoard5.Text))).ToString();
                txtEthanol5.Text = ((int)(float.Parse(txtSize5.Text) - float.Parse(txt90P5.Text))).ToString();
                lblTotalLoad5.Text = ((int)float.Parse(txtSize5.Text)).ToString();
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            if (ddlGasType1.SelectedValue == "3")
            {
                txtReg1.Text = "0";
                txtSuper1.Text = "0";
                txtEthanol1.Text = ((int)(float.Parse(txtOnBoard1.Text)*-1)).ToString();
                lblTotalLoad1.Text = "0";
            }

            if (ddlGasType2.SelectedValue == "3")
            {
                txtReg2.Text = "0";
                txtSuper2.Text = "0";
                txtEthanol2.Text = ((int)(float.Parse(txtOnBoard2.Text) * -1)).ToString();
                lblTotalLoad1.Text = "0";
            }
            if (ddlGasType3.SelectedValue == "3")
            {
                txtReg3.Text = "0";
                txtSuper3.Text = "0";
                txtEthanol3.Text = ((int)(float.Parse(txtOnBoard3.Text) * -1)).ToString();
                lblTotalLoad1.Text = "0";
            }
            if (ddlGasType4.SelectedValue == "3")
            {
                txtReg4.Text = "0";
                txtSuper4.Text = "0";
                txtEthanol4.Text = ((int)(float.Parse(txtOnBoard4.Text) * -1)).ToString();
                lblTotalLoad1.Text = "0";
            }
            if (ddlGasType5.SelectedValue == "3")
            {
                txtReg5.Text = "0";
                txtSuper5.Text = "0";
                txtEthanol5.Text = ((int)(float.Parse(txtOnBoard5.Text) * -1)).ToString();
                lblTotalLoad1.Text = "0";
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////
            if (ddlGasType1.SelectedValue == "4")
            {
                txtReg1.Text = "0";
                txtSuper1.Text = "0";
                txtEthanol1.Text = ((int)(float.Parse(txtOnBoard1.Text)/10)).ToString();
                lblTotalLoad1.Text = ((int) (float.Parse(txtOnBoard1.Text) + float.Parse(txtEthanol1.Text))).ToString();

            }

            if (ddlGasType2.SelectedValue == "4")
            {
                txtReg2.Text = "0";
                txtSuper2.Text = "0";
                txtEthanol2.Text = ((int)(float.Parse(txtOnBoard2.Text)/10)).ToString();
                lblTotalLoad2.Text = ((int)(float.Parse(txtOnBoard2.Text) + float.Parse(txtEthanol2.Text))).ToString();
            }
            if (ddlGasType3.SelectedValue == "4")
            {
                txtReg3.Text = "0";
                txtSuper3.Text = "0";
                txtEthanol3.Text = ((int)(float.Parse(txtOnBoard3.Text)/10)).ToString();
                lblTotalLoad3.Text = ((int)(float.Parse(txtOnBoard3.Text) + float.Parse(txtEthanol3.Text))).ToString();
            }
            if (ddlGasType4.SelectedValue == "4")
            {
                txtReg4.Text = "0";
                txtSuper4.Text = "0";
                txtEthanol4.Text = ((int)(float.Parse(txtOnBoard4.Text)/10)).ToString();
                lblTotalLoad4.Text = ((int)(float.Parse(txtOnBoard4.Text) + float.Parse(txtEthanol4.Text))).ToString();
            }
            if (ddlGasType5.SelectedValue == "4")
            {
                txtReg5.Text = "0";
                txtSuper5.Text = "0";
                txtEthanol5.Text = ((int)(float.Parse(txtOnBoard5.Text)/10)).ToString();
                lblTotalLoad5.Text = ((int)(float.Parse(txtOnBoard5.Text) + float.Parse(txtEthanol5.Text))).ToString();
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////////////
 
            if (ddlGasType1.SelectedValue == "5")
            {
                txtReg1.Text = ((int)((float.Parse(txt90P1.Text) / 2) - float.Parse(txtOnBoard1.Text))).ToString();
                txtSuper1.Text = ((int) ((float.Parse(txt90P1.Text)/2))).ToString();
                txtEthanol1.Text = ((int)(float.Parse(txtSize1.Text) / 10)).ToString();
                lblTotalLoad1.Text = ((int)float.Parse(txtSize1.Text)).ToString();
            }

            if (ddlGasType2.SelectedValue == "5")
            {
                txtReg2.Text = "0";
                txtSuper2.Text = "0";
                txtEthanol2.Text = ((int)(float.Parse(txtOnBoard2.Text) / 10)).ToString();
                lblTotalLoad2.Text = ((int)float.Parse(txtSize2.Text)).ToString();
            }
            if (ddlGasType3.SelectedValue == "5")
            {
                txtReg3.Text = "0";
                txtSuper3.Text = "0";
                txtEthanol3.Text = ((int)(float.Parse(txtOnBoard3.Text) / 10)).ToString();
                lblTotalLoad3.Text = ((int)float.Parse(txtSize3.Text)).ToString();
            }
            if (ddlGasType4.SelectedValue == "5")
            {
                txtReg4.Text = "0";
                txtSuper4.Text = "0";
                txtEthanol4.Text = ((int)(float.Parse(txtOnBoard4.Text) / 10)).ToString();
                lblTotalLoad4.Text = ((int)float.Parse(txtSize4.Text)).ToString();
            }
            if (ddlGasType5.SelectedValue == "5")
            {
                txtReg5.Text = "0";
                txtSuper5.Text = "0";
                txtEthanol5.Text = ((int)(float.Parse(txtOnBoard5.Text) / 10)).ToString();
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
            lblFinalTotal.Text = ((int)(float.Parse(lblTotalRight1.Text) + float.Parse(lblTotalRight2.Text) + float.Parse(lblTotalRight3.Text))).ToString();
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

        }

        protected void txtPercentage_TextChanged(object sender, EventArgs e)
        {
            CalculateSize();
        }

        protected void txtOnBoard1_TextChanged(object sender, EventArgs e)
        {
            CalculateSize();
        }

        protected void txtOnBoard2_TextChanged(object sender, EventArgs e)
        {
            CalculateSize();
        }

        protected void txtOnBoard3_TextChanged(object sender, EventArgs e)
        {
            CalculateSize();
        }

        protected void txtOnBoard4_TextChanged(object sender, EventArgs e)
        {
            CalculateSize();
        }

        protected void txtOnBoard5_TextChanged(object sender, EventArgs e)
        {
            CalculateSize();
        }

        protected void txtReg1_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        protected void txtReg2_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        protected void txtReg3_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        protected void txtReg4_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        protected void txtReg5_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        protected void txtSuper1_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        protected void txtSuper2_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        protected void txtSuper3_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        protected void txtSuper4_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        protected void txtSuper5_TextChanged(object sender, EventArgs e)
        {
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

    }

}