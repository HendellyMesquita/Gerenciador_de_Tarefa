using System.Windows.Forms;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas
{
    public interface IServicoDeGerrenciamentoDeArquivos
    {
        void SalvarArquivo(string texto, string moduloExecucao);

        string AbrirArquivo();

        string ObterNomeArquivo();

        void VerificarSaveDoArquivo(string texto, string moduloExecucao, string salvarTexto);
        
       
    }
}
