using System;
using System.Collections.Generic;
using System.IO;

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

        public List<Arquivos> GetArquivos()
        {

            var listaArquivos = new List<Arquivos>();
            var diretorio = new DirectoryInfo(@"C:\Users\usuario\Documents\Projetos\Diretorio IntBank\Z_Anotações");
            var arquivos = diretorio.GetFiles("*.rtf");

            foreach (var arquivo in arquivos)
            {
                var dataArquivo = new FileInfo(arquivo.FullName);

                listaArquivos.Add(new Arquivos(arquivo.Name, dataArquivo.CreationTime, arquivo.FullName));
            }
            return listaArquivos;
        }
    }
}
