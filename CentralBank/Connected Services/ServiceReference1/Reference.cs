﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CentralBank.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UplatnicaModel", Namespace="http://schemas.datacontract.org/2004/07/BankApi.model")]
    [System.SerializableAttribute()]
    public partial class UplatnicaModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CenaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool CheckboxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DatumValuteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DuznikNalogodavacField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MestoDatumPrijemaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Model2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PoverilacPrimalacField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PozivNaBrojZaduzenjaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RacunDuznikaNalogodavcaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RacunNaBrojOdobrenjeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RecunPoveriocaPrimaocaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SifraPlacanjaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SvrhaPlacanjaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Cena {
            get {
                return this.CenaField;
            }
            set {
                if ((this.CenaField.Equals(value) != true)) {
                    this.CenaField = value;
                    this.RaisePropertyChanged("Cena");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Checkbox {
            get {
                return this.CheckboxField;
            }
            set {
                if ((this.CheckboxField.Equals(value) != true)) {
                    this.CheckboxField = value;
                    this.RaisePropertyChanged("Checkbox");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DatumValute {
            get {
                return this.DatumValuteField;
            }
            set {
                if ((object.ReferenceEquals(this.DatumValuteField, value) != true)) {
                    this.DatumValuteField = value;
                    this.RaisePropertyChanged("DatumValute");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DuznikNalogodavac {
            get {
                return this.DuznikNalogodavacField;
            }
            set {
                if ((object.ReferenceEquals(this.DuznikNalogodavacField, value) != true)) {
                    this.DuznikNalogodavacField = value;
                    this.RaisePropertyChanged("DuznikNalogodavac");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MestoDatumPrijema {
            get {
                return this.MestoDatumPrijemaField;
            }
            set {
                if ((object.ReferenceEquals(this.MestoDatumPrijemaField, value) != true)) {
                    this.MestoDatumPrijemaField = value;
                    this.RaisePropertyChanged("MestoDatumPrijema");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model {
            get {
                return this.ModelField;
            }
            set {
                if ((object.ReferenceEquals(this.ModelField, value) != true)) {
                    this.ModelField = value;
                    this.RaisePropertyChanged("Model");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Model2 {
            get {
                return this.Model2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Model2Field, value) != true)) {
                    this.Model2Field = value;
                    this.RaisePropertyChanged("Model2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PoverilacPrimalac {
            get {
                return this.PoverilacPrimalacField;
            }
            set {
                if ((object.ReferenceEquals(this.PoverilacPrimalacField, value) != true)) {
                    this.PoverilacPrimalacField = value;
                    this.RaisePropertyChanged("PoverilacPrimalac");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PozivNaBrojZaduzenja {
            get {
                return this.PozivNaBrojZaduzenjaField;
            }
            set {
                if ((object.ReferenceEquals(this.PozivNaBrojZaduzenjaField, value) != true)) {
                    this.PozivNaBrojZaduzenjaField = value;
                    this.RaisePropertyChanged("PozivNaBrojZaduzenja");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RacunDuznikaNalogodavca {
            get {
                return this.RacunDuznikaNalogodavcaField;
            }
            set {
                if ((object.ReferenceEquals(this.RacunDuznikaNalogodavcaField, value) != true)) {
                    this.RacunDuznikaNalogodavcaField = value;
                    this.RaisePropertyChanged("RacunDuznikaNalogodavca");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RacunNaBrojOdobrenje {
            get {
                return this.RacunNaBrojOdobrenjeField;
            }
            set {
                if ((object.ReferenceEquals(this.RacunNaBrojOdobrenjeField, value) != true)) {
                    this.RacunNaBrojOdobrenjeField = value;
                    this.RaisePropertyChanged("RacunNaBrojOdobrenje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RecunPoveriocaPrimaoca {
            get {
                return this.RecunPoveriocaPrimaocaField;
            }
            set {
                if ((object.ReferenceEquals(this.RecunPoveriocaPrimaocaField, value) != true)) {
                    this.RecunPoveriocaPrimaocaField = value;
                    this.RaisePropertyChanged("RecunPoveriocaPrimaoca");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SifraPlacanja {
            get {
                return this.SifraPlacanjaField;
            }
            set {
                if ((object.ReferenceEquals(this.SifraPlacanjaField, value) != true)) {
                    this.SifraPlacanjaField = value;
                    this.RaisePropertyChanged("SifraPlacanja");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SvrhaPlacanja {
            get {
                return this.SvrhaPlacanjaField;
            }
            set {
                if ((object.ReferenceEquals(this.SvrhaPlacanjaField, value) != true)) {
                    this.SvrhaPlacanjaField = value;
                    this.RaisePropertyChanged("SvrhaPlacanja");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IServiceBank")]
    public interface IServiceBank {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBank/AddUplatnica", ReplyAction="http://tempuri.org/IServiceBank/AddUplatnicaResponse")]
        bool AddUplatnica(CentralBank.ServiceReference1.UplatnicaModel uplatnica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBank/AddUplatnica", ReplyAction="http://tempuri.org/IServiceBank/AddUplatnicaResponse")]
        System.Threading.Tasks.Task<bool> AddUplatnicaAsync(CentralBank.ServiceReference1.UplatnicaModel uplatnica);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBank/GetIzvod", ReplyAction="http://tempuri.org/IServiceBank/GetIzvodResponse")]
        CentralBank.ServiceReference1.UplatnicaModel[] GetIzvod();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBank/GetIzvod", ReplyAction="http://tempuri.org/IServiceBank/GetIzvodResponse")]
        System.Threading.Tasks.Task<CentralBank.ServiceReference1.UplatnicaModel[]> GetIzvodAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBank/IsplataIzvrsena", ReplyAction="http://tempuri.org/IServiceBank/IsplataIzvrsenaResponse")]
        void IsplataIzvrsena(long id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBank/IsplataIzvrsena", ReplyAction="http://tempuri.org/IServiceBank/IsplataIzvrsenaResponse")]
        System.Threading.Tasks.Task IsplataIzvrsenaAsync(long id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceBankChannel : CentralBank.ServiceReference1.IServiceBank, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceBankClient : System.ServiceModel.ClientBase<CentralBank.ServiceReference1.IServiceBank>, CentralBank.ServiceReference1.IServiceBank {
        
        public ServiceBankClient() {
        }
        
        public ServiceBankClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceBankClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBankClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBankClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddUplatnica(CentralBank.ServiceReference1.UplatnicaModel uplatnica) {
            return base.Channel.AddUplatnica(uplatnica);
        }
        
        public System.Threading.Tasks.Task<bool> AddUplatnicaAsync(CentralBank.ServiceReference1.UplatnicaModel uplatnica) {
            return base.Channel.AddUplatnicaAsync(uplatnica);
        }
        
        public CentralBank.ServiceReference1.UplatnicaModel[] GetIzvod() {
            return base.Channel.GetIzvod();
        }
        
        public System.Threading.Tasks.Task<CentralBank.ServiceReference1.UplatnicaModel[]> GetIzvodAsync() {
            return base.Channel.GetIzvodAsync();
        }
        
        public void IsplataIzvrsena(long id) {
            base.Channel.IsplataIzvrsena(id);
        }
        
        public System.Threading.Tasks.Task IsplataIzvrsenaAsync(long id) {
            return base.Channel.IsplataIzvrsenaAsync(id);
        }
    }
}
