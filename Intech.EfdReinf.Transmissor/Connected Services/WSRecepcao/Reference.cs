﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Intech.EfdReinf.Transmissor.WSRecepcao {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sped.fazenda.gov.br/", ConfigurationName="WSRecepcao.RecepcaoLoteReinf")]
    public interface RecepcaoLoteReinf {
        
        // CODEGEN: Generating message contract since element name loteEventos from namespace http://sped.fazenda.gov.br/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sped.fazenda.gov.br/RecepcaoLoteReinf/ReceberLoteEventos", ReplyAction="http://sped.fazenda.gov.br/RecepcaoLoteReinf/ReceberLoteEventosResponse")]
        Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosResponse ReceberLoteEventos(Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sped.fazenda.gov.br/RecepcaoLoteReinf/ReceberLoteEventos", ReplyAction="http://sped.fazenda.gov.br/RecepcaoLoteReinf/ReceberLoteEventosResponse")]
        System.Threading.Tasks.Task<Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosResponse> ReceberLoteEventosAsync(Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReceberLoteEventosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReceberLoteEventos", Namespace="http://sped.fazenda.gov.br/", Order=0)]
        public Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosRequestBody Body;
        
        public ReceberLoteEventosRequest() {
        }
        
        public ReceberLoteEventosRequest(Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sped.fazenda.gov.br/")]
    public partial class ReceberLoteEventosRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement loteEventos;
        
        public ReceberLoteEventosRequestBody() {
        }
        
        public ReceberLoteEventosRequestBody(System.Xml.Linq.XElement loteEventos) {
            this.loteEventos = loteEventos;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReceberLoteEventosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReceberLoteEventosResponse", Namespace="http://sped.fazenda.gov.br/", Order=0)]
        public Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosResponseBody Body;
        
        public ReceberLoteEventosResponse() {
        }
        
        public ReceberLoteEventosResponse(Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sped.fazenda.gov.br/")]
    public partial class ReceberLoteEventosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement ReceberLoteEventosResult;
        
        public ReceberLoteEventosResponseBody() {
        }
        
        public ReceberLoteEventosResponseBody(System.Xml.Linq.XElement ReceberLoteEventosResult) {
            this.ReceberLoteEventosResult = ReceberLoteEventosResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RecepcaoLoteReinfChannel : Intech.EfdReinf.Transmissor.WSRecepcao.RecepcaoLoteReinf, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RecepcaoLoteReinfClient : System.ServiceModel.ClientBase<Intech.EfdReinf.Transmissor.WSRecepcao.RecepcaoLoteReinf>, Intech.EfdReinf.Transmissor.WSRecepcao.RecepcaoLoteReinf {
        
        public RecepcaoLoteReinfClient() {
        }
        
        public RecepcaoLoteReinfClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RecepcaoLoteReinfClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RecepcaoLoteReinfClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RecepcaoLoteReinfClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosResponse Intech.EfdReinf.Transmissor.WSRecepcao.RecepcaoLoteReinf.ReceberLoteEventos(Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosRequest request) {
            return base.Channel.ReceberLoteEventos(request);
        }
        
        public System.Xml.Linq.XElement ReceberLoteEventos(System.Xml.Linq.XElement loteEventos) {
            Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosRequest inValue = new Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosRequest();
            inValue.Body = new Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosRequestBody();
            inValue.Body.loteEventos = loteEventos;
            Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosResponse retVal = ((Intech.EfdReinf.Transmissor.WSRecepcao.RecepcaoLoteReinf)(this)).ReceberLoteEventos(inValue);
            return retVal.Body.ReceberLoteEventosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosResponse> Intech.EfdReinf.Transmissor.WSRecepcao.RecepcaoLoteReinf.ReceberLoteEventosAsync(Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosRequest request) {
            return base.Channel.ReceberLoteEventosAsync(request);
        }
        
        public System.Threading.Tasks.Task<Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosResponse> ReceberLoteEventosAsync(System.Xml.Linq.XElement loteEventos) {
            Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosRequest inValue = new Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosRequest();
            inValue.Body = new Intech.EfdReinf.Transmissor.WSRecepcao.ReceberLoteEventosRequestBody();
            inValue.Body.loteEventos = loteEventos;
            return ((Intech.EfdReinf.Transmissor.WSRecepcao.RecepcaoLoteReinf)(this)).ReceberLoteEventosAsync(inValue);
        }
    }
}