using AutoMapper;
using RecargaApp.Application.ViewModels;
using RecargaApp.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecargaApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {

            CreateMap<EstacaoRecarga, EstacaoRecargaViewModel>()
                .ForMember(d => d.Nome, o => o.MapFrom(s => s.Nome))
                .ForMember(d => d.Tipo, o => o.MapFrom(s => ConvertTipo(s.Tipo)))
                .ForMember(d => d.Latitude, o => o.MapFrom(s => s.Latitude))
                .ForMember(d => d.Longitude, o => o.MapFrom(s => s.Longitude))
                .ForMember(d=>d.Id, o=>o.MapFrom(s=>s.Id));                            
        }

        private static string ConvertTipo(string tipo)
        {
            switch (tipo)
            {
                case "ESTACAOMOVEL":
                    return "Estação Móvel";

                case "ESTACAOVEICULAR":
                    return "Estação Veicular";

                default:
                    return "";
            }
        }
    }
}
