using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;

namespace ServicesOperations.Interface
{
    public interface IStateService
    {
        void AddState(sp_fetch_tblstates_Result state);
        void UpdateState(sp_fetch_tblstates_Result state);
        void DeleteState(sp_fetch_tblstates_Result state);
        List<sp_fetch_tblstates_Result> GetAllStates();
        sp_fetch_tblstates_Result GetState(int state_id);
        void RestoreState(sp_fetch_tblstates_Result state);
    }
}
