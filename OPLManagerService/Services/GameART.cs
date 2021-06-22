using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace OPLManagerService.Services
{
    [DebuggerStepThrough]
    [GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name = "GameART", Namespace = "http://oplmanager.no-ip.info/")]
    [Serializable]
    public class GameART : IExtensibleDataObject, INotifyPropertyChanged
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
        public GameType TYPE
        {
            get
            {
                return this.TYPEField;
            }
            set
            {
                if (!this.TYPEField.Equals(value))
                {
                    this.TYPEField = value;
                    this.RaisePropertyChanged("TYPE");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 1)]
        public string ID
        {
            get
            {
                return this.IDField;
            }
            set
            {
                if (!object.ReferenceEquals(this.IDField, value))
                {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 2)]
        public string COV
        {
            get
            {
                return this.COVField;
            }
            set
            {
                if (!object.ReferenceEquals(this.COVField, value))
                {
                    this.COVField = value;
                    this.RaisePropertyChanged("COV");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 3)]
        public string COV2
        {
            get
            {
                return this.COV2Field;
            }
            set
            {
                if (!object.ReferenceEquals(this.COV2Field, value))
                {
                    this.COV2Field = value;
                    this.RaisePropertyChanged("COV2");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 4)]
        public string ICO
        {
            get
            {
                return this.ICOField;
            }
            set
            {
                if (!object.ReferenceEquals(this.ICOField, value))
                {
                    this.ICOField = value;
                    this.RaisePropertyChanged("ICO");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 5)]
        public string LGO
        {
            get
            {
                return this.LGOField;
            }
            set
            {
                if (!object.ReferenceEquals(this.LGOField, value))
                {
                    this.LGOField = value;
                    this.RaisePropertyChanged("LGO");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 6)]
        public string LAB
        {
            get
            {
                return this.LABField;
            }
            set
            {
                if (!object.ReferenceEquals(this.LABField, value))
                {
                    this.LABField = value;
                    this.RaisePropertyChanged("LAB");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 7)]
        public ArrayOfString SCR
        {
            get
            {
                return this.SCRField;
            }
            set
            {
                if (!object.ReferenceEquals(this.SCRField, value))
                {
                    this.SCRField = value;
                    this.RaisePropertyChanged("SCR");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 8)]
        public ArrayOfString BG
        {
            get
            {
                return this.BGField;
            }
            set
            {
                if (!object.ReferenceEquals(this.BGField, value))
                {
                    this.BGField = value;
                    this.RaisePropertyChanged("BG");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 9)]
        public string ExCOV
        {
            get
            {
                return this.ExCOVField;
            }
            set
            {
                if (!object.ReferenceEquals(this.ExCOVField, value))
                {
                    this.ExCOVField = value;
                    this.RaisePropertyChanged("ExCOV");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 10)]
        public string ExCOV2
        {
            get
            {
                return this.ExCOV2Field;
            }
            set
            {
                if (!object.ReferenceEquals(this.ExCOV2Field, value))
                {
                    this.ExCOV2Field = value;
                    this.RaisePropertyChanged("ExCOV2");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 11)]
        public string ExICO
        {
            get
            {
                return this.ExICOField;
            }
            set
            {
                if (!object.ReferenceEquals(this.ExICOField, value))
                {
                    this.ExICOField = value;
                    this.RaisePropertyChanged("ExICO");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 12)]
        public string ExLGO
        {
            get
            {
                return this.ExLGOField;
            }
            set
            {
                if (!object.ReferenceEquals(this.ExLGOField, value))
                {
                    this.ExLGOField = value;
                    this.RaisePropertyChanged("ExLGO");
                }
            }
        }

        [DataMember(EmitDefaultValue = false, Order = 13)]
        public string ExLAB
        {
            get
            {
                return this.ExLABField;
            }
            set
            {
                if (!object.ReferenceEquals(this.ExLABField, value))
                {
                    this.ExLABField = value;
                    this.RaisePropertyChanged("ExLAB");
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

        private GameType TYPEField;

        [OptionalField]
        private string IDField;

        [OptionalField]
        private string COVField;

        [OptionalField]
        private string COV2Field;

        [OptionalField]
        private string ICOField;

        [OptionalField]
        private string LGOField;

        [OptionalField]
        private string LABField;

        [OptionalField]
        private ArrayOfString SCRField;

        [OptionalField]
        private ArrayOfString BGField;

        [OptionalField]
        private string ExCOVField;

        [OptionalField]
        private string ExCOV2Field;

        [OptionalField]
        private string ExICOField;

        [OptionalField]
        private string ExLGOField;

        [OptionalField]
        private string ExLABField;
    }
}