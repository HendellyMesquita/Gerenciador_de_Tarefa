using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas
{
    public class ServicoBlocoDeNota : IServicoBlocoDeNota
    {

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

        public void DefinirCorTexto(RichTextBox TbAnotacao)
        {
            throw new NotImplementedException();
        }

        //TODO: Criar serviço para funçoes de fonte
        //TODO: Entender ao clicar no ts o texto n altera entre regular e fonte selecionada
        //TODO: Possibilitar adicionar a um texto duas ou mais fulções de estilo
        //TODO: Verificar Porque alterações de Fonte não estao sendo salvas
        

        public void DefinirTextoComoItalico(RichTextBox TbAnotacao, NumericUpDown nUpTamanho)
        {
            var fonte = TbAnotacao.Font.Name;
            var tamanho = (float)nUpTamanho.Value;
            if (TbAnotacao.Font.Style != FontStyle.Italic)

            {
                TbAnotacao.SelectionFont = new Font(fonte, tamanho, FontStyle.Italic);
            }
            else
            {
                TbAnotacao.SelectionFont = new Font(fonte, tamanho, FontStyle.Regular);
            }
        }

        public void DefinirTextoComoNegrito(RichTextBox TbAnotacao, NumericUpDown nUpTamanho)
        {
            var fonte = TbAnotacao.Font.Name;
            var tamanho = (float)nUpTamanho.Value;
            if (TbAnotacao.Font.Style != FontStyle.Bold)
            {
                TbAnotacao.SelectionFont = new Font(fonte, tamanho, FontStyle.Bold);
            }
            else
            {
                TbAnotacao.SelectionFont = new Font(fonte, tamanho, FontStyle.Regular);
            }
        }

        public void DefinirTextoComoSublinhado(RichTextBox TbAnotacao, NumericUpDown nUpTamanho)
        {
            var fonte = TbAnotacao.Font.Name;
            var tamanho = (float)nUpTamanho.Value;
            if (TbAnotacao.Font.Style != FontStyle.Underline)
            {
                TbAnotacao.SelectionFont = new Font(fonte, tamanho, FontStyle.Underline);
            }
            else
            {
                TbAnotacao.SelectionFont = new Font(fonte, tamanho, FontStyle.Regular);
            }
        }

        //TODO: Passar nUpTamanho por parametro em Fonte
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
    }
}
