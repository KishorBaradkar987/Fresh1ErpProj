using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;
using ServicesOperations.Interface.Master;

namespace ServicesOperations.Implementations.Master
{
    public class FeeModeService : IFeeModeService
    {
        private IRepository<sp_fetch_tblfee_modes_Result> feemoderepo;

        public FeeModeService(IRepository<sp_fetch_tblfee_modes_Result> feemoderepo)
        {
            this.feemoderepo = feemoderepo;
        }

        public void AddFeeMode(sp_fetch_tblfee_modes_Result feemode)
        {
            string spname = "[sp_tblfee_modes]{0},{1},{2}";
            object[] parameters = { "Insert", feemode.fee_mode_id, feemode.fee_mode };
            feemoderepo.ExecuteCommand(spname, parameters);
        }

        public void DeleteFeeMode(sp_fetch_tblfee_modes_Result feemode)
        {
            string spname = "[sp_tblfee_modes]{0},{1},{2}";
            object[] parameters = { "Delete", feemode.fee_mode_id, feemode.fee_mode };
            feemoderepo.ExecuteCommand(spname, parameters);
        }

        public List<sp_fetch_tblfee_modes_Result> GetAllFeeModes()
        {
            string spname = "[sp_fetch_tblfee_modes]{0}";
            object[] parameters = { 0 };
            return feemoderepo.ExecuteQuery(spname, parameters);
        }

        public sp_fetch_tblfee_modes_Result GetFeeMode(int feemode_id)
        {
            string spname = "[sp_fetch_tblfee_modes]{0}";
            object[] parameters = { feemode_id };
            return feemoderepo.ExecuteQuery(spname, parameters).First();
        }

        public void RestoreFeeMode(sp_fetch_tblfee_modes_Result feemode)
        {
            string spname = "[sp_tblfee_modes]{0},{1},{2}";
            object[] parameters = { "Restore", feemode.fee_mode_id, feemode.fee_mode };
            feemoderepo.ExecuteCommand(spname, parameters);
        }

        public void UpdateFeeMode(sp_fetch_tblfee_modes_Result feemode)
        {
            string spname = "[sp_tblfee_modes]{0},{1},{2}";
            object[] parameters = { "Update", feemode.fee_mode_id, feemode.fee_mode };
            feemoderepo.ExecuteCommand(spname, parameters);
        }
    }
}
