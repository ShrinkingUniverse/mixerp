/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. 
If a copy of the MPL was not distributed  with this file, You can obtain one at 
http://mozilla.org/MPL/2.0/.
***********************************************************************************/

using System.Data;
using MixERP.Net.DBFactory;
using Npgsql;

namespace MixERP.Net.DatabaseLayer.Core
{
    public static class ShippingAddresses
    {
        public static DataTable GetShippingAddressView(int partyId)
        {
            const string sql = "SELECT * FROM core.shipping_address_view WHERE party_id=@PartyId;";
            using(NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@PartyId", partyId);

                return DbOperations.GetDataTable(command);
            }
        }

        public static DataTable GetShippingAddressView(string partyCode)
        {
            const string sql = "SELECT * FROM core.shipping_address_view WHERE party_id = core.get_party_id_by_party_code(@PartyCode);";
            using(NpgsqlCommand command = new NpgsqlCommand(sql))
            {
                command.Parameters.AddWithValue("@PartyCode", partyCode);

                return DbOperations.GetDataTable(command);
            }
        }
    }
}
