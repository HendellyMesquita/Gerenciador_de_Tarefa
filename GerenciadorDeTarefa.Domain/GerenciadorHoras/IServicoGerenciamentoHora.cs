using System;

namespace GerenciadorDeTarefa.Domain.GerenciadorHoras
{
    public interface IServicoGerenciamentoHora
    {
        DateTime MarcadorHoras(int contador, GerenciadorHora gerenteHora);
        string TotalHorasTrabalhada(int contador, GerenciadorHora gerenteHora);
        string LimparFiltro(int contador, GerenciadorHora gerenteHora);
    }
}
