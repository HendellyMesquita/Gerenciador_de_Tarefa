using System.Windows.Forms;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas
{
    public interface IServicoDeGerrenciamentoDeArquivos
    {
        void SalvarArquivo(string texto);

        string AbrirArquivo();

        string ObterNomeArquivo();

        void VerificarSaveDoArquivo(string texto, string sender, string salvarTexto);
        
       
    }
}
