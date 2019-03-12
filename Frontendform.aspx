<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Frontendform.aspx.vb" Inherits="WebApplication3.Frontendform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Google Assignment</title>
    <style type="text/css">
        #Image1{
            background-image:url('');

        }
        #Button2 {
            width: 281px;
            height: 39px;
            margin-left: 302px;
            margin-top: 16px;
        }
        .newStyle1 {
            font-style: normal;
        }
        #Button3 {
            width: 279px;
            margin-left: 40px;
            height: 39px;
        }
        #Button1 {
            margin-left: 297px; 
            margin-bottom: 47px;
            width:285px;
            height:77px;
        }
        body {
            background-color:lightcyan;
            height: 433px; 
            width: 906px;
        }
        #FileUpload1{
            margin-left: 40px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" src="App_Data/gbanner.png" Height="87px" Width="267px"/>
            <asp:Image ID="Image2" runat="server" src="App_Data/signin.png" Height="85px" Width="351px"/>
        </div>
        <div>
        </div>
        <p style="height: 55px">
            <asp:Button ID="Button1" runat="server"  Text="Sign-in with GMAIL"  tabindex="1"/>  
        </p>
        <br /><br />
        <asp:Label ID="Label1" runat="server" style="font-size: medium" Text="File Upload:"></asp:Label>
        <asp:FileUpload ID="FileUpload1" runat="server" tabindex="2" Width="465px" /><br />
        
        <asp:Button id="Button2" runat="server" text="Upload Files GDrive" tabindex="3"/>
        <p>
        <asp:Label ID="Label2" runat="server" Text="Are you ready?Click and download the file."></asp:Label>
        <asp:Button id="Button3" runat="server" text="Download Files GDrive" tabindex="4"/>

        </p>
    
    </form>
    


</body>
</html>
