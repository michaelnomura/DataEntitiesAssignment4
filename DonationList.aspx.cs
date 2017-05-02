using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DonationList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userKey"] != null)
        {
            int key = (int)Session["userKey"];
            Community_AssistEntities db = new Community_AssistEntities();
            var don = (from d in db.Donations
                       where d.PersonKey==key
                       select d).ToList();
            GridView1.DataSource = don;
            GridView1.DataBind();

        }
        else
        {
            Response.Redirect("Default.aspx");
        }

        //Community_AssistEntities db = new Community_AssistEntities();
        //var dons = (from a in db.Donations
        //             select a).ToList();
        //GridView1.DataSource = dons;
        //GridView1.DataBind();
    }
}