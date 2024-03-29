﻿using System.Drawing;
using System.Windows.Forms;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas.Fonte
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
            var tamanho = (float)nUpTamanho.Value;
            if (TbAnotacao.Font.Size != tamanho)
                ConfiguracaoFonte(TbAnotacao, nUpTamanho);
        }

        public void Alinhamento(RichTextBox TbAnotacao, string moduloExecucao)
        {

            switch (moduloExecucao)
            {
                case "Alinhar à Esquerda":
                    TbAnotacao.SelectionAlignment = HorizontalAlignment.Left;
                    break;

                case "Centralizar":
                    TbAnotacao.SelectionAlignment = HorizontalAlignment.Center;
                    break;

                case "Alinhar à Direita":
                    TbAnotacao.SelectionAlignment = HorizontalAlignment.Right;
                    break;
            }
        }

        public void ConfiguracaoFonte(RichTextBox TbAnotacao, NumericUpDown nUpTamanho)
        {
            var fonte = TbAnotacao.Font.Name;
            var tamanho = (float)nUpTamanho.Value;
            TbAnotacao.SelectionFont = new Font(fonte, tamanho, _fonte.Sublinhado | _fonte.Negrito | _fonte.Italico);
        }

        public void AnexarImagem(RichTextBox TbAnotacao, OpenFileDialog openFileDialog)
        {
            openFileDialog.Filter = "Images |*.bmp;*.jpg;*.png;*.gif;*.ico";
            openFileDialog.Multiselect = false;
            openFileDialog.FileName = "";
            DialogResult resultado = openFileDialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog.FileName);
                Clipboard.SetImage(img);
                TbAnotacao.Paste();
            }
        }
    }
}

