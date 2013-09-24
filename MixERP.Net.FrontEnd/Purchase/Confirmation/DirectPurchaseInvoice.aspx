﻿<%-- 
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. 
If a copy of the MPL was not distributed  with this file, You can obtain one at 
http://mozilla.org/MPL/2.0/.
--%>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DirectPurchaseInvoice.aspx.cs" Inherits="MixERP.Net.FrontEnd.Purchase.Confirmation.DirectPurchaseInvoice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <mixerp:Report ID="DirectPurchaseInvoiceReport" runat="server" 
        Path="~/Reports/Sources/Purchase.View.Purchase.Invoice.xml" AutoInitialize="true" />
    </form>
</body>
</html>
