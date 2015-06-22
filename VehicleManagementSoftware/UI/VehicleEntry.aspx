<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VehicleEntry.aspx.cs" Inherits="VehicleManagementSoftware.UI.SheduleOfVehicle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css">

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap-theme.min.css">
</head>
<body>
    <form id="form1" runat="server">
     <div class="container">
         <ul class="nav nav-pills">
             <li class="active"><a href="VehicleEntry.aspx">Vehicle Entry</a></li>
             <li><a href="VehicleEntry.aspx">Shedule Of Vehicle</a></li>
             <li><a href="ViewVehicleShedule.aspx">View</a></li>
             
         </ul>
         <br/><br/>
            <div style="width: 454px">
                <h1>Vehicle Information Details</h1>
                <hr/>
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Reg No"></asp:Label>
                            </td>
                           <td>
                            <asp:TextBox ID="regNoTextBox" runat="server" Width="345px"></asp:TextBox>
                        </td>
                    </tr>
                    <br/><br/>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Engine No"></asp:Label>
                           </td>
                        <td>
                            <asp:TextBox ID="engineNoTextBox" runat="server" Width="341px"></asp:TextBox>
                        </td>
                    </tr>
                    <br/><br/>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                           </td>
                        <td>
                            <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
                        </td>
                    </tr>
                    <br/>
                </table>
                <br/>
                <asp:Label ID="errorMessage" runat="server" Text="label"></asp:Label>
                
            </div>
    
    </div>
    </form>
     <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
</body>
</html>
