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
    public class GetDesktopAppVersionResponse
    {
        public GetDesktopAppVersionResponse()
        {
        }

        public GetDesktopAppVersionResponse(GetDesktopAppVersionResponseBody Body)
        {
            this.Body = Body;
        }

        [MessageBodyMember(Name = "GetDesktopAppVersionResponse", Namespace = "http://oplmanager.no-ip.info/", Order = 0)]
        public GetDesktopAppVersionResponseBody Body;
    }
}