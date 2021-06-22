using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPLManagerService.Services
{
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DataContract(Namespace = "http://oplmanager.no-ip.info/")]
    public class ServiceStatusResponseBody
    {
        public ServiceStatusResponseBody()
        {
        }

        public ServiceStatusResponseBody(ServerStatus ServiceStatusResult)
        {
            this.ServiceStatusResult = ServiceStatusResult;
        }

        [DataMember(EmitDefaultValue = false, Order = 0)]
        public ServerStatus ServiceStatusResult;
    }
}