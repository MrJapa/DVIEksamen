﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.dvi {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://dvimonitor.azurewebsites.net/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://dvimonitor.azurewebsites.net/", ConfigurationName="dvi.monitorSoap")]
    public interface monitorSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockTemp", ReplyAction="*")]
        double StockTemp();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockTemp", ReplyAction="*")]
        System.Threading.Tasks.Task<double> StockTempAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockHumidity", ReplyAction="*")]
        double StockHumidity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockHumidity", ReplyAction="*")]
        System.Threading.Tasks.Task<double> StockHumidityAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/OutdoorTemp", ReplyAction="*")]
        double OutdoorTemp();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/OutdoorTemp", ReplyAction="*")]
        System.Threading.Tasks.Task<double> OutdoorTempAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/OutdoorHumidity", ReplyAction="*")]
        double OutdoorHumidity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/OutdoorHumidity", ReplyAction="*")]
        System.Threading.Tasks.Task<double> OutdoorHumidityAsync();
        
        // CODEGEN: Generating message contract since element name StockItemsUnderMinResult from namespace http://dvimonitor.azurewebsites.net/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockItemsUnderMin", ReplyAction="*")]
        WindowsFormsApp1.dvi.StockItemsUnderMinResponse StockItemsUnderMin(WindowsFormsApp1.dvi.StockItemsUnderMinRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockItemsUnderMin", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp1.dvi.StockItemsUnderMinResponse> StockItemsUnderMinAsync(WindowsFormsApp1.dvi.StockItemsUnderMinRequest request);
        
        // CODEGEN: Generating message contract since element name StockItemsOverMaxResult from namespace http://dvimonitor.azurewebsites.net/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockItemsOverMax", ReplyAction="*")]
        WindowsFormsApp1.dvi.StockItemsOverMaxResponse StockItemsOverMax(WindowsFormsApp1.dvi.StockItemsOverMaxRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockItemsOverMax", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp1.dvi.StockItemsOverMaxResponse> StockItemsOverMaxAsync(WindowsFormsApp1.dvi.StockItemsOverMaxRequest request);
        
        // CODEGEN: Generating message contract since element name StockItemsMostSoldResult from namespace http://dvimonitor.azurewebsites.net/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockItemsMostSold", ReplyAction="*")]
        WindowsFormsApp1.dvi.StockItemsMostSoldResponse StockItemsMostSold(WindowsFormsApp1.dvi.StockItemsMostSoldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://dvimonitor.azurewebsites.net/StockItemsMostSold", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp1.dvi.StockItemsMostSoldResponse> StockItemsMostSoldAsync(WindowsFormsApp1.dvi.StockItemsMostSoldRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsUnderMinRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsUnderMin", Namespace="http://dvimonitor.azurewebsites.net/", Order=0)]
        public WindowsFormsApp1.dvi.StockItemsUnderMinRequestBody Body;
        
        public StockItemsUnderMinRequest() {
        }
        
        public StockItemsUnderMinRequest(WindowsFormsApp1.dvi.StockItemsUnderMinRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class StockItemsUnderMinRequestBody {
        
        public StockItemsUnderMinRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsUnderMinResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsUnderMinResponse", Namespace="http://dvimonitor.azurewebsites.net/", Order=0)]
        public WindowsFormsApp1.dvi.StockItemsUnderMinResponseBody Body;
        
        public StockItemsUnderMinResponse() {
        }
        
        public StockItemsUnderMinResponse(WindowsFormsApp1.dvi.StockItemsUnderMinResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dvimonitor.azurewebsites.net/")]
    public partial class StockItemsUnderMinResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WindowsFormsApp1.dvi.ArrayOfString StockItemsUnderMinResult;
        
        public StockItemsUnderMinResponseBody() {
        }
        
        public StockItemsUnderMinResponseBody(WindowsFormsApp1.dvi.ArrayOfString StockItemsUnderMinResult) {
            this.StockItemsUnderMinResult = StockItemsUnderMinResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsOverMaxRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsOverMax", Namespace="http://dvimonitor.azurewebsites.net/", Order=0)]
        public WindowsFormsApp1.dvi.StockItemsOverMaxRequestBody Body;
        
        public StockItemsOverMaxRequest() {
        }
        
        public StockItemsOverMaxRequest(WindowsFormsApp1.dvi.StockItemsOverMaxRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class StockItemsOverMaxRequestBody {
        
        public StockItemsOverMaxRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsOverMaxResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsOverMaxResponse", Namespace="http://dvimonitor.azurewebsites.net/", Order=0)]
        public WindowsFormsApp1.dvi.StockItemsOverMaxResponseBody Body;
        
        public StockItemsOverMaxResponse() {
        }
        
        public StockItemsOverMaxResponse(WindowsFormsApp1.dvi.StockItemsOverMaxResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dvimonitor.azurewebsites.net/")]
    public partial class StockItemsOverMaxResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WindowsFormsApp1.dvi.ArrayOfString StockItemsOverMaxResult;
        
        public StockItemsOverMaxResponseBody() {
        }
        
        public StockItemsOverMaxResponseBody(WindowsFormsApp1.dvi.ArrayOfString StockItemsOverMaxResult) {
            this.StockItemsOverMaxResult = StockItemsOverMaxResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsMostSoldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsMostSold", Namespace="http://dvimonitor.azurewebsites.net/", Order=0)]
        public WindowsFormsApp1.dvi.StockItemsMostSoldRequestBody Body;
        
        public StockItemsMostSoldRequest() {
        }
        
        public StockItemsMostSoldRequest(WindowsFormsApp1.dvi.StockItemsMostSoldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class StockItemsMostSoldRequestBody {
        
        public StockItemsMostSoldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class StockItemsMostSoldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="StockItemsMostSoldResponse", Namespace="http://dvimonitor.azurewebsites.net/", Order=0)]
        public WindowsFormsApp1.dvi.StockItemsMostSoldResponseBody Body;
        
        public StockItemsMostSoldResponse() {
        }
        
        public StockItemsMostSoldResponse(WindowsFormsApp1.dvi.StockItemsMostSoldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://dvimonitor.azurewebsites.net/")]
    public partial class StockItemsMostSoldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WindowsFormsApp1.dvi.ArrayOfString StockItemsMostSoldResult;
        
        public StockItemsMostSoldResponseBody() {
        }
        
        public StockItemsMostSoldResponseBody(WindowsFormsApp1.dvi.ArrayOfString StockItemsMostSoldResult) {
            this.StockItemsMostSoldResult = StockItemsMostSoldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface monitorSoapChannel : WindowsFormsApp1.dvi.monitorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class monitorSoapClient : System.ServiceModel.ClientBase<WindowsFormsApp1.dvi.monitorSoap>, WindowsFormsApp1.dvi.monitorSoap {
        
        public monitorSoapClient() {
        }
        
        public monitorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public monitorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public monitorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public monitorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double StockTemp() {
            return base.Channel.StockTemp();
        }
        
        public System.Threading.Tasks.Task<double> StockTempAsync() {
            return base.Channel.StockTempAsync();
        }
        
        public double StockHumidity() {
            return base.Channel.StockHumidity();
        }
        
        public System.Threading.Tasks.Task<double> StockHumidityAsync() {
            return base.Channel.StockHumidityAsync();
        }
        
        public double OutdoorTemp() {
            return base.Channel.OutdoorTemp();
        }
        
        public System.Threading.Tasks.Task<double> OutdoorTempAsync() {
            return base.Channel.OutdoorTempAsync();
        }
        
        public double OutdoorHumidity() {
            return base.Channel.OutdoorHumidity();
        }
        
        public System.Threading.Tasks.Task<double> OutdoorHumidityAsync() {
            return base.Channel.OutdoorHumidityAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp1.dvi.StockItemsUnderMinResponse WindowsFormsApp1.dvi.monitorSoap.StockItemsUnderMin(WindowsFormsApp1.dvi.StockItemsUnderMinRequest request) {
            return base.Channel.StockItemsUnderMin(request);
        }
        
        public WindowsFormsApp1.dvi.ArrayOfString StockItemsUnderMin() {
            WindowsFormsApp1.dvi.StockItemsUnderMinRequest inValue = new WindowsFormsApp1.dvi.StockItemsUnderMinRequest();
            inValue.Body = new WindowsFormsApp1.dvi.StockItemsUnderMinRequestBody();
            WindowsFormsApp1.dvi.StockItemsUnderMinResponse retVal = ((WindowsFormsApp1.dvi.monitorSoap)(this)).StockItemsUnderMin(inValue);
            return retVal.Body.StockItemsUnderMinResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp1.dvi.StockItemsUnderMinResponse> WindowsFormsApp1.dvi.monitorSoap.StockItemsUnderMinAsync(WindowsFormsApp1.dvi.StockItemsUnderMinRequest request) {
            return base.Channel.StockItemsUnderMinAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.dvi.StockItemsUnderMinResponse> StockItemsUnderMinAsync() {
            WindowsFormsApp1.dvi.StockItemsUnderMinRequest inValue = new WindowsFormsApp1.dvi.StockItemsUnderMinRequest();
            inValue.Body = new WindowsFormsApp1.dvi.StockItemsUnderMinRequestBody();
            return ((WindowsFormsApp1.dvi.monitorSoap)(this)).StockItemsUnderMinAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp1.dvi.StockItemsOverMaxResponse WindowsFormsApp1.dvi.monitorSoap.StockItemsOverMax(WindowsFormsApp1.dvi.StockItemsOverMaxRequest request) {
            return base.Channel.StockItemsOverMax(request);
        }
        
        public WindowsFormsApp1.dvi.ArrayOfString StockItemsOverMax() {
            WindowsFormsApp1.dvi.StockItemsOverMaxRequest inValue = new WindowsFormsApp1.dvi.StockItemsOverMaxRequest();
            inValue.Body = new WindowsFormsApp1.dvi.StockItemsOverMaxRequestBody();
            WindowsFormsApp1.dvi.StockItemsOverMaxResponse retVal = ((WindowsFormsApp1.dvi.monitorSoap)(this)).StockItemsOverMax(inValue);
            return retVal.Body.StockItemsOverMaxResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp1.dvi.StockItemsOverMaxResponse> WindowsFormsApp1.dvi.monitorSoap.StockItemsOverMaxAsync(WindowsFormsApp1.dvi.StockItemsOverMaxRequest request) {
            return base.Channel.StockItemsOverMaxAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.dvi.StockItemsOverMaxResponse> StockItemsOverMaxAsync() {
            WindowsFormsApp1.dvi.StockItemsOverMaxRequest inValue = new WindowsFormsApp1.dvi.StockItemsOverMaxRequest();
            inValue.Body = new WindowsFormsApp1.dvi.StockItemsOverMaxRequestBody();
            return ((WindowsFormsApp1.dvi.monitorSoap)(this)).StockItemsOverMaxAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp1.dvi.StockItemsMostSoldResponse WindowsFormsApp1.dvi.monitorSoap.StockItemsMostSold(WindowsFormsApp1.dvi.StockItemsMostSoldRequest request) {
            return base.Channel.StockItemsMostSold(request);
        }
        
        public WindowsFormsApp1.dvi.ArrayOfString StockItemsMostSold() {
            WindowsFormsApp1.dvi.StockItemsMostSoldRequest inValue = new WindowsFormsApp1.dvi.StockItemsMostSoldRequest();
            inValue.Body = new WindowsFormsApp1.dvi.StockItemsMostSoldRequestBody();
            WindowsFormsApp1.dvi.StockItemsMostSoldResponse retVal = ((WindowsFormsApp1.dvi.monitorSoap)(this)).StockItemsMostSold(inValue);
            return retVal.Body.StockItemsMostSoldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp1.dvi.StockItemsMostSoldResponse> WindowsFormsApp1.dvi.monitorSoap.StockItemsMostSoldAsync(WindowsFormsApp1.dvi.StockItemsMostSoldRequest request) {
            return base.Channel.StockItemsMostSoldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.dvi.StockItemsMostSoldResponse> StockItemsMostSoldAsync() {
            WindowsFormsApp1.dvi.StockItemsMostSoldRequest inValue = new WindowsFormsApp1.dvi.StockItemsMostSoldRequest();
            inValue.Body = new WindowsFormsApp1.dvi.StockItemsMostSoldRequestBody();
            return ((WindowsFormsApp1.dvi.monitorSoap)(this)).StockItemsMostSoldAsync(inValue);
        }
    }
}
