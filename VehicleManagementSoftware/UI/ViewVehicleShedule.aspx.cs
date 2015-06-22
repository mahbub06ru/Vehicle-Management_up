using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VehicleManagementSoftware.BLL;

namespace VehicleManagementSoftware.UI
{
    public partial class ViewVehicleShedule : System.Web.UI.Page
    {
        SheduleManager sheduleManager=new SheduleManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                vehicleDropDownList.DataSource = sheduleManager.GetAllVehicles();
                vehicleDropDownList.DataTextField = "EnginNo";
                vehicleDropDownList.DataValueField = "Vid";
                vehicleDropDownList.DataBind();
            }

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {

        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            int vid = Convert.ToInt32(vehicleDropDownList.SelectedValue);
            GridView1.DataSource = sheduleManager.GetAllShedules(vid);
            GridView1.DataBind();
        }
    }
}