using System.Windows.Forms;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas
{
    public interface IServicoBlocoDeNota
    {
        void SalvarArquivo(string path, string texto);

        string AbrirArquivo(string path);

        string ObterNomeArquivo(string path);
        
        void DefinirTextoComoNegrito(RichTextBox TbAnotacao, NumericUpDown nUpTamanho);
        void DefinirTextoComoItalico(RichTextBox TbAnotacao, NumericUpDown nUpTamanho);

        void DefinirTextoComoSublinhado(RichTextBox TbAnotacao, NumericUpDown nUpTamanho);

        void DefinirTamanhoTexto(RichTextBox TbAnotacao, NumericUpDown nUpTamanho);

        void DefinirCorTexto(RichTextBox TbAnotacao);
    }
}
