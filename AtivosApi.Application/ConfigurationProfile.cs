using AtivosApi.Data.DTO;
using AtivosApi.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivosApi.Application;

public class ConfigurationProfile : Profile
{

    public ConfigurationProfile()
    {
        CreateMap<AtivoDto, Ativo>();
    }

}
