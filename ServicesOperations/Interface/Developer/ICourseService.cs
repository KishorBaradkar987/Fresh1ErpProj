using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseOpworks;

namespace ServicesOperations.Interface.Developer
{
    public interface ICourseService
    {
        void AddCourse(sp_fetch_tbltrainingcourses_Result course);
        void UpdateCourse(sp_fetch_tbltrainingcourses_Result course);
        void DeleteCourse(sp_fetch_tbltrainingcourses_Result course);
        List<sp_fetch_tbltrainingcourses_Result> GetAllCourses();
        sp_fetch_tbltrainingcourses_Result GetCourse(int course_id);
        void RestoreCourse(sp_fetch_tbltrainingcourses_Result course);
    }
}
