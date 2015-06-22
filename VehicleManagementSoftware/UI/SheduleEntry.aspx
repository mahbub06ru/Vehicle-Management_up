<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SheduleEntry.aspx.cs" Inherits="VehicleManagementSoftware.UI.SheduleEntry" %>

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
             <li><a href="VehicleEntry.aspx">Vehicle Entry</a></li>
             <li class="active"><a href="VehicleEntry.aspx">Shedule Of Vehicle</a></li>
             <li><a href="ViewVehicleShedule.aspx">View</a></li>
         </ul>
         <br/><br/>
            <div style="width: 454px">
                <h1>Shedule of Vehicle</h1>
                <hr/>
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Select Vehicle"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="vehicleDropDownList" runat="server"></asp:DropDownList>
                        </td>
                    </tr><br/>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Select Date"></asp:Label>
                        </td>
                        <td>
                            <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                                <OtherMonthDayStyle ForeColor="#CC9966" />
                                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                                <SelectorStyle BackColor="#FFCC66" />
                                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
                            </asp:Calendar>
                        </td>
                    </tr><br/>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Select Shift"></asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="shiftDropList" runat="server">
                                <asp:ListItem>Morning</asp:ListItem>
                                <asp:ListItem>Evening</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr><br/>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Booked By"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="bookedByTextBox" runat="server"></asp:TextBox>
                        </td>
                    </tr><br/>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label>
                        </td>
                        <td>
                            <textarea id="TextArea1"  runat="server" cols="20" rows="2"></textarea>
                        </td>
                    </tr><br/>
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
                        </td>
                    </tr><br/>   
                    <tr>
                        <td>
                            <asp:Label ID="errorMessage" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>                 
                </table>
                

             </div>
         </div>
        </form>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
</body>
</html>
