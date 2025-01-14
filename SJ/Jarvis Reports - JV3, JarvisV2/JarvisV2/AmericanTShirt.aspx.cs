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

public partial class _AmericanTShirt : System.Web.UI.Page
{
    public static string _RFIDSystem = ConfigurationManager.ConnectionStrings["RFIDString"].ConnectionString;
    public static DataTable dtNew;
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
            SqlCommand cmd = new SqlCommand("", connection);
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AMTSH";
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
                if (int.Parse(previousRow.Cells[4].Text) < 15)
                {
          //          previousRow.Cells[4].BackColor = Color.Red;
                }
                if (int.Parse(previousRow.Cells[4].Text) > 15 && int.Parse(previousRow.Cells[4].Text) < 30)
                {
          //          previousRow.Cells[4].BackColor = Color.Orange;
                }
            }
            for (int j = 0; j < 1; j++)
            {

                    if (int.Parse(row.Cells[4].Text) < 10)
                    {
           //             row.Cells[4].BackColor = Color.Red;
                    }
                    if (int.Parse(row.Cells[4].Text) > 10 && int.Parse(row.Cells[4].Text) < 30)
                    {
         //               row.Cells[4].BackColor = Color.Orange;
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