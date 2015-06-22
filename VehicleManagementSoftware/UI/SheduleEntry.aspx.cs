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
    public partial class SheduleEntry : System.Web.UI.Page
    {
        SheduleManager sheduleManager = new SheduleManager();
        protected void Page_Load(object sender, EventArgs e)
        {

            vehicleDropDownList.DataSource = sheduleManager.GetAllVehicles();
            vehicleDropDownList.DataTextField = "EngineNo";
            vehicleDropDownList.DataValueField = "Vid";
            vehicleDropDownList.DataBind();
        }

        Shedule aShedule=new Shedule();
        protected void saveButton_Click(object sender, EventArgs e)
        {
            int vid = Convert.ToInt32(vehicleDropDownList.SelectedValue);
            DateTime date = Calendar1.SelectedDate;
            string shift = shiftDropList.SelectedValue;
            string bookedBy = bookedByTextBox.Text;
            string address = TextArea1.InnerText;
            if (date.Year.ToString().Equals("1"))
            {
                errorMessage.Text = "Please select a time";
            }
            else if (String.IsNullOrEmpty(bookedBy))
            {
                errorMessage.Text = "Give Your Name First";
            }
            else if (String.IsNullOrEmpty(address))
            {
                errorMessage.Text = "Give Your Address First";
            }
            else
            {
                Shedule aShedule = new Shedule();
                aShedule.Address = address;
                aShedule.BookedBy = bookedBy;
                aShedule.Date = date;
                aShedule.Shift = shift;
                aShedule.Vid = vid;
                if (sheduleManager.Save(aShedule))
                {
                    errorMessage.Text = "Successfully Shedule Add";
                }
                else
                {
                    errorMessage.Text = "Shedule already Exist";
                }
            }
        }
    }
}