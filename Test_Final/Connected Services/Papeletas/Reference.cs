﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test_Final.Papeletas {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PapeletaBE", Namespace="http://schemas.datacontract.org/2004/07/WCF_Final_01")]
    [System.SerializableAttribute()]
    public partial class PapeletaBE : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Cod_AgenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Cod_InfraccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Est_PapeletaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Fec_PapeletaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Num_PapeletaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Num_PlacaField;
        
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
        public string Cod_Agente {
            get {
                return this.Cod_AgenteField;
            }
            set {
                if ((object.ReferenceEquals(this.Cod_AgenteField, value) != true)) {
                    this.Cod_AgenteField = value;
                    this.RaisePropertyChanged("Cod_Agente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Cod_Infraccion {
            get {
                return this.Cod_InfraccionField;
            }
            set {
                if ((object.ReferenceEquals(this.Cod_InfraccionField, value) != true)) {
                    this.Cod_InfraccionField = value;
                    this.RaisePropertyChanged("Cod_Infraccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Est_Papeleta {
            get {
                return this.Est_PapeletaField;
            }
            set {
                if ((object.ReferenceEquals(this.Est_PapeletaField, value) != true)) {
                    this.Est_PapeletaField = value;
                    this.RaisePropertyChanged("Est_Papeleta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Fec_Papeleta {
            get {
                return this.Fec_PapeletaField;
            }
            set {
                if ((this.Fec_PapeletaField.Equals(value) != true)) {
                    this.Fec_PapeletaField = value;
                    this.RaisePropertyChanged("Fec_Papeleta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Num_Papeleta {
            get {
                return this.Num_PapeletaField;
            }
            set {
                if ((object.ReferenceEquals(this.Num_PapeletaField, value) != true)) {
                    this.Num_PapeletaField = value;
                    this.RaisePropertyChanged("Num_Papeleta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Num_Placa {
            get {
                return this.Num_PlacaField;
            }
            set {
                if ((object.ReferenceEquals(this.Num_PlacaField, value) != true)) {
                    this.Num_PlacaField = value;
                    this.RaisePropertyChanged("Num_Placa");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Papeletas.IServicioPapeletas")]
    public interface IServicioPapeletas {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPapeletas/ListarPapeleta", ReplyAction="http://tempuri.org/IServicioPapeletas/ListarPapeletaResponse")]
        Test_Final.Papeletas.PapeletaBE[] ListarPapeleta();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPapeletas/ListarPapeleta", ReplyAction="http://tempuri.org/IServicioPapeletas/ListarPapeletaResponse")]
        System.Threading.Tasks.Task<Test_Final.Papeletas.PapeletaBE[]> ListarPapeletaAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPapeletas/ListarPapeletasPorFechas", ReplyAction="http://tempuri.org/IServicioPapeletas/ListarPapeletasPorFechasResponse")]
        Test_Final.Papeletas.PapeletaBE[] ListarPapeletasPorFechas(System.DateTime fecini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPapeletas/ListarPapeletasPorFechas", ReplyAction="http://tempuri.org/IServicioPapeletas/ListarPapeletasPorFechasResponse")]
        System.Threading.Tasks.Task<Test_Final.Papeletas.PapeletaBE[]> ListarPapeletasPorFechasAsync(System.DateTime fecini, System.DateTime fecfin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPapeletas/ListarPapeletasImpagas", ReplyAction="http://tempuri.org/IServicioPapeletas/ListarPapeletasImpagasResponse")]
        Test_Final.Papeletas.PapeletaBE[] ListarPapeletasImpagas(string strCod);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPapeletas/ListarPapeletasImpagas", ReplyAction="http://tempuri.org/IServicioPapeletas/ListarPapeletasImpagasResponse")]
        System.Threading.Tasks.Task<Test_Final.Papeletas.PapeletaBE[]> ListarPapeletasImpagasAsync(string strCod);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioPapeletasChannel : Test_Final.Papeletas.IServicioPapeletas, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioPapeletasClient : System.ServiceModel.ClientBase<Test_Final.Papeletas.IServicioPapeletas>, Test_Final.Papeletas.IServicioPapeletas {
        
        public ServicioPapeletasClient() {
        }
        
        public ServicioPapeletasClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioPapeletasClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPapeletasClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPapeletasClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Test_Final.Papeletas.PapeletaBE[] ListarPapeleta() {
            return base.Channel.ListarPapeleta();
        }
        
        public System.Threading.Tasks.Task<Test_Final.Papeletas.PapeletaBE[]> ListarPapeletaAsync() {
            return base.Channel.ListarPapeletaAsync();
        }
        
        public Test_Final.Papeletas.PapeletaBE[] ListarPapeletasPorFechas(System.DateTime fecini, System.DateTime fecfin) {
            return base.Channel.ListarPapeletasPorFechas(fecini, fecfin);
        }
        
        public System.Threading.Tasks.Task<Test_Final.Papeletas.PapeletaBE[]> ListarPapeletasPorFechasAsync(System.DateTime fecini, System.DateTime fecfin) {
            return base.Channel.ListarPapeletasPorFechasAsync(fecini, fecfin);
        }
        
        public Test_Final.Papeletas.PapeletaBE[] ListarPapeletasImpagas(string strCod) {
            return base.Channel.ListarPapeletasImpagas(strCod);
        }
        
        public System.Threading.Tasks.Task<Test_Final.Papeletas.PapeletaBE[]> ListarPapeletasImpagasAsync(string strCod) {
            return base.Channel.ListarPapeletasImpagasAsync(strCod);
        }
    }
}
