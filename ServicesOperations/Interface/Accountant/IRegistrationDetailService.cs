using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;

namespace ServicesOperations.Interface.Accountant
{
    public interface IRegistrationDetailService
    {
        void AddRegistrationDetail(tblstudent_registration_details registration);
        void UpdateRegistrationDetail(tblstudent_registration_details registration);
        void DeleteRegistrationDetail(int registration_id);
        List<tblstudent_registration_details> GetAllRegistrationDetails();
        tblstudent_registration_details GetRegistrationDetail(int registration_id);
    }
}
