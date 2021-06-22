using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPLManagerService.Services
{
    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "BatchArtShareRequestClass", Namespace = "http://oplmanager.no-ip.info/")]
    [Serializable]
    public class BatchArtShareRequestClass : IExtensibleDataObject, INotifyPropertyChanged
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

        [DataMember(EmitDefaultValue = false, Order = 1)]
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

        [DataMember(EmitDefaultValue = false, Order = 2)]
        public string HashedICO
        {
            get
            {
                return this.HashedICOField;
            }
            set
            {
                if (!object.ReferenceEquals(this.HashedICOField, value))
                {
                    this.HashedICOField = value;
                    this.RaisePropertyChanged("HashedICO");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 3)]
        public string HashedCOV
        {
            get
            {
                return this.HashedCOVField;
            }
            set
            {
                if (!object.ReferenceEquals(this.HashedCOVField, value))
                {
                    this.HashedCOVField = value;
                    this.RaisePropertyChanged("HashedCOV");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 4)]
        public string HashedCOV2
        {
            get
            {
                return this.HashedCOV2Field;
            }
            set
            {
                if (!object.ReferenceEquals(this.HashedCOV2Field, value))
                {
                    this.HashedCOV2Field = value;
                    this.RaisePropertyChanged("HashedCOV2");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 5)]
        public string HashedLAB
        {
            get
            {
                return this.HashedLABField;
            }
            set
            {
                if (!object.ReferenceEquals(this.HashedLABField, value))
                {
                    this.HashedLABField = value;
                    this.RaisePropertyChanged("HashedLAB");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 6)]
        public string HashedLGO
        {
            get
            {
                return this.HashedLGOField;
            }
            set
            {
                if (!object.ReferenceEquals(this.HashedLGOField, value))
                {
                    this.HashedLGOField = value;
                    this.RaisePropertyChanged("HashedLGO");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 7)]
        public string HashedSCR
        {
            get
            {
                return this.HashedSCRField;
            }
            set
            {
                if (!object.ReferenceEquals(this.HashedSCRField, value))
                {
                    this.HashedSCRField = value;
                    this.RaisePropertyChanged("HashedSCR");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 8)]
        public string HashedSCR2
        {
            get
            {
                return this.HashedSCR2Field;
            }
            set
            {
                if (!object.ReferenceEquals(this.HashedSCR2Field, value))
                {
                    this.HashedSCR2Field = value;
                    this.RaisePropertyChanged("HashedSCR2");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 9)]
        public string HashedBG
        {
            get
            {
                return this.HashedBGField;
            }
            set
            {
                if (!object.ReferenceEquals(this.HashedBGField, value))
                {
                    this.HashedBGField = value;
                    this.RaisePropertyChanged("HashedBG");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 10)]
        public string OrigICO
        {
            get
            {
                return this.OrigICOField;
            }
            set
            {
                if (!object.ReferenceEquals(this.OrigICOField, value))
                {
                    this.OrigICOField = value;
                    this.RaisePropertyChanged("OrigICO");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 11)]
        public string OrigCOV
        {
            get
            {
                return this.OrigCOVField;
            }
            set
            {
                if (!object.ReferenceEquals(this.OrigCOVField, value))
                {
                    this.OrigCOVField = value;
                    this.RaisePropertyChanged("OrigCOV");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 12)]
        public string OrigCOV2
        {
            get
            {
                return this.OrigCOV2Field;
            }
            set
            {
                if (!object.ReferenceEquals(this.OrigCOV2Field, value))
                {
                    this.OrigCOV2Field = value;
                    this.RaisePropertyChanged("OrigCOV2");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 13)]
        public string OrigLAB
        {
            get
            {
                return this.OrigLABField;
            }
            set
            {
                if (!object.ReferenceEquals(this.OrigLABField, value))
                {
                    this.OrigLABField = value;
                    this.RaisePropertyChanged("OrigLAB");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 14)]
        public string OrigLGO
        {
            get
            {
                return this.OrigLGOField;
            }
            set
            {
                if (!object.ReferenceEquals(this.OrigLGOField, value))
                {
                    this.OrigLGOField = value;
                    this.RaisePropertyChanged("OrigLGO");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 15)]
        public string OrigSCR
        {
            get
            {
                return this.OrigSCRField;
            }
            set
            {
                if (!object.ReferenceEquals(this.OrigSCRField, value))
                {
                    this.OrigSCRField = value;
                    this.RaisePropertyChanged("OrigSCR");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 16)]
        public string OrigSCR2
        {
            get
            {
                return this.OrigSCR2Field;
            }
            set
            {
                if (!object.ReferenceEquals(this.OrigSCR2Field, value))
                {
                    this.OrigSCR2Field = value;
                    this.RaisePropertyChanged("OrigSCR2");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 17)]
        public string OrigBG
        {
            get
            {
                return this.OrigBGField;
            }
            set
            {
                if (!object.ReferenceEquals(this.OrigBGField, value))
                {
                    this.OrigBGField = value;
                    this.RaisePropertyChanged("OrigBG");
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

        private GameType GameTypeField;

        [OptionalField]
        private string GameIDField;

        [OptionalField]
        private string HashedICOField;

        [OptionalField]
        private string HashedCOVField;

        [OptionalField]
        private string HashedCOV2Field;

        [OptionalField]
        private string HashedLABField;

        [OptionalField]
        private string HashedLGOField;

        [OptionalField]
        private string HashedSCRField;

        [OptionalField]
        private string HashedSCR2Field;

        [OptionalField]
        private string HashedBGField;

        [OptionalField]
        private string OrigICOField;

        [OptionalField]
        private string OrigCOVField;

        [OptionalField]
        private string OrigCOV2Field;

        [OptionalField]
        private string OrigLABField;

        [OptionalField]
        private string OrigLGOField;

        [OptionalField]
        private string OrigSCRField;

        [OptionalField]
        private string OrigSCR2Field;

        [OptionalField]
        private string OrigBGField;
    }
}