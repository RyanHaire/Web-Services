using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        int count = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(ViewState["variable"] != null)
            {
                count = (int)ViewState["variable"] + 1;
            }
 
            TextBox1.Text = count.ToString();
            ViewState["variable"] = count;
        }
    }
}