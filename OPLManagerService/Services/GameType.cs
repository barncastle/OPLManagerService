using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace OPLManagerService.Services
{
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "GameType", Namespace = "http://oplmanager.no-ip.info/")]
    public enum GameType
    {
        [EnumMember]
        INVALID,

        [EnumMember]
        POPS,

        [EnumMember]
        PS2,

        [EnumMember]
        APP
    }
}