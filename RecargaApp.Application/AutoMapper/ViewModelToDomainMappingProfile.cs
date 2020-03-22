using AutoMapper;
using RecargaApp.Application.ViewModels;
using RecargaApp.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecargaApp.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<EstacaoRecargaViewModel, EstacaoRecarga>()
                .ForMember(o => o.Nome, d => d.MapFrom(c => c.Nome))
                .ForMember(o => o.Tipo, d => d.MapFrom(c => c.Tipo))
                .ForMember(o => o.Latitude, d => d.MapFrom(c => c.Latitude))
                .ForMember(o => o.Longitude, d => d.MapFrom(c => c.Longitude));
        }
       
    }
}
