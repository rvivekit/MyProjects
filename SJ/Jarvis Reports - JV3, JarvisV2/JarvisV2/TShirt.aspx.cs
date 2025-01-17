﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    public static string _RFIDSystem = ConfigurationManager.ConnectionStrings["RFIDString"].ConnectionString;
    public static DataTable dtNew;
    protected void Page_Load(object sender, EventArgs e)
    {
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
            SqlCommand cmd = new SqlCommand("SELECT  Description , Barcode, '~/TShirtImage/'+Family+'.jpg' as Family,cnt,SalesCount,SalesCount1 FROM dbo.TShirtCatagory LEFT OUTER JOIN (SELECT UPC, COUNT(*) AS cnt FROM TrackerRetail.dbo.ProductItems WHERE RFID IS NOT NULL AND Status <> 'Hold' GROUP BY UPC) b ON b.UPC = dbo.TShirtCatagory.Barcode  LEFT OUTER JOIN (SELECT UPC, COUNT(*) AS SalesCount FROM TrackerRetail.dbo.KT_Decommissioned_Details WHERE  DateModified BETWEEN GETDATE() - 10 AND GETDATE() GROUP BY UPC) c ON c.upc = b.UPC   LEFT OUTER JOIN (SELECT UPC, COUNT(*) AS SalesCount1 FROM TrackerRetail.dbo.KT_Decommissioned_Details WHERE  DateModified BETWEEN GETDATE() - 20 AND GETDATE()-11 GROUP BY UPC) d ON d.upc = b.UPC   ORDER BY SNO", connection);
            //cmd.CommandType = CommandType.StoredProcedure;
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
}