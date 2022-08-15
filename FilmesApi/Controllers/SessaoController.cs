using AutoMapper;
using FilmesApi.Data;
using FilmesApi.Data.Dtos.Sessao;
using FilmesApi.Models;
using FilmesApi.Services;
using FilmesAPI.Data.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessaoController : ControllerBase
    {
        private SessaoService _sessaoService;

        public SessaoController(SessaoService sessaoService)
        {
            _sessaoService = sessaoService;
        }

        [HttpPost]
        public IActionResult AdicionaSessao(CreateSessaoDto dto)
        {
            ReadSessaoDto readDto = _sessaoService.AdicionaSessao(dto);
            return CreatedAtAction(nameof(RecuperaSessoesPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet]
        public IActionResult RecuperaSessoes()
        {
            List<ReadSessaoDto> readDto = _sessaoService.RecuperaSessoes();
            if (readDto != null)
            {
                return Ok(readDto);
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaSessoesPorId (int id)
        {
            ReadSessaoDto readDto = _sessaoService.RecuperaSessoesPorId(id);
            if (readDto != null)
            {
                return Ok(readDto);
            }
            return NotFound();
        }
    }
}
