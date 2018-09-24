import React from "react";
import { BrowserRouter as Router, Route } from "react-router-dom";

import { VersaoService } from "@intechprev/efdreinf-service";

import GetRotas from './Rotas';

const rotas = GetRotas();

export default class MasterPage extends React.Component {

    componentWillMount() {
        if(localStorage.getItem("token")) {
            VersaoService.ValidarToken()
                .then(() => {})
                .catch((err) => {
                    if(err.message.indexOf("401") > -1)
                    {
                        localStorage.removeItem("token");
                        document.location = "/";
                    }
                });
        } else {
            localStorage.removeItem("token");
            document.location = "/";
        }
        
    }

    getTitle() {
        var rota = window.location.pathname;
        
        for(var i = 0; i < rotas.length; i++) {
            if(rota === rotas[i].caminho) {
                return(<h2>{rotas[i].titulo}</h2>);
            }
        }
    }

    getRota() {
        var rota = window.location.pathname;
        for(var i = 0; i < rotas.length; i++) {
            if(rota === rotas[i].caminho)
                return rotas[i].componente();
        }
    }

    logout() {
        localStorage.removeItem("token");
        document.location = "/";
    }

	render() {
		return (
			<div className="wrapper">
                <nav className="navbar-default nav-open">
                    <ul>
                        <li className="navbar-header">
                            <img src="/imagens/intech.png" alt="Intech" />
                        </li>
                        {
                            rotas.map((rota, index) => {
                                var link = rota.caminhoLink ? rota.caminhoLink : rota.caminho;

                                if(rota.mostrarMenu) {
                                    return (
                                        <li key={index}>
                                            <a href={link}>
                                                <i className={rota.icone}></i>
                                                {rota.titulo}
                                            </a>
                                        </li>
                                    );
                                }
                                else return "";
                            })
                        }
                        <li>
                            <a href="." onClick={this.logout}>
                                <i className="fas fa-sign-out-alt"></i>
                                Sair
                            </a>
                        </li>
                    </ul>
                </nav>

                <div className="page-wrapper nav-open">
                    <div className="row page-heading">
                        <div className="col-sm-12">
                            <button className="btn btn-primary btn-menu" onClick={this.toggleMenu}>
                                <i className="fa fa-list"></i>
                            </button>

                            {this.getTitle()}
                        </div>
                    </div>

                    <div className="wrapper-content">
                        <Router basename={process.env.PUBLIC_URL}>
                            <div id="route">
                                { rotas.map((rota, index) => <Route key={index} exact={rota.exact} path={rota.caminho} component={rota.componente} />) }
                            </div>
                        </Router>
                    </div>
                </div>
            </div>
		);
	}
}