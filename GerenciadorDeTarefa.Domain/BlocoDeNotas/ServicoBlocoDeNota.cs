using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GerenciadorDeTarefa.Domain.BlocoDeNotas.Fonte;

//TODO: Passar informações do form por parametro em Fonte
//TODO: Verificar Porque alterações de Fonte não estao sendo salvas
//TODO: Adicionar verificador ortografico https://www.macoratti.net/vbn_wrde.htm    https://social.msdn.microsoft.com/Forums/pt-BR/4c40182d-f4fe-4d1e-b486-0305de8078d9/corretor-ortografico-csharp?forum=vscsharppt
namespace GerenciadorDeTarefa.Domain.BlocoDeNotas
{
    public class ServicoBlocoDeNota : IServicoBlocoDeNota
    {
        FonteDeNota _fonte = new FonteDeNota();
        private void Send() => ColorUpdated?.Invoke(_fonte.BackColor, _fonte.ForeColor);
        internal delegate void UpdatrColor(Color backcolor, Color forecolor);
        internal event UpdatrColor ColorUpdated;
        SaveFileDialog salvarArquivo = new SaveFileDialog();
        OpenFileDialog abrirArquivo = new OpenFileDialog();

        public void SalvarArquivo(string texto)
        {
            try
            {
                salvarArquivo = new SaveFileDialog { Filter = @"Arquivo txt.(*.txt)|*.txt|Todos os arquivos (*.*)|*.*" };
                salvarArquivo.FileName = $"{DateTime.Today:ddMMyyyy}_{DateTime.Now:HHmmss}.txt";
                if (salvarArquivo.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(salvarArquivo.FileName, texto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao escrever o arquivo {salvarArquivo}. Erro: {ex}", "ERRO", MessageBoxButtons.OK);
            }
        }

        public string AbrirArquivo()
        {
            try
            {
                if (abrirArquivo.ShowDialog() == DialogResult.OK)
                {
                    return File.ReadAllText(abrirArquivo.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao abrir o arquivo {abrirArquivo}. Erro: {ex}", "ERRO", MessageBoxButtons.OK);
            }
            return null;
        }

        public string ObterNomeArquivo()
        {

            var heNovoArquivo = !string.IsNullOrEmpty(salvarArquivo.FileName);
            var nomeArquivo = heNovoArquivo ? salvarArquivo.FileName : abrirArquivo.FileName;

            var parts = nomeArquivo.Split('\\');
            Console.WriteLine(parts);

            var nomeEstencao = parts[parts.Length - 1].Split('.');
            return $"{nomeEstencao[0]} - Gerente de Horas";
        }


















        //Configuração de Fonte
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

            if (ContemNegrito == false)
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
            if (ContemItalico == false)

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

            if (ContemSublinhado == false)
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
