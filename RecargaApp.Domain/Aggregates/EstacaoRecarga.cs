using RecargaApp.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecargaApp.Domain.Aggregates
{
    public class EstacaoRecarga : Entity, IAggregateRoot
    {        
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}
