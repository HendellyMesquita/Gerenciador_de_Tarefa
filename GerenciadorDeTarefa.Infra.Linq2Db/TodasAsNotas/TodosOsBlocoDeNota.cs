using GerenciadorDeTarefa.Domain;
using System.Collections.Generic;
using LinqToDB;
using System.Data;
using System.Linq;
using GerenciadorDeTarefa.Domain.BlocoDeNotas;
using System;

namespace GerenciadorDeTarefa.Infra.Linq2Db.TodasAsNotas
{
    public class TodosOsBlocoDeNota : ITodosOsBlocoDeNota
    {
        const int menorvalor = 0;

        public void Adicionar(Anotacao anotacao)
        {
            if (anotacao.Id == menorvalor)
            {
                using (var db = new DB_GerenciadorDeTarefa())
                {
                    anotacao.Id = db.GetTable<Anotacao>().InsertWithInt32Identity(() => new Anotacao
                    {
                       Id = anotacao.Id,
                        Titulo = anotacao.Titulo,
                        Conteudo = anotacao.Conteudo,
                        DataCriacao = anotacao.DataCriacao,
                        Fonte = anotacao.Fonte,
                    });
                }
            }
        }

        public void Editar(Anotacao anotacao)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int Codigo)
        {
            throw new NotImplementedException();
        }

        public Anotacao GetAnotacao(int Codigo)
        {
            throw new NotImplementedException();
        }

        public List<Anotacao> GetUpdateNota()
        {
            throw new NotImplementedException();
        }

        public class DB_GerenciadorDeTarefa : LinqToDB.Data.DataConnection
        {
            public DB_GerenciadorDeTarefa() : base("DB_GerenciadorDeTarefa") { }
            public ITable<Anotacao> anotacao => GetTable<anotacao>();
        }
    }
}
