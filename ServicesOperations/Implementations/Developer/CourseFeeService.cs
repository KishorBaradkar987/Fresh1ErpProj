using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;
using ServicesOperations.Interface.Developer;

namespace ServicesOperations.Implementations.Developer
{
    public class CourseFeeService : ICourseFeeService
    {
        private IRepository<sp_fetch_tblcourse_fees_Result> cfrepo;

        public CourseFeeService(IRepository<sp_fetch_tblcourse_fees_Result> cfrepo)
        {
            this.cfrepo = cfrepo;
        }

        public void AddCourseFee(sp_fetch_tblcourse_fees_Result coursefee)
        {
            string spname = "[sp_tblcourse_fees]{0},{1},{2},{3},{4},{5}";
            object[] parameters = { "Insert", coursefee.course_fee_id, coursefee.course_id, coursefee.fee_mode_id, coursefee.amount, coursefee.tax };
            cfrepo.ExecuteCommand(spname, parameters);
        }
   

        public void DeleteCourseFee(sp_fetch_tblcourse_fees_Result coursefee)
        {
            string spname = "[sp_tblcourse_fees]{0},{1},{2},{3},{4},{5}";
            object[] parameters = { "Delete", coursefee.course_fee_id, coursefee.course_id, coursefee.fee_mode_id, coursefee.amount, coursefee.tax };
            cfrepo.ExecuteCommand(spname, parameters);
        }

        public List<sp_fetch_tblcourse_fees_Result> GetAllCourseFees()
        {
            string spname = "[sp_fetch_tblcourse_fees]{0}";
            object[] parameters = { 0 };
            return cfrepo.ExecuteQuery(spname, parameters);
        }

        public sp_fetch_tblcourse_fees_Result GetCourseFee(int course_id)
        {
            string spname = "[sp_fetch_tblcourse_fees]{0}";
            object[] parameters = { course_id };
            return cfrepo.ExecuteQuery(spname, parameters).First();
        }

        public void RestoreCourseFee(sp_fetch_tblcourse_fees_Result coursefee)
        {
            string spname = "[sp_tblcourse_fees]{0},{1},{2},{3},{4},{5}";
            object[] parameters = { "Restore", coursefee.course_fee_id, coursefee.course_id, coursefee.fee_mode_id, coursefee.amount, coursefee.tax };
            cfrepo.ExecuteCommand(spname, parameters);
        }

        public void UpdateCourseFee(sp_fetch_tblcourse_fees_Result coursefee)
        {
            string spname = "[sp_tblcourse_fees]{0},{1},{2},{4},{5}";
            object[] parameters = { "Update", coursefee.course_fee_id, coursefee.course_id, coursefee.fee_mode_id, coursefee.amount, coursefee.tax };
            cfrepo.ExecuteCommand(spname, parameters);
        }
    }
}

