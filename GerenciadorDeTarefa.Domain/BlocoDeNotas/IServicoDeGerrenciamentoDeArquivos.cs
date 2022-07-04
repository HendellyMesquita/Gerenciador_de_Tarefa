using System.Windows.Forms;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas
{
    public interface IServicoDeGerrenciamentoDeArquivos
    {
        void SalvarArquivo(string texto, string sender);

        string AbrirArquivo();

        string ObterNomeArquivo();

        void VerificarSaveDoArquivo(string texto, string sender, string salvarTexto);
        
       
    }
}
