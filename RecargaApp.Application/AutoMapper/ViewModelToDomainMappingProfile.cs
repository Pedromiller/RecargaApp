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
                .ConstructUsing(c => new EstacaoRecarga(c.Nome, c.Tipo, c.Latitude, c.Longitude));
    
        }
       
    }
}
