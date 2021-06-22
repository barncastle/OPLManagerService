using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPLManagerService.Services
{
    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "ServerStatus", Namespace = "http://oplmanager.no-ip.info/")]
    [Serializable]
    public class ServerStatus : IExtensibleDataObject, INotifyPropertyChanged
    {
        [Browsable(false)]
        public ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [DataMember(EmitDefaultValue = false)]
        public string userID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                if (!object.ReferenceEquals(this.userIDField, value))
                {
                    this.userIDField = value;
                    this.RaisePropertyChanged("userID");
                }
            }
        }

        [DataMember(IsRequired = true)]
        public long usersOnline
        {
            get
            {
                return this.usersOnlineField;
            }
            set
            {
                if (!this.usersOnlineField.Equals(value))
                {
                    this.usersOnlineField = value;
                    this.RaisePropertyChanged("usersOnline");
                }
            }
        }

        [DataMember(IsRequired = true, Order = 2)]
        public long countIcos
        {
            get
            {
                return this.countIcosField;
            }
            set
            {
                if (!this.countIcosField.Equals(value))
                {
                    this.countIcosField = value;
                    this.RaisePropertyChanged("countIcos");
                }
            }
        }

        [DataMember(IsRequired = true, Order = 3)]
        public long countCov
        {
            get
            {
                return this.countCovField;
            }
            set
            {
                if (!this.countCovField.Equals(value))
                {
                    this.countCovField = value;
                    this.RaisePropertyChanged("countCov");
                }
            }
        }

        [DataMember(IsRequired = true, Order = 4)]
        public long countCov2
        {
            get
            {
                return this.countCov2Field;
            }
            set
            {
                if (!this.countCov2Field.Equals(value))
                {
                    this.countCov2Field = value;
                    this.RaisePropertyChanged("countCov2");
                }
            }
        }

        [DataMember(IsRequired = true, Order = 5)]
        public long countScr
        {
            get
            {
                return this.countScrField;
            }
            set
            {
                if (!this.countScrField.Equals(value))
                {
                    this.countScrField = value;
                    this.RaisePropertyChanged("countScr");
                }
            }
        }

        [DataMember(IsRequired = true, Order = 6)]
        public long countBg
        {
            get
            {
                return this.countBgField;
            }
            set
            {
                if (!this.countBgField.Equals(value))
                {
                    this.countBgField = value;
                    this.RaisePropertyChanged("countBg");
                }
            }
        }

        [DataMember(IsRequired = true, Order = 7)]
        public long countLab
        {
            get
            {
                return this.countLabField;
            }
            set
            {
                if (!this.countLabField.Equals(value))
                {
                    this.countLabField = value;
                    this.RaisePropertyChanged("countLab");
                }
            }
        }

        [DataMember(IsRequired = true, Order = 8)]
        public long countLgo
        {
            get
            {
                return this.countLgoField;
            }
            set
            {
                if (!this.countLgoField.Equals(value))
                {
                    this.countLgoField = value;
                    this.RaisePropertyChanged("countLgo");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 9)]
        public string serverTime
        {
            get
            {
                return this.serverTimeField;
            }
            set
            {
                if (!object.ReferenceEquals(this.serverTimeField, value))
                {
                    this.serverTimeField = value;
                    this.RaisePropertyChanged("serverTime");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [NonSerialized]
        private ExtensionDataObject extensionDataField;

        [OptionalField]
        private string userIDField;

        private long usersOnlineField;

        private long countIcosField;

        private long countCovField;

        private long countCov2Field;

        private long countScrField;

        private long countBgField;

        private long countLabField;

        private long countLgoField;

        [OptionalField]
        private string serverTimeField;
    }
}