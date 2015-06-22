using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VehicleManagementSoftware.DAL;
using VehicleManagementSoftware.Model;

namespace VehicleManagementSoftware.BLL
{
    public class VehicleManager
    {
        VehicleGateway vehicleGateway=new VehicleGateway();

        public bool Save(Vehicle aVehicle)
        {
            if (vehicleGateway.CheckVehicle(aVehicle))
            {
                return false;
            }
            return vehicleGateway.Save(aVehicle)>0;
        }
    }
}