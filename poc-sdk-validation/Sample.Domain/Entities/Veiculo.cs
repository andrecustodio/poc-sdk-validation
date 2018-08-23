using Sample.Domain.Base;
using System.Collections.Generic;

namespace Sample.Domain.Entities
{
    public class Veiculo : Entity
    {
        public string Placa { get; set; }
        public string ClasseRequerida { get; set; }

        public virtual Motorista MotoristaPrincipal { get; set; }
        public virtual List<Motorista> MotoristasReserva { get; set; }
    }
}