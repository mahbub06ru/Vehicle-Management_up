using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VehicleManagementSoftware.DAL;
using VehicleManagementSoftware.Model;

namespace VehicleManagementSoftware.BLL
{
    
    public class SheduleManager
    {
        SheduleGateway sheduleGateway = new SheduleGateway();
        public List<Vehicle> GetAllVehicles()
        {
            return sheduleGateway.GetAllVehicles();
        }

        public bool Save(Shedule aShedule)
        {
            if (sheduleGateway.CheckShedule(aShedule))
            {
                return false;
            }
            return sheduleGateway.Save(aShedule) > 0;
        }

        public List<View> GetAllShedules(int vid)
        {
            return SheduleGateway.GetAllShedules(vid);
        }
    }
}