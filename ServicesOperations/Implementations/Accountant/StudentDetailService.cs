using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;
using ServicesOperations.Interface.Accountant;

namespace ServicesOperations.Implementations.Accountant
{
    public class StudentDetailService : IStudentDetailService
    {
        ITable<tblstudent_details> studentrepo;

        public StudentDetailService(ITable<tblstudent_details> studentrepo)
        {
            this.studentrepo = studentrepo;
        }

        public void AddStudentDetails(tblstudent_details studentdetail)
        {
            studentrepo.create(studentdetail);
        }

        public void DeleteStudentDetails(int studentdetail_id)
        {
            studentrepo.delete(studentdetail_id);
        }

        public List<tblstudent_details> GetAllStudentDetails()
        {
            return studentrepo.GetAll();
        }

        public tblstudent_details GetStudentDetails(int studentdetail_id)
        {
            return studentrepo.GetById(studentdetail_id);
        }

        public void UpdateStudentDetails(tblstudent_details studentdetail)
        {
            studentrepo.update(studentdetail);
        }
    }
}
