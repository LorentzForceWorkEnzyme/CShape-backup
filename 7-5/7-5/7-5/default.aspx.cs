using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
namespace _7_5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static string strConn = "Data Source= Injd—zpx;Initial Catalog = CheCi; User ID= sa;pwd= 1";
        SqlConnection myConn = new SqlConnection(strConn);
        SqlDataAdapter myDataAdapter; private void FillData()
        {
            string strSql = " select* from Bus";
            myDataAdapter = new SqlDataAdapter(strSql , myConn);
            DataSet myDataSet = new DataSet();
            myConn.Open();
            myDataAdapter.Fill(myDataSet,"Bus"); GridView1.DataSource = myDataSet.Tables["Busn"];
            GridView1.DataBind();
            myConn.Close();
        }
    protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillData();
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            FillData();
        }
    }

}