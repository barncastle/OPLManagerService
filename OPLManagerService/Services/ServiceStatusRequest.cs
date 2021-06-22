using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace OPLManagerService.Services
{
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class ServiceStatusRequest
    {
        public ServiceStatusRequest()
        {
        }

        public ServiceStatusRequest(ServiceStatusRequestBody Body)
        {
            this.Body = Body;
        }

        [MessageBodyMember(Name = "ServiceStatus", Namespace = "http://oplmanager.no-ip.info/", Order = 0)]
        public ServiceStatusRequestBody Body;
    }
}