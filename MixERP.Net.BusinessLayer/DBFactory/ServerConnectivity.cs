/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. 
If a copy of the MPL was not distributed  with this file, You can obtain one at 
http://mozilla.org/MPL/2.0/.
***********************************************************************************/

namespace MixERP.Net.BusinessLayer.DBFactory
{
    public static class ServerConnectivity
    {
        public static bool IsDbServerAvailable()
        {
            return DatabaseLayer.DBFactory.ServerConnectivity.IsDbServerAvailable();
        }
    }
}
