using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // what is the IsPostBack property?
            if(IsPostBack == false)
                TextBox1.Text = "Hello there";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Label1.Text = "Hello " + TextBox1.Text;
        }
    }
}