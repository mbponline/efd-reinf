﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Intech.EfdReinf.Transmissor.WSConsultaPreprod {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://sped.fazenda.gov.br/", ConfigurationName="WSConsultaPreprod.ConsultasReinf")]
    public interface ConsultasReinf {
        
        // CODEGEN: Generating message contract since element name numeroInscricaoContribuinte from namespace http://sped.fazenda.gov.br/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://sped.fazenda.gov.br/ConsultasReinf/ConsultaInformacoesConsolidadas", ReplyAction="http://sped.fazenda.gov.br/ConsultasReinf/ConsultaInformacoesConsolidadasResponse" +
            "")]
        Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasResponse ConsultaInformacoesConsolidadas(Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://sped.fazenda.gov.br/ConsultasReinf/ConsultaInformacoesConsolidadas", ReplyAction="http://sped.fazenda.gov.br/ConsultasReinf/ConsultaInformacoesConsolidadasResponse" +
            "")]
        System.Threading.Tasks.Task<Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasResponse> ConsultaInformacoesConsolidadasAsync(Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaInformacoesConsolidadasRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConsultaInformacoesConsolidadas", Namespace="http://sped.fazenda.gov.br/", Order=0)]
        public Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasRequestBody Body;
        
        public ConsultaInformacoesConsolidadasRequest() {
        }
        
        public ConsultaInformacoesConsolidadasRequest(Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sped.fazenda.gov.br/")]
    public partial class ConsultaInformacoesConsolidadasRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public byte tipoInscricaoContribuinte;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string numeroInscricaoContribuinte;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string numeroProtocoloFechamento;
        
        public ConsultaInformacoesConsolidadasRequestBody() {
        }
        
        public ConsultaInformacoesConsolidadasRequestBody(byte tipoInscricaoContribuinte, string numeroInscricaoContribuinte, string numeroProtocoloFechamento) {
            this.tipoInscricaoContribuinte = tipoInscricaoContribuinte;
            this.numeroInscricaoContribuinte = numeroInscricaoContribuinte;
            this.numeroProtocoloFechamento = numeroProtocoloFechamento;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConsultaInformacoesConsolidadasResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConsultaInformacoesConsolidadasResponse", Namespace="http://sped.fazenda.gov.br/", Order=0)]
        public Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasResponseBody Body;
        
        public ConsultaInformacoesConsolidadasResponse() {
        }
        
        public ConsultaInformacoesConsolidadasResponse(Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://sped.fazenda.gov.br/")]
    public partial class ConsultaInformacoesConsolidadasResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public System.Xml.Linq.XElement ConsultaInformacoesConsolidadasResult;
        
        public ConsultaInformacoesConsolidadasResponseBody() {
        }
        
        public ConsultaInformacoesConsolidadasResponseBody(System.Xml.Linq.XElement ConsultaInformacoesConsolidadasResult) {
            this.ConsultaInformacoesConsolidadasResult = ConsultaInformacoesConsolidadasResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ConsultasReinfChannel : Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultasReinf, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConsultasReinfClient : System.ServiceModel.ClientBase<Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultasReinf>, Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultasReinf {
        
        public ConsultasReinfClient() {
        }
        
        public ConsultasReinfClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConsultasReinfClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConsultasReinfClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConsultasReinfClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasResponse Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultasReinf.ConsultaInformacoesConsolidadas(Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasRequest request) {
            return base.Channel.ConsultaInformacoesConsolidadas(request);
        }
        
        public System.Xml.Linq.XElement ConsultaInformacoesConsolidadas(byte tipoInscricaoContribuinte, string numeroInscricaoContribuinte, string numeroProtocoloFechamento) {
            Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasRequest inValue = new Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasRequest();
            inValue.Body = new Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasRequestBody();
            inValue.Body.tipoInscricaoContribuinte = tipoInscricaoContribuinte;
            inValue.Body.numeroInscricaoContribuinte = numeroInscricaoContribuinte;
            inValue.Body.numeroProtocoloFechamento = numeroProtocoloFechamento;
            Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasResponse retVal = ((Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultasReinf)(this)).ConsultaInformacoesConsolidadas(inValue);
            return retVal.Body.ConsultaInformacoesConsolidadasResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasResponse> Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultasReinf.ConsultaInformacoesConsolidadasAsync(Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasRequest request) {
            return base.Channel.ConsultaInformacoesConsolidadasAsync(request);
        }
        
        public System.Threading.Tasks.Task<Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasResponse> ConsultaInformacoesConsolidadasAsync(byte tipoInscricaoContribuinte, string numeroInscricaoContribuinte, string numeroProtocoloFechamento) {
            Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasRequest inValue = new Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasRequest();
            inValue.Body = new Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultaInformacoesConsolidadasRequestBody();
            inValue.Body.tipoInscricaoContribuinte = tipoInscricaoContribuinte;
            inValue.Body.numeroInscricaoContribuinte = numeroInscricaoContribuinte;
            inValue.Body.numeroProtocoloFechamento = numeroProtocoloFechamento;
            return ((Intech.EfdReinf.Transmissor.WSConsultaPreprod.ConsultasReinf)(this)).ConsultaInformacoesConsolidadasAsync(inValue);
        }
    }
}