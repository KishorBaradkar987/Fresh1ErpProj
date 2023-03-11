using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DatabaseOpworks;
using ServicesOperations.Interface.Accountant;
using ServicesOperations.Implementations.Accountant;

namespace Fresh1ErpProj.Controllers
{
    public class AccountantApiController : ApiController
    {
        IStudentDetailService studentservice;
        IStudentQualificationService qualificationservice;
        IRegistrationDetailService registrationservice;
        IPaymentDetailService paymentservice;

        public AccountantApiController(IStudentDetailService studentservice,IStudentQualificationService qualificationservice, IRegistrationDetailService registrationservice, IPaymentDetailService paymentservice)
        {
            this.studentservice = studentservice;
            this.qualificationservice = qualificationservice;
            this.registrationservice = registrationservice;
            this.paymentservice = paymentservice;
        }

        //-----------------------------------------------Student Detail Apis-------------------------------------------//

        [HttpGet]
        [Route("api/StudentDetails")]
        public List<tblstudent_details> GetAllStudentDetails()
        {
            return studentservice.GetAllStudentDetails();
        }

        [HttpGet]
        [Route("api/StudentDetails/{id}")]
        public tblstudent_details GetStudentDetailsById(int id)
        {
            return studentservice.GetStudentDetails(id);
        }

        [HttpPost]
        [Route("api/StudentDetails")]
        public string AddDetails(tblstudent_details student)
        {
            studentservice.AddStudentDetails(student);
            return "Student Details Added Successfully";
        }

        [HttpPut]
        [Route("api/StudentDetails")]
        public string UpdateDetails(tblstudent_details student)
        {
            studentservice.UpdateStudentDetails(student);
            return "Student Details Updated Successfully";
        }

        [HttpDelete]
        [Route("api/deleteStudentDetails/{id}")]
        public string DeleteDetails(int id)
        {
            studentservice.DeleteStudentDetails(id);
            return "Student Details Delated Successfully";
        }

        //-----------------------------------------------Student Qualification--------------------------------------------//

        [HttpGet]
        [Route("api/StudentQualification")]
        public List<tblstudent_qualifications> GetAllStudentQualifications()
        {
            return qualificationservice.GetAllStudentQualifications();
        }

        [HttpGet]
        [Route("api/StudentQualification/{id}")]
        public tblstudent_qualifications GetStudentQualificationById(int id)
        {
            return qualificationservice.GetStudentQualification(id);
        }

        [HttpPost]
        [Route("api/StudentQualification")]
        public string AddStudentQualification(tblstudent_qualifications qualification)
        {
            qualificationservice.AddStudentQualification(qualification);
            return "Student Qualification Added Successfully";
        }

        [HttpPut]
        [Route("api/StudentQualification")]
        public string UpdateStudentQualification(tblstudent_qualifications qualification)
        {
            qualificationservice.UpdateStudentQualification(qualification);
            return "Student Qualification Updated Successfully";
        }

        [HttpDelete]
        [Route("api/deleteStudentQualification/{id}")]
        public string DeleteStudentQualification(int id)
        {
            qualificationservice.DeleteStudentQualification(id);
            return "Student Qualification Deleted Successfully";
        }

        //----------------------------------------------------Student Registration Apis------------------------------------------//

        [HttpGet]
        [Route("api/StudentRegistration")]
        public List<tblstudent_registration_details> GetAllStudentRegistrations()
        {
            return registrationservice.GetAllRegistrationDetails();
        }

        [HttpGet]
        [Route("api/StudentRegistration/{id}")]
        public tblstudent_registration_details GetStudentRegistrationById(int id)
        {
            return registrationservice.GetRegistrationDetail(id);
        }

        [HttpPost]
        [Route("api/StudentRegistration")]
        public string AddStudentRegistration(tblstudent_registration_details registration)
        {
            registrationservice.AddRegistrationDetail(registration);
            return "Student Qualification Added Successfully";
        }

        [HttpPut]
        [Route("api/StudentRegistration")]
        public string UpdateStudentRegistrationn(tblstudent_registration_details registration)
        {
            registrationservice.UpdateRegistrationDetail(registration);
            return "Student Registration Updated Successfully";
        }

        [HttpDelete]
        [Route("api/deleteStudentRegistration/{id}")]
        public string DeleteStudentRegistration(int id)
        {
            registrationservice.DeleteRegistrationDetail(id);
            return "Student Registration Deleted Successfully";
        }

        //-------------------------------------------------------Payment Apis----------------------------------------------//

        [HttpGet]
        [Route("api/PaymentDetail")]
        public List<tblstudent_payment_details> GetAllPaymentDetails()
        {
            return paymentservice.GetAllPaymentDetails();   
        }

        [HttpGet]
        [Route("api/PaymentDetail/{id}")]
        public tblstudent_payment_details GetPaymentDetailById(int id)
        {
            return paymentservice.GetPaymentDetail(id);
        }

        [HttpPost]
        [Route("api/PaymentDetail")]
        public string AddPaymentDetail(tblstudent_payment_details payment)
        {
            paymentservice.AddPaymentDetail(payment);
            return "Payment Detail Added Successfully";
        }

        [HttpPut]
        [Route("api/PaymentDetail")]
        public string UpdatePaymentDetail(tblstudent_payment_details payment)
        {
            paymentservice.UpdatePaymentDetail(payment);
            return "Payment Detail Updated Successfully";
        }

        [HttpDelete]
        [Route("api/deletePaymentDetail/{id}")]
        public string DeletePaymentDetail(int id)
        {
            paymentservice.DeletePaymentDetail(id);
            return "Payment Detail Deleted Successfully";
        }
    }
}
