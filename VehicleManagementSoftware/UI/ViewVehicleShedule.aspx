<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewVehicleShedule.aspx.cs" Inherits="VehicleManagementSoftware.UI.ViewVehicleShedule" %>

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
             <li ><a href="VehicleEntry.aspx">Vehicle Entry</a></li>
             <li><a href="VehicleEntry.aspx">Shedule Of Vehicle</a></li>
             <li class="active"><a href="ViewVehicleShedule.aspx">View</a></li>
             
         </ul>
         <br/><br/>
            <div style="width: 454px">
                <h1>View</h1>
                <hr/>
                <table>
                      <tr>
                          <td>
                              <asp:Label ID="Label1" runat="server" Text="Select Vehicle"></asp:Label>
                          </td>
                          <td>
                              <asp:DropDownList ID="vehicleDropDownList" runat="server"></asp:DropDownList>
                          </td>
                          <td>
                              <asp:Button ID="showButton" runat="server" Text="Show" OnClick="showButton_Click"/>
                          </td>
                      </tr>
                    <tr>
                        <td>
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                                <AlternatingRowStyle BackColor="White" />
                                <Columns>
                                    <asp:BoundField DataField="Date" HeaderText="Date" />
                                    <asp:BoundField DataField="Shift" HeaderText="Shift" />
                                </Columns>
                                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                                <SortedDescendingHeaderStyle BackColor="#820000" />
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </div>
      </div>
    </form>
</body>
</html>
