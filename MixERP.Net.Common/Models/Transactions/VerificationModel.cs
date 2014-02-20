﻿/********************************************************************************
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. 
If a copy of the MPL was not distributed  with this file, You can obtain one at 
http://mozilla.org/MPL/2.0/.
***********************************************************************************/
using System;

namespace MixERP.Net.Common.Models.Transactions
{
    public class VerificationModel
    {
        public short Verification { get; set; }
        public int VerifierUserId { get; set; }
        public string VerifierName { get; set; }
        public DateTime VerifiedDate { get; set; }
        public string VerificationReason { get; set; }
    }
}
