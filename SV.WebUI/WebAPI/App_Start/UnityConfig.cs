using Microsoft.Practices.Unity;
using System.Web.Http;
using DependencyResolution;
using Unity.WebApi;

namespace WebAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            RegisterTypes(container);
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            ComponentLoader.LoaderContainer(container, ".\\bin", "WebApi.dll");
            ComponentLoader.LoaderContainer(container, ".\\bin", "Infrastructure.dll");
        }
    }
}