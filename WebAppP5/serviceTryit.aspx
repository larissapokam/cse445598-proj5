<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="serviceTryit.aspx.cs" Inherits="WebAppP5.serviceTryit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3> Service 8: File Storage:</h3>
            <asp:Label ID="Label1" runat="server" Text="The following service can load a local file and store it file into the server and return the URL of the saved location."></asp:Label>
            <br />
            <br />
      
            <asp:Label ID="Label2" runat="server" Text="Select the file name with local path or a URL"></asp:Label>
            <br />
         <br />
         <asp:FileUpload ID="FileUpload1" runat="server" />
         <br /><br />
         <asp:Button ID="btnsave" runat="server" onclick="btnsave_Click"  Text="Save" style="width:85px" />
         <br /><br />
         <asp:Label ID="lblmessage" runat="server" />

        </div>
    </form>
</body>
</html>
