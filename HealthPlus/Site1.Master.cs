using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HealthPlus
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            // Response.Redirect("hospitallogin.aspx");
            Server.Transfer("hospitallogin.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            //Response.Redirect("membermanagement.aspx");
            Server.Transfer("adminlogin.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            //Response.Redirect("medicalfacility.aspx");
            Server.Transfer("medicalfacility.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //Response.Redirect("userlogin.aspx");
            Server.Transfer("userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            //Response.Redirect("usersignup.aspx"); 
            Server.Transfer("usersignup.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Server.Transfer("pharlogin.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Server.Transfer("ambulance.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "null";
            Session["fullname"] = "null";
            Session["role"] = "null";
            Session["status"] = "null";

            LinkButton1.Visible = true; 
            

            LinkButton3.Visible = false; 
            LinkButton7.Visible = false; 


            LinkButton6.Visible = true; 
            LinkButton11.Visible = true; 
            LinkButton12.Visible = true; 
            LinkButton8.Visible = true; 
           
        }
    }
}