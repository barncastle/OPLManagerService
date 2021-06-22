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
    public class ReportArtResponseBody
    {
        public ReportArtResponseBody()
        {
        }

        public ReportArtResponseBody(bool ReportArtResult)
        {
            this.ReportArtResult = ReportArtResult;
        }

        [DataMember(Order = 0)]
        public bool ReportArtResult;
    }
}