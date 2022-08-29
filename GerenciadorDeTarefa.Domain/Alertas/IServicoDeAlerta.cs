using System;

namespace GerenciadorDeTarefa.Domain.Alertas
{
    public interface IServicoDeAlerta
    {
        void ObterHorasEMinutos(string intervalo);
        TimeSpan ObterIntervaloDeHoras(DateTime HoraIntervalo);
        bool VerificaTimer(bool timeAtivado);

    }
}
