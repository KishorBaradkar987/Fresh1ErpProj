using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;

namespace ServicesOperations.Interface.Accountant
{
    public interface IStudentQualificationService
    {
        void AddStudentQualification(tblstudent_qualifications qualification);
        void UpdateStudentQualification(tblstudent_qualifications qualification);
        void DeleteStudentQualification(int qualification_id);
        List<tblstudent_qualifications> GetAllStudentQualifications();
        tblstudent_qualifications GetStudentQualification(int qualification_id);
    }
}
