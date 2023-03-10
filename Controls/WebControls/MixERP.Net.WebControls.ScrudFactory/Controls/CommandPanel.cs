/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. 
If a copy of the MPL was not distributed  with this file, You can obtain one at 
http://mozilla.org/MPL/2.0/.
***********************************************************************************/
using System;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using MixERP.Net.WebControls.ScrudFactory.Resources;
using System.Web.UI;
using System.Web;

namespace MixERP.Net.WebControls.ScrudFactory.Controls
{
    public class CommandPanel : IDisposable
    {
        private bool disposed;

        public Button EditButton { get; private set; }

        public event EventHandler EditButtonClick;

        public Button DeleteButton { get; private set; }

        public event EventHandler DeleteButtonClick;

        public string ButtonCssClass { get; set; }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    if (this.commandPanel != null)
                    {
                        this.commandPanel.Dispose();
                        this.commandPanel = null;
                    }

                    if (this.EditButton != null)
                    {
                        this.EditButton.Click -= this.OnEditButtonClick;
                        this.EditButtonClick = null;
                        this.EditButton.Dispose();
                        this.EditButton = null;
                    }


                    if (this.DeleteButton != null)
                    {
                        this.DeleteButton.Click -= this.OnDeleteButtonClick;
                        this.DeleteButtonClick = null;
                        this.DeleteButton.Dispose();
                        this.DeleteButton = null;
                    }
                }

                this.disposed = true;
            }
        }
        public Panel GetCommandPanel()
        {
            this.commandPanel = new Panel { CssClass = "vpad16" };

            this.AddSelectButton(this.commandPanel);
            this.AddShowCompactButton(this.commandPanel);
            this.AddShowAllButton(this.commandPanel);
            this.AddAddButton(this.commandPanel);
            this.AddEditButton(this.commandPanel);
            this.AddDeleteButton(this.commandPanel);
            this.AddPrintButton(this.commandPanel);
            return this.commandPanel;
        }

        private Panel commandPanel;

        private bool IsModal()
        {
            Page page = HttpContext.Current.CurrentHandler as Page;

            if (page != null)
            {
                var modal = page.Request.QueryString["modal"];
                if (modal != null)
                {
                    if (modal.Equals("1"))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        //Todo:Complete this implementation
        private void AddSelectButton(Panel p)
        {
            if (this.IsModal())
            {
                var addSelectButton = this.GetInputButton("RETURN", "scrudSelectAndClose();", ScrudResource.Select);
                p.Controls.Add(addSelectButton);            
            }
        }

        private void AddShowCompactButton(Panel p)
        {
            var showCompactButton = this.GetInputButton("ALT + C", "scrudShowCompact();", ScrudResource.ShowCompact);
            p.Controls.Add(showCompactButton);
        }

        private void AddShowAllButton(Panel p)
        {
            var showAllButton = this.GetInputButton("CTRL + S", "scrudShowAll();", ScrudResource.ShowAll);
            p.Controls.Add(showAllButton);
        }

        private void AddAddButton(Panel p)
        {
            var addButton = this.GetInputButton("ALT + A", "return(scrudAddNew());", ScrudResource.AddNew);
            p.Controls.Add(addButton);
        }

        private void AddEditButton(Panel p)
        {
            this.EditButton = this.GetButton("CTRL + E", "return(scrudConfirmAction());", ScrudResource.EditSelected);
            this.EditButton.Click += this.OnEditButtonClick;
            p.Controls.Add(this.EditButton);
        }

        private void OnEditButtonClick(object sender, EventArgs e)
        {
            if (this.EditButtonClick != null)
            {
                this.EditButtonClick(this, e);
            }
        }

        private void AddDeleteButton(Panel p)
        {
            this.DeleteButton = this.GetButton("CTRL + D", "return(scrudConfirmAction());", ScrudResource.DeleteSelected);
            this.DeleteButton.Click += this.OnDeleteButtonClick;
            p.Controls.Add(this.DeleteButton);
        }

        private void OnDeleteButtonClick(object sender, EventArgs e)
        {
            if (this.DeleteButtonClick != null)
            {
                this.DeleteButtonClick(this, e);
            }
        }

        private void AddPrintButton(Panel p)
        {
            var printButton = this.GetInputButton("CTRL + P", "scrudPrintGridView();", ScrudResource.Print);
            p.Controls.Add(printButton);
        }

        private HtmlInputButton GetInputButton(string title, string onclick, string value)
        {
            using (var inputButton = new HtmlInputButton())
            {
                inputButton.Attributes.Add("class", this.ButtonCssClass);
                inputButton.Attributes.Add("title", title);
                inputButton.Attributes.Add("onclick", onclick);
                inputButton.Value = value;

                return inputButton;
            }
        }

        private Button GetButton(string toolTip, string onClientClick, string text)
        {
            using (var button = new Button())
            {
                button.CssClass = this.ButtonCssClass;
                button.ToolTip = toolTip;
                button.OnClientClick = onClientClick;
                button.Text = text;

                return button;
            }
        }
    }
}
