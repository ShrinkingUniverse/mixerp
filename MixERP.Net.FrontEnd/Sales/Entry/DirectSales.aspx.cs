using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MixERP.Net.BusinessLayer;

namespace MixERP.Net.FrontEnd.Sales.Entry
{
    public partial class DirectSales : MixERPWebpage
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            this.OverridePath = "~/Sales/DirectSales.aspx";
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}