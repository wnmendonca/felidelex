using AutoMapper;
using ProjetoFidelidade.Model;
using ProjetoFidelidade.WS.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoFidelidade.WS.Mappings
{
    public class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Cliente, ClienteDTO>();
        }
    }
}