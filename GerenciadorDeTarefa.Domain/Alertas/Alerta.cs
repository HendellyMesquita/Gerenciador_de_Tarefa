using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefa.Domain.Alertas
{
    public class Alerta
    {
        public int HoraIntervalo { get; set; }
        public int MinutoIntervalo{ get; set; }

        public DateTime DezMinutos = DateTime.Now.AddMinutes(10);


    }
}
