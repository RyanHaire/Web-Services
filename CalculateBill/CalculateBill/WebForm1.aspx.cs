using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculateBill
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected String[] category = { "Individual", "NonProfit", "Corporate" };
        // HW --> use array list as data source
        protected void Page_Load(object sender, EventArgs e)
        {
            // when a page is requested, 2 things happen
            // 1) Init -> occurs first. It is raised so
            // that the view state of the page and its controls
            // can be restored

            // 2) Load -> After all controls have been initialized, the 
            // Page Load event is invoked to perform the initialization
            // of controls, define SQL connections, retrieveing data etc
            // Page Load is always invoked when the page is loaded for processing

            // See notes on Page Life Cycle

            if(!IsPostBack)
            {
                drdCategory.DataSource = category;
                drdCategory.DataBind(); // contents of the datasource
                                        // are assigned to the drop down
                                        // control
            }

        }

        protected void tbQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            String c;
            int q;
            float r, a, d, n;
            d = 0;
            q = Convert.ToInt32(tbQuantity.Text);
            r = Convert.ToSingle(tbCost.Text); // single precision float
            a = q * r;
            c = drdCategory.SelectedItem.Text;
            if(String.Compare(c, "Individual") == 0)
            {
                d = (float)a * 10 / 100;
            }

            if (String.Compare(c, "NonProfit") == 0)
            {
                d = (float)a * 20 / 100;
            }
            if (String.Compare(c, "Corporate") == 0)
            {
                d = (float)a * 30 / 100;
            }
            // d = (float)a * 10 / 100;
            n = a - d;
     
            tbDiscount.Text = d.ToString();
            tbNetAmount.Text = n.ToString();
            tbAmount.Text = a.ToString();
        }
    }
}