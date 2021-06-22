using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPLManagerService.Services
{
    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "VersionDesktopInfo", Namespace = "http://oplmanager.no-ip.info/")]
    [Serializable]
    public class VersionDesktopInfo : IExtensibleDataObject, INotifyPropertyChanged
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

        [DataMember(IsRequired = true)]
        public int major
        {
            get
            {
                return this.majorField;
            }
            set
            {
                if (!this.majorField.Equals(value))
                {
                    this.majorField = value;
                    this.RaisePropertyChanged("major");
                }
            }
        }

        [DataMember(IsRequired = true)]
        public int minor
        {
            get
            {
                return this.minorField;
            }
            set
            {
                if (!this.minorField.Equals(value))
                {
                    this.minorField = value;
                    this.RaisePropertyChanged("minor");
                }
            }
        }

        [DataMember(IsRequired = true)]
        public int versionid
        {
            get
            {
                return this.versionidField;
            }
            set
            {
                if (!this.versionidField.Equals(value))
                {
                    this.versionidField = value;
                    this.RaisePropertyChanged("versionid");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 3)]
        public string date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                if (!object.ReferenceEquals(this.dateField, value))
                {
                    this.dateField = value;
                    this.RaisePropertyChanged("date");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 4)]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                if (!object.ReferenceEquals(this.urlField, value))
                {
                    this.urlField = value;
                    this.RaisePropertyChanged("url");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 5)]
        public string changes
        {
            get
            {
                return this.changesField;
            }
            set
            {
                if (!object.ReferenceEquals(this.changesField, value))
                {
                    this.changesField = value;
                    this.RaisePropertyChanged("changes");
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

        private int majorField;

        private int minorField;

        private int versionidField;

        [OptionalField]
        private string dateField;

        [OptionalField]
        private string urlField;

        [OptionalField]
        private string changesField;
    }
}