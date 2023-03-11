using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;

namespace ServicesOperations.Interface.Developer
{
    public interface ICourseFeeService
    {
        void AddCourseFee(sp_fetch_tblcourse_fees_Result coursefee);
        void UpdateCourseFee(sp_fetch_tblcourse_fees_Result coursefee);
        void DeleteCourseFee(sp_fetch_tblcourse_fees_Result coursefee);
        List<sp_fetch_tblcourse_fees_Result> GetAllCourseFees();
        sp_fetch_tblcourse_fees_Result GetCourseFee(int course_id);
        void RestoreCourseFee(sp_fetch_tblcourse_fees_Result coursefee);
    }
}
