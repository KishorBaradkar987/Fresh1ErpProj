using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;
using ServicesOperations.Interface.Accountant;

namespace ServicesOperations.Implementations.Accountant
{
    public class RegistrationDetailService : IRegistrationDetailService
    {
        ITable<tblstudent_registration_details> regisrepo;

        public RegistrationDetailService(ITable<tblstudent_registration_details> regisrepo)
        {
            this.regisrepo = regisrepo;
        }

        public void AddRegistrationDetail(tblstudent_registration_details registration)
        {
            regisrepo.create(registration);
        }

        public void DeleteRegistrationDetail(int registration_id)
        {
            regisrepo.delete(registration_id);
        }

        public List<tblstudent_registration_details> GetAllRegistrationDetails()
        {
            return regisrepo.GetAll();
        }

        public tblstudent_registration_details GetRegistrationDetail(int registration_id)
        {
            return regisrepo.GetById(registration_id);
        }

        public void UpdateRegistrationDetail(tblstudent_registration_details registration)
        {
            regisrepo.update(registration);
        }
    }
}
