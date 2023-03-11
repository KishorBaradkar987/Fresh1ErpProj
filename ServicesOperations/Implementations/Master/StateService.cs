using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;
using ServicesOperations.Interface;

namespace ServicesOperations.Implementations
{
    public class StateService : IStateService
    {
        private IRepository<sp_fetch_tblstates_Result> staterepo;

        public StateService(IRepository<sp_fetch_tblstates_Result> staterepo)
        {
            this.staterepo = staterepo;
        }

        public void AddState(sp_fetch_tblstates_Result state)
        {
            string spname = "[sp_tblstates]{0},{1},{2}";
            object[] parameters = { "Insert",state.state_id, state.state_name };
            staterepo.ExecuteCommand(spname, parameters);
        }

        public void DeleteState(sp_fetch_tblstates_Result state)
        {
            string spname = "[sp_tblstates]{0},{1},{2}";
            object[] parameters = { "Delete",state.state_id, state.state_name };
            staterepo.ExecuteCommand(spname, parameters);
        }

        public List<sp_fetch_tblstates_Result> GetAllStates()
        {
            string spname = "[sp_fetch_tblstates]{0}";
            object[] parameters = { 0 };
            return staterepo.ExecuteQuery(spname, parameters);
        }

        public sp_fetch_tblstates_Result GetState(int state_id)
        {
            string spname = "[sp_fetch_tblstates]{0}";
            object[] parameters = { state_id };
            return staterepo.ExecuteQuery(spname, parameters).First();
        }

        public void RestoreState(sp_fetch_tblstates_Result state)
        {
            string spname = "[sp_tblstates]{0},{1},{2}";
            object[] parameters = { "Restore", state.state_id, state.state_name };
            staterepo.ExecuteCommand(spname, parameters);
        }

        public void UpdateState(sp_fetch_tblstates_Result state)
        {
            string spname = "[sp_tblstates]{0},{1},{2}";
            object[] parameters = { "Update", state.state_id, state.state_name };
            staterepo.ExecuteCommand(spname, parameters);
        }
    }
}
