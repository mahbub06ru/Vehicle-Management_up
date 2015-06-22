using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VehicleManagementSoftware.BLL;
using VehicleManagementSoftware.Model;

namespace VehicleManagementSoftware.UI
{
    public partial class SheduleOfVehicle : System.Web.UI.Page
    {
        VehicleManager vehicleManager=new VehicleManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        protected void saveButton_Click(object sender, EventArgs e)
        {
            string regNo = regNoTextBox.Text;
            string engineNo = engineNoTextBox.Text;
            if (String.IsNullOrEmpty(regNo))
            {
                errorMessage.Text = "Reg No can't be empty";
            }
            else if (String.IsNullOrEmpty(engineNo))
            {
                errorMessage.Text = "Engine No can't be empty";
            }
            else
            {
                Vehicle aVehicle = new Vehicle();
                aVehicle.RegNo = regNo;
                aVehicle.EngineNo = engineNo;
                if (vehicleManager.Save(aVehicle))
                {
                    errorMessage.Text = "Successfully Saved";
                }
                else
                {
                    errorMessage.Text = "Exist Data";
                }

            }
            
        }
    }
}