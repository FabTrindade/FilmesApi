using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>()
                .ForMember(cinema => cinema.Gerente, opts => opts
                .MapFrom(c => new
                {
                    c.Gerente.Id,
                    c.Gerente.Nome
                }))
                .ForMember(cinema => cinema.Endereco, opts => opts
                .MapFrom(c => new
                {
                    c.Endereco.Id,
                    c.Endereco.Logradouro,
                    c.Endereco.Numero,
                    c.Endereco.Bairro
                }));
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
