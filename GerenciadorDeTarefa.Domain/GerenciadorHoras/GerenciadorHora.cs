using System;

namespace GerenciadorDeTarefa.Domain.GerenciadorHoras
{
    public class GerenciadorHora
    {
        public string Tarefa { get; set; }
        public DateTime HoraAtual { get; set; }
        public TimeSpan Total { get; set; }       
        public DateTime EntradaServico { get; set; }
        public DateTime EntradaAlmoco { get; set; }
        public DateTime EntradaReserva { get; set; }
        public DateTime SaidaServico { get; set; }
        public DateTime SaidaAlmoco { get; set; }
        public DateTime SaidaReserva { get; set; }

    }
}
