using System.Collections.Generic;
using System.Windows.Forms;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas.Arquivos
{
    public interface IServicoDeGerrenciamentoDeArquivos
    {
        void SalvarArquivo(RichTextBox tbAnotacao, string tituloTarefa);

        RichTextBox AbrirArquivo(RichTextBox tbAnotacao, string caminho = null);

        string ObterNomeArquivo();

        void VerificarSaveDoArquivo(string texto, string moduloExecucao, string salvarTexto, RichTextBox tbAnotacao);

       // List<Arquivos> GetArquivos();

    }
}
