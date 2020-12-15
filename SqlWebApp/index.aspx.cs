using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SqlWebApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            //Connecting to db
            string connString = "Server=tcp:sep6-server.database.windows.net,1433;Initial Catalog=AirData;Persist Security Info=False;User ID={};Password={};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            //Creating a command
            SqlCommand cmd = new SqlCommand("SELECT * FROM [dbo].[airlines]");
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;

            //Read from db
            string temp = "";

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())   //while reader still has data
            {
                temp += reader["carrier"].ToString();
                temp += "&nbsp";
                temp += reader["name"].ToString();
                temp += "<br/>";
            }

            conn.Close();

            //displaying data
            lbl_test.Text = temp;
            */

        }
    }
}