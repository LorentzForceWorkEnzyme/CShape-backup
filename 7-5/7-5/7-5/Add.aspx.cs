using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System. Data.SqlClient;
namespace _7_5
{
    public partial class Add : System.Web.UI.Page
    {
        static string strConn = "Data Source=lnjd一 zpx; Initial Catalog = CheCi ; User ID=sa;pwd=ln;
        SqlConnection myConn = new SqlConnection(strConn);
        SqlCommand myComm;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillData();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strSql = "insert into Bus(BusID，BeginStation，EndStation，ServiceTime，Description)"
                +"values(@BusID，@BeginStation，@EndStation，@ServiceTime,@Description)";
            myComm = new SqlCommand(strSql,myConn);
            myComm.Parameters.Add("@BusIDn" ,SqlDbType. VarChar, 10);
            myComm.Parameters.Add("@BeginStation", SqlDbType.VarChar, 20);
            myComm.Parameters.Add(" @EndStation" ,SqlDbType. VarChar, 20);
            myComm.Parameters.Add("@ServiceTime" ,SqlDbType. VarChar, 20);
            myComm.Parameters.Add("@Description" , SqlDbType.VarChar, 50); 
            myComm.Parameters["@BusID"].Value = txtBusID.Text.Trim();
            myComm.Parameters["@BeginStation"].Value = txtBeginStation.Text.Trim();
            myComm.Parameters["@EndStation"].Value = txtEndStation.Text.Trim();
            myComm.Parameters["@ServiceTime"].Value = txtServiceTime.Text.Trim();
            myComm.Parameters["@Description"].Value =txtDescription. Text. Trim();
            myConn.Open();
            myComm.ExecuteNonQuery();
            myConn.Close();
            Response.Redirect("default.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}