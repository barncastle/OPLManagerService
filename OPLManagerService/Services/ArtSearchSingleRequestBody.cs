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
    public class ArtSearchSingleRequestBody
    {
        public ArtSearchSingleRequestBody()
        {
        }

        public ArtSearchSingleRequestBody(GameType type, string userID, string gameId)
        {
            this.type = type;
            this.userID = userID;
            this.gameId = gameId;
        }

        [DataMember(Order = 0)]
        public GameType type;

        [DataMember(EmitDefaultValue = false, Order = 1)]
        public string userID;

        [DataMember(EmitDefaultValue = false, Order = 2)]
        public string gameId;
    }
}