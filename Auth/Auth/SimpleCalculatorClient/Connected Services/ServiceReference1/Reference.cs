﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuthClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthName", Namespace="http://schemas.datacontract.org/2004/07/AuthService")]
    [System.SerializableAttribute()]
    public partial class AuthName : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAuthTest")]
    public interface IAuthTest {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthTest/GetAuthName", ReplyAction="http://tempuri.org/IAuthTest/GetAuthNameResponse")]
        AuthClient.ServiceReference1.AuthName GetAuthName();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthTest/GetAuthName", ReplyAction="http://tempuri.org/IAuthTest/GetAuthNameResponse")]
        System.Threading.Tasks.Task<AuthClient.ServiceReference1.AuthName> GetAuthNameAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthTestChannel : AuthClient.ServiceReference1.IAuthTest, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthTestClient : System.ServiceModel.ClientBase<AuthClient.ServiceReference1.IAuthTest>, AuthClient.ServiceReference1.IAuthTest {
        
        public AuthTestClient() {
        }
        
        public AuthTestClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthTestClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthTestClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthTestClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public AuthClient.ServiceReference1.AuthName GetAuthName() {
            return base.Channel.GetAuthName();
        }
        
        public System.Threading.Tasks.Task<AuthClient.ServiceReference1.AuthName> GetAuthNameAsync() {
            return base.Channel.GetAuthNameAsync();
        }
    }
}
