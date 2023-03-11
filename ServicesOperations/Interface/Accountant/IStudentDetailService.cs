using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;

namespace ServicesOperations.Interface.Accountant
{
    public interface IStudentDetailService
    {
        void AddStudentDetails(tblstudent_details studentdetail);
        void UpdateStudentDetails(tblstudent_details studentdetail);
        void DeleteStudentDetails(int  studentdetail_id);
        List<tblstudent_details> GetAllStudentDetails();
        tblstudent_details GetStudentDetails(int studentdetail_id);
    }
}
