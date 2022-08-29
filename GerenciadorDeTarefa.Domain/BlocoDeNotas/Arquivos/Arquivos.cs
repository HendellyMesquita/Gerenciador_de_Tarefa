using System;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas.Arquivos
{
    public class Arquivos
    {
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Caminho { get; set; }

        public Arquivos() { }

        public Arquivos(string nome, DateTime dataCriacao, string caminho)
        {
            Nome = nome;
            DataCriacao = dataCriacao;
            Caminho = caminho;
        }
    }
}
