using GerenciadorDeTarefa.Domain.BlocoDeNotas;
using System.Collections.Generic;

namespace GerenciadorDeTarefa.Infra.Linq2Db.TodasAsNotas
{
    public interface ITodosOsBlocoDeNota
    {
        void Adicionar(Anotacao anotacao);
        void Editar(Anotacao anotacao);
        void Excluir(int Codigo);
        Anotacao GetAnotacao(int Codigo);
        List<Anotacao> GetUpdateNota();

    }
}
