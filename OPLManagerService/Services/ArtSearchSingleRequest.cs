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
    public class ArtSearchSingleRequest
    {
        public ArtSearchSingleRequest()
        {
        }

        public ArtSearchSingleRequest(ArtSearchSingleRequestBody Body)
        {
            this.Body = Body;
        }

        [MessageBodyMember(Name = "ArtSearchSingle", Namespace = "http://oplmanager.no-ip.info/", Order = 0)]
        public ArtSearchSingleRequestBody Body;
    }
}