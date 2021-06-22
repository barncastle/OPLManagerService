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
    public class ServiceStatusResponse
    {
        public ServiceStatusResponse()
        {
        }

        public ServiceStatusResponse(ServiceStatusResponseBody Body)
        {
            this.Body = Body;
        }

        [MessageBodyMember(Name = "ServiceStatusResponse", Namespace = "http://oplmanager.no-ip.info/", Order = 0)]
        public ServiceStatusResponseBody Body;
    }
}