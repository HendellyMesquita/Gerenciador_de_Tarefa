using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using GerenciadorDeTarefa.Domain.BlocoDeNotas.Fonte;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas
{
    public class ServicoDeGerrenciamentoDeArquivos : IServicoDeGerrenciamentoDeArquivos
    {
        SaveFileDialog salvarArquivo = new SaveFileDialog();
        OpenFileDialog abrirArquivo = new OpenFileDialog();


        public void SalvarArquivo(string texto, string sender)
        {
            try
            {
                var verificaSender = sender.ToString() == "Salvar Como";

                if (!File.Exists(salvarArquivo.FileName)|| verificaSender)
                {
                    salvarArquivo = new SaveFileDialog { Filter = @"Arquivo txt.(*.txt)|*.txt|Todos os arquivos (*.*)|*.*" };
                    salvarArquivo.FileName = $"{DateTime.Today:ddMMyyyy}_{DateTime.Now:HHmmss}.txt";
                    if (salvarArquivo.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(salvarArquivo.FileName, texto);
                    }
                    return;
                }
                File.WriteAllText(salvarArquivo.FileName, texto);
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

        public void VerificarSaveDoArquivo(string texto, string sender, string salvarTexto = null)
        {
            var MensagemNovo = "Deseja salvar suas Anotações antes de Criar um novo arquivo?";
            var MensagemClose = "Deseja salvar suas Anotações antes de Sair? Essa ação NÃO salvará o intervalo de horas do dia";

            var verificaSender = sender.ToString() == "Novo";
            var mensagemAlerta = verificaSender ? MensagemNovo : MensagemClose;

            if (!string.IsNullOrEmpty(texto))
            {
                if (texto != salvarTexto)
                {
                    if (MessageBox.Show(mensagemAlerta, "Salvar?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SalvarArquivo(texto, sender);
                        MessageBox.Show("Salvo com Sucesso");
                    }
                }
            }
        }

    }
}
//TODO: Adicionar verificador ortografico https://pt.answacode.com/stackoverflow/23834001/como-ativar-a-verificacao-ortografica-em-c-windows-form-application
//https://docs.microsoft.com/pt-br/dotnet/desktop/wpf/controls/how-to-use-spell-checking-with-a-context-menu?view=netframeworkdesktop-4.8
//https://www.macoratti.net/vbn_wrde.htm
//https://social.msdn.microsoft.com/Forums/pt-BR/4c40182d-f4fe-4d1e-b486-0305de8078d9/corretor-ortografico-csharp?forum=vscsharppt

//TODO: usar Save File para salvar formatação do arquivo https://www.youtube.com/watch?v=7er96RwzvRc
//https://imasters.com.br/back-end/editor-de-texto-com-richtextbox-e-printdocument-parte-01

//Criar tela de historico de notas

//criar função notas fixcadas