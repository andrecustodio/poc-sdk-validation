using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Application.ViewModels.Listings
{
    public class MotoristaListagemViewModel
    {
        public string IdMotorista { get; set; }
        public string Nome { get; set; }
        public string NumeroCarteiraMotorista { get; set; }
        public List<string> ClasseCarteira { get; set; } = new List<string>();
        public bool ProblemasCadastrais { get; set; }
        public string PlacaVeiculo { get; set; }
    }
}
