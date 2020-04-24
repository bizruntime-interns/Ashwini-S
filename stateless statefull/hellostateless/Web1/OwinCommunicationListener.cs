using Microsoft.ServiceFabric.Services.Communication.Runtime;
using System.Fabric;

namespace HelloWorldStateless
{
    internal class OwinCommunicationListener : ICommunicationListener
    {
        private string v;
        private Startup startup;
        private StatelessServiceContext initParams;

        public OwinCommunicationListener(string v, Startup startup, StatelessServiceContext initParams)
        {
            this.v = v;
            this.startup = startup;
            this.initParams = initParams;
        }
    }
}