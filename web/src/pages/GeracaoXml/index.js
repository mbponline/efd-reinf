import React, { Component } from 'react';
import { Link } from 'react-router-dom';
import { Botao, CampoTexto, Combo, Checkbox, Box, Col, Row } from '../../components';
import ArquivosGerados from './ArquivosGerados';

export default class GeracaoXml extends Component {
    constructor(props) {
        super(props);

        this.listaCampos = [];
        this.erros = [];

        this.state = {
            // States de Campos:
            r1000: false,
            r1070: false,
            r2010: false,
            r2098: false,
            r2099: false,

            tipoOperacao: "",
            ambienteEnvio: "",
            contribuinte: "",
            periodoInicial: "",
            periodoFinal: "",
            referenciaAno: "",
            referenciaMes: "",
            contratacaoServicos: "",
            prestacaoServicos: "",
            associacaoDesportiva: "",
            repasseAssociacaoDesportiva: "",
            producaoRural: "",
            pagamentosDiversos: "",
            competenciaAno: "",
            competenciaMes: "",

            // States de visibilidade e campos desabilitados:
            checkboxR1000Desabilitado: false,
            checkboxR1070Desabilitado: false,
            checkboxR2010Desabilitado: false,
            checkboxR2098Desabilitado: false,
            checkboxR2099Desabilitado: false,

            tipoOperacaoVisivel: true,
            ambienteEnvioVisivel: true,
            contribuinteVisivel: true,
            usuarioResponsavelVisivel: true,
            periodoVisivel: true,
            referenciaVisivel: true,
            combosR2099Visiveis: true,

            // States validação:
            erros: [],

            // States de combos e tabela:
            arquivosGerados: [
                {
                    registro: "R-1000",
                    dataGeracao: "30/09/2018 17:21:46",
                    ambiente: "Produção",
                    status: "Gerado",
                    usuario: "Cleber"
                },
                {
                    registro: "R-2010",
                    dataGeracao: "20/09/2018 09:56:03",
                    ambiente: "Pré-Produção",
                    status: "Enviado",
                    usuario: "Cleber"
                }
            ]
        }
    }

    limparErros = async () => {
        this.erros = [];
        await this.setState({
            erros: this.erros
        });
    }

    adicionarErro = async (mensagem) => {
        this.erros.push(mensagem);
        await this.setState({
            erros: this.erros
        });
    }

    onChange = async (checkbox) => { 
        if(checkbox !== 'r1000')
            await this.setState({ r1000: false, checkboxR1000Desabilitado: !this.state.checkboxR1000Desabilitado });
        if(checkbox !== 'r1070')
            await this.setState({ r1070: false, checkboxR1070Desabilitado: !this.state.checkboxR1070Desabilitado });
        if(checkbox !== 'r2010')
            await this.setState({ r2010: false, checkboxR2010Desabilitado: !this.state.checkboxR2010Desabilitado });
        if(checkbox !== 'r2098')
            await this.setState({ r2098: false, checkboxR2098Desabilitado: !this.state.checkboxR2098Desabilitado });
        if(checkbox !== 'r2099')
            await this.setState({ r2099: false, checkboxR2099Desabilitado: !this.state.checkboxR2099Desabilitado });
    }

    onChangeR1000 = async (checkbox) => {
        this.onChange(checkbox);

        this.handlePeriodo();
        this.handleReferencia();
        this.handleCombosR2099();
    }

    onChangeR1070 = async (checkbox) => {
        this.onChange(checkbox);

        this.handleTipoOperacao();
        this.handleContribuinte();
        this.handleUsuarioResponsavel();
        this.handlePeriodo();
        this.handleReferencia();
        this.handleCombosR2099();
    }

    onChangeR2010 = async (checkbox) => {
        this.onChange(checkbox);

        this.handleContribuinte();
        this.handleUsuarioResponsavel();
        this.handleReferencia();
        this.handleCombosR2099();
    }

    onChangeR2098 = async (checkbox) => {
        this.onChange(checkbox);

        this.handleTipoOperacao();
        this.handleContribuinte();
        this.handleUsuarioResponsavel();
        this.handlePeriodo();
        this.handleCombosR2099();
    }

    onChangeR2099 = async (checkbox) => {
        this.onChange(checkbox);

        this.handleTipoOperacao();
        this.handleContribuinte();
        this.handleUsuarioResponsavel();
        this.handlePeriodo();
    }

    handleTipoOperacao = async () => {
        await this.setState({ tipoOperacao: "", tipoOperacaoVisivel: !this.state.tipoOperacaoVisivel });
    }
    
