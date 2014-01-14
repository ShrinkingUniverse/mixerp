﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MixERP.Net.BusinessLayer.Helpers;
using MixERP.Net.Common.Helpers;
using MixERP.Net.WebControls.ScrudFactory;

namespace MixERP.Net.FrontEnd.Setup.Policy
{
    public partial class VoucherVerification : MixERP.Net.BusinessLayer.MixERPWebPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (ScrudForm scrud = new ScrudForm())
            {
                scrud.DenyAdd = !MixERP.Net.BusinessLayer.Helpers.SessionHelper.IsAdmin();
                scrud.DenyEdit = !MixERP.Net.BusinessLayer.Helpers.SessionHelper.IsAdmin();
                scrud.DenyDelete = !MixERP.Net.BusinessLayer.Helpers.SessionHelper.IsAdmin();

                scrud.KeyColumn = "user_id";

                scrud.TableSchema = "policy";
                scrud.Table = "auto_verification_policy";
                scrud.ViewSchema = "policy";
                scrud.View = "auto_verification_policy_view";

                scrud.PageSize = 100;
                scrud.Width = 2000;

                scrud.DisplayFields = GetDisplayFields();
                scrud.DisplayViews = GetDisplayViews();

                scrud.Text = Resources.Titles.AutoVerificationPolicy;

                ScriptManager1.NamingContainer.Controls.Add(scrud);
            }
        }

        private static string GetDisplayFields()
        {
            List<string> displayFields = new List<string>();
            ScrudHelper.AddDisplayField(displayFields, "office.users.user_id", ConfigurationHelper.GetDbParameter("UserDisplayField"));
            return string.Join(",", displayFields);
        }

        private static string GetDisplayViews()
        {
            List<string> displayViews = new List<string>();
            ScrudHelper.AddDisplayView(displayViews, "office.users.user_id", "office.user_view");
            return string.Join(",", displayViews);
        }

    }
}