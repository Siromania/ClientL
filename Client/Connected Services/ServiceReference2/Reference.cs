﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Decryptorus")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="STG", Namespace="http://schemas.datacontract.org/2004/07/Decryptorus")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(Client.ServiceReference2.CompositeType))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(object[]))]
    public partial class STG : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AppVersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object[] DataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InfoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OperationNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OperationVersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool StatusOpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TokenAppField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TokenUserField;

        public STG(bool statusOp, string operationVersion, string appVersion, string operationName, string info, string tokenUser, string tokenApp, object[] data)
        {
            StatusOp = statusOp;
            OperationVersion = operationVersion;
            AppVersion = appVersion;
            OperationName = operationName;
            Info = info;
            TokenUser = tokenUser;
            TokenApp = tokenApp;
            Data = data;
        }

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
        public string AppVersion {
            get {
                return this.AppVersionField;
            }
            set {
                if ((object.ReferenceEquals(this.AppVersionField, value) != true)) {
                    this.AppVersionField = value;
                    this.RaisePropertyChanged("AppVersion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object[] Data {
            get {
                return this.DataField;
            }
            set {
                if ((object.ReferenceEquals(this.DataField, value) != true)) {
                    this.DataField = value;
                    this.RaisePropertyChanged("Data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Info {
            get {
                return this.InfoField;
            }
            set {
                if ((object.ReferenceEquals(this.InfoField, value) != true)) {
                    this.InfoField = value;
                    this.RaisePropertyChanged("Info");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OperationName {
            get {
                return this.OperationNameField;
            }
            set {
                if ((object.ReferenceEquals(this.OperationNameField, value) != true)) {
                    this.OperationNameField = value;
                    this.RaisePropertyChanged("OperationName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OperationVersion {
            get {
                return this.OperationVersionField;
            }
            set {
                if ((object.ReferenceEquals(this.OperationVersionField, value) != true)) {
                    this.OperationVersionField = value;
                    this.RaisePropertyChanged("OperationVersion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool StatusOp {
            get {
                return this.StatusOpField;
            }
            set {
                if ((this.StatusOpField.Equals(value) != true)) {
                    this.StatusOpField = value;
                    this.RaisePropertyChanged("StatusOp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TokenApp {
            get {
                return this.TokenAppField;
            }
            set {
                if ((object.ReferenceEquals(this.TokenAppField, value) != true)) {
                    this.TokenAppField = value;
                    this.RaisePropertyChanged("TokenApp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TokenUser {
            get {
                return this.TokenUserField;
            }
            set {
                if ((object.ReferenceEquals(this.TokenUserField, value) != true)) {
                    this.TokenUserField = value;
                    this.RaisePropertyChanged("TokenUser");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IDecrypt")]
    public interface IDecrypt {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDecrypt/GetData", ReplyAction="http://tempuri.org/IDecrypt/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDecrypt/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IDecrypt/GetDataUsingDataContractResponse")]
        Client.ServiceReference2.CompositeType GetDataUsingDataContract(Client.ServiceReference2.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDecrypt/m_service", ReplyAction="http://tempuri.org/IDecrypt/m_serviceResponse")]
        Client.ServiceReference2.STG m_service(Client.ServiceReference2.STG msg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDecryptChannel : Client.ServiceReference2.IDecrypt, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DecryptClient : System.ServiceModel.ClientBase<Client.ServiceReference2.IDecrypt>, Client.ServiceReference2.IDecrypt {
        
        public DecryptClient() {
        }
        
        public DecryptClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DecryptClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DecryptClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DecryptClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public Client.ServiceReference2.CompositeType GetDataUsingDataContract(Client.ServiceReference2.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public Client.ServiceReference2.STG m_service(Client.ServiceReference2.STG msg) {
            return base.Channel.m_service(msg);
        }
    }
}
