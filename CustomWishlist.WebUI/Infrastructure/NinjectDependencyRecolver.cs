using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;

namespace CustomWishlist.WebUI.Infrastructure
{
    public class NinjectDependencyRecolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyRecolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            // привязки
        }
    }
}