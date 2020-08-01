using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthPlus
{
    public partial class userlogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["RCB2C"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                //if(con.State==System.Data.ConnectionState.Closed)
                //{
                    con.Open();
              //  }
                SqlCommand cmd = new SqlCommand("SELECT * from ", con);
            }


            catch(Exception ex)
            {

            }

            //Response.Write("<script>alert('User ID already exists, try with another ID');</script>");
        }
    }
}