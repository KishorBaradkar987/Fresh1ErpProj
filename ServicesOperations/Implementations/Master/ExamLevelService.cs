using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;
using ServicesOperations.Interface.Master;

namespace ServicesOperations.Implementations.Master
{
    public class ExamLevelService : IExamLevelService
    {
        private IRepository<sp_fetch_tblexam_level_Result> examlevelrepo;

        public ExamLevelService(IRepository<sp_fetch_tblexam_level_Result> examlevelrepo)
        {
            this.examlevelrepo = examlevelrepo;
        }

        public void AddExamLevel(sp_fetch_tblexam_level_Result examlevel)
        {
            string spname = "[sp_tblexam_levels]{0},{1},{2}";
            object[] parameters = { "Insert", examlevel.level_id, examlevel.level_name };
            examlevelrepo.ExecuteCommand(spname, parameters);
        }

        public void DeleteExamLevel(sp_fetch_tblexam_level_Result examlevel)
        {
            string spname = "[sp_tblexam_levels]{0},{1},{2}";
            object[] parameters = { "Delete", examlevel.level_id, examlevel.level_name };
            examlevelrepo.ExecuteCommand(spname, parameters);
        }

        public List<sp_fetch_tblexam_level_Result> GetAllExamLevels()
        {
            string spname = "[sp_fetch_tblexam_level]{0}";
            object[] parameters = { 0 };
            return examlevelrepo.ExecuteQuery(spname, parameters);
        }

        public sp_fetch_tblexam_level_Result GetExamLevel(int examlevel_id)
        {
            string spname = "[sp_fetch_tblexam_level]{0}";
            object[] parameters = { examlevel_id };
            return examlevelrepo.ExecuteQuery(spname, parameters).First();
        }

        public void RestoreExamLevel(sp_fetch_tblexam_level_Result examlevel)
        {
            string spname = "[sp_tblexam_levels]{0},{1},{2}";
            object[] parameters = { "Restore", examlevel.level_id, examlevel.level_name };
            examlevelrepo.ExecuteCommand(spname, parameters);
        }

        public void UpdateExamLevel(sp_fetch_tblexam_level_Result examlevel)
        {
            string spname = "[sp_tblexam_levels]{0},{1},{2}";
            object[] parameters = { "Update", examlevel.level_id, examlevel.level_name };
            examlevelrepo.ExecuteCommand(spname, parameters);
        }
    }
}
