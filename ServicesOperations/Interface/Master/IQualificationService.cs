using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;

namespace ServicesOperations.Interface
{
    public interface IQualificationService
    {
        void AddQualification(sp_fetch_tblqualifications_Result qualification);
        void UpdateQualification(sp_fetch_tblqualifications_Result qualification);
        void DeleteQualification(sp_fetch_tblqualifications_Result qualification);
        List<sp_fetch_tblqualifications_Result> GetAllQualifications();
        sp_fetch_tblqualifications_Result GetQualification(int qualification_id);
        void RestoreQualification(sp_fetch_tblqualifications_Result qualification);
    }
}
