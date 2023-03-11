using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;
using ServicesOperations.Interface.Master;

namespace ServicesOperations.Implementations.Master
{
    public class DesignationService : IDesignationService
    {
        private IRepository<sp_fetch_tbldesignations_Result> designationrepo;

        public DesignationService(IRepository<sp_fetch_tbldesignations_Result> designationrepo)
        {
            this.designationrepo = designationrepo;
        }

        public void AddDesignation(sp_fetch_tbldesignations_Result designation)
        {
            string spname = "[sp_tbldesignations]{0},{1},{2}";
            object[] parameters = { "Insert", designation.designation_id, designation.designation_name };
            designationrepo.ExecuteCommand(spname, parameters);
        }

        public void DeleteDesignation(sp_fetch_tbldesignations_Result designation)
        {
            string spname = "[sp_tbldesignations]{0},{1},{2}";
            object[] parameters = { "Delete", designation.designation_id, designation.designation_name };
            designationrepo.ExecuteCommand(spname, parameters);
        }

        public List<sp_fetch_tbldesignations_Result> GetAllDesignations()
        {
            string spname = "[sp_fetch_tbldesignations]{0}";
            object[] parameters = { 0 };
            return designationrepo.ExecuteQuery(spname, parameters);
        }

        public sp_fetch_tbldesignations_Result GetDesignation(int designation_id)
        {
            string spname = "[sp_fetch_tbldesignations]{0}";
            object[] parameters = { designation_id };
            return designationrepo.ExecuteQuery(spname, parameters).First();
        }

        public void RestoreDesignation(sp_fetch_tbldesignations_Result designation)
        {
            string spname = "[sp_tbldesignations]{0},{1},{2}";
            object[] parameters = { "Restore", designation.designation_id, designation.designation_name };
            designationrepo.ExecuteCommand(spname, parameters);
        }

        public void UpdateDesignation(sp_fetch_tbldesignations_Result designation)
        {
            string spname = "[sp_tbldesignations]{0},{1},{2}";
            object[] parameters = { "Update", designation.designation_id, designation.designation_name };
            designationrepo.ExecuteCommand(spname, parameters);
        }
    }
}
