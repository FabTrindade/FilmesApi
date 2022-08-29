using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Data.Requests;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]    
    public class CadastroController : ControllerBase
    {
        private CadastroService _cadastroService;

        public CadastroController(CadastroService cadastroService)
        {
            _cadastroService = cadastroService;
        }

        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDto createDto)
        {
            Result res = _cadastroService.CadastraUsuario(createDto);
            if (res.IsFailed)
            {
                return StatusCode(500);
            }
            return Ok(res.Successes.FirstOrDefault());
        }

        [HttpPost("/ativa")]
        public IActionResult AtivaUsuario(AtivaRequest request)
        {
            Result res = _cadastroService.AtivaUsuario(request);
            if (res.IsFailed)
            {
                return StatusCode(500);
            }
            return Ok(res.Successes);
        }
    }
}
