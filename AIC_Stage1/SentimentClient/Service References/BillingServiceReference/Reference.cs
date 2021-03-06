﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SentimentClient.BillingServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BillDetails", Namespace="http://schemas.datacontract.org/2004/07/BillingService")]
    [System.SerializableAttribute()]
    public partial class BillDetails : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double amountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int customerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string customerUsernameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool isPayedField;
        
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
        public double amount {
            get {
                return this.amountField;
            }
            set {
                if ((this.amountField.Equals(value) != true)) {
                    this.amountField = value;
                    this.RaisePropertyChanged("amount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int customerId {
            get {
                return this.customerIdField;
            }
            set {
                if ((this.customerIdField.Equals(value) != true)) {
                    this.customerIdField = value;
                    this.RaisePropertyChanged("customerId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string customerUsername {
            get {
                return this.customerUsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.customerUsernameField, value) != true)) {
                    this.customerUsernameField = value;
                    this.RaisePropertyChanged("customerUsername");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isPayed {
            get {
                return this.isPayedField;
            }
            set {
                if ((this.isPayedField.Equals(value) != true)) {
                    this.isPayedField = value;
                    this.RaisePropertyChanged("isPayed");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BillingServiceReference.IBillingService")]
    public interface IBillingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillingService/ListUsersBills", ReplyAction="http://tempuri.org/IBillingService/ListUsersBillsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentException), Action="http://tempuri.org/IBillingService/ListUsersBillsArgumentExceptionFault", Name="ArgumentException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        int[] ListUsersBills(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillingService/ListUsersBills", ReplyAction="http://tempuri.org/IBillingService/ListUsersBillsResponse")]
        System.Threading.Tasks.Task<int[]> ListUsersBillsAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillingService/GetBill", ReplyAction="http://tempuri.org/IBillingService/GetBillResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentException), Action="http://tempuri.org/IBillingService/GetBillArgumentExceptionFault", Name="ArgumentException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        SentimentClient.BillingServiceReference.BillDetails GetBill(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillingService/GetBill", ReplyAction="http://tempuri.org/IBillingService/GetBillResponse")]
        System.Threading.Tasks.Task<SentimentClient.BillingServiceReference.BillDetails> GetBillAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillingService/PayBill", ReplyAction="http://tempuri.org/IBillingService/PayBillResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentException), Action="http://tempuri.org/IBillingService/PayBillArgumentExceptionFault", Name="ArgumentException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        void PayBill(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillingService/PayBill", ReplyAction="http://tempuri.org/IBillingService/PayBillResponse")]
        System.Threading.Tasks.Task PayBillAsync(int Id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillingService/CalculateBillsForUser", ReplyAction="http://tempuri.org/IBillingService/CalculateBillsForUserResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentException), Action="http://tempuri.org/IBillingService/CalculateBillsForUserArgumentExceptionFault", Name="ArgumentException", Namespace="http://schemas.datacontract.org/2004/07/System")]
        void CalculateBillsForUser(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBillingService/CalculateBillsForUser", ReplyAction="http://tempuri.org/IBillingService/CalculateBillsForUserResponse")]
        System.Threading.Tasks.Task CalculateBillsForUserAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBillingServiceChannel : SentimentClient.BillingServiceReference.IBillingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BillingServiceClient : System.ServiceModel.ClientBase<SentimentClient.BillingServiceReference.IBillingService>, SentimentClient.BillingServiceReference.IBillingService {
        
        public BillingServiceClient() {
        }
        
        public BillingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BillingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BillingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BillingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int[] ListUsersBills(string username) {
            return base.Channel.ListUsersBills(username);
        }
        
        public System.Threading.Tasks.Task<int[]> ListUsersBillsAsync(string username) {
            return base.Channel.ListUsersBillsAsync(username);
        }
        
        public SentimentClient.BillingServiceReference.BillDetails GetBill(int Id) {
            return base.Channel.GetBill(Id);
        }
        
        public System.Threading.Tasks.Task<SentimentClient.BillingServiceReference.BillDetails> GetBillAsync(int Id) {
            return base.Channel.GetBillAsync(Id);
        }
        
        public void PayBill(int Id) {
            base.Channel.PayBill(Id);
        }
        
        public System.Threading.Tasks.Task PayBillAsync(int Id) {
            return base.Channel.PayBillAsync(Id);
        }
        
        public void CalculateBillsForUser(string username) {
            base.Channel.CalculateBillsForUser(username);
        }
        
        public System.Threading.Tasks.Task CalculateBillsForUserAsync(string username) {
            return base.Channel.CalculateBillsForUserAsync(username);
        }
    }
}
