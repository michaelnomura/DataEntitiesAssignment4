<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donation.aspx.cs" Inherits="DonationPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Donation</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <h1>Donate</h1>
    <form id="form1" runat="server">
    <div>
        <p>Donation Amount <asp:TextBox ID="DonationTextBox" runat="server"></asp:TextBox></p>
        <p>
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" 
                OnClick="SubmitButton_Click" style="height: 26px" /></p>
        
    </div>
    </form>
</body>
</html>
