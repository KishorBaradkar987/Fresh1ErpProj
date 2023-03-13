using System.Web.Http;
using Unity;
using Unity.WebApi;
using DatabaseOpworks;
using ServicesOperations.Implementations;
using ServicesOperations.Interface;
using ServicesOperations.Interface.Master;
using ServicesOperations.Implementations.Master;
using ServicesOperations.Interface.Developer;
using ServicesOperations.Implementations.Developer;
using ServicesOperations.Interface.Accountant;
using ServicesOperations.Implementations.Accountant;
using ServicesOperations.Interface.Branch;
using ServicesOperations.Implementations.Branch;


namespace Fresh1ErpProj
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType(typeof(IRepository<>), typeof(Repository<>));
            container.RegisterType<IQualificationService, QualificationService>();
            container.RegisterType<ISpecializationService, SpecializationService>();
            container.RegisterType<IStateService, StateService>();
            container.RegisterType<ICityService, CityService>();
            container.RegisterType<ILocationService, LocationService>();
            container.RegisterType<IFeeModeService, FeeModeService>();
            container.RegisterType<ITechnologyService, TechnologyService>();
            container.RegisterType<ICourseService, CourseService>();
            container.RegisterType<ICourseFeeService, CourseFeeService>();
            container.RegisterType<IDesignationService, DesignationService>();
            container.RegisterType<IEmployeeDetailsService, EmployeeDetailsService>();
            container.RegisterType<ICenterDetailsService, CenterDetailsService>();
            
            container.RegisterType(typeof(ITable<>), typeof(Table<>));
            container.RegisterType<IStudentDetailService, StudentDetailService>();
            container.RegisterType<IRegistrationDetailService, RegistrationDetailService>();
            container.RegisterType<IStudentQualificationService, StudentQualificationService>();
            container.RegisterType<IPaymentDetailService, PaymentDetailService>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}