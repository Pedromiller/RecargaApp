using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RecargaApp.Application.ViewModels
{
    public class EstacaoRecargaViewModel
    {
        public Guid Id { get; private set; }
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Tipo { get; set; }

        [Range(-90.0, 90.0,ErrorMessage ="Valor fora do limite esperado.")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double Latitude { get; set; }

        [Range(-180.0, 180.0, ErrorMessage = "Valor fora do limite esperado.")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public double Longitude { get; set; }
    }
}
