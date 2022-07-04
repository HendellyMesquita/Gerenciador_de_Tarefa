using System;

namespace GerenciadorDeTarefa.Domain.Alertas
{
    public class ServicoDeAlerta : IServicoDeAlerta
    {
        private readonly Alerta _alerta = new Alerta();

        public void ObterHorasEMinutos(string intervalo)
        {
            string[] Horaintervalo = intervalo.Split(':');
            _alerta.HoraIntervalo = int.Parse(Horaintervalo[0]);
            _alerta.MinutoIntervalo = int.Parse(Horaintervalo[1]);
        }

        public TimeSpan ObterIntervaloDeHoras(DateTime horaIntervalo)
        {
            TimeSpan intervalo = horaIntervalo - DateTime.Now;

            return intervalo;
        }
    }
}
