using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CASE_STUDY
{
    public partial class Searchapp : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());

            adp = new SqlDataAdapter("select * from Census where ApplicationID=@a", con);
            adp.SelectCommand.Parameters.AddWithValue("@a", txtAppId.Text);
            DataSet ds = new DataSet();
            adp.Fill(ds, "p");
            GridView1.DataSource = ds.Tables["p"];
            GridView1.DataBind();






        }

       
    }
}