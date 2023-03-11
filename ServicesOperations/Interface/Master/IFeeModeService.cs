using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;

namespace ServicesOperations.Interface.Master
{
    public interface IFeeModeService
    {
        void AddFeeMode(sp_fetch_tblfee_modes_Result feemode);
        void UpdateFeeMode(sp_fetch_tblfee_modes_Result feemode);
        void DeleteFeeMode(sp_fetch_tblfee_modes_Result feemode);
        List<sp_fetch_tblfee_modes_Result> GetAllFeeModes();
        sp_fetch_tblfee_modes_Result GetFeeMode(int feemode_id);
        void RestoreFeeMode(sp_fetch_tblfee_modes_Result feemode);
    }
}
