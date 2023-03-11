using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;

namespace ServicesOperations.Interface.Master
{
    public interface IExamLevelService
    {
        void AddExamLevel(sp_fetch_tblexam_level_Result examlevel);
        void UpdateExamLevel(sp_fetch_tblexam_level_Result examlevel);
        void DeleteExamLevel(sp_fetch_tblexam_level_Result examlevel);
        List<sp_fetch_tblexam_level_Result> GetAllExamLevels();
        sp_fetch_tblexam_level_Result GetExamLevel(int examlevel_id);
        void RestoreExamLevel(sp_fetch_tblexam_level_Result examlevel);
    }
}
