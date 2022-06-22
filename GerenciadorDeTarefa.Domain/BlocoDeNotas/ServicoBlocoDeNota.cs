using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GerenciadorDeTarefa.Domain.BlocoDeNotas.Fonte;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas
{
    public class ServicoBlocoDeNota : IServicoBlocoDeNota
    {
        FonteDeNota _fonte = new FonteDeNota();
        private void Send() => ColorUpdated?.Invoke(_fonte.BackColor, _fonte.ForeColor);
        internal delegate void UpdatrColor(Color backcolor, Color forecolor);
        internal event UpdatrColor ColorUpdated;
        //TODO: Passar informações do form por parametro em Fonte

        public void SalvarArquivo(string path, string texto)
        {
            try
            {
                File.WriteAllText(path, texto);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao escrever o arquivo {path}. Erro: {ex}", "ERRO", MessageBoxButtons.OK);
            }
        }

        public string AbrirArquivo(string path)
        {
            if (!File.Exists(path))
                return null;

            return File.ReadAllText(path);
        }

        public string ObterNomeArquivo(string path)
        {
            var parts = path.Split('\\');
            Console.WriteLine(parts);

            var nomeEstencao = parts[parts.Length - 1].Split('.');
            Console.WriteLine(nomeEstencao);
            Console.WriteLine(nomeEstencao[0]);

            return $"{nomeEstencao[0]} - Gerente de Horas";
        }

        public void DefinirCorTexto(RichTextBox TbAnotacao, NumericUpDown nUpTamanho, ColorDialog colorDialog)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                TbAnotacao.SelectionColor = colorDialog.Color;
                Send();
            }
            ConfiguracaoFonte(TbAnotacao, nUpTamanho);
        }

        //TODO:Corrigir btn ts não alterando entre finção e regular
        //TODO: Verificar Porque alterações de Fonte não estao sendo salvas

        public void DefinirTextoComoItalico(RichTextBox TbAnotacao, NumericUpDown nUpTamanho)
        {
            if (TbAnotacao.Font.Style != FontStyle.Italic)

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

        public void DefinirTextoComoNegrito(RichTextBox TbAnotacao, NumericUpDown nUpTamanho)
        {
            if (TbAnotacao.Font.Style != FontStyle.Bold)
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

        public void DefinirTextoComoSublinhado(RichTextBox TbAnotacao, NumericUpDown nUpTamanho)
        {
            if (TbAnotacao.Font.Style != FontStyle.Underline)
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
