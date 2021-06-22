using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPLManagerService.Services
{
    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "ArtUploadRequestClass", Namespace = "http://oplmanager.no-ip.info/")]
    [Serializable]
    public class ArtUploadRequestClass : IExtensibleDataObject, INotifyPropertyChanged
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
        public string FileName
        {
            get
            {
                return this.FileNameField;
            }
            set
            {
                if (!object.ReferenceEquals(this.FileNameField, value))
                {
                    this.FileNameField = value;
                    this.RaisePropertyChanged("FileName");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 1)]
        public byte[] FileData
        {
            get
            {
                return this.FileDataField;
            }
            set
            {
                if (!object.ReferenceEquals(this.FileDataField, value))
                {
                    this.FileDataField = value;
                    this.RaisePropertyChanged("FileData");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 2)]
        public string FileHash
        {
            get
            {
                return this.FileHashField;
            }
            set
            {
                if (!object.ReferenceEquals(this.FileHashField, value))
                {
                    this.FileHashField = value;
                    this.RaisePropertyChanged("FileHash");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 3)]
        public string GameID
        {
            get
            {
                return this.GameIDField;
            }
            set
            {
                if (!object.ReferenceEquals(this.GameIDField, value))
                {
                    this.GameIDField = value;
                    this.RaisePropertyChanged("GameID");
                }
            }
        }

        [DataMember(IsRequired = true, Order = 4)]
        public GameType GameType
        {
            get
            {
                return this.GameTypeField;
            }
            set
            {
                if (!this.GameTypeField.Equals(value))
                {
                    this.GameTypeField = value;
                    this.RaisePropertyChanged("GameType");
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
        private string FileNameField;

        [OptionalField]
        private byte[] FileDataField;

        [OptionalField]
        private string FileHashField;

        [OptionalField]
        private string GameIDField;

        private GameType GameTypeField;
    }
}