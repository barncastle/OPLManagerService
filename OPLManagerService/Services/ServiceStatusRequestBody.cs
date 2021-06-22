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
    public class ServiceStatusRequestBody
    {
        public ServiceStatusRequestBody()
        {
        }

        public ServiceStatusRequestBody(string userID, int versionid)
        {
            this.userID = userID;
            this.versionid = versionid;
        }

        [DataMember(EmitDefaultValue = false, Order = 0)]
        public string userID;

        [DataMember(Order = 1)]
        public int versionid;
    }
}