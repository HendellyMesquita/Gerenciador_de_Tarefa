using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GerenciadorDeTarefa.Domain.BlocoDeNotas.Fonte;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas
{
    public class ServicoDeFontes : IServicoDeFontes
    {
        FonteDeNota _fonte = new FonteDeNota();
        internal delegate void UpdatrColor(Color backcolor, Color forecolor);
        internal event UpdatrColor ColorUpdated;
      
        private void Send() => ColorUpdated?.Invoke(_fonte.BackColor, _fonte.ForeColor);

        public void DefinirCorTexto(RichTextBox TbAnotacao, NumericUpDown nUpTamanho, ColorDialog colorDialog)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                TbAnotacao.SelectionColor = colorDialog.Color;
                Send();
            }
            ConfiguracaoFonte(TbAnotacao, nUpTamanho);
        }

        public void DefinirTextoComoNegrito(RichTextBox TbAnotacao, NumericUpDown nUpTamanho)
        {
            var ContemNegrito = TbAnotacao.SelectionFont.Style.ToString().Contains("Bold");

            if (!ContemNegrito)
            {
                _fonte.Negrito = FontStyle.Bold;
                ConfiguracaoFonte(TbAnotacao, nUpTamanho);
            }
            else
            {
                _fonte.Negrito = FontStyle.Regular;
                ConfiguracaoFonte(TbAnotacao, nUpTamanho);
            }
        }

        public void DefinirTextoComoItalico(RichTextBox TbAnotacao, NumericUpDown nUpTamanho)
        {
            var ContemItalico = TbAnotacao.SelectionFont.Style.ToString().Contains("Italic");
            if (!ContemItalico)

            {
                _fonte.Italico = FontStyle.Italic;
                ConfiguracaoFonte(TbAnotacao, nUpTamanho);
            }
            else
            {
                _fonte.Italico = FontStyle.Regular;
                ConfiguracaoFonte(TbAnotacao, nUpTamanho);
            }
        }

        public void DefinirTextoComoSublinhado(RichTextBox TbAnotacao, NumericUpDown nUpTamanho)
        {
            var ContemSublinhado = TbAnotacao.SelectionFont.Style.ToString().Contains("Underline");

            if (!ContemSublinhado)
            {
                _fonte.Sublinhado = FontStyle.Underline;
                ConfiguracaoFonte(TbAnotacao, nUpTamanho);
            }
            else
            {
                _fonte.Sublinhado = FontStyle.Regular;
                ConfiguracaoFonte(TbAnotacao, nUpTamanho);
            }
        }

        public void DefinirTamanhoTexto(RichTextBox TbAnotacao, NumericUpDown nUpTamanho)
        {
            var fonte = TbAnotacao.Font.Name;
            var tamanho = (float)nUpTamanho.Value;
            var estilo = TbAnotacao.Font.Style;
            if (TbAnotacao.Font.Size != tamanho)
            {
                TbAnotacao.SelectionFont = new Font(fonte, tamanho, estilo);
            }
        }

        public void ConfiguracaoFonte(RichTextBox TbAnotacao, NumericUpDown nUpTamanho)
        {
            var fonte = TbAnotacao.Font.Name;
            var tamanho = (float)nUpTamanho.Value;
            TbAnotacao.SelectionFont = new Font(fonte, tamanho, _fonte.Sublinhado | _fonte.Negrito | _fonte.Italico);
        }
    }
}
//TODO: Passar informações do form por parametro em Fonte

