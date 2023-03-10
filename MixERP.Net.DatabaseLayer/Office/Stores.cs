/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. 
If a copy of the MPL was not distributed  with this file, You can obtain one at 
http://mozilla.org/MPL/2.0/.
***********************************************************************************/

using MixERP.Net.DBFactory;
using Npgsql;

namespace MixERP.Net.DatabaseLayer.Office
{
    public static class Stores
    {
        public static bool IsSalesAllowed(int storeId)
        {
            const string sql = "SELECT 1 FROM office.stores WHERE store_id=@StoreId and allow_sales='yes';";

            using(NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@StoreId", storeId);
                return DbOperations.GetDataTable(command).Rows.Count.Equals(1);
            }
        }
    }
}
