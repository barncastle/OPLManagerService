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
    public class GetGameNameByIdRequestBody
    {
        public GetGameNameByIdRequestBody()
        {
        }

        public GetGameNameByIdRequestBody(GameType type, string GameId)
        {
            this.type = type;
            this.GameId = GameId;
        }

        [DataMember(Order = 0)]
        public GameType type;

        [DataMember(EmitDefaultValue = false, Order = 1)]
        public string GameId;
    }
}