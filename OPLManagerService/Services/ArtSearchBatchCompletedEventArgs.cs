using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace OPLManagerService.Services
{
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class ArtSearchBatchCompletedEventArgs : AsyncCompletedEventArgs
    {
        public ArtSearchBatchCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, RuntimeHelpers.GetObjectValue(userState))
        {
            this.results = results;
        }

        public GameART[] Result
        {
            get
            {
                base.RaiseExceptionIfNecessary();
                return (GameART[])this.results[0];
            }
        }

        private object[] results;
    }
}