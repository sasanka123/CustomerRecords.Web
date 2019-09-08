using CustomerRecords.BLL;
using CustomerRecords.DAL;
using CustomerRecords.DAL.Data;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerRecords.Web.App_Start
{
    public static class DIResolver
    {
        public static void RegisterServices()
        {
            var container = new Container();           
            container.Register<ICustomerDataService,CustomerDataService>();
            container.Register<IUserDataService, UserDataService>();
            container.Register<IUserDataRepository, UserDataRepository>();
            container.Register<CustomerRepository, CustomerRepository>(Lifestyle.Singleton);
            container.Register<DataContext, DataContext>(Lifestyle.Singleton);
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}