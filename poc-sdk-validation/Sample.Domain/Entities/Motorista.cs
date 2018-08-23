using Sample.Domain.Base;
using System;
using System.Collections.Generic;

namespace Sample.Domain.Entities
{
    public class Motorista : Entity
    {
        public string Nome { get; set; }
        public string NumeroCarteiraMotorista { get; set; }
        public List<string> ClasseCarteira { get; set; }
        public DateTime DataValidadeCarteira { get; set; }
        public virtual Veiculo VeiculoPrincipal { get; set; }
    }
}
