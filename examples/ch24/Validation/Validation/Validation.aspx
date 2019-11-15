<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Validation.aspx.vb" Inherits="Validation.Validation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Demonstrating Validation Controls</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h3>
           <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
           </ajaxToolkit:ToolkitScriptManager>
           Please fill in all the fields in the following form:</h3>
        <ajaxToolkit:TabContainer ID="TabContainer1" runat="server" ActiveTabIndex="0" Width="450px">
           <ajaxToolkit:TabPanel runat="server" HeaderText="TabPanel1" ID="TabPanel1">
              <HeaderTemplate>
                 Name
              </HeaderTemplate>
              <ContentTemplate>
                 <table class="auto-style1">
                    <tr>
                       <td>Name:</td>
                       <td>
                          <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
                          <br />
                          <asp:RequiredFieldValidator ID="nameRequiredFieldValidator" runat="server" ControlToValidate="nameTextBox" Display="None" ErrorMessage="Please enter your name" ForeColor="Red"></asp:RequiredFieldValidator>
                          <ajaxToolkit:ValidatorCalloutExtender ID="nameRequiredFieldValidator_ValidatorCalloutExtender" runat="server" Enabled="True" TargetControlID="nameRequiredFieldValidator">
                          </ajaxToolkit:ValidatorCalloutExtender>
                       </td>
                    </tr>
                 </table>
              </ContentTemplate>
           </ajaxToolkit:TabPanel>
           <ajaxToolkit:TabPanel runat="server" HeaderText="TabPanel2" ID="TabPanel2">
              <HeaderTemplate>
                 Contact
              </HeaderTemplate>
              <ContentTemplate>
                 <table class="auto-style1">
                    <tr>
                       <td>E-mail:</td>
                       <td>
                          <asp:TextBox ID="emailTextBox" runat="server" TextMode="Email"></asp:TextBox>
                          &nbsp;email@domain.com<br />&nbsp;<asp:RequiredFieldValidator ID="emailRequiredFieldValidator" runat="server" ControlToValidate="emailTextBox" Display="None" ErrorMessage="Please enter your e-mail address" ForeColor="Red"></asp:RequiredFieldValidator>
                          <ajaxToolkit:ValidatorCalloutExtender ID="emailRequiredFieldValidator_ValidatorCalloutExtender" runat="server" Enabled="True" TargetControlID="emailRequiredFieldValidator">
                          </ajaxToolkit:ValidatorCalloutExtender>
                          <asp:RegularExpressionValidator ID="emailRegularExpressionValidator" runat="server" ControlToValidate="emailTextBox" Display="None" ErrorMessage="Please enter an e-mail address in a valid format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                          <ajaxToolkit:ValidatorCalloutExtender ID="emailRegularExpressionValidator_ValidatorCalloutExtender" runat="server" Enabled="True" TargetControlID="emailRegularExpressionValidator">
                          </ajaxToolkit:ValidatorCalloutExtender>
                       </td>
                    </tr>
                    <tr>
                       <td>Phone:</td>
                       <td>
                          <asp:TextBox ID="phoneTextBox" runat="server" TextMode="Phone"></asp:TextBox>
                          &nbsp;(555) 555-1234<br />&nbsp;<asp:RequiredFieldValidator ID="phoneRequiredFieldValidator" runat="server" ControlToValidate="phoneTextBox" Display="None" ErrorMessage="Please enter your phone number" ForeColor="Red"></asp:RequiredFieldValidator>
                          <ajaxToolkit:ValidatorCalloutExtender ID="phoneRequiredFieldValidator_ValidatorCalloutExtender" runat="server" Enabled="True" TargetControlID="phoneRequiredFieldValidator">
                          </ajaxToolkit:ValidatorCalloutExtender>
                          <asp:RegularExpressionValidator ID="phoneRegularExpressionValidator" runat="server" ControlToValidate="phoneTextBox" Display="None" ErrorMessage="Please enter a phone number in a valid format" ForeColor="Red" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
                          <ajaxToolkit:ValidatorCalloutExtender ID="phoneRegularExpressionValidator_ValidatorCalloutExtender" runat="server" Enabled="True" TargetControlID="phoneRegularExpressionValidator">
                          </ajaxToolkit:ValidatorCalloutExtender>
                       </td>
                    </tr>
                 </table>
              </ContentTemplate>
           </ajaxToolkit:TabPanel>
        </ajaxToolkit:TabContainer>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
           <ContentTemplate>
              <br />
              <asp:Button ID="submitButton" runat="server" Text="Submit" />
              <br />
              <br />
              <asp:Label ID="outputLabel" runat="server" Visible="False"></asp:Label>
           </ContentTemplate>
        </asp:UpdatePanel>
        <p>
           &nbsp;</p>
        <p>
            &nbsp;</p>
    </div>
    </form>
</body>
</html>
