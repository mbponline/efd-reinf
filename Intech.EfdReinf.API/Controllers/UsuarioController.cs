﻿#region Usings
using Intech.EfdReinf.Entidades;
using Intech.EfdReinf.Negocio.Proxy;
using Intech.Lib.Dominios;
using Intech.Lib.Web;
using Intech.Lib.Web.JWT;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic; 
#endregion

namespace Intech.EfdReinf.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : BaseController
    {
        #region Rotas Publicas

        [HttpGet("buscarPorOid/{oid}")]
        public IActionResult BuscarPorOid(decimal oid)
        {
            try
            {
                return Json(new UsuarioProxy().BuscarPorChave(oid));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("login")]
        public ActionResult Post(
            [FromServices] SigningConfigurations signingConfigurations,
            [FromServices] TokenConfigurations tokenConfigurations,
            [FromBody] UsuarioLogin dados)
        {
            try
            {
                var usuario = new UsuarioProxy().Login(dados.Email, dados.Senha);

                var claims = new List<KeyValuePair<string, string>> {
                    new KeyValuePair<string, string>("Oid", usuario.OID_USUARIO.ToString()),
                    new KeyValuePair<string, string>("Email", usuario.TXT_EMAIL)
                };

                var token = AuthenticationToken.Generate(signingConfigurations, tokenConfigurations, usuario.OID_USUARIO.ToString(), claims);

                return Json(new
                {
                    token.AccessToken,
                    token.Authenticated,
                    token.Created,
                    token.Expiration,
                    token.Message
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("criar")]
        public ActionResult CriarUsuario(UsuarioEntidade usuario)
        {
            try
            {
                var proxyUsuario = new UsuarioProxy();
                var oidUsuarioNovo = proxyUsuario.InserirNovoUsuario(usuario);
                var usuarioNovo = proxyUsuario.BuscarPorChave(oidUsuarioNovo);

                return Json(usuarioNovo);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("reenviarConfirmacao")]
        public ActionResult ReenviarConfirmacao([FromBody] UsuarioLogin dados)
        {
            try
            {
                var proxyUsuario = new UsuarioProxy();
                var usuario = proxyUsuario.BuscarPorEmail(dados.Email);

                proxyUsuario.EnviarEmailConfirmacao(usuario);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("confirmarEmail/{token}")]
        public ActionResult ConfirmarEmail(string token)
        {
            try
            {
                var proxyUsuario = new UsuarioProxy();
                var usuario = proxyUsuario.BuscarPorToken(token);

                if (usuario == null)
                    return BadRequest("Token inválido!");

                usuario.IND_EMAIL_VERIFICADO = DMN_SN.SIM;

                proxyUsuario.Atualizar(usuario);

                var config = AppSettings.Get();

                return new ContentResult()
                {
                    Content = $"E-mail confirmado com sucesso! Clique <a href=\"{config.PublicacaoPortal}\">aqui</a> para ir para o Portal.",
                    ContentType = "text/html",
                };
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("recuperarSenha")]
        public ActionResult RecuperarSenha([FromBody] UsuarioLogin dados)
        {
            try
            {
                new UsuarioProxy().RecuperarSenha(dados.Email);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion

        #region Rotas Privadas
        
        [HttpGet]
        [Authorize("Bearer")]
        public IActionResult Buscar()
        {
            try
            {
                return Json(new UsuarioProxy().BuscarPorChave(OidUsuario));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Authorize("Bearer")]
        public IActionResult Editar([FromBody] UsuarioEntidade usuario)
        {
            try
            {
                new UsuarioProxy().Atualizar(usuario);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("alterarSenha")]
        [Authorize("Bearer")]
        public IActionResult AlterarSenha([FromBody] SenhaLogin senhas)
        {
            try
            {
                new UsuarioProxy().AlterarSenha(EmailUsuario, senhas.SenhaAtual, senhas.SenhaNova);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }

    public class UsuarioLogin
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }

    public class SenhaLogin
    {
        public string SenhaAtual { get; set; }
        public string SenhaNova { get; set; }
    }
}
