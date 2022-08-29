using System.Windows.Forms;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas.Arquivos
{
    public interface IServicoDeGerrenciamentoDeArquivos
    {
        string ObterNomeArquivo();

        void SalvarArquivo(RichTextBox conteudoAnotacao, string tituloTarefa);

        RichTextBox AbrirArquivo(RichTextBox conteudoAnotacao, string caminho = null);

        void VerificarSaveDoArquivo(string texto, string moduloExecucao, string salvarTexto, RichTextBox conteudoAnotacao);

        void MostrarConteudoDoArquivo(RichTextBox conteudoAnotacao, ListView listaAnotacoes);

        void MostrarEntradas(string rota, ListView listaAnotacoes);
    }
}
