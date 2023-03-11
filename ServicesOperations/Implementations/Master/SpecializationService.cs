using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;
using ServicesOperations.Interface;

namespace ServicesOperations.Implementations
{
    public class SpecializationService : ISpecializationService
    {
        
        private IRepository<sp_fetch_tblspecializations_Result> specializationservice;

        public SpecializationService(IRepository<sp_fetch_tblspecializations_Result> specializationservice)
        {
            this.specializationservice = specializationservice;
        }

        public void AddSpecialization(sp_fetch_tblspecializations_Result specialization)
        {
            string spname = "[sp_tblspecialization]]{0},{1},{2}, {3}";
            object[] parameters = { "Insert", specialization.specialization_id, specialization.specialization_name, specialization.qualification_id  };
            specializationservice.ExecuteCommand(spname, parameters);
        }

        public void DeleteSpecialization(sp_fetch_tblspecializations_Result specialization)
        {
            string spname = "[sp_tblspecialization]{0},{1},{2},{3}";
            object[] parameters = { "Delete", specialization.specialization_id, specialization.specialization_name, specialization.qualification_id };
            specializationservice.ExecuteCommand(spname, parameters);
        }

        public List<sp_fetch_tblspecializations_Result> GetAllSpecializations()
        {
            string spname = "[sp_fetch_tblspecializations]{0}";
            object[] parameters = { 0 };
            return specializationservice.ExecuteQuery(spname, parameters);
        }
 
        public sp_fetch_tblspecializations_Result GetSpecialization(int specialization)
        {
            string spname = "[sp_fetch_tblspecializations]{0}";
            object[] parameters = { specialization};
            return specializationservice.ExecuteQuery(spname, parameters).First();
        }

        public void RestoreSpecialization(sp_fetch_tblspecializations_Result specialization)
        {
            string spname = "[sp_tblspecialization]{0},{1},{2},{3}";
            object[] parameters = { "Restore", specialization.specialization_id, specialization.specialization_name, specialization.qualification_id  };
            specializationservice.ExecuteCommand(spname, parameters);
        }

        public void UpdateSpecialization(sp_fetch_tblspecializations_Result specialization)
        {
            string spname = "[sp_tblspecialization]{0},{1},{2},{3}";
            object[] parameters = { "Update", specialization.specialization_id, specialization.specialization_name, specialization.qualification_id};
            specializationservice.ExecuteCommand(spname, parameters);
        }
    }
}
