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
    public class BatchArtShareCheckResponse
    {
        public BatchArtShareCheckResponse()
        {
        }

        public BatchArtShareCheckResponse(BatchArtShareCheckResponseBody Body)
        {
            this.Body = Body;
        }

        [MessageBodyMember(Name = "BatchArtShareCheckResponse", Namespace = "http://oplmanager.no-ip.info/", Order = 0)]
        public BatchArtShareCheckResponseBody Body;
    }
}