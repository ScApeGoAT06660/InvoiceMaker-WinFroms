﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InvoiceMaker.GusApiService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ParametryWyszukiwania", Namespace="http://CIS/BIR/PUBL/2014/07/DataContract")]
    [System.SerializableAttribute()]
    public partial class ParametryWyszukiwania : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KrsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KrsyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NipField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NipyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Regony14znField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Regony9znField;
        
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
        public string Krs {
            get {
                return this.KrsField;
            }
            set {
                if ((object.ReferenceEquals(this.KrsField, value) != true)) {
                    this.KrsField = value;
                    this.RaisePropertyChanged("Krs");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Krsy {
            get {
                return this.KrsyField;
            }
            set {
                if ((object.ReferenceEquals(this.KrsyField, value) != true)) {
                    this.KrsyField = value;
                    this.RaisePropertyChanged("Krsy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nip {
            get {
                return this.NipField;
            }
            set {
                if ((object.ReferenceEquals(this.NipField, value) != true)) {
                    this.NipField = value;
                    this.RaisePropertyChanged("Nip");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nipy {
            get {
                return this.NipyField;
            }
            set {
                if ((object.ReferenceEquals(this.NipyField, value) != true)) {
                    this.NipyField = value;
                    this.RaisePropertyChanged("Nipy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regon {
            get {
                return this.RegonField;
            }
            set {
                if ((object.ReferenceEquals(this.RegonField, value) != true)) {
                    this.RegonField = value;
                    this.RaisePropertyChanged("Regon");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regony14zn {
            get {
                return this.Regony14znField;
            }
            set {
                if ((object.ReferenceEquals(this.Regony14znField, value) != true)) {
                    this.Regony14znField = value;
                    this.RaisePropertyChanged("Regony14zn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regony9zn {
            get {
                return this.Regony9znField;
            }
            set {
                if ((object.ReferenceEquals(this.Regony9znField, value) != true)) {
                    this.Regony9znField = value;
                    this.RaisePropertyChanged("Regony9zn");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GusApiService.IUslugaBIRzewnPubl")]
    public interface IUslugaBIRzewnPubl {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://CIS/BIR/2014/07) of message GetValueRequest does not match the default value (http://tempuri.org/)
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/2014/07/IUslugaBIR/GetValue", ReplyAction="http://CIS/BIR/2014/07/IUslugaBIR/GetValueResponse")]
        InvoiceMaker.GusApiService.GetValueResponse GetValue(InvoiceMaker.GusApiService.GetValueRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/2014/07/IUslugaBIR/GetValue", ReplyAction="http://CIS/BIR/2014/07/IUslugaBIR/GetValueResponse")]
        System.Threading.Tasks.Task<InvoiceMaker.GusApiService.GetValueResponse> GetValueAsync(InvoiceMaker.GusApiService.GetValueRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://CIS/BIR/PUBL/2014/07) of message ZalogujRequest does not match the default value (http://tempuri.org/)
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Zaloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/ZalogujResponse")]
        InvoiceMaker.GusApiService.ZalogujResponse Zaloguj(InvoiceMaker.GusApiService.ZalogujRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Zaloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/ZalogujResponse")]
        System.Threading.Tasks.Task<InvoiceMaker.GusApiService.ZalogujResponse> ZalogujAsync(InvoiceMaker.GusApiService.ZalogujRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://CIS/BIR/PUBL/2014/07) of message WylogujRequest does not match the default value (http://tempuri.org/)
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Wyloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/WylogujResponse")]
        InvoiceMaker.GusApiService.WylogujResponse Wyloguj(InvoiceMaker.GusApiService.WylogujRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/Wyloguj", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/WylogujResponse")]
        System.Threading.Tasks.Task<InvoiceMaker.GusApiService.WylogujResponse> WylogujAsync(InvoiceMaker.GusApiService.WylogujRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://CIS/BIR/PUBL/2014/07) of message DaneSzukajPodmiotyRequest does not match the default value (http://tempuri.org/)
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajPodmioty", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajPodmiotyResponse")]
        InvoiceMaker.GusApiService.DaneSzukajPodmiotyResponse DaneSzukajPodmioty(InvoiceMaker.GusApiService.DaneSzukajPodmiotyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajPodmioty", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DaneSzukajPodmiotyResponse")]
        System.Threading.Tasks.Task<InvoiceMaker.GusApiService.DaneSzukajPodmiotyResponse> DaneSzukajPodmiotyAsync(InvoiceMaker.GusApiService.DaneSzukajPodmiotyRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://CIS/BIR/PUBL/2014/07) of message DanePobierzPelnyRaportRequest does not match the default value (http://tempuri.org/)
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaport", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaportResponse")]
        InvoiceMaker.GusApiService.DanePobierzPelnyRaportResponse DanePobierzPelnyRaport(InvoiceMaker.GusApiService.DanePobierzPelnyRaportRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaport", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzPelnyRaportResponse")]
        System.Threading.Tasks.Task<InvoiceMaker.GusApiService.DanePobierzPelnyRaportResponse> DanePobierzPelnyRaportAsync(InvoiceMaker.GusApiService.DanePobierzPelnyRaportRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://CIS/BIR/PUBL/2014/07) of message DanePobierzRaportZbiorczyRequest does not match the default value (http://tempuri.org/)
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzRaportZbiorczy", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzRaportZbiorczyResponse")]
        InvoiceMaker.GusApiService.DanePobierzRaportZbiorczyResponse DanePobierzRaportZbiorczy(InvoiceMaker.GusApiService.DanePobierzRaportZbiorczyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzRaportZbiorczy", ReplyAction="http://CIS/BIR/PUBL/2014/07/IUslugaBIRzewnPubl/DanePobierzRaportZbiorczyResponse")]
        System.Threading.Tasks.Task<InvoiceMaker.GusApiService.DanePobierzRaportZbiorczyResponse> DanePobierzRaportZbiorczyAsync(InvoiceMaker.GusApiService.DanePobierzRaportZbiorczyRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetValue", WrapperNamespace="http://CIS/BIR/2014/07", IsWrapped=true)]
    public partial class GetValueRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/2014/07", Order=0)]
        public string pNazwaParametru;
        
        public GetValueRequest() {
        }
        
        public GetValueRequest(string pNazwaParametru) {
            this.pNazwaParametru = pNazwaParametru;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetValueResponse", WrapperNamespace="http://CIS/BIR/2014/07", IsWrapped=true)]
    public partial class GetValueResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/2014/07", Order=0)]
        public string GetValueResult;
        
        public GetValueResponse() {
        }
        
        public GetValueResponse(string GetValueResult) {
            this.GetValueResult = GetValueResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Zaloguj", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class ZalogujRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pKluczUzytkownika;
        
        public ZalogujRequest() {
        }
        
        public ZalogujRequest(string pKluczUzytkownika) {
            this.pKluczUzytkownika = pKluczUzytkownika;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ZalogujResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class ZalogujResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string ZalogujResult;
        
        public ZalogujResponse() {
        }
        
        public ZalogujResponse(string ZalogujResult) {
            this.ZalogujResult = ZalogujResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Wyloguj", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class WylogujRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pIdentyfikatorSesji;
        
        public WylogujRequest() {
        }
        
        public WylogujRequest(string pIdentyfikatorSesji) {
            this.pIdentyfikatorSesji = pIdentyfikatorSesji;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WylogujResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class WylogujResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public bool WylogujResult;
        
        public WylogujResponse() {
        }
        
        public WylogujResponse(bool WylogujResult) {
            this.WylogujResult = WylogujResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DaneSzukajPodmioty", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DaneSzukajPodmiotyRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public InvoiceMaker.GusApiService.ParametryWyszukiwania pParametryWyszukiwania;
        
        public DaneSzukajPodmiotyRequest() {
        }
        
        public DaneSzukajPodmiotyRequest(InvoiceMaker.GusApiService.ParametryWyszukiwania pParametryWyszukiwania) {
            this.pParametryWyszukiwania = pParametryWyszukiwania;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DaneSzukajPodmiotyResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DaneSzukajPodmiotyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string DaneSzukajPodmiotyResult;
        
        public DaneSzukajPodmiotyResponse() {
        }
        
        public DaneSzukajPodmiotyResponse(string DaneSzukajPodmiotyResult) {
            this.DaneSzukajPodmiotyResult = DaneSzukajPodmiotyResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzPelnyRaport", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzPelnyRaportRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pRegon;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=1)]
        public string pNazwaRaportu;
        
        public DanePobierzPelnyRaportRequest() {
        }
        
        public DanePobierzPelnyRaportRequest(string pRegon, string pNazwaRaportu) {
            this.pRegon = pRegon;
            this.pNazwaRaportu = pNazwaRaportu;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzPelnyRaportResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzPelnyRaportResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string DanePobierzPelnyRaportResult;
        
        public DanePobierzPelnyRaportResponse() {
        }
        
        public DanePobierzPelnyRaportResponse(string DanePobierzPelnyRaportResult) {
            this.DanePobierzPelnyRaportResult = DanePobierzPelnyRaportResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzRaportZbiorczy", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzRaportZbiorczyRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string pDataRaportu;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=1)]
        public string pNazwaRaportu;
        
        public DanePobierzRaportZbiorczyRequest() {
        }
        
        public DanePobierzRaportZbiorczyRequest(string pDataRaportu, string pNazwaRaportu) {
            this.pDataRaportu = pDataRaportu;
            this.pNazwaRaportu = pNazwaRaportu;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DanePobierzRaportZbiorczyResponse", WrapperNamespace="http://CIS/BIR/PUBL/2014/07", IsWrapped=true)]
    public partial class DanePobierzRaportZbiorczyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://CIS/BIR/PUBL/2014/07", Order=0)]
        public string DanePobierzRaportZbiorczyResult;
        
        public DanePobierzRaportZbiorczyResponse() {
        }
        
        public DanePobierzRaportZbiorczyResponse(string DanePobierzRaportZbiorczyResult) {
            this.DanePobierzRaportZbiorczyResult = DanePobierzRaportZbiorczyResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUslugaBIRzewnPublChannel : InvoiceMaker.GusApiService.IUslugaBIRzewnPubl, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UslugaBIRzewnPublClient : System.ServiceModel.ClientBase<InvoiceMaker.GusApiService.IUslugaBIRzewnPubl>, InvoiceMaker.GusApiService.IUslugaBIRzewnPubl {
        
        public UslugaBIRzewnPublClient() {
        }
        
        public UslugaBIRzewnPublClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UslugaBIRzewnPublClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UslugaBIRzewnPublClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UslugaBIRzewnPublClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InvoiceMaker.GusApiService.GetValueResponse InvoiceMaker.GusApiService.IUslugaBIRzewnPubl.GetValue(InvoiceMaker.GusApiService.GetValueRequest request) {
            return base.Channel.GetValue(request);
        }
        
        public string GetValue(string pNazwaParametru) {
            InvoiceMaker.GusApiService.GetValueRequest inValue = new InvoiceMaker.GusApiService.GetValueRequest();
            inValue.pNazwaParametru = pNazwaParametru;
            InvoiceMaker.GusApiService.GetValueResponse retVal = ((InvoiceMaker.GusApiService.IUslugaBIRzewnPubl)(this)).GetValue(inValue);
            return retVal.GetValueResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InvoiceMaker.GusApiService.GetValueResponse> InvoiceMaker.GusApiService.IUslugaBIRzewnPubl.GetValueAsync(InvoiceMaker.GusApiService.GetValueRequest request) {
            return base.Channel.GetValueAsync(request);
        }
        
        public System.Threading.Tasks.Task<InvoiceMaker.GusApiService.GetValueResponse> GetValueAsync(string pNazwaParametru) {
            InvoiceMaker.GusApiService.GetValueRequest inValue = new InvoiceMaker.GusApiService.GetValueRequest();
            inValue.pNazwaParametru = pNazwaParametru;
            return ((InvoiceMaker.GusApiService.IUslugaBIRzewnPubl)(this)).GetValueAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InvoiceMaker.GusApiService.ZalogujResponse InvoiceMaker.GusApiService.IUslugaBIRzewnPubl.Zaloguj(InvoiceMaker.GusApiService.ZalogujRequest request) {
            return base.Channel.Zaloguj(request);
        }
        
        public string Zaloguj(string pKluczUzytkownika) {
            InvoiceMaker.GusApiService.ZalogujRequest inValue = new InvoiceMaker.GusApiService.ZalogujRequest();
            inValue.pKluczUzytkownika = pKluczUzytkownika;
            InvoiceMaker.GusApiService.ZalogujResponse retVal = ((InvoiceMaker.GusApiService.IUslugaBIRzewnPubl)(this)).Zaloguj(inValue);
            return retVal.ZalogujResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InvoiceMaker.GusApiService.ZalogujResponse> InvoiceMaker.GusApiService.IUslugaBIRzewnPubl.ZalogujAsync(InvoiceMaker.GusApiService.ZalogujRequest request) {
            return base.Channel.ZalogujAsync(request);
        }
        
        public System.Threading.Tasks.Task<InvoiceMaker.GusApiService.ZalogujResponse> ZalogujAsync(string pKluczUzytkownika) {
            InvoiceMaker.GusApiService.ZalogujRequest inValue = new InvoiceMaker.GusApiService.ZalogujRequest();
            inValue.pKluczUzytkownika = pKluczUzytkownika;
            return ((InvoiceMaker.GusApiService.IUslugaBIRzewnPubl)(this)).ZalogujAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InvoiceMaker.GusApiService.WylogujResponse InvoiceMaker.GusApiService.IUslugaBIRzewnPubl.Wyloguj(InvoiceMaker.GusApiService.WylogujRequest request) {
            return base.Channel.Wyloguj(request);
        }
        
        public bool Wyloguj(string pIdentyfikatorSesji) {
            InvoiceMaker.GusApiService.WylogujRequest inValue = new InvoiceMaker.GusApiService.WylogujRequest();
            inValue.pIdentyfikatorSesji = pIdentyfikatorSesji;
            InvoiceMaker.GusApiService.WylogujResponse retVal = ((InvoiceMaker.GusApiService.IUslugaBIRzewnPubl)(this)).Wyloguj(inValue);
            return retVal.WylogujResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InvoiceMaker.GusApiService.WylogujResponse> InvoiceMaker.GusApiService.IUslugaBIRzewnPubl.WylogujAsync(InvoiceMaker.GusApiService.WylogujRequest request) {
            return base.Channel.WylogujAsync(request);
        }
        
        public System.Threading.Tasks.Task<InvoiceMaker.GusApiService.WylogujResponse> WylogujAsync(string pIdentyfikatorSesji) {
            InvoiceMaker.GusApiService.WylogujRequest inValue = new InvoiceMaker.GusApiService.WylogujRequest();
            inValue.pIdentyfikatorSesji = pIdentyfikatorSesji;
            return ((InvoiceMaker.GusApiService.IUslugaBIRzewnPubl)(this)).WylogujAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InvoiceMaker.GusApiService.DaneSzukajPodmiotyResponse InvoiceMaker.GusApiService.IUslugaBIRzewnPubl.DaneSzukajPodmioty(InvoiceMaker.GusApiService.DaneSzukajPodmiotyRequest request) {
            return base.Channel.DaneSzukajPodmioty(request);
        }
        
        public string DaneSzukajPodmioty(InvoiceMaker.GusApiService.ParametryWyszukiwania pParametryWyszukiwania) {
            InvoiceMaker.GusApiService.DaneSzukajPodmiotyRequest inValue = new InvoiceMaker.GusApiService.DaneSzukajPodmiotyRequest();
            inValue.pParametryWyszukiwania = pParametryWyszukiwania;
            InvoiceMaker.GusApiService.DaneSzukajPodmiotyResponse retVal = ((InvoiceMaker.GusApiService.IUslugaBIRzewnPubl)(this)).DaneSzukajPodmioty(inValue);
            return retVal.DaneSzukajPodmiotyResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InvoiceMaker.GusApiService.DaneSzukajPodmiotyResponse> InvoiceMaker.GusApiService.IUslugaBIRzewnPubl.DaneSzukajPodmiotyAsync(InvoiceMaker.GusApiService.DaneSzukajPodmiotyRequest request) {
            return base.Channel.DaneSzukajPodmiotyAsync(request);
        }
        
        public System.Threading.Tasks.Task<InvoiceMaker.GusApiService.DaneSzukajPodmiotyResponse> DaneSzukajPodmiotyAsync(InvoiceMaker.GusApiService.ParametryWyszukiwania pParametryWyszukiwania) {
            InvoiceMaker.GusApiService.DaneSzukajPodmiotyRequest inValue = new InvoiceMaker.GusApiService.DaneSzukajPodmiotyRequest();
            inValue.pParametryWyszukiwania = pParametryWyszukiwania;
            return ((InvoiceMaker.GusApiService.IUslugaBIRzewnPubl)(this)).DaneSzukajPodmiotyAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InvoiceMaker.GusApiService.DanePobierzPelnyRaportResponse InvoiceMaker.GusApiService.IUslugaBIRzewnPubl.DanePobierzPelnyRaport(InvoiceMaker.GusApiService.DanePobierzPelnyRaportRequest request) {
            return base.Channel.DanePobierzPelnyRaport(request);
        }
        
        public string DanePobierzPelnyRaport(string pRegon, string pNazwaRaportu) {
            InvoiceMaker.GusApiService.DanePobierzPelnyRaportRequest inValue = new InvoiceMaker.GusApiService.DanePobierzPelnyRaportRequest();
            inValue.pRegon = pRegon;
            inValue.pNazwaRaportu = pNazwaRaportu;
            InvoiceMaker.GusApiService.DanePobierzPelnyRaportResponse retVal = ((InvoiceMaker.GusApiService.IUslugaBIRzewnPubl)(this)).DanePobierzPelnyRaport(inValue);
            return retVal.DanePobierzPelnyRaportResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InvoiceMaker.GusApiService.DanePobierzPelnyRaportResponse> InvoiceMaker.GusApiService.IUslugaBIRzewnPubl.DanePobierzPelnyRaportAsync(InvoiceMaker.GusApiService.DanePobierzPelnyRaportRequest request) {
            return base.Channel.DanePobierzPelnyRaportAsync(request);
        }
        
        public System.Threading.Tasks.Task<InvoiceMaker.GusApiService.DanePobierzPelnyRaportResponse> DanePobierzPelnyRaportAsync(string pRegon, string pNazwaRaportu) {
            InvoiceMaker.GusApiService.DanePobierzPelnyRaportRequest inValue = new InvoiceMaker.GusApiService.DanePobierzPelnyRaportRequest();
            inValue.pRegon = pRegon;
            inValue.pNazwaRaportu = pNazwaRaportu;
            return ((InvoiceMaker.GusApiService.IUslugaBIRzewnPubl)(this)).DanePobierzPelnyRaportAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        InvoiceMaker.GusApiService.DanePobierzRaportZbiorczyResponse InvoiceMaker.GusApiService.IUslugaBIRzewnPubl.DanePobierzRaportZbiorczy(InvoiceMaker.GusApiService.DanePobierzRaportZbiorczyRequest request) {
            return base.Channel.DanePobierzRaportZbiorczy(request);
        }
        
        public string DanePobierzRaportZbiorczy(string pDataRaportu, string pNazwaRaportu) {
            InvoiceMaker.GusApiService.DanePobierzRaportZbiorczyRequest inValue = new InvoiceMaker.GusApiService.DanePobierzRaportZbiorczyRequest();
            inValue.pDataRaportu = pDataRaportu;
            inValue.pNazwaRaportu = pNazwaRaportu;
            InvoiceMaker.GusApiService.DanePobierzRaportZbiorczyResponse retVal = ((InvoiceMaker.GusApiService.IUslugaBIRzewnPubl)(this)).DanePobierzRaportZbiorczy(inValue);
            return retVal.DanePobierzRaportZbiorczyResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<InvoiceMaker.GusApiService.DanePobierzRaportZbiorczyResponse> InvoiceMaker.GusApiService.IUslugaBIRzewnPubl.DanePobierzRaportZbiorczyAsync(InvoiceMaker.GusApiService.DanePobierzRaportZbiorczyRequest request) {
            return base.Channel.DanePobierzRaportZbiorczyAsync(request);
        }
        
        public System.Threading.Tasks.Task<InvoiceMaker.GusApiService.DanePobierzRaportZbiorczyResponse> DanePobierzRaportZbiorczyAsync(string pDataRaportu, string pNazwaRaportu) {
            InvoiceMaker.GusApiService.DanePobierzRaportZbiorczyRequest inValue = new InvoiceMaker.GusApiService.DanePobierzRaportZbiorczyRequest();
            inValue.pDataRaportu = pDataRaportu;
            inValue.pNazwaRaportu = pNazwaRaportu;
            return ((InvoiceMaker.GusApiService.IUslugaBIRzewnPubl)(this)).DanePobierzRaportZbiorczyAsync(inValue);
        }
    }
}
