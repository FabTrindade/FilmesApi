using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuariosApi.Data.Requests;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private LoginService _loginService;

        public LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        public IActionResult LogaUsuario(LoginRequest request)
        {
            Result res = _loginService.LogaUsuario(request);

            if (res.IsFailed)
            {
                return Unauthorized(res.Errors.FirstOrDefault());
            }
            return Ok(res.Successes.FirstOrDefault());
        }
        [HttpPost("/senha-reset")]
        public IActionResult SolicitaResetSenhaUsuario(ResetRequest request)
        {
            Result res = _loginService.SolicitaResetSenhaUsuario(request);

            if (res.IsFailed)
            {
                return Unauthorized(res.Errors.FirstOrDefault());
            }
            return Ok(res.Successes.FirstOrDefault());
        }

        [HttpPost("/efetua-reset")]
        public IActionResult ResetSenhaUsuario(EfetuaResetRequest request)
        {
            Result res = _loginService.ResetSenhaUsuario(request);

            if (res.IsFailed)
            {
                return Unauthorized(res.Errors.FirstOrDefault());
            }
            return Ok(res.Successes.FirstOrDefault());
        }
    }
}
