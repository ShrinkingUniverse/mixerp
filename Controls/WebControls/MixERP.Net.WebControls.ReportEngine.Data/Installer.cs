/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. 
If a copy of the MPL was not distributed  with this file, You can obtain one at 
http://mozilla.org/MPL/2.0/.
***********************************************************************************/

using MixERP.Net.DBFactory;
using Npgsql;

namespace MixERP.Net.WebControls.ReportEngine.Data
{
    public static class Installer
    {

        public static void InstallReport(string menuCode, string parentMenuCode, int level, string menuText, string path)
        {
            const string sql = @"INSERT INTO core.menus(menu_text, url, menu_code, level, parent_menu_id)
                            SELECT @MenuText, @Path, @MenuCode, @Level, core.get_menu_id(@ParentMenuCode)
                            WHERE NOT EXISTS(SELECT * FROM core.menus WHERE menu_code=@MenuCode);";
            
            using(NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@MenuCode", menuCode);
                command.Parameters.AddWithValue("@MenuText", menuText);
                command.Parameters.AddWithValue("@Path", path);
                command.Parameters.AddWithValue("@Level", level);
                command.Parameters.AddWithValue("@ParentMenuCode", parentMenuCode);
                //command.UnpreparedExecute = true;

                DbOperations.ExecuteNonQuery(command);
            }
        }
    }
}
