using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;
using ServicesOperations.Interface;

namespace ServicesOperations.Implementations
{
        public class QualificationService : IQualificationService
        {
            private IRepository<sp_fetch_tblqualifications_Result> qualificationrepo;

            public QualificationService(IRepository<sp_fetch_tblqualifications_Result> qualificationrepo)
            {
                this.qualificationrepo = qualificationrepo;
            }

            public void AddQualification(sp_fetch_tblqualifications_Result qualification)
            {
                string spname = "[sp_tblqualifications]{0},{1},{2}";
                object[] parameters = { "Insert", qualification.qualification_id, qualification.qualification_name };
                qualificationrepo.ExecuteCommand(spname, parameters);
            }

            public void DeleteQualification(sp_fetch_tblqualifications_Result qualification)
            {
                string spname = "[sp_tblqualifications]{0},{1},{2}";
                object[] parameters = { "Delete", qualification.qualification_id, qualification.qualification_name };
                qualificationrepo.ExecuteCommand(spname, parameters);
            }

            public List<sp_fetch_tblqualifications_Result> GetAllQualifications()
            {
                string spname = "[sp_fetch_tblqualifications]{0}";
                object[] parameters = { 0 };
                return qualificationrepo.ExecuteQuery(spname, parameters);
            }

            public sp_fetch_tblqualifications_Result GetQualification(int qualification_id)
            {
                string spname = "[sp_fetch_tblqualifications]{0}";
                object[] parameters = { qualification_id };
                return qualificationrepo.ExecuteQuery(spname, parameters).First();
            }

            public void RestoreQualification(sp_fetch_tblqualifications_Result qualification)
            {
                string spname = "[sp_tblqualifications]{0},{1},{2}";
                object[] parameters = { "Restore", qualification.qualification_id, qualification.qualification_name };
                qualificationrepo.ExecuteCommand(spname, parameters);
            }

            public void UpdateQualification(sp_fetch_tblqualifications_Result qualification)
            {
                string spname = "[sp_tblqualifications]{0},{1},{2}";
                object[] parameters = { "Update", qualification.qualification_id, qualification.qualification_name };
                qualificationrepo.ExecuteCommand(spname, parameters);
            }
            
            
        }
    }
