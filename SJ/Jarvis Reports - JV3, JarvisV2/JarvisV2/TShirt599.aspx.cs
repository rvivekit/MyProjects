﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using Image = System.Web.UI.WebControls.Image;

public partial class _Default : System.Web.UI.Page
{
    public static string _RFIDSystem = ConfigurationManager.ConnectionStrings["RFIDString"].ConnectionString;
    public static DataTable dtNew;
    public static int _TShirt599RedMin = int.Parse(ConfigurationManager.AppSettings["TShirt599RedMin"].ToString());
    public static int _TShirt599RedMax = int.Parse(ConfigurationManager.AppSettings["TShirt599RedMax"].ToString());
    public static int _TShirt599OrgMin = int.Parse(ConfigurationManager.AppSettings["TShirt599OrgMin"].ToString());
    public static int _TShirt599OrgMax = int.Parse(ConfigurationManager.AppSettings["TShirt599OrgMax"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        lblDate.Text = DateTime.Now.ToString("F");
        DataTable allData = GetTShirtDetails();
        GridView1.DataSource = allData;
        GridView1.DataBind();
    }


    public DataTable GetTShirtDetails()
    {
        DataTable allData = new DataTable();
        SqlConnection connection = new SqlConnection(_RFIDSystem);
        try
        {
            SqlCommand cmd = new SqlCommand("SELECT  Description , [Stock code],Barcode, '~/TShirtImage/'+Family+'.jpg' as Family,cnt,ISNULL(SalesCount,0) as SalesCount,SalesCount1 FROM dbo.TShirtCatagory LEFT OUTER JOIN (SELECT UPC, COUNT(*) AS cnt FROM TrackerRetail.dbo.ProductItems WHERE RFID IS NOT NULL AND Status <> 'Hold' GROUP BY UPC) b ON b.UPC = dbo.TShirtCatagory.Barcode  LEFT OUTER JOIN (SELECT UPC, COUNT(*) AS SalesCount FROM TrackerRetail.dbo.KT_Decommissioned_Details WHERE  DateModified BETWEEN GETDATE() - 10 AND GETDATE() GROUP BY UPC) c ON c.upc = b.UPC   LEFT OUTER JOIN (SELECT UPC, COUNT(*) AS SalesCount1 FROM TrackerRetail.dbo.KT_Decommissioned_Details WHERE  DateModified BETWEEN GETDATE() - 20 AND GETDATE()-11 GROUP BY UPC) d ON d.upc = b.UPC  WHERE TShirtCatagory.maincatagory IS NOT NULL  ORDER BY maincatagory,[SortOrder],sno", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "TShirt_599";
            //cmd.Parameters.Add(new SqlParameter("@numberofdays", NoOfDays));
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(allData);
            connection.Close();
        }
        catch (Exception ex)
        {
            connection.Close();
        }
        return allData;
    }
    protected void GridView1_DataBound(object sender, EventArgs e)
    {
        for (int i = GridView1.Rows.Count - 1; i > 0; i--)
        {
            GridViewRow row = GridView1.Rows[i];
            GridViewRow previousRow = GridView1.Rows[i - 1];

            if (i == 1)
            {
                if (int.Parse(previousRow.Cells[4].Text) < _TShirt599RedMax)
                {
                    previousRow.Cells[4].BackColor = Color.Red;
                }
                if (int.Parse(previousRow.Cells[4].Text) > _TShirt599OrgMin && int.Parse(previousRow.Cells[4].Text) < _TShirt599OrgMax)
                {
                    previousRow.Cells[4].BackColor = Color.Orange;
                }
            }
            for (int j = 0; j < 1; j++)
            {

                if (int.Parse(row.Cells[4].Text) < _TShirt599RedMax)
                {
                    row.Cells[4].BackColor = Color.Red;
                }
                if (int.Parse(row.Cells[4].Text) > _TShirt599OrgMin && int.Parse(row.Cells[4].Text) < _TShirt599OrgMax)
                {
                    row.Cells[4].BackColor = Color.Orange;
                }


                if ( ((Image) row.Cells[j].Controls[0]).ImageUrl == ((Image)previousRow.Cells[j].Controls[0]).ImageUrl)
                {
                    if (previousRow.Cells[j].RowSpan == 0)
                    {
                        if (row.Cells[j].RowSpan == 0)
                        {
                            previousRow.Cells[j].RowSpan += 2;
                        }
                        else
                        {
                            previousRow.Cells[j].RowSpan = row.Cells[j].RowSpan + 1;
                        }
                        row.Cells[j].Visible = false;
                    }
                }
            }
        }
    }
}