using Microsoft.ServiceFabric.Services.Communication.Runtime;
using System.Fabric.Query;

namespace HelloWorldStateless
{
    /// <summary>
    /// The FabricRuntime creates an instance of this class for each service type instance. 
    /// </summary>
    internal sealed class HellStateless : StatelessService
    {
        /// <summary>
        /// Optional override to create listeners (like tcp, http) for this service instance.
        /// </summary>
        /// <returns>The collection of listeners.</returns>
        protected override IEnumerable<ServiceInstanceListener> CreateServiceInstanceListeners()
        {
            return new[]
            {
                new ServiceInstanceListener(initParams =>
                new OwinCommunicationListener("webapp", new Startup(), initParams))
            };
        }
    }
}