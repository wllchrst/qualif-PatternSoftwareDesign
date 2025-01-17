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

namespace TrainingFrontEnd.SongService {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="SongServiceSoap", Namespace="http://tempuri.org/")]
    public partial class SongService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetAllSongsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSongOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateSongOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateSongOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteSongOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SongService() {
            this.Url = global::TrainingFrontEnd.Properties.Settings.Default.TrainingFrontEnd_SongService_SongService;
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
        public event GetAllSongsCompletedEventHandler GetAllSongsCompleted;
        
        /// <remarks/>
        public event GetSongCompletedEventHandler GetSongCompleted;
        
        /// <remarks/>
        public event UpdateSongCompletedEventHandler UpdateSongCompleted;
        
        /// <remarks/>
        public event CreateSongCompletedEventHandler CreateSongCompleted;
        
        /// <remarks/>
        public event DeleteSongCompletedEventHandler DeleteSongCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetAllSongs", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetAllSongs() {
            object[] results = this.Invoke("GetAllSongs", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetAllSongsAsync() {
            this.GetAllSongsAsync(null);
        }
        
        /// <remarks/>
        public void GetAllSongsAsync(object userState) {
            if ((this.GetAllSongsOperationCompleted == null)) {
                this.GetAllSongsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetAllSongsOperationCompleted);
            }
            this.InvokeAsync("GetAllSongs", new object[0], this.GetAllSongsOperationCompleted, userState);
        }
        
        private void OnGetAllSongsOperationCompleted(object arg) {
            if ((this.GetAllSongsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetAllSongsCompleted(this, new GetAllSongsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetSong", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetSong(string id) {
            object[] results = this.Invoke("GetSong", new object[] {
                        id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetSongAsync(string id) {
            this.GetSongAsync(id, null);
        }
        
        /// <remarks/>
        public void GetSongAsync(string id, object userState) {
            if ((this.GetSongOperationCompleted == null)) {
                this.GetSongOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSongOperationCompleted);
            }
            this.InvokeAsync("GetSong", new object[] {
                        id}, this.GetSongOperationCompleted, userState);
        }
        
        private void OnGetSongOperationCompleted(object arg) {
            if ((this.GetSongCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSongCompleted(this, new GetSongCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateSong", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string UpdateSong(string id, string songName, int price) {
            object[] results = this.Invoke("UpdateSong", new object[] {
                        id,
                        songName,
                        price});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateSongAsync(string id, string songName, int price) {
            this.UpdateSongAsync(id, songName, price, null);
        }
        
        /// <remarks/>
        public void UpdateSongAsync(string id, string songName, int price, object userState) {
            if ((this.UpdateSongOperationCompleted == null)) {
                this.UpdateSongOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateSongOperationCompleted);
            }
            this.InvokeAsync("UpdateSong", new object[] {
                        id,
                        songName,
                        price}, this.UpdateSongOperationCompleted, userState);
        }
        
        private void OnUpdateSongOperationCompleted(object arg) {
            if ((this.UpdateSongCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateSongCompleted(this, new UpdateSongCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CreateSong", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string CreateSong(string songName, int price) {
            object[] results = this.Invoke("CreateSong", new object[] {
                        songName,
                        price});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CreateSongAsync(string songName, int price) {
            this.CreateSongAsync(songName, price, null);
        }
        
        /// <remarks/>
        public void CreateSongAsync(string songName, int price, object userState) {
            if ((this.CreateSongOperationCompleted == null)) {
                this.CreateSongOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateSongOperationCompleted);
            }
            this.InvokeAsync("CreateSong", new object[] {
                        songName,
                        price}, this.CreateSongOperationCompleted, userState);
        }
        
        private void OnCreateSongOperationCompleted(object arg) {
            if ((this.CreateSongCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateSongCompleted(this, new CreateSongCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DeleteSong", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DeleteSong(string id) {
            object[] results = this.Invoke("DeleteSong", new object[] {
                        id});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteSongAsync(string id) {
            this.DeleteSongAsync(id, null);
        }
        
        /// <remarks/>
        public void DeleteSongAsync(string id, object userState) {
            if ((this.DeleteSongOperationCompleted == null)) {
                this.DeleteSongOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteSongOperationCompleted);
            }
            this.InvokeAsync("DeleteSong", new object[] {
                        id}, this.DeleteSongOperationCompleted, userState);
        }
        
        private void OnDeleteSongOperationCompleted(object arg) {
            if ((this.DeleteSongCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteSongCompleted(this, new DeleteSongCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public delegate void GetAllSongsCompletedEventHandler(object sender, GetAllSongsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetAllSongsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetAllSongsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void GetSongCompletedEventHandler(object sender, GetSongCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSongCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSongCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void UpdateSongCompletedEventHandler(object sender, UpdateSongCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateSongCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateSongCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void CreateSongCompletedEventHandler(object sender, CreateSongCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateSongCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreateSongCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public delegate void DeleteSongCompletedEventHandler(object sender, DeleteSongCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9037.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteSongCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteSongCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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