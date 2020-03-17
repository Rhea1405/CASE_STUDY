using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CASE_STUDY
{
    public class DBclass
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public  int appid()
        {
            int c = 0;
            try
            {
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
                con.Open();
                cmd = new SqlCommand("select max(ApplicationID) from Census", con);
                string s = cmd.ExecuteScalar().ToString();
                if (s=="")

                    c++;
                else
                    c=int.Parse(s)+1;
            }
            catch(SqlException s)
            {

                
            }
            finally
            {
                con.Close();
            }
            return c;






        }
        public string savemembers(List<Population> l)
        {
           
            string str = null;
            try
            {
                
                con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ToString());
                
                cmd = new SqlCommand("sp_census", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                DataTable dt = new DataTable();
                dt.Columns.Add("ApplicationID", typeof(Int32));
                dt.Columns.Add("MemberID", typeof(Int32));
                dt.Columns.Add("Firstname", typeof(string));
                dt.Columns.Add("MiddleName", typeof(string));
                dt.Columns.Add("LastName", typeof(string));
                dt.Columns.Add("Suffix", typeof(string));
                dt.Columns.Add("Dob", typeof(DateTime));
                dt.Columns.Add("Gender", typeof(string));

                for(int i=0;i<l.Count;i++)
                {
                    dt.Rows.Add(l[i].ApplicationID, l[i].MemberID, l[i].Firstname, l[i].MiddleName, l[i].LastName, l[i].Suffix, l[i].Dob, l[i].Gender);
                }
                SqlParameter p = new SqlParameter("@c",dt);
                p.SqlDbType = SqlDbType.Structured;
                cmd.Parameters.Add(p);
                cmd.ExecuteNonQuery();
                str = "Application submitted with " + l.Count + "member details .Application Id :"+l[0].ApplicationID;
                
                    



            }
            catch(SqlException e)
            {
                
            }
            finally
            {
                con.Close();
            }


            return str;
        }






    }
}