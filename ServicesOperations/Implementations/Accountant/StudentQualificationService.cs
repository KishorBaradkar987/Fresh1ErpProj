using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;
using ServicesOperations.Interface.Accountant;

namespace ServicesOperations.Implementations.Accountant
{
    public class StudentQualificationService : IStudentQualificationService
    {
        ITable<tblstudent_qualifications> qualrepo;

        public StudentQualificationService(ITable<tblstudent_qualifications> qualrepo)
        {
            this.qualrepo = qualrepo;
        }

        public void AddStudentQualification(tblstudent_qualifications qualification)
        {
            qualrepo.create(qualification);
        }

        public void DeleteStudentQualification(int qualification_id)
        {
            qualrepo.delete(qualification_id);
        }

        public List<tblstudent_qualifications> GetAllStudentQualifications()
        {
            return qualrepo.GetAll();
        }

        public tblstudent_qualifications GetStudentQualification(int qualification_id)
        {
            return qualrepo.GetById(qualification_id);
        }

        public void UpdateStudentQualification(tblstudent_qualifications qualification)
        {
            qualrepo.update(qualification);
        }
    }
}
