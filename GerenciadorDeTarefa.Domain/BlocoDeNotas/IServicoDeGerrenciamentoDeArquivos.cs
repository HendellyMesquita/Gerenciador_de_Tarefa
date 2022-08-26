using System.Windows.Forms;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas
{
    public interface IServicoDeGerrenciamentoDeArquivos
    {
        void SalvarArquivo(RichTextBox tbAnotacao, string tituloTarefa);

        RichTextBox AbrirArquivo(RichTextBox tbAnotacao);

        string ObterNomeArquivo();

        void VerificarSaveDoArquivo(string texto, string moduloExecucao, string salvarTexto, RichTextBox tbAnotacao);


    }
}
