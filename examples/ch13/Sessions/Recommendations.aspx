﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Recommendations.aspx.vb" Inherits="Recommendations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book Recommendations</title>
    <style type="text/css">
       .labelStyle {
          font-size: x-large;
          font-weight: bold;
       }
       .listBoxStyle {
          width: 450px;
          height: 125px;
       }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <asp:Label ID="recommendationsLabel" runat="server" CssClass="labelStyle" Text="Recommendations"></asp:Label>
       <br />
       <asp:ListBox ID="booksListBox" runat="server" CssClass="listBoxStyle"></asp:ListBox>
       <br />
       <asp:HyperLink ID="languageLink" runat="server" NavigateUrl="~/Options.aspx">Click here to choose another language</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
