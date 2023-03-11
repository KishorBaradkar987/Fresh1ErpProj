using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;

namespace ServicesOperations.Interface
{
    public interface ICityService
    {
        void AddCity(sp_fetch_tblcities_Result city);
        void UpdateCity(sp_fetch_tblcities_Result city);
        void DeleteCity(sp_fetch_tblcities_Result city);
        List<sp_fetch_tblcities_Result> GetAllCities();
        sp_fetch_tblcities_Result GetCity(int city_id);
        void RestoreCity(sp_fetch_tblcities_Result city);
    }
}
