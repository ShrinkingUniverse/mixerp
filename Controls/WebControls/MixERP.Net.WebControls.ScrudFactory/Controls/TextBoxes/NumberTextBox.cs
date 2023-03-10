/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. 
If a copy of the MPL was not distributed  with this file, You can obtain one at 
http://mozilla.org/MPL/2.0/.
***********************************************************************************/
using System;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using MixERP.Net.Common.Helpers;
using MixERP.Net.WebControls.ScrudFactory.Helpers;
using MixERP.Net.WebControls.ScrudFactory.Resources;

namespace MixERP.Net.WebControls.ScrudFactory.Controls.TextBoxes
{
    public static class ScrudNumberTextBox
    {
        public static void AddNumberTextBox(HtmlTable htmlTable, string resourceClassName, string columnName, string defaultValue, bool isSerial, bool isNullable, int maxLength, string domain)
        {
            if (htmlTable == null)
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(columnName))
            {
                return;
            }

            var textBox = GetNumberTextBox(columnName + "_textbox", maxLength);
            var numberValidator = GetNumberValidator(textBox, domain);
            var label = LocalizationHelper.GetResourceString(resourceClassName, columnName);

            if (!string.IsNullOrWhiteSpace(defaultValue))
            {
                if (!defaultValue.StartsWith("nextVal", StringComparison.OrdinalIgnoreCase))
                {
                    textBox.Text = defaultValue;
                }
            }

            textBox.Width = 200;

            if (isSerial)
            {
                textBox.ReadOnly = true;
            }
            else
            {
                if (!isNullable)
                {
                    var required = ScrudFactoryHelper.GetRequiredFieldValidator(textBox);
                    ScrudFactoryHelper.AddRow(htmlTable, label + ScrudResource.RequiredFieldIndicator, textBox, numberValidator, required);
                    return;
                }
            }

            ScrudFactoryHelper.AddRow(htmlTable, label, textBox, numberValidator);
        }

        private static TextBox GetNumberTextBox(string id, int maxLength)
        {
            var textBox = ScrudTextBox.GetTextBox(id, maxLength);
            //textBox.Attributes["type"] = "number";
            return textBox;
        }

        private static CompareValidator GetNumberValidator(Control controlToValidate, string domain)
        {
            using (var validator = new CompareValidator())
            {
                validator.ID = controlToValidate.ID + "NumberValidator";
                validator.ErrorMessage = @"<br/>" + ScrudResource.OnlyNumbersAllowed;
                validator.CssClass = "form-error";
                validator.ControlToValidate = controlToValidate.ID;
                validator.EnableClientScript = true;
                validator.SetFocusOnError = true;
                validator.Display = ValidatorDisplay.Dynamic;
                validator.Type = ValidationDataType.Integer;

                //MixERP strict data type
                if (domain.Contains("strict"))
                {
                    validator.Operator = ValidationCompareOperator.GreaterThan;
                }
                else
                {
                    validator.Operator = ValidationCompareOperator.GreaterThanEqual;
                }

                validator.ValueToCompare = "0";

                return validator;
            }
        }
    }
}
