using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;
using ServicesOperations.Interface.Branch;

namespace ServicesOperations.Implementations.Branch
{
    public class EmployeeDetailsService : IEmployeeDetailsService
    {
        private IRepository<sp_fetch_tblemployee_details_Result> emprepo;

        public EmployeeDetailsService(IRepository<sp_fetch_tblemployee_details_Result> emprepo)
        {
            this.emprepo = emprepo;
        }

        public void AddEmployeeDetail(sp_fetch_tblemployee_details_Result employee)
        {
            string spname = "[sp_tblemployee_details]{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}";
            object[] parameters = { "Insert",employee.employee_id, employee.employee_code, employee.first_name, employee.middle_name, employee.last_name, employee.birth_date, employee.joining_date, employee.mobile_number, employee.email_address, employee.photo, employee.designation_id, employee.location_id, employee.permenant_address, employee.local_address, employee.center_id, employee.password };
            emprepo.ExecuteCommand(spname, parameters);
        }

        public void DeleteEmployeeDetail(sp_fetch_tblemployee_details_Result employee)
        {
            string spname = "[sp_tblemployee_details]{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}";
            object[] parameters = { "Delete", employee.employee_id, employee.employee_code, employee.first_name, employee.middle_name, employee.last_name, employee.birth_date, employee.joining_date, employee.mobile_number, employee.email_address, employee.photo, employee.designation_id, employee.location_id, employee.permenant_address, employee.local_address, employee.center_id, employee.password };
            emprepo.ExecuteCommand(spname, parameters);
        }

        public List<sp_fetch_tblemployee_details_Result> GetAllEmployeeDetails()
        {
            string spname = "[sp_fetch_tblemployee_details]{0}";
            object[] parameters = { 0 };
            return emprepo.ExecuteQuery(spname, parameters);
        }

        public sp_fetch_tblemployee_details_Result GetEmployeeDetail(int employee_id)
        {
            string spname = "[sp_fetch_tblemployee_details]{0}";
            object[] parameters = { employee_id };
            return emprepo.ExecuteQuery(spname, parameters).First();
        }

        public void RestoreEmployeeDetail(sp_fetch_tblemployee_details_Result employee)
        {
            string spname = "[sp_tblemployee_details]{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}";
            object[] parameters = { "Restore", employee.employee_id, employee.employee_code, employee.first_name, employee.middle_name, employee.last_name, employee.birth_date, employee.joining_date, employee.mobile_number, employee.email_address, employee.photo, employee.designation_id, employee.location_id, employee.permenant_address, employee.local_address, employee.center_id, employee.password };
            emprepo.ExecuteCommand(spname, parameters);
        }

        public void UpdateEmployeeDetail(sp_fetch_tblemployee_details_Result employee)
        {
            string spname = "[sp_tblemployee_details]{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16}";
            object[] parameters = { "Update", employee.employee_id, employee.employee_code, employee.first_name, employee.middle_name, employee.last_name, employee.birth_date, employee.joining_date, employee.mobile_number, employee.email_address, employee.photo, employee.designation_id, employee.location_id, employee.permenant_address, employee.local_address, employee.center_id, employee.password };
            emprepo.ExecuteCommand(spname, parameters);
        }
    }
}
