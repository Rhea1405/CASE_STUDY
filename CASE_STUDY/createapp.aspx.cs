using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CASE_STUDY
{
    public partial class createapp : System.Web.UI.Page
    {
        

        List<Population> l1 = new List<Population>();
      


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["s"] != null)
                l1 = (List<Population>)Session["s"];


        }
       
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           Population p = new Population();
            //l = new List<Population>();
            DBclass db = new DBclass();

           
                p.ApplicationID = db.appid();

            
                p.MemberID = l1.Count+1;
                p.Firstname = TextBox1.Text;
                p.MiddleName = TextBox2.Text;
                p.LastName = TextBox3.Text;
                p.Suffix = DropDownList1.SelectedValue;
                p.Dob = DateTime.Parse(TextBox4.Text);
                p.Gender= RadioButtonList1.SelectedValue;
                l1.Add(p);




            
            Session["s"] = l1;

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            DropDownList1.SelectedIndex=-1;
            TextBox4.Text = "";







        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
           


        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            DBclass d = new DBclass();
            string s = d.savemembers(l1);
            Session.Remove("s");
            Response.Redirect("confirm.aspx");

        }
    }
}