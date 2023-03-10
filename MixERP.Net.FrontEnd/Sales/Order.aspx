<%-- 
Copyright (C) Binod Nepal, Mix Open Foundation (http://mixof.org).

This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0. 
If a copy of the MPL was not distributed  with this file, You can obtain one at 
http://mozilla.org/MPL/2.0/.
--%>

<%@ Page Title="" Language="C#" MasterPageFile="~/ContentMaster.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="MixERP.Net.FrontEnd.Sales.Order" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ScriptContentPlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="StyleSheetContentPlaceholder" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="BodyContentPlaceholder" runat="server">
    <mixerp:ProductView
        runat="server"
        Book="Sales" SubBook="Order"
        Text="<%$Resources:Titles, SalesOrder %>"
        AddNewUrl="~/Sales/Entry/Order.aspx"
        PreviewUrl="~/Sales/Confirmation/ReportSalesOrder.aspx"
        ChecklistUrl="~/Sales/Confirmation/Order.aspx" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="BottomScriptContentPlaceholder" runat="server">
</asp:Content>
