using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Lektion22.Models.Repositories.Abstract;
using Lektion22.Models.Entities;
using Lektion22.Models.Repositories;
using System.Configuration;

namespace Lektion22.Web.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            ninjectKernel.Bind<IAppUserRepository>().To<AppUserRepository>();
            ninjectKernel.Bind(typeof(IRepository<>)).To(typeof(Repository<>));
        }
    }
}