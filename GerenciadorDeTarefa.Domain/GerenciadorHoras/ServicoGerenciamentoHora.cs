using System;
using static GerenciadorDeTarefa.Domain.Exceptions.GerenciadorDeTarefaException;

namespace GerenciadorDeTarefa.Domain.GerenciadorHoras
{
    public class ServicoGerenciamentoHora : IServicoGerenciamentoHora
    {

        public DateTime MarcadorHoras(int contador, GerenciadorHora gerenteHora)
        {
            try
            {
                switch (contador)
                {
                    case 0:
                        gerenteHora.HoraAtual = gerenteHora.EntradaServico = DateTime.Now;
                        break;
                    case 1:
                        gerenteHora.HoraAtual = gerenteHora.SaidaAlmoco = DateTime.Now;
                        break;
                    case 2:
                        gerenteHora.HoraAtual = gerenteHora.EntradaAlmoco = DateTime.Now;
                        break;
                    case 3:
                        gerenteHora.HoraAtual = gerenteHora.SaidaReserva = DateTime.Now;
                        break;
                    case 4:
                        gerenteHora.HoraAtual = gerenteHora.EntradaReserva = DateTime.Now;
                        break;
                    case 5:
                        gerenteHora.HoraAtual = gerenteHora.SaidaServico = DateTime.Now;
                        break;
                }
                return gerenteHora.HoraAtual;

            }
            catch (MarcadorHorasException ex)
            {

                throw new Exception($"Impossivel Marcar Hora atual.  Erro:{ex}");

            }
        }

        public string TotalHorasTrabalhada(int contador, GerenciadorHora gerenteHora)
        {
            try
            {
                var Ciclo1 = gerenteHora.SaidaAlmoco - gerenteHora.EntradaServico;
                var Ciclo2 = gerenteHora.SaidaReserva - gerenteHora.EntradaAlmoco;
                var Ciclo3 = gerenteHora.SaidaServico - gerenteHora.EntradaReserva;


                switch (contador)
                {
                    case 2:
                    case 3:
                        gerenteHora.Total = Ciclo1;
                        break;
                    case 4:
                    case 5:
                        gerenteHora.Total = Ciclo1 + Ciclo2;
                        break;
                    case 6:
                        gerenteHora.Total = Ciclo1 + Ciclo2 + Ciclo3;
                        break;
                }

                return gerenteHora.Total.ToString("hh':'mm");
            }
            catch (TotalHorasTrabalhadaException ex)
            {

                throw new Exception($"Impossivel Gerar Total.  Erro:{ex}");

            }
        }

        public void LimparFiltro(int contador, GerenciadorHora gerenteHora)
        {

            try
            {
                gerenteHora.EntradaServico = DateTime.MinValue;
                gerenteHora.SaidaAlmoco = DateTime.MinValue;
                gerenteHora.EntradaAlmoco = DateTime.MinValue;
                gerenteHora.SaidaReserva = DateTime.MinValue;
                gerenteHora.EntradaReserva = DateTime.MinValue;
                gerenteHora.SaidaServico = DateTime.MinValue;
                gerenteHora.Total = TimeSpan.Zero;
            }
            catch (LimparFiltroException ex)
            {

                throw new Exception($"Impossivel Limpar Filtro.  Erro:{ex}");

            }
        }
    }
}

