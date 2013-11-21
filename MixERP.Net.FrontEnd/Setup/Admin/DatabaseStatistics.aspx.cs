﻿/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. 
If a copy of the MPL was not distributed  with this file, You can obtain one at 
http://mozilla.org/MPL/2.0/.
***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MixERP.Net.WebControls.ScrudFactory;

namespace MixERP.Net.FrontEnd.Setup.Admin
{
    public partial class DatabaseStatistics : MixERP.Net.BusinessLayer.BasePageClass
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VacuumButton.OnClientClick = "return(confirm('" + Resources.Questions.ConfirmVacuum + "'));";
            FullVacuumButton.OnClientClick = "return(confirm('" + Resources.Questions.ConfirmVacuumFull + "'));";
            AnalyzeButton.OnClientClick = "return(confirm('" + Resources.Questions.ConfirmAnalyze + "'));";
            this.AddScrud();
            this.LocalizeButtons();
        }

        private void LocalizeButtons()
        {
            VacuumButton.Text = Resources.Titles.VacuumDatabase;
            FullVacuumButton.Text = Resources.Titles.VacuumFullDatabase;
            AnalyzeButton.Text = Resources.Titles.AnalyzeDatabse;
        }

        private void AddScrud()
        {
            using (ScrudForm scrud = new ScrudForm())
            {
                scrud.DenyAdd = true;
                scrud.DenyDelete = true;
                scrud.DenyEdit = true;

                scrud.KeyColumn = "relname";
                scrud.PageSize = 500;

                scrud.TableSchema = "public";
                scrud.Table = "db_stat";
                scrud.ViewSchema = "public";
                scrud.View = "db_stat";

                scrud.Text = Resources.Titles.DatabaseStatistics;

                ScriptManager1.NamingContainer.Controls.Add(scrud);
            }
        }

        protected void VacuumButton_Click(object sender, EventArgs e)
        {
            MixERP.Net.BusinessLayer.Helpers.Maintenance.Vacuum();
            this.DisplaySuccess();
        }

        protected void FullVacuumButton_Click(object sender, EventArgs e)
        {
            MixERP.Net.BusinessLayer.Helpers.Maintenance.VacuumFull();
            this.DisplaySuccess();
        }

        protected void AnalyzeButton_Click(object sender, EventArgs e)
        {
            MixERP.Net.BusinessLayer.Helpers.Maintenance.Analyze();
            this.DisplaySuccess();
        }

        private void DisplaySuccess()
        {
            MessageLiteral.Text = "<div class='success'>Task completed successfully.</div>";
        }
    }
}