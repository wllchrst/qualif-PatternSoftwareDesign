﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace TrainingFrontEnd.TableService {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="TableServiceSoap", Namespace="http://tempuri.org/")]
    public partial class TableService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetTableByUserIDSongIDOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateTableOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetUserTransactionOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetAllTableOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public TableService() {
            this.Url = global::TrainingFrontEnd.Properties.Settings.Default.TrainingFrontEnd_TableService_TableService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetTableByUserIDSongIDCompletedEventHandler GetTableByUserIDSongIDCompleted;
        
        /// <remarks/>
        public event CreateTableCompletedEventHandler CreateTableCompleted;
        
        /// <remarks/>
        public event GetUserTransactionCompletedEventHandler GetUserTransactionCompleted;
        
        /// <remarks/>
        public event GetAllTableCompletedEventHandler GetAllTableCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetTableByUserIDSongID", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetTableByUserIDSongID(string songID, string userID) {
            object[] results = this.Invoke("GetTableByUserIDSongID", new object[] {
                        songID,
                        userID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetTableByUserIDSongIDAsync(string songID, string userID) {
            this.GetTableByUserIDSongIDAsync(songID, userID, null);
        }
        
        /// <remarks/>
        public void GetTableByUserIDSongIDAsync(string songID, string userID, object userState) {
            if ((this.GetTableByUserIDSongIDOperationCompleted == null)) {
                this.GetTableByUserIDSongIDOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetTableByUserIDSongIDOperationCompleted);
            }
            this.InvokeAsync("GetTableByUserIDSongID", new object[] {
                        songID,
                        userID}, this.GetTableByUserIDSongIDOperationCompleted, userState);
        }
        
        private void OnGetTableByUserIDSongIDOperationCompleted(object arg) {
            if ((this.GetTableByUserIDSongIDCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetTableByUserIDSongIDCompleted(this, new GetTableByUserIDSongIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CreateTable", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CreateTable(string userID, string songID) {
            object[] results = this.Invoke("CreateTable", new object[] {
                        userID,
                        songID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CreateTableAsync(string userID, string songID) {
            this.CreateTableAsync(userID, songID, null);
        }
        
        /// <remarks/>
        public void CreateTableAsync(string userID, string songID, object userState) {
            if ((this.CreateTableOperationCompleted == null)) {
                this.CreateTableOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateTableOperationCompleted);
            }
            this.InvokeAsync("CreateTable", new object[] {
                        userID,
                        songID}, this.CreateTableOperationCompleted, userState);
        }
        
        private void OnCreateTableOperationCompleted(object arg) {
            if ((this.CreateTableCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateTableCompleted(this, new CreateTableCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetUserTransaction", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetUserTransaction(string userID) {
            object[] results = this.Invoke("GetUserTransaction", new object[] {
                        userID});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetUserTransactionAsync(string userID) {
            this.GetUserTransactionAsync(userID, null);
        }
        
        /// <remarks/>
        public void GetUserTransactionAsync(string userID, object userState) {
            if ((this.GetUserTransactionOperationCompleted == null)) {
                this.GetUserTransactionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetUserTransactionOperationCompleted);
            }
            this.InvokeAsync("GetUserTransaction", new object[] {
                        userID}, this.GetUserTransactionOperationCompleted, userState);
        }
        
        private void OnGetUserTransactionOperationCompleted(object arg) {
            if ((this.GetUserTransactionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetUserTransactionCompleted(this, new GetUserTransactionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllTable", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllTable() {
            object[] results = this.Invoke("GetAllTable", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllTableAsync() {
            this.GetAllTableAsync(null);
        }
        
        /// <remarks/>
        public void GetAllTableAsync(object userState) {
            if ((this.GetAllTableOperationCompleted == null)) {
                this.GetAllTableOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllTableOperationCompleted);
            }
            this.InvokeAsync("GetAllTable", new object[0], this.GetAllTableOperationCompleted, userState);
        }
        
        private void OnGetAllTableOperationCompleted(object arg) {
            if ((this.GetAllTableCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllTableCompleted(this, new GetAllTableCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void GetTableByUserIDSongIDCompletedEventHandler(object sender, GetTableByUserIDSongIDCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetTableByUserIDSongIDCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetTableByUserIDSongIDCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void CreateTableCompletedEventHandler(object sender, CreateTableCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateTableCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreateTableCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void GetUserTransactionCompletedEventHandler(object sender, GetUserTransactionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetUserTransactionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetUserTransactionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    public delegate void GetAllTableCompletedEventHandler(object sender, GetAllTableCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllTableCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllTableCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591