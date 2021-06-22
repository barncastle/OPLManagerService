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
    public class ArtUploadResponseBody
    {
        public ArtUploadResponseBody()
        {
        }

        public ArtUploadResponseBody(bool ArtUploadResult)
        {
            this.ArtUploadResult = ArtUploadResult;
        }

        [DataMember(Order = 0)]
        public bool ArtUploadResult;
    }
}