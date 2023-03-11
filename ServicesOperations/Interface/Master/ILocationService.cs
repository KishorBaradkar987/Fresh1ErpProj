using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;

namespace ServicesOperations.Interface.Master
{
    public interface ILocationService
    {
        void AddLocation(sp_fetch_tbllocations_Result location);
        void UpdateLocation(sp_fetch_tbllocations_Result location);
        void DeleteLocation(sp_fetch_tbllocations_Result location);
        List<sp_fetch_tbllocations_Result> GetAllLocations();
        sp_fetch_tbllocations_Result GetLocation(int location_id);
        void RestoreLocation(sp_fetch_tbllocations_Result location);
    }
}
