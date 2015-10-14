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

namespace istEncuestasMVC.Service700vipProxy {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Service700vipSoap", Namespace="http://tempuri.org/WebService700vip/Service700vip.asmx")]
    public partial class Service700vip : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback WsIstSemEmpIngresoOperationCompleted;
        
        private System.Threading.SendOrPostCallback WsIstSemEmpListaSemaforoOperationCompleted;
        
        private System.Threading.SendOrPostCallback WsIstSemEmpDetalleListaOperationCompleted;
        
        private System.Threading.SendOrPostCallback WsIstSemEmpEmpresaDetOperationCompleted;
        
        private System.Threading.SendOrPostCallback WsIstSemEmpGuardaestadoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Service700vip() {
            this.Url = global::istEncuestasMVC.Properties.Settings.Default.istEncuestasMVC_Service700vipProxy_Service700vip;
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
        public event WsIstSemEmpIngresoCompletedEventHandler WsIstSemEmpIngresoCompleted;
        
        /// <remarks/>
        public event WsIstSemEmpListaSemaforoCompletedEventHandler WsIstSemEmpListaSemaforoCompleted;
        
        /// <remarks/>
        public event WsIstSemEmpDetalleListaCompletedEventHandler WsIstSemEmpDetalleListaCompleted;
        
        /// <remarks/>
        public event WsIstSemEmpEmpresaDetCompletedEventHandler WsIstSemEmpEmpresaDetCompleted;
        
        /// <remarks/>
        public event WsIstSemEmpGuardaestadoCompletedEventHandler WsIstSemEmpGuardaestadoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WebService700vip/Service700vip.asmx/WsIstSemEmpIngreso", RequestNamespace="http://tempuri.org/WebService700vip/Service700vip.asmx", ResponseNamespace="http://tempuri.org/WebService700vip/Service700vip.asmx", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string WsIstSemEmpIngreso(string Rut, string Clave) {
            object[] results = this.Invoke("WsIstSemEmpIngreso", new object[] {
                        Rut,
                        Clave});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void WsIstSemEmpIngresoAsync(string Rut, string Clave) {
            this.WsIstSemEmpIngresoAsync(Rut, Clave, null);
        }
        
        /// <remarks/>
        public void WsIstSemEmpIngresoAsync(string Rut, string Clave, object userState) {
            if ((this.WsIstSemEmpIngresoOperationCompleted == null)) {
                this.WsIstSemEmpIngresoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWsIstSemEmpIngresoOperationCompleted);
            }
            this.InvokeAsync("WsIstSemEmpIngreso", new object[] {
                        Rut,
                        Clave}, this.WsIstSemEmpIngresoOperationCompleted, userState);
        }
        
