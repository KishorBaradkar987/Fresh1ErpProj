using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;

namespace ServicesOperations.Interface
{
    public interface ISpecializationService
    {
        void AddSpecialization(sp_fetch_tblspecializations_Result specialization);
        void UpdateSpecialization(sp_fetch_tblspecializations_Result specialization);
        void DeleteSpecialization(sp_fetch_tblspecializations_Result specialization);
        List<sp_fetch_tblspecializations_Result> GetAllSpecializations();
        sp_fetch_tblspecializations_Result GetSpecialization(int specialization);
        void RestoreSpecialization(sp_fetch_tblspecializations_Result specialization);
    }
}
