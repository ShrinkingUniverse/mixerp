<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="MixERP.Net.FrontEnd.SignIn" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="/bundles/stylesheets/sign-in.min.css" rel="stylesheet" />
    <script src="//code.jquery.com/jquery-1.9.1.js" type="text/javascript"></script>
    <title>Sign In</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="sign-in-logo">
            <a href="/SignIn.aspx">
                <asp:Image runat="server" ImageUrl="~/Themes/purple/images/mixerp-logo.png" />
            </a>
        </div>
        <div class="sign-in">
            <h1>
                <asp:Literal ID="SignInLiteral" runat="server" Text="<%$Resources:Titles, SignIn %>" />
            </h1>
            <hr class="hr" />
            <table width="100%">
                <tr>
                    <td style="width: 150px;">
                        <label for="UserIdTextBox">
                            <asp:Literal ID="UserIdLiteral" runat="server" Text="<%$Resources:Titles, UserId %>" />
                        </label>
                    </td>
                    <td>
                        <p>
                            <asp:TextBox ID="UserIdTextBox" runat="server" Width="180px" />
                        </p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="PasswordTextBox">
                            <asp:Literal ID="PasswordLiteral" runat="server" Text="<%$Resources:Titles, Password %>" />
                        </label>
                    </td>
                    <td>
                        <p>
                            <asp:TextBox ID="PasswordTextBox" runat="server" TextMode="Password" Width="180px" />
                        </p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label for="BranchDropDownList">
                            <asp:Literal ID="SelectBranchLiteral" runat="server" Text="<%$Resources:Titles, SelectYourBranch  %>" />
                        </label>
                    </td>
                    <td>
                        <asp:DropDownList ID="BranchDropDownList" runat="server"
                            DataTextField="OfficeName" DataValueField="OfficeId" Width="186px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Select Language
                    </td>
                    <td>
                        <p>
                            <asp:DropDownList ID="LanguageDropDownList" runat="server" Width="186px">
                                <asp:ListItem Text="English (United States)" Value="en-US" />
                                <asp:ListItem Text="English (Great Britain)" Value="en-GB" />
                                <asp:ListItem Text="Français (France)" Value="fr-FR" />
                                <asp:ListItem Text="Deutsch (Deutschland)" Value="de-DE" />
                                <asp:ListItem Text="नेपाली (नेपाल)" Value="ne-NP" />
                                <asp:ListItem Text="हिन्दी (India)" Value="hi-IN" />
                            </asp:DropDownList>
                        </p>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <p>
                            <asp:CheckBox ID="RememberMe" runat="server" Text="<%$Resources:Titles, RememberMe %>" />
                        </p>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Literal ID="MessageLiteral" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <p>
                            <asp:Button ID="SignInButton" runat="server" Text="<%$Resources:Titles, SignIn %>" OnClick="SignInButton_Click" />
                        </p>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <hr class="hr" />
                        <p>
                            <asp:LinkButton ID="CannotAccessAccountLinkButton" runat="server" Text="<%$Resources:Questions, CannotAccessAccount %>" />
                        </p>
                    </td>
                </tr>
            </table>
        </div>
        <script type="text/javascript">
            $("#UserIdTextBox").val('binod');
            $("#PasswordTextBox").val('binod');
        </script>
    </form>
</body>
</html>
