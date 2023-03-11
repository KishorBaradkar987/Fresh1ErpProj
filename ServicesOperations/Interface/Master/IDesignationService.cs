using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;

namespace ServicesOperations.Interface.Master
{
    public interface IDesignationService
    {
        void AddDesignation(sp_fetch_tbldesignations_Result designation);
        void UpdateDesignation(sp_fetch_tbldesignations_Result designation);
        void DeleteDesignation(sp_fetch_tbldesignations_Result designation);
        List<sp_fetch_tbldesignations_Result> GetAllDesignations();
        sp_fetch_tbldesignations_Result GetDesignation(int designation_id);
        void RestoreDesignation(sp_fetch_tbldesignations_Result designation);
    }
}
