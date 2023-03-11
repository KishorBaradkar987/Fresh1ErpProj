using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;
using ServicesOperations.Interface.Developer;

namespace ServicesOperations.Implementations.Developer
{
    public class CourseService : ICourseService
    {
        private IRepository<sp_fetch_tbltrainingcourses_Result> courserepo;

        public CourseService(IRepository<sp_fetch_tbltrainingcourses_Result> courserepo)
        {
            this.courserepo = courserepo;
        }

        public void AddCourse(sp_fetch_tbltrainingcourses_Result course)
        {
            string spname = "[sp_tbltrainingcourses]{0},{1},{2},{3},{4}";
            object[] parameters = { "Insert", course.course_id,course.course_name ,course.course_code, course.technology_id };
            courserepo.ExecuteCommand(spname, parameters);
        }

        public void DeleteCourse(sp_fetch_tbltrainingcourses_Result course)
        {
            string spname = "[sp_tbltrainingcourses]{0},{1},{2},{3},{4}";
            object[] parameters = { "Delete", course.course_id, course.course_name, course.course_code, course.technology_id };
            courserepo.ExecuteCommand(spname, parameters);
        }

        public List<sp_fetch_tbltrainingcourses_Result> GetAllCourses()
        {
            string spname = "[sp_fetch_tbltrainingcourses]{0}";
            object[] parameters = { 0 };
            return courserepo.ExecuteQuery(spname, parameters);
        }

        public sp_fetch_tbltrainingcourses_Result GetCourse(int course_id)
        {
            string spname = "[sp_fetch_tbltrainingcourses]{0}";
            object[] parameters = { course_id };
            return courserepo.ExecuteQuery(spname, parameters).First();
        }

        public void RestoreCourse(sp_fetch_tbltrainingcourses_Result course)
        {
            string spname = "[sp_tbltrainingcourses]{0},{1},{2},{3},{4}";
            object[] parameters = { "Restore", course.course_id, course.course_name, course.course_code, course.technology_id };
            courserepo.ExecuteCommand(spname, parameters);
        }

        public void UpdateCourse(sp_fetch_tbltrainingcourses_Result course)
        {
            string spname = "[sp_tbltrainingcourses]{0},{1},{2},{3},{4}";
            object[] parameters = { "Update", course.course_id, course.course_name, course.course_code, course.technology_id };
            courserepo.ExecuteCommand(spname, parameters);
        }
    }
}
