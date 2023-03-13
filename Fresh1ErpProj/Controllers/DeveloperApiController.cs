using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DatabaseOpworks;
using ServicesOperations.Interface.Developer;
using ServicesOperations.Implementations.Developer;

namespace Fresh1ErpProj.Controllers
{
    public class DeveloperApiController : ApiController
    {
        private ICourseService courseService;
        private ICourseFeeService courseFeeService;

        public DeveloperApiController(ICourseService courseService, ICourseFeeService courseFeeService)
        {
            this.courseService = courseService;
            this.courseFeeService = courseFeeService;
        }

        //--------------------------------------------------Course Apis--------------------------------------------------------//
        [HttpGet]
        [Route("api/course")]
        public List<sp_fetch_tbltrainingcourses_Result> GetallCourses()
        {
            return  courseService.GetAllCourses();
        }

        [HttpGet]
        [Route("api/course/{id}")]
        public sp_fetch_tbltrainingcourses_Result GetCourse(int id)
        {
            return courseService.GetCourse(id);
        }

        [HttpPost]
        [Route("api/course")]
        public string AddCourse(sp_fetch_tbltrainingcourses_Result course)
        {
            courseService.AddCourse(course);
            return "Course Added Successfully";
        }

        [HttpPut]
        [Route("api/course")]
        public string UpdateQualification(sp_fetch_tbltrainingcourses_Result course)
        {
            courseService.UpdateCourse(course);
            return "Course Updated Successfully";
        }

        [HttpDelete]
        [Route("api/deletecourse/{id}")]
        public string DeleteCourse(int id)
        {
            sp_fetch_tbltrainingcourses_Result q = new sp_fetch_tbltrainingcourses_Result()
            {
                course_id = id
            };
            courseService.DeleteCourse(q);
            return "Course Deleted Successfully";
        }

        [HttpDelete]
        [Route("api/restorecourse/{id}")]
        public string RestoreCourse(int id)
        {
            sp_fetch_tbltrainingcourses_Result q = new sp_fetch_tbltrainingcourses_Result()
            {
                course_id = id
            };
            courseService.RestoreCourse(q);
            return "Course Restored Successfully";
        }

        //-------------------------------------------------Course Fees Apis-----------------------------------------------------//

        [HttpGet]
        [Route("api/coursefee")]
        public List<sp_fetch_tblcourse_fees_Result> GetallCourseFees()
        {
            return courseFeeService.GetAllCourseFees();
        }

        [HttpGet]
        [Route("api/coursefee/{id}")]
        public sp_fetch_tblcourse_fees_Result GetCourseFee(int id)
        {
            return courseFeeService.GetCourseFee(id);
        }

        [HttpPost]
        [Route("api/coursefee")]
        public string AddCourseFee(sp_fetch_tblcourse_fees_Result coursefee)
        {
            courseFeeService.AddCourseFee(coursefee);
            return "Course Fee Added Successfully";
        }

        [HttpPut]
        [Route("api/coursefee")]
        public string UpdateCourseFee(sp_fetch_tblcourse_fees_Result coursefee)
        {
            courseFeeService.UpdateCourseFee(coursefee);
            return "Course Fee Updated Successfully";
        }

        [HttpDelete]
        [Route("api/deletecoursefee/{id}")]
        public string DeleteCourseFee(int id)
        {
            sp_fetch_tblcourse_fees_Result q = new sp_fetch_tblcourse_fees_Result()
            {
                course_fee_id = id
            };
            courseFeeService.DeleteCourseFee(q);
            return "Course Fee Deleted Successfully";
        }

        [HttpDelete]
        [Route("api/restorecoursefee/{id}")]
        public string RestoreCourseFee(int id)
        {
            sp_fetch_tblcourse_fees_Result q = new sp_fetch_tblcourse_fees_Result()
            {
                course_fee_id = id
            };
            courseFeeService.RestoreCourseFee(q);
            return "Course Fee  Restored Successfully";
        }

        [HttpGet]
        [Route("api/GetAmountbycoursefee/{courseid}/{feemodeid}")]
        public List<sp_fetch_tblcourse_fees_Result> GetAmountbycoursefee(int courseid, int feemodeid)
        {
           
            return courseFeeService.GetAllCourseFees().Where(e=>e.course_id.Equals(courseid) && e.fee_mode_id.Equals(feemodeid)).ToList();
        }

    }
}
