using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;
using ServicesOperations.Interface.Master;

namespace ServicesOperations.Implementations.Master
{
    public class LocationService : ILocationService
    {
        private IRepository<sp_fetch_tbllocations_Result> locationrepo;

        public LocationService(IRepository<sp_fetch_tbllocations_Result> locationrepo)
        {
            this.locationrepo = locationrepo;
        }

        public void AddLocation(sp_fetch_tbllocations_Result location)
        {
            string spname = "[sp_tbllocation]{0},{1},{2},{3}";
            object[] parameters = { "Insert", location.location_id, location.location_name, location.city_id };
            locationrepo.ExecuteCommand(spname, parameters);
        }

        public void DeleteLocation(sp_fetch_tbllocations_Result location)
        {
            string spname = "[sp_tbllocation]{0},{1},{2},{3}";
            object[] parameters = { "Delete", location.location_id, location.location_name, location.city_id };
            locationrepo.ExecuteCommand(spname, parameters); ;
        }

        public List<sp_fetch_tbllocations_Result> GetAllLocations()
        {
            string spname = "[sp_fetch_tbllocations]{0}";
            object[] parameters = { 0 };
            return locationrepo.ExecuteQuery(spname, parameters);
        }

        public sp_fetch_tbllocations_Result GetLocation(int location_id)
        {
            string spname = "[sp_fetch_tbllocations]{0}";
            object[] parameters = { location_id };
            return locationrepo.ExecuteQuery(spname, parameters).First();
        }

        public void RestoreLocation(sp_fetch_tbllocations_Result location)
        {
            string spname = "[sp_tbllocation]{0},{1},{2},{3}";
            object[] parameters = { "Restore", location.location_id, location.location_name, location.city_id };
            locationrepo.ExecuteCommand(spname, parameters);
        }

        public void UpdateLocation(sp_fetch_tbllocations_Result location)
        {
            string spname = "[sp_tbllocation]{0},{1},{2},{3}";
            object[] parameters = { "Update", location.location_id, location.location_name, location.city_id };
            locationrepo.ExecuteCommand(spname, parameters);
        }
    }
}
