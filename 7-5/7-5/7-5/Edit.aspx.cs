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
    public partial class Edit : System.Web.UI.Page
    {
        static string strConn = "Data Source=lnjd-zpx; Initial Catalog = CheCi ; User ID=sa;pwd=ln";
        SqlConnection myConn = new SqlConnection(strConn);
        SqlCommand myComm;
        SqlDataAdapter myDataAdapter;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillData();
            }
        }
        private void FillData()
        {
            string strSql = "select *from Bus";
            myDataAdapter = new SqlDataAdapter(strSql , myConn);
            DataSet myDataSet = new DataSet();
            myConn.Open();
            myDataAdapter.Fill(myDataSet, "Bus");
            GridView1.DataSource = myDataSet.Tables["Bus"];
            GridView1.DataBind();
            myConn.Close();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            FillData();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            FillData();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.ToString());
            TextBox txtBusID = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            TextBox txtBeginStation = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];

            TextBox txtEndStation = (TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0];
            TextBox txtServiceTime = (TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0];
            TextBox txtDescription = (TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0];
            string busid = txtBusID.Text ; 
            string beginstation = txtBeginStation.Text;
            string endstation = txtEndStation.Text;
            string servicetime = txtServiceTime.Text;
            string description = txtDescription.Text;
            GridView1.EditIndex = -1;
            myConn.Open();
            string strSql = " select * from Bus";
            myDataAdapter = new SqlDataAdapter(strSql, myConn);
            DataSet ds = new DataSet(); myDataAdapter.Fill(ds, "Bus");
            DataTable dt = ds.Tables["Bus"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[ID] };
            DataRow dr = dt.Rows.Find(id);
            dr["BusID"] = busid;
            dr["BeginStation"] = beginstation;
            dr["EndStation"] = endstation;
            dr["ServiceTime"] = servicetime;
            dr["Description"] = description;
            SqlCommandBuilder myCB = new SqlCommandBuilder(myDataAdapter);
            myDataAdapter.Update(ds.Tables["Bus"]);
            myConn.Close() ;
            FillData();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value.IbString());
            GridView1.EditIndex = -1;
            myConn.Open();
            string strSql ="select * from Bus1";
            myDataAdapter = new SqlDataAdapter(strSql, myConn);
            DataSet ds = new DataSet();
            myDataAdapter.Fill(ds, "Bus");
            myConn.Close();
            DataTable dt = ds.Tables["Bus"];
            dt.PrimaryKey = new DataColumn[] { dt.Columns[ID]};
            DataRow dr = dt.Rows.Find(id);
            dr.Delete();
            SqlCommandBuilder myCB = new SqlCommandBuilder(myDataAdapter);
            myDataAdapter.Update(ds.Tables["Bus"]);
            FillData();
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            FillData();
        }
    }
}