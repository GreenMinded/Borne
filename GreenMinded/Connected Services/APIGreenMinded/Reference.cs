﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GreenMinded.APIGreenMinded {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="stations", Namespace="http://schemas.datacontract.org/2004/07/WebService")]
    [System.SerializableAttribute()]
    public partial class stations : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> client_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GreenMinded.APIGreenMinded.clients clientsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string latField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string longField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string mac_addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GreenMinded.APIGreenMinded.questions[] questionsField;
        
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
        public System.Nullable<int> client_id {
            get {
                return this.client_idField;
            }
            set {
                if ((this.client_idField.Equals(value) != true)) {
                    this.client_idField = value;
                    this.RaisePropertyChanged("client_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GreenMinded.APIGreenMinded.clients clients {
            get {
                return this.clientsField;
            }
            set {
                if ((object.ReferenceEquals(this.clientsField, value) != true)) {
                    this.clientsField = value;
                    this.RaisePropertyChanged("clients");
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
        public string lat {
            get {
                return this.latField;
            }
            set {
                if ((object.ReferenceEquals(this.latField, value) != true)) {
                    this.latField = value;
                    this.RaisePropertyChanged("lat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string @long {
            get {
                return this.longField;
            }
            set {
                if ((object.ReferenceEquals(this.longField, value) != true)) {
                    this.longField = value;
                    this.RaisePropertyChanged("long");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string mac_address {
            get {
                return this.mac_addressField;
            }
            set {
                if ((object.ReferenceEquals(this.mac_addressField, value) != true)) {
                    this.mac_addressField = value;
                    this.RaisePropertyChanged("mac_address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GreenMinded.APIGreenMinded.questions[] questions {
            get {
                return this.questionsField;
            }
            set {
                if ((object.ReferenceEquals(this.questionsField, value) != true)) {
                    this.questionsField = value;
                    this.RaisePropertyChanged("questions");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="clients", Namespace="http://schemas.datacontract.org/2004/07/WebService")]
    [System.SerializableAttribute()]
    public partial class clients : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string business_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GreenMinded.APIGreenMinded.stations[] stationsField;
        
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
        public string business_name {
            get {
                return this.business_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.business_nameField, value) != true)) {
                    this.business_nameField = value;
                    this.RaisePropertyChanged("business_name");
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
        public GreenMinded.APIGreenMinded.stations[] stations {
            get {
                return this.stationsField;
            }
            set {
                if ((object.ReferenceEquals(this.stationsField, value) != true)) {
                    this.stationsField = value;
                    this.RaisePropertyChanged("stations");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="questions", Namespace="http://schemas.datacontract.org/2004/07/WebService")]
    [System.SerializableAttribute()]
    public partial class questions : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> answer_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GreenMinded.APIGreenMinded.answers answersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> date_endField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> date_startField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string labelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> station_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GreenMinded.APIGreenMinded.stations stationsField;
        
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
        public System.Nullable<int> answer_id {
            get {
                return this.answer_idField;
            }
            set {
                if ((this.answer_idField.Equals(value) != true)) {
                    this.answer_idField = value;
                    this.RaisePropertyChanged("answer_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GreenMinded.APIGreenMinded.answers answers {
            get {
                return this.answersField;
            }
            set {
                if ((object.ReferenceEquals(this.answersField, value) != true)) {
                    this.answersField = value;
                    this.RaisePropertyChanged("answers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> date_end {
            get {
                return this.date_endField;
            }
            set {
                if ((this.date_endField.Equals(value) != true)) {
                    this.date_endField = value;
                    this.RaisePropertyChanged("date_end");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> date_start {
            get {
                return this.date_startField;
            }
            set {
                if ((this.date_startField.Equals(value) != true)) {
                    this.date_startField = value;
                    this.RaisePropertyChanged("date_start");
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
        public string label {
            get {
                return this.labelField;
            }
            set {
                if ((object.ReferenceEquals(this.labelField, value) != true)) {
                    this.labelField = value;
                    this.RaisePropertyChanged("label");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> station_id {
            get {
                return this.station_idField;
            }
            set {
                if ((this.station_idField.Equals(value) != true)) {
                    this.station_idField = value;
                    this.RaisePropertyChanged("station_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GreenMinded.APIGreenMinded.stations stations {
            get {
                return this.stationsField;
            }
            set {
                if ((object.ReferenceEquals(this.stationsField, value) != true)) {
                    this.stationsField = value;
                    this.RaisePropertyChanged("stations");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="answers", Namespace="http://schemas.datacontract.org/2004/07/WebService")]
    [System.SerializableAttribute()]
    public partial class answers : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> count_leftField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> count_rightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GreenMinded.APIGreenMinded.questions[] questionsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string response_leftField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string response_rightField;
        
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
        public System.Nullable<int> count_left {
            get {
                return this.count_leftField;
            }
            set {
                if ((this.count_leftField.Equals(value) != true)) {
                    this.count_leftField = value;
                    this.RaisePropertyChanged("count_left");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> count_right {
            get {
                return this.count_rightField;
            }
            set {
                if ((this.count_rightField.Equals(value) != true)) {
                    this.count_rightField = value;
                    this.RaisePropertyChanged("count_right");
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
        public GreenMinded.APIGreenMinded.questions[] questions {
            get {
                return this.questionsField;
            }
            set {
                if ((object.ReferenceEquals(this.questionsField, value) != true)) {
                    this.questionsField = value;
                    this.RaisePropertyChanged("questions");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string response_left {
            get {
                return this.response_leftField;
            }
            set {
                if ((object.ReferenceEquals(this.response_leftField, value) != true)) {
                    this.response_leftField = value;
                    this.RaisePropertyChanged("response_left");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string response_right {
            get {
                return this.response_rightField;
            }
            set {
                if ((object.ReferenceEquals(this.response_rightField, value) != true)) {
                    this.response_rightField = value;
                    this.RaisePropertyChanged("response_right");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SPI_QuestionAnswer_Result", Namespace="http://schemas.datacontract.org/2004/07/WebService")]
    [System.SerializableAttribute()]
    public partial class SPI_QuestionAnswer_Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> answer_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> date_endField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> date_startField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string labelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string response_leftField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string response_rightField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> station_idField;
        
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
        public System.Nullable<int> answer_id {
            get {
                return this.answer_idField;
            }
            set {
                if ((this.answer_idField.Equals(value) != true)) {
                    this.answer_idField = value;
                    this.RaisePropertyChanged("answer_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> date_end {
            get {
                return this.date_endField;
            }
            set {
                if ((this.date_endField.Equals(value) != true)) {
                    this.date_endField = value;
                    this.RaisePropertyChanged("date_end");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> date_start {
            get {
                return this.date_startField;
            }
            set {
                if ((this.date_startField.Equals(value) != true)) {
                    this.date_startField = value;
                    this.RaisePropertyChanged("date_start");
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
        public string label {
            get {
                return this.labelField;
            }
            set {
                if ((object.ReferenceEquals(this.labelField, value) != true)) {
                    this.labelField = value;
                    this.RaisePropertyChanged("label");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string response_left {
            get {
                return this.response_leftField;
            }
            set {
                if ((object.ReferenceEquals(this.response_leftField, value) != true)) {
                    this.response_leftField = value;
                    this.RaisePropertyChanged("response_left");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string response_right {
            get {
                return this.response_rightField;
            }
            set {
                if ((object.ReferenceEquals(this.response_rightField, value) != true)) {
                    this.response_rightField = value;
                    this.RaisePropertyChanged("response_right");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> station_id {
            get {
                return this.station_idField;
            }
            set {
                if ((this.station_idField.Equals(value) != true)) {
                    this.station_idField = value;
                    this.RaisePropertyChanged("station_id");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="APIGreenMinded.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStation", ReplyAction="http://tempuri.org/IService1/GetStationResponse")]
        GreenMinded.APIGreenMinded.stations[] GetStation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetStation", ReplyAction="http://tempuri.org/IService1/GetStationResponse")]
        System.Threading.Tasks.Task<GreenMinded.APIGreenMinded.stations[]> GetStationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetQuestionAnswer", ReplyAction="http://tempuri.org/IService1/GetQuestionAnswerResponse")]
        GreenMinded.APIGreenMinded.SPI_QuestionAnswer_Result[] GetQuestionAnswer();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetQuestionAnswer", ReplyAction="http://tempuri.org/IService1/GetQuestionAnswerResponse")]
        System.Threading.Tasks.Task<GreenMinded.APIGreenMinded.SPI_QuestionAnswer_Result[]> GetQuestionAnswerAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : GreenMinded.APIGreenMinded.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<GreenMinded.APIGreenMinded.IService1>, GreenMinded.APIGreenMinded.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GreenMinded.APIGreenMinded.stations[] GetStation() {
            return base.Channel.GetStation();
        }
        
        public System.Threading.Tasks.Task<GreenMinded.APIGreenMinded.stations[]> GetStationAsync() {
            return base.Channel.GetStationAsync();
        }
        
        public GreenMinded.APIGreenMinded.SPI_QuestionAnswer_Result[] GetQuestionAnswer() {
            return base.Channel.GetQuestionAnswer();
        }
        
        public System.Threading.Tasks.Task<GreenMinded.APIGreenMinded.SPI_QuestionAnswer_Result[]> GetQuestionAnswerAsync() {
            return base.Channel.GetQuestionAnswerAsync();
        }
    }
}
