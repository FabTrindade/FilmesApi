using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LogoutController : Controller
    {
        private LogoutService _logoutService;

        public LogoutController(LogoutService logoutService)
        {
            _logoutService = logoutService;
        }
        [HttpPost]
        public IActionResult DeslogaUsuario()
        {
            Result res = _logoutService.DeslogaUsuario();

            if (res.IsFailed)
            {
                return Unauthorized(res.Errors);
            }

            return Ok(res.Successes);
        }
    }
}
