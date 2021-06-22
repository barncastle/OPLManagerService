using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPLManagerService.Services
{
    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "ArtSearchBatchRequestClass", Namespace = "http://oplmanager.no-ip.info/")]
    [Serializable]
    public class ArtSearchBatchRequestClass : IExtensibleDataObject, INotifyPropertyChanged
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

        [DataMember(IsRequired = true)]
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
        private string GameIDField;

        private GameType GameTypeField;
    }
}