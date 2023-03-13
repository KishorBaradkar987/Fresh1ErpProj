using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;

namespace ServicesOperations.Interface.Branch
{
    public interface IEmployeeDetailsService
    {
        void AddEmployeeDetail(sp_fetch_tblemployee_details_Result employee);
        void UpdateEmployeeDetail(sp_fetch_tblemployee_details_Result employee);
        void DeleteEmployeeDetail(sp_fetch_tblemployee_details_Result employee);
        List<sp_fetch_tblemployee_details_Result> GetAllEmployeeDetails();
        sp_fetch_tblemployee_details_Result GetEmployeeDetail(int employee_id);
        void RestoreEmployeeDetail(sp_fetch_tblemployee_details_Result employee);
    }
}
