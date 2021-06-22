using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace OPLManagerService.Services
{
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class ServiceStatusCompletedEventArgs : AsyncCompletedEventArgs
    {
        public ServiceStatusCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public ServerStatus Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return (ServerStatus)this.results[0];
            }
        }

        private object[] results;
    }
}