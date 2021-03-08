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
    public partial class Search : System.Web.UI.Page
    {
        static string strConn = "Data Source=lnjd-zpx; Initial Catalog = CheCi ; User ID=sa;pwd=ln";
        SqlConnection myConn = new SqlConnection(strConn);
        SqlCommand myComm;
        SqlDataAdapter myDataAdapter;
        private void FillData()
        {
            string strSql = "select* from Bus where";
            if (chkBeginStation.Checked&&txtBeginStation.Text.Trim( ) !=string.Empty)
            {
                strSql = strSql + "BeginStation" + txtBeginStation.Text.Trim()+" or ";
            }
            if (clikEndStation.Checked&&txtEndStation.Text.Trim() != string.Empty)
            {
                strSql = strSql + "EndStation=" +txtEndStation.Text.Trim() + " or ";
            }
            strSql = strSql.Substring(0 , strSql.Length-5);
            myDataAdapter = new SqlDataAdapter(strSql , myConn);
            DataSet myDataSet = new DataSet();
            myConn.Open() ;
            myDataAdapter.Fill(myDataSet, "Bus");
            GridView1.DataSource = myDataSet.Tables["Bus"];
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            FillData();
        }
    }
}