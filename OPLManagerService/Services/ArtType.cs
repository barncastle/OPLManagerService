using System.CodeDom.Compiler;
using System.Runtime.Serialization;

namespace OPLManagerService.Services
{
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "ArtType", Namespace = "http://oplmanager.no-ip.info/")]
    public enum ArtType
    {
        [EnumMember]
        ICO,

        [EnumMember]
        COV,

        [EnumMember]
        COV2,

        [EnumMember]
        SCR,

        [EnumMember]
        SCR2,

        [EnumMember]
        BG,

        [EnumMember]
        LAB,

        [EnumMember]
        LGO
    }
}