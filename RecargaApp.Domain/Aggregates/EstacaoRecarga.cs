using RecargaApp.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecargaApp.Domain.Aggregates
{
    public class EstacaoRecarga : Entity, IAggregateRoot
    {
        public EstacaoRecarga(string nome, string tipo, double latitude, double longitude)
        {
            Nome = nome;
            Tipo = tipo;
            Latitude = latitude;
            Longitude = longitude;    
        }

        public string Nome { get; private set; }
        public string Tipo { get; private set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

    }
}
