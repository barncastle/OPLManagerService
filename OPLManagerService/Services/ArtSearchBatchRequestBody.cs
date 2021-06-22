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
    public class ArtSearchBatchRequestBody
    {
        public ArtSearchBatchRequestBody()
        {
        }

        public ArtSearchBatchRequestBody(string userID, ArtSearchBatchRequestClass[] games)
        {
            this.userID = userID;
            this.games = games;
        }

        [DataMember(EmitDefaultValue = false, Order = 0)]
        public string userID;

        [DataMember(EmitDefaultValue = false, Order = 1)]
        public ArtSearchBatchRequestClass[] games;
    }
}