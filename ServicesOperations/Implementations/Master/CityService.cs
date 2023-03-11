using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;
using ServicesOperations.Interface;

namespace ServicesOperations.Implementations
{
    public class CityService : ICityService
    {
        private IRepository<sp_fetch_tblcities_Result> cityrepo;

        public CityService(IRepository<sp_fetch_tblcities_Result> cityrepo)
        {
            this.cityrepo = cityrepo;
        }

        public void AddCity(sp_fetch_tblcities_Result city)
        {
            string spname = "[sp_tblcities]{0},{1},{2},{3}";
            object[] parameters = { "Insert", city.city_id, city.city_name, city.state_id};
            cityrepo.ExecuteCommand(spname, parameters);
        }

        public void DeleteCity(sp_fetch_tblcities_Result city)
        {
            string spname = "[sp_tblcities]{0},{1},{2},{3}";
            object[] parameters = { "Delete", city.city_id, city.city_name, city.state_id };
            cityrepo.ExecuteCommand(spname, parameters);
        }

        public List<sp_fetch_tblcities_Result> GetAllCities()
        {
            string spname = "[sp_fetch_tblcities]{0}";
            object[] parameters = { 0 };
            return cityrepo.ExecuteQuery(spname, parameters);
        }

        public sp_fetch_tblcities_Result GetCity(int city_id)
        {
            string spname = "[sp_fetch_tblcities]{0}";
            object[] parameters = { city_id };
            return cityrepo.ExecuteQuery(spname, parameters).First();
        }

        public void RestoreCity(sp_fetch_tblcities_Result city)
        {
            string spname = "[sp_tblcities]{0},{1},{2},{3}";
            object[] parameters = { "Restore", city.city_id, city.city_name, city.state_id };
            cityrepo.ExecuteCommand(spname, parameters);
        }

        public void UpdateCity(sp_fetch_tblcities_Result city)
        {
            string spname = "[sp_tblstates]{0},{1},{2},{3}";
            object[] parameters = { "Update", city.city_id, city.city_name, city.state_id };
            cityrepo.ExecuteCommand(spname, parameters);
        }
    }
}
