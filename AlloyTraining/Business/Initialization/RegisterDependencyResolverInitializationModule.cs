using System;
using System.Linq;
using System.Web.Mvc;
using AlloyTraining.Business.DependencyResolvers;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;

namespace AlloyTraining.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class RegisterDependencyResolverInitializationModule : IConfigurableModule
    {
        public void Initialize(InitializationEngine context)
        { }

        public void Uninitialize(InitializationEngine context)
        { }

        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            DependencyResolver.SetResolver(
                new StructureMapDependencyResolver(context.StructureMap()));

            // Implementations for custom interfaces can be registered here.
            context.ConfigurationComplete += (o, e) =>
            {
                // Register custom implementations that should be used in favor of the
                // default implementations
            };
        }
    }
}