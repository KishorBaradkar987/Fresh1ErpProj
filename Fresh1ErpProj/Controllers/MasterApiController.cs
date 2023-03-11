using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DatabaseOpworks;
using ServicesOperations.Interface;
using ServicesOperations.Interface.Master;
using ServicesOperations.Implementations;

namespace Fresh1ErpProj.Controllers
{
    public class MasterApiController : ApiController
    {
        private IQualificationService qualificationservice;
        private ISpecializationService specializationservice;
        private IStateService stateservice;
        private ICityService cityservice;
        private ILocationService locationservice;
        private IFeeModeService feemodeservice;
        private ITechnologyService technologyservice;
        private IDesignationService designationservice;

        public MasterApiController(IQualificationService qualificationservice, ISpecializationService specializationservice, IStateService stateservice, ICityService cityservice,ILocationService locationservice, IFeeModeService feemodeservice, ITechnologyService technologyservice, IDesignationService designationservice)
        {
            this.qualificationservice = qualificationservice;
            this.specializationservice = specializationservice;
            this.stateservice = stateservice;
            this.cityservice = cityservice;
            this.locationservice = locationservice;
            this.feemodeservice = feemodeservice;
            this.technologyservice = technologyservice;
            this.designationservice = designationservice;
        }

        //-------------------------------------- Qualification Apis -------------------------------------------//

        [HttpGet]
        [Route("api/qualification")]
        public List<sp_fetch_tblqualifications_Result> GetallQualifications()
        {
            return qualificationservice.GetAllQualifications();
        }

        [HttpGet]
        [Route("api/qualification/{id}")]
        public sp_fetch_tblqualifications_Result GetQualification(int id)
        {
            return qualificationservice.GetQualification(id);
        }

        [HttpPost]
        [Route("api/qualification")]
        public string AddQualification(sp_fetch_tblqualifications_Result qualification)
        {
            qualificationservice.AddQualification(qualification);
            return "Qualification Added Successfully";
        }

        [HttpPut]
        [Route("api/qualification")]
        public string UpdateQualification(sp_fetch_tblqualifications_Result qualification)
        {
            qualificationservice.UpdateQualification(qualification);
            return "Qualification Updated Successfully";
        }

        [HttpDelete]
        [Route("api/qualification/{id}")]
        public string DeleteQualification(int id)
        {
            sp_fetch_tblqualifications_Result q = new sp_fetch_tblqualifications_Result()
            {
                qualification_id = id 
            };
            qualificationservice.DeleteQualification(q);
            return "Qualification Deleted Successfully";
        }

        [HttpDelete]
        [Route("api/restorequalification/{id}")]
        public string RestoreQualification(int id)
        {
            sp_fetch_tblqualifications_Result q = new sp_fetch_tblqualifications_Result()
            {
                qualification_id = id
            };
            qualificationservice.RestoreQualification(q);
            return "Qualification Restored Successfully";
        }

        //---------------------------------------- Specialization Apis -----------------------------------------//

        [HttpGet]
        [Route("api/specialization")]
        public List<sp_fetch_tblspecializations_Result> Getallspecializations()
        {
            return specializationservice.GetAllSpecializations();
        }
        [HttpGet]
        [Route("api/specialization/{id}")]
        public sp_fetch_tblspecializations_Result Getspecialization(int id)
        {
            return specializationservice.GetSpecialization(id);
        }

        [HttpPost]
        [Route("api/specialization")]
        public string AddSpecialization(sp_fetch_tblspecializations_Result specialization)
        {
            specializationservice.AddSpecialization(specialization);
            return "Specialization Added Successfully";
        }

        [HttpPut]
        [Route("api/specialization")]
        public string UpdateSpecialization(sp_fetch_tblspecializations_Result specialization)
        {
            specializationservice.UpdateSpecialization(specialization);
            return "Specialization Updated Successfully";
        }

        [HttpDelete]
        [Route("api/specialization/{id}")]
        public string DeleteSpecialization(int id)
        {
            sp_fetch_tblspecializations_Result s = new sp_fetch_tblspecializations_Result()
            {
                qualification_id = id
            };
            specializationservice.DeleteSpecialization(s);
            return "Specialization Deleted Successfully";
        }

        [HttpDelete]
        [Route("api/restorespecialization/{id}")]
        public string RestoreSpecialization(int id)
        {
            sp_fetch_tblspecializations_Result s = new sp_fetch_tblspecializations_Result()
            {
                specialization_id = id
            };
            specializationservice.RestoreSpecialization(s);
            return "Specialization Restored Successfully";
        }

        //---------------------------------- State Apis --------------------------------------------------------//

        [HttpGet]
        [Route("api/state")]
        public List<sp_fetch_tblstates_Result> GetallStates()
        {
            return stateservice.GetAllStates();
        }

        [HttpGet]
        [Route("api/state/{id}")]
        public sp_fetch_tblstates_Result GetState(int id)
        {
            return stateservice.GetState(id);
        }

        [HttpPost]
        [Route("api/state")]
        public string AddState(sp_fetch_tblstates_Result state)
        {
            stateservice.AddState(state);
            return "State Added Successfully";
        }

        [HttpPut]
        [Route("api/state")]
        public string UpdateState(sp_fetch_tblstates_Result state)
        {
            stateservice.UpdateState(state);
            return "State Updated Successfully";
        }

        [HttpDelete]
        [Route("api/deletestate/{id}")]
        public string DeleteState(int id)
        {
            sp_fetch_tblstates_Result s = new sp_fetch_tblstates_Result()
            {
                state_id = id
            };
            stateservice.DeleteState(s);
            return "State Deleted Successfully";
        }

        [HttpDelete]
        [Route("api/restorestate/{id}")]
        public string RestoreState(int id)
        {
            sp_fetch_tblstates_Result s = new sp_fetch_tblstates_Result()
            {
                state_id = id
            };
            stateservice.RestoreState(s);
            return "State Restored Successfully";
        }

        //----------------------------------------------- City Apis -----------------------------------------------//

        [HttpGet]
        [Route("api/city")]
        public List<sp_fetch_tblcities_Result> GetallCities()
        {
            return cityservice.GetAllCities();
        }

        [HttpGet]
        [Route("api/city/{id}")]
        public sp_fetch_tblcities_Result GetCity(int id)
        {
            return cityservice.GetCity(id);
        }

        [HttpPost]
        [Route("api/city")]
        public string AddCity(sp_fetch_tblcities_Result city)
        {
            cityservice.AddCity(city);
            return "City Added Successfully";
        }

        [HttpPut]
        [Route("api/city")]
        public string UpdateCity(sp_fetch_tblcities_Result city)
        {
            cityservice.UpdateCity(city);
            return "City Updated Successfully";
        }

        [HttpDelete]
        [Route("api/deletecity/{id}")]
        public string DeleteCity(int id)
        {
            sp_fetch_tblcities_Result s = new sp_fetch_tblcities_Result()
            {
                city_id = id
            };
            cityservice.DeleteCity(s);
            return "City Deleted Successfully";
        }

        [HttpDelete]
        [Route("api/restorecity/{id}")]
        public string RestoreCity(int id)
        {
            sp_fetch_tblcities_Result s = new sp_fetch_tblcities_Result()
            {
                city_id = id
            };
            cityservice.RestoreCity(s);
            return "City Restored Successfully";
        }

        //-------------------------------------------------Location Apis------------------------------------------------------//

        [HttpGet]
        [Route("api/location")]
        public List<sp_fetch_tbllocations_Result> GetallLocations()
        {
            return locationservice.GetAllLocations();
        }

        [HttpGet]
        [Route("api/location/{id}")]
        public sp_fetch_tbllocations_Result GetLocations(int id)
        {
            return locationservice.GetLocation(id);
        }

        [HttpPost]
        [Route("api/location")]
        public string AddLocation(sp_fetch_tbllocations_Result location)
        {
            locationservice.AddLocation(location);
            return "Location Added Successfully";
        }

        [HttpPut]
        [Route("api/location")]
        public string UpdateLocation(sp_fetch_tbllocations_Result location)
        {
            locationservice.UpdateLocation(location);
            return "Location Updated Successfully";
        }

        [HttpDelete]
        [Route("api/deletelocation/{id}")]
        public string DeleteLocation(int id)
        {
            sp_fetch_tbllocations_Result s = new sp_fetch_tbllocations_Result()
            {
                location_id = id
            };
            locationservice.DeleteLocation(s);
            return "Location Deleted Successfully";
        }

        [HttpDelete]
        [Route("api/restorelocation/{id}")]
        public string RestoreLocation(int id)
        {
            sp_fetch_tbllocations_Result s = new sp_fetch_tbllocations_Result()
            {
                location_id = id
            };
            locationservice.RestoreLocation(s);
            return "Location Restored Successfully";
        }
        //-----------------------------------------------------Fee Mode Apis-------------------------------------------------------//

        [HttpGet]
        [Route("api/feemode")]
        public List<sp_fetch_tblfee_modes_Result> Getallfeemodes()
        {
            return feemodeservice.GetAllFeeModes();
        }

        [HttpGet]
        [Route("api/feemode/{id}")]
        public sp_fetch_tblfee_modes_Result GetFeeMode(int id)
        {
            return feemodeservice.GetFeeMode(id);
        }

        [HttpPost]
        [Route("api/feemode")]
        public string AddFeeMode(sp_fetch_tblfee_modes_Result feemode)
        {
            feemodeservice.AddFeeMode(feemode);
            return "Fee Mode Added Successfully";
        }

        [HttpPut]
        [Route("api/feemode")]
        public string UpdateFeeMode(sp_fetch_tblfee_modes_Result feemode)
        {
            feemodeservice.UpdateFeeMode(feemode);
            return "Fee Mode Updated Successfully";
        }

        [HttpDelete]
        [Route("api/feemode/{id}")]
        public string DeleteFeeMode(int id)
        {
            sp_fetch_tblfee_modes_Result s = new sp_fetch_tblfee_modes_Result()
            {
                fee_mode_id = id
            };
            feemodeservice.DeleteFeeMode(s);
            return "Fee Mode Deleted Successfully";
        }

        [HttpDelete]
        [Route("api/restorefeemode/{id}")]
        public string RestoreFeeMode(int id)
        {
            sp_fetch_tblfee_modes_Result s = new sp_fetch_tblfee_modes_Result()
            {
                fee_mode_id = id
            };
            feemodeservice.RestoreFeeMode(s);
            return "Fee Mode Restored Successfully";
        }

        //------------------------------------------------Technology Apis-----------------------------------------------------//

        [HttpGet]
        [Route("api/technology")]
        public List<sp_fetch_tbltechnologies_Result> GetallTechnologies()
        {
            return technologyservice.GetAllTechnologies();
        }

        [HttpGet]
        [Route("api/technology/{id}")]
        public sp_fetch_tbltechnologies_Result GetTechnology(int id)
        {
            return technologyservice.GetTechnology(id);
        }

        [HttpPost]
        [Route("api/technology")]
        public string AddTechnology(sp_fetch_tbltechnologies_Result technology)
        {
            technologyservice.AddTechnology(technology);
            return "Technology Added Successfully";
        }

        [HttpPut]
        [Route("api/technology")]
        public string UpdateTechnology(sp_fetch_tbltechnologies_Result technology)
        {
            technologyservice.UpdateTechnology(technology);
            return "Technology Updated Successfully";
        }

        [HttpDelete]
        [Route("api/technology/{id}")]
        public string DeleteTechnology(int id)
        {
            sp_fetch_tbltechnologies_Result s = new sp_fetch_tbltechnologies_Result()
            {
                technology_id = id
            };
            technologyservice.DeleteTechnology(s);
            return "Technology Deleted Successfully";
        }

        [HttpDelete]
        [Route("api/restoretechnology/{id}")]
        public string RestoreTechnology(int id)
        {
            sp_fetch_tbltechnologies_Result s = new sp_fetch_tbltechnologies_Result()
            {
                technology_id = id
            };
            technologyservice.RestoreTechnology(s);
            return "Technology Restored Successfully";
        }

        //--------------------------------------------------------Designation Apis------------------------------------------------//

        [HttpGet]
        [Route("api/designation")]
        public List<sp_fetch_tbldesignations_Result> GetallDesignations()
        {
            return designationservice.GetAllDesignations();
        }

        [HttpGet]
        [Route("api/designation/{id}")]
        public sp_fetch_tbldesignations_Result GetDesignation(int id)
        {
            return designationservice.GetDesignation(id);
        }

        [HttpPost]
        [Route("api/designation")]
        public string AddDesignation(sp_fetch_tbldesignations_Result designation)
        {
            designationservice.AddDesignation(designation);
            return "Designation Added Successfully";
        }

        [HttpPut]
        [Route("api/designation")]
        public string UpdateDesignation(sp_fetch_tbldesignations_Result designation)
        {
            designationservice.UpdateDesignation(designation);
            return "Designation Updated Successfully";
        }

        [HttpDelete]
        [Route("api/designation/{id}")]
        public string DeleteDesignation(int id)
        {
            sp_fetch_tbldesignations_Result s = new sp_fetch_tbldesignations_Result()
            {
                designation_id = id
            };
            designationservice.DeleteDesignation(s);
            return "Designation Deleted Successfully";
        }

        [HttpDelete]
        [Route("api/restoredesignation/{id}")]
        public string RestoreDesignation(int id)
        {
            sp_fetch_tbldesignations_Result s = new sp_fetch_tbldesignations_Result()
            {
                designation_id = id
            };
            designationservice.RestoreDesignation(s);
            return "Designation Restored Successfully";
        }
    }
}