        private void OnWsIstSemEmpIngresoOperationCompleted(object arg) {
            if ((this.WsIstSemEmpIngresoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WsIstSemEmpIngresoCompleted(this, new WsIstSemEmpIngresoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WebService700vip/Service700vip.asmx/WsIstSemEmpListaSemaforo", RequestNamespace="http://tempuri.org/WebService700vip/Service700vip.asmx", ResponseNamespace="http://tempuri.org/WebService700vip/Service700vip.asmx", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string WsIstSemEmpListaSemaforo(string RutPer) {
            object[] results = this.Invoke("WsIstSemEmpListaSemaforo", new object[] {
                        RutPer});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void WsIstSemEmpListaSemaforoAsync(string RutPer) {
            this.WsIstSemEmpListaSemaforoAsync(RutPer, null);
        }
        
        /// <remarks/>
        public void WsIstSemEmpListaSemaforoAsync(string RutPer, object userState) {
            if ((this.WsIstSemEmpListaSemaforoOperationCompleted == null)) {
                this.WsIstSemEmpListaSemaforoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWsIstSemEmpListaSemaforoOperationCompleted);
            }
            this.InvokeAsync("WsIstSemEmpListaSemaforo", new object[] {
                        RutPer}, this.WsIstSemEmpListaSemaforoOperationCompleted, userState);
        }
        
        private void OnWsIstSemEmpListaSemaforoOperationCompleted(object arg) {
            if ((this.WsIstSemEmpListaSemaforoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WsIstSemEmpListaSemaforoCompleted(this, new WsIstSemEmpListaSemaforoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WebService700vip/Service700vip.asmx/WsIstSemEmpDetalleLista", RequestNamespace="http://tempuri.org/WebService700vip/Service700vip.asmx", ResponseNamespace="http://tempuri.org/WebService700vip/Service700vip.asmx", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string WsIstSemEmpDetalleLista(string RutPer, string Color) {
            object[] results = this.Invoke("WsIstSemEmpDetalleLista", new object[] {
                        RutPer,
                        Color});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void WsIstSemEmpDetalleListaAsync(string RutPer, string Color) {
            this.WsIstSemEmpDetalleListaAsync(RutPer, Color, null);
        }
        
        /// <remarks/>
        public void WsIstSemEmpDetalleListaAsync(string RutPer, string Color, object userState) {
            if ((this.WsIstSemEmpDetalleListaOperationCompleted == null)) {
                this.WsIstSemEmpDetalleListaOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWsIstSemEmpDetalleListaOperationCompleted);
            }
            this.InvokeAsync("WsIstSemEmpDetalleLista", new object[] {
                        RutPer,
                        Color}, this.WsIstSemEmpDetalleListaOperationCompleted, userState);
        }
        
        private void OnWsIstSemEmpDetalleListaOperationCompleted(object arg) {
            if ((this.WsIstSemEmpDetalleListaCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WsIstSemEmpDetalleListaCompleted(this, new WsIstSemEmpDetalleListaCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WebService700vip/Service700vip.asmx/WsIstSemEmpEmpresaDet", RequestNamespace="http://tempuri.org/WebService700vip/Service700vip.asmx", ResponseNamespace="http://tempuri.org/WebService700vip/Service700vip.asmx", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string WsIstSemEmpEmpresaDet(string CodVip) {
            object[] results = this.Invoke("WsIstSemEmpEmpresaDet", new object[] {
                        CodVip});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void WsIstSemEmpEmpresaDetAsync(string CodVip) {
            this.WsIstSemEmpEmpresaDetAsync(CodVip, null);
        }
        
        /// <remarks/>
        public void WsIstSemEmpEmpresaDetAsync(string CodVip, object userState) {
            if ((this.WsIstSemEmpEmpresaDetOperationCompleted == null)) {
                this.WsIstSemEmpEmpresaDetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWsIstSemEmpEmpresaDetOperationCompleted);
            }
            this.InvokeAsync("WsIstSemEmpEmpresaDet", new object[] {
                        CodVip}, this.WsIstSemEmpEmpresaDetOperationCompleted, userState);
        }
        
        private void OnWsIstSemEmpEmpresaDetOperationCompleted(object arg) {
            if ((this.WsIstSemEmpEmpresaDetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WsIstSemEmpEmpresaDetCompleted(this, new WsIstSemEmpEmpresaDetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/WebService700vip/Service700vip.asmx/WsIstSemEmpGuardaestado", RequestNamespace="http://tempuri.org/WebService700vip/Service700vip.asmx", ResponseNamespace="http://tempuri.org/WebService700vip/Service700vip.asmx", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string WsIstSemEmpGuardaestado(string CodVip, string RutEjeEmp, string CodSitVip700, string GlsSeguimiento) {
            object[] results = this.Invoke("WsIstSemEmpGuardaestado", new object[] {
                        CodVip,
                        RutEjeEmp,
                        CodSitVip700,
                        GlsSeguimiento});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void WsIstSemEmpGuardaestadoAsync(string CodVip, string RutEjeEmp, string CodSitVip700, string GlsSeguimiento) {
            this.WsIstSemEmpGuardaestadoAsync(CodVip, RutEjeEmp, CodSitVip700, GlsSeguimiento, null);
        }
        
        /// <remarks/>
        public void WsIstSemEmpGuardaestadoAsync(string CodVip, string RutEjeEmp, string CodSitVip700, string GlsSeguimiento, object userState) {
            if ((this.WsIstSemEmpGuardaestadoOperationCompleted == null)) {
                this.WsIstSemEmpGuardaestadoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnWsIstSemEmpGuardaestadoOperationCompleted);
            }
            this.InvokeAsync("WsIstSemEmpGuardaestado", new object[] {
                        CodVip,
                        RutEjeEmp,
                        CodSitVip700,
                        GlsSeguimiento}, this.WsIstSemEmpGuardaestadoOperationCompleted, userState);
        }
        
        private void OnWsIstSemEmpGuardaestadoOperationCompleted(object arg) {
            if ((this.WsIstSemEmpGuardaestadoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.WsIstSemEmpGuardaestadoCompleted(this, new WsIstSemEmpGuardaestadoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void WsIstSemEmpIngresoCompletedEventHandler(object sender, WsIstSemEmpIngresoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WsIstSemEmpIngresoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WsIstSemEmpIngresoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void WsIstSemEmpListaSemaforoCompletedEventHandler(object sender, WsIstSemEmpListaSemaforoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WsIstSemEmpListaSemaforoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WsIstSemEmpListaSemaforoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void WsIstSemEmpDetalleListaCompletedEventHandler(object sender, WsIstSemEmpDetalleListaCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WsIstSemEmpDetalleListaCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WsIstSemEmpDetalleListaCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void WsIstSemEmpEmpresaDetCompletedEventHandler(object sender, WsIstSemEmpEmpresaDetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WsIstSemEmpEmpresaDetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WsIstSemEmpEmpresaDetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void WsIstSemEmpGuardaestadoCompletedEventHandler(object sender, WsIstSemEmpGuardaestadoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class WsIstSemEmpGuardaestadoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal WsIstSemEmpGuardaestadoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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