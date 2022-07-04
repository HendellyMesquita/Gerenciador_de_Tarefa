using System.Windows.Forms;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas
{
    public interface IServicoDeFontes
    {
        void DefinirTextoComoNegrito(RichTextBox TbAnotacao, NumericUpDown nUpTamanho);

        void DefinirTextoComoItalico(RichTextBox TbAnotacao, NumericUpDown nUpTamanho);

        void DefinirTextoComoSublinhado(RichTextBox TbAnotacao, NumericUpDown nUpTamanho);

        void DefinirTamanhoTexto(RichTextBox TbAnotacao, NumericUpDown nUpTamanho);

        void DefinirCorTexto(RichTextBox TbAnotacao, NumericUpDown nUpTamanho, ColorDialog colorDialog);

        void Alinhamento(RichTextBox TbAnotacao, string sender);
    }
}
