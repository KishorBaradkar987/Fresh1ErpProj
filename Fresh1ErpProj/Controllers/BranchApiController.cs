using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DatabaseOpworks;
using ServicesOperations.Interface.Branch;
using ServicesOperations.Implementations.Branch;

namespace Fresh1ErpProj.Controllers
{
    public class BranchApiController : ApiController
    {
        private IEmployeeDetailsService employeeservice;
        private ICenterDetailsService centerservice;

        public BranchApiController(IEmployeeDetailsService employeeservice, ICenterDetailsService centerservice)
        {
            this.employeeservice = employeeservice;
            this.centerservice = centerservice;
        }

        //-------------------------------------------------Employee Detail Servie------------------------------------------------//


        [HttpGet]
        [Route("api/employee")]
        public List<sp_fetch_tblemployee_details_Result> GetallEmployeeDetails()
        {
            return employeeservice.GetAllEmployeeDetails();
        }

        [HttpGet]
        [Route("api/employee/{id}")]
        public sp_fetch_tblemployee_details_Result GetEmployeeDetail(int id)
        {
            return employeeservice.GetEmployeeDetail(id);
        }

        [HttpPost]
        [Route("api/employee")]
        public string AddEmployeeDetail(sp_fetch_tblemployee_details_Result employee)
        {
            employeeservice.AddEmployeeDetail(employee);
            return "Employee Detail Added Successfully";
        }

        [HttpPut]
        [Route("api/employee")]
        public string UpdateEmployeeDetail(sp_fetch_tblemployee_details_Result employee)
        {
            employeeservice.UpdateEmployeeDetail(employee);
            return "Employee Detail Updated Successfully";
        }

        [HttpDelete]
        [Route("api/deleteemployee/{id}")]
        public string DeleteEmployeeDetail(int id)
        {
            sp_fetch_tblemployee_details_Result q = new sp_fetch_tblemployee_details_Result()
            {
                employee_id = id
            };
            employeeservice.DeleteEmployeeDetail(q);    
            return "Employee Detail Deleted Successfully";
        }

        [HttpDelete]
        [Route("api/restoreemployee/{id}")]
        public string RestoreEmployeeDetail(int id)
        {
            sp_fetch_tblemployee_details_Result q = new sp_fetch_tblemployee_details_Result()
            {
                employee_id = id
            };
            employeeservice.RestoreEmployeeDetail(q);
            return "Employee Detail Restored Successfully";
        }

        //---------------------------------------------Center Details Apis------------------------------------------------------//

        [HttpGet]
        [Route("api/center")]
        public List<sp_fetch_tblcenter_details_Result> GetallCenterDetails()
        {
            return centerservice.GetAllCenterDetails();
        }
        [HttpGet]
        [Route("api/center/{id}")]
        public sp_fetch_tblcenter_details_Result GetCenterDetails(int id)
        {
            return centerservice.GetCenterDetail(id);
        }
        [HttpPost]
        [Route("api/center")]
        public string AddCenterDetails(sp_fetch_tblcenter_details_Result center)
        {
            centerservice.AddCenterDetail(center);
            return "Center Detail Added Successfully";
        }

        [HttpPut]
        [Route("api/center")]
        public string UpdateCenterDetails(sp_fetch_tblcenter_details_Result center)
        {
           centerservice.UpdateCenterDetail(center);
            return "Center Detail Updated Successfully";
        }

        [HttpDelete]
        [Route("api/deletecenter/{id}")]
        public string DeleteCenterDetails(int id)
        {
            sp_fetch_tblcenter_details_Result s = new sp_fetch_tblcenter_details_Result()
            {
                center_id = id
            };
            centerservice.DeleteCenterDetail(s);
            return "Center Detail Deleted Successfully";
        }

        [HttpDelete]
        [Route("api/restorecenter/{id}")]
        public string RestoreCenterDetails(int id)
        {
            sp_fetch_tblcenter_details_Result s = new sp_fetch_tblcenter_details_Result()
            {
                center_id = id
            };
            centerservice.RestoreCenterDetail(s);
            return "Center Detail Restored Successfully";
        }
    }
}
