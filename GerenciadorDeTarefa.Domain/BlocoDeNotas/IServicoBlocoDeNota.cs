using System.Windows.Forms;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas
{
    public interface IServicoBlocoDeNota
    {
        void SalvarArquivo(string texto);

        string AbrirArquivo();

        string ObterNomeArquivo();

        void VerificarSaveDoArquivo(string texto, string sender, string salvarTexto);
        
        void DefinirTextoComoNegrito(RichTextBox TbAnotacao, NumericUpDown nUpTamanho);

        void DefinirTextoComoItalico(RichTextBox TbAnotacao, NumericUpDown nUpTamanho);

        void DefinirTextoComoSublinhado(RichTextBox TbAnotacao, NumericUpDown nUpTamanho);

        void DefinirTamanhoTexto(RichTextBox TbAnotacao, NumericUpDown nUpTamanho);

        void DefinirCorTexto(RichTextBox TbAnotacao, NumericUpDown nUpTamanho, ColorDialog colorDialog);
    }
}
