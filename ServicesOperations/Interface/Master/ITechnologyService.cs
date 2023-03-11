using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;

namespace ServicesOperations.Interface.Master
{
    public interface ITechnologyService
    {
        void AddTechnology(sp_fetch_tbltechnologies_Result technology);
        void UpdateTechnology(sp_fetch_tbltechnologies_Result technology);
        void DeleteTechnology(sp_fetch_tbltechnologies_Result technology);
        List<sp_fetch_tbltechnologies_Result> GetAllTechnologies();
        sp_fetch_tbltechnologies_Result GetTechnology(int technology_id);
        void RestoreTechnology(sp_fetch_tbltechnologies_Result technology);
    }
}
