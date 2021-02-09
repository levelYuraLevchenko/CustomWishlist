using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject;
using System.Linq;
using Moq;
using CustomWishlist.Domain.Abstract;
using CustomWishlist.Domain.Entities;

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
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product>
            {
                new Product { Name = "A", Price = 25},
                new Product { Name = "B", Price = 50 },
                new Product { Name = "C", Price = 5 }
            });
            kernel.Bind<IProductRepository>().ToConstant(mock.Object);
        }
    }
}