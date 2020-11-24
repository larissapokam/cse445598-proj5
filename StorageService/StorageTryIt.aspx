<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StorageTryIt.aspx.cs" Inherits="StorageService.StorageTryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <h3> Service 8: File Storage:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
            </h3>
            <asp:Label ID="Label1" runat="server" Text="The following service can load a local file and store it file into the server and return the URL of the saved location."></asp:Label>
            <br />
            <br />
      
            <asp:Label ID="Label2" runat="server" Text="Select the file name with local path or a URL"></asp:Label>
            <br />
         <br />
         <asp:FileUpload ID="FileUpload1" runat="server" />
         <br /><br />
         <asp:Button ID="btnsave" runat="server"  Text="Upload" style="width:85px" OnClick="btnsave_Click" />
         <br /><br />
         <asp:Label ID="lblmessage" runat="server" />

            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