    handleAmbienteEnvio = async () => {
        await this.setState({ ambienteEnvio: "", ambienteEnvioVisivel: !this.state.ambienteEnvioVisivel });
    }

    handleContribuinte = async () => { 
        await this.setState({ contribuinte: "", contribuinteVisivel: !this.state.contribuinteVisivel });
    }

    handleUsuarioResponsavel = async () => { 
        await this.setState({ usuarioResponsavel: "", usuarioResponsavelVisivel: !this.state.usuarioResponsavelVisivel });
    }

    handlePeriodo = async () => { 
        await this.setState({ periodoInicial: "", periodoFinal: "", periodoVisivel: !this.state.periodoVisivel });
    }

    handleReferencia = async () => { 
        await this.setState({ referenciaAno: "", referenciaMes: "", referenciaVisivel: !this.state.referenciaVisivel });
    }

    handleCombosR2099 = async () => { 
        await this.setState({ 
            contratacaoServicos: "",
            prestacaoServicos: "",
            associacaoDesportiva: "",
            repasseAssociacaoDesportiva: "",
            producaoRural: "",
            pagamentosDiversos: "",
            competenciaAno: "",
            competenciaMes: "",
            combosR2099Visiveis: !this.state.combosR2099Visiveis
        });
    }

    render() {
        return (
            <div>
                <Box titulo={"Tipo de Registro"}>
                    <Checkbox contexto={this} ref={ (input) => this.listaCampos[0] = input } nome={"r1000"} onChange={() => this.onChangeR1000('r1000')}
                              valor={this.state.r1000} desabilitado={this.state.checkboxR1000Desabilitado} label={"R-1000 - Informações do Contribuinte"} />

                    <Checkbox contexto={this} ref={ (input) => this.listaCampos[1] = input } nome={"r1070"} onChange={() => this.onChangeR1070('r1070')}
                              valor={this.state.r1070} desabilitado={this.state.checkboxR1070Desabilitado} label={"R-1070 - Tabela de Processos Administrativos/Judiciais"} />

                    <Checkbox contexto={this} ref={ (input) => this.listaCampos[2] = input } nome={"r2010"} onChange={() => this.onChangeR2010('r2010')}
                              valor={this.state.r2010} desabilitado={this.state.checkboxR2010Desabilitado} label={"R-2010 - Retenção Contribuição Previdenciária - Serviços Tomados"} />
                                
                    <Checkbox contexto={this} ref={ (input) => this.listaCampos[3] = input } nome={"r2098"} onChange={() => this.onChangeR2098('r2098')}
                              valor={this.state.r2098} desabilitado={this.state.checkboxR2098Desabilitado} label={"R-2098 - Reabertura dos Eventos Periódicos"} />

                    <Checkbox contexto={this} ref={ (input) => this.listaCampos[4] = input } nome={"r2099"} onChange={() => this.onChangeR2099('r2099')}
                              valor={this.state.r2099} desabilitado={this.state.checkboxR2099Desabilitado} label={"R-2099 - Fechamento de Eventos Periódicos"} />
                </Box>
                <br />

                <Box>
                    {this.state.tipoOperacaoVisivel &&
                        <Combo contexto={this} label={"Tipo de operação"} ref={ (input) => this.listaCampos[5] = input } 
                               nome="tipoOperacao" valor={this.state.tipoOperacao} obrigatorio={true} padrao={""}
                               opcoes={[{nome: "Operação 1", valor: 1}]} />
                    }
                    
                    {this.state.ambienteEnvioVisivel && 
                        <Combo contexto={this} label={"Ambiente para envio"} ref={ (input) => this.listaCampos[6] = input } 
                               nome="ambienteEnvio" valor={this.state.ambienteEnvio} obrigatorio={true}
                               opcoes={[{nome: "Ambiente 1", valor: 1}]} />
                    }

                    {this.state.contribuinteVisivel &&
                        <CampoTexto contexto={this} ref={ (input) => this.listaCampos[7] = input }
                                    label={"Contribuinte"} nome={"contribuinte"} tipo={"text"} 
                                    placeholder={"Contribuinte"} valor={this.state.contribuinte}
                                    obrigatorio={true} />
                    }

                    {this.state.usuarioResponsavelVisivel &&
                        <Combo contexto={this} label={"Usuário Responsável"} ref={ (input) => this.listaCampos[8] = input } 
                               nome="usuarioResponsavel" valor={this.state.usuarioResponsavel} obrigatorio={true}
                               opcoes={[{nome: "Usuário 1", valor: 1}]} />
                    }

                    {this.state.periodoVisivel &&
                        <Row>
                            <Col>
                                <div className="form-group row">
                                    <div className="col-lg-2 col-md-12 text-lg-right col-form-label">
                                        <b><label htmlFor="periodoInicial">
                                            Período *
                                        </label></b>
                                    </div>

                                    <div className="col-3">
                                        <input className="form-control" name="periodoInicial" id="periodoInicial" type="date" />
                                    </div>

                                    <div className="col-form-label">
                                        <b><label htmlFor="periodoFinal">
                                            a
                                        </label></b>
                                    </div>

                                    <div className="col-3">
                                        <input className="form-control" name="periodoFinal" id="periodoFinal" type="date" />
                                    </div>
                                </div>
                            </Col>
                        </Row>
                    }

                    {this.state.referenciaVisivel &&
                        <Row>
                            <Col>
                                <div className="form-group row">
                                    <div className="col-lg-2 col-md-12 text-lg-right col-form-label">
                                        <b><label htmlFor="referencia">
                                            Referência *
                                        </label></b>
                                    </div>

                                    <div className="col-2">
                                        <select className="form-control" id="referencia" name="referencia">
                                            <option>AAAA</option>
                                        </select>
                                    </div>

                                    <div className="col-2">
                                        <select className="form-control" id="referencia" name="referencia">
                                            <option>MM</option>
                                        </select>
                                    </div>
                                </div>
                            </Col>
                        </Row>
                    }

                    {this.state.combosR2099Visiveis && 
                        <div>

                            <Combo contexto={this} ref={ (input) => this.listaCampos[9] = input } 
                                   label={"Contratou serviços sujeitos à retenção de contribuição previdenciária?"}
                                   nome="contratacaoServicos" valor={this.state.contratacaoServicos} obrigatorio={true}
                                   opcoes={[{nome: "Opção 1", valor: 1}]} />

                            <Combo contexto={this} ref={ (input) => this.listaCampos[10] = input } 
                                   label={"Prestou serviços sujeitos à retenção de contribuição previdenciária?"} 
                                   nome="prestacaoServicos" valor={this.state.prestacaoServicos} obrigatorio={true}
                                   opcoes={[{nome: "Opção 1", valor: 1}]} />

                            <Combo contexto={this} ref={ (input) => this.listaCampos[11] = input } 
                                   label={"A associação desportiva que mantém equipe de futebol profissional, possui informações sobre recursos recebidos?"}
                                   nome="associacaoDesportiva" valor={this.state.associacaoDesportiva} obrigatorio={true}
                                   opcoes={[{nome: "Opção 1", valor: 1}]} />

                            <Combo contexto={this} ref={ (input) => this.listaCampos[12] = input } 
                                   label={"Possui informações sobre repasses efetuados à associação desportiva que mantém equipe de futebol profissional?"}
                                   nome="repasseAssociacaoDesportiva" valor={this.state.repasseAssociacaoDesportiva} obrigatorio={true}
                                   opcoes={[{nome: "Opção 1", valor: 1}]} />

                            <Combo contexto={this} ref={ (input) => this.listaCampos[13] = input } 
                                   label={"O produtor rural PJ/Agroindústria possui informações de comercialização de produção?"} 
                                   nome="producaoRural" valor={this.state.producaoRural} obrigatorio={true}
                                   opcoes={[{nome: "Opção 1", valor: 1}]} />

                            <Combo contexto={this} ref={ (input) => this.listaCampos[14] = input } 
                                   label={"Possui informações de pagamentos diversos no período de apuração?"}
                                   nome="pagamentosDiversos" valor={this.state.pagamentosDiversos} obrigatorio={true}
                                   opcoes={[{nome: "Opção 1", valor: 1}]} />                                                                                                                                                                                                    

                            <Row>
                                <Col>
                                    <div className="form-group row">
                                        <div className="col-lg-2 col-md-12 text-lg-right col-form-label">
                                            <b><label htmlFor="competencia">
                                                Competência a partir da qual não houve movimento, cuja situação perdura até a competência atual. *
                                            </label></b>
                                        </div>

                                        <div className="col-2">
                                            <select className="form-control" id="competenciaAno" name="competencia">
                                                <option>AAAA</option>
                                            </select>
                                        </div>
                                        <div className="col-2">
                                            <select className="form-control" id="competenciaMes" name="competencia">
                                                <option>MM</option>
                                            </select>
                                        </div>
                                    </div>
                                </Col>
                            </Row>

                        </div>
                    }

                    <Botao titulo={"Gerar"} tipo={"primary"} clicar={() => {}} usaLoading={true} />
                </Box>
                <br />

                <ArquivosGerados arquivos={this.state.arquivosGerados} />
            </div>

        )
    }

}
