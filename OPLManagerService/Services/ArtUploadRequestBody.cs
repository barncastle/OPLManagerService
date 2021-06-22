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
    public class ArtUploadRequestBody
    {
        public ArtUploadRequestBody()
        {
        }

        public ArtUploadRequestBody(string userID, ArtUploadRequestClass uploaded)
        {
            this.userID = userID;
            this.uploaded = uploaded;
        }

        [DataMember(EmitDefaultValue = false, Order = 0)]
        public string userID;

        [DataMember(EmitDefaultValue = false, Order = 1)]
        public ArtUploadRequestClass uploaded;
    }
}