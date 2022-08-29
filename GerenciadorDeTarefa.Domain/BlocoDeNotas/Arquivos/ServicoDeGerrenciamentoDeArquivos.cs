using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas.Arquivos
{
    public class ServicoDeGerrenciamentoDeArquivos : IServicoDeGerrenciamentoDeArquivos
    {
        SaveFileDialog salvarArquivo = new SaveFileDialog();
        OpenFileDialog abrirArquivo = new OpenFileDialog();
        private const string rotaPadrao = @"C:\Users\usuario\Desktop\";
        private const string limparCaminho = "";

        public void SalvarArquivo(RichTextBox conteudoAnotacao, string tituloTarefa)
        {
            try
            {
                salvarArquivo = new SaveFileDialog { Filter = @"Arquivos rtf.(*.rtf)|*.rtf", OverwritePrompt = true };
                salvarArquivo.FileName = !string.IsNullOrEmpty(tituloTarefa)
                    ? tituloTarefa : $"{DateTime.Today:ddMMyyyy}_{DateTime.Now:HHmmss}";

                if (salvarArquivo.ShowDialog() == DialogResult.OK)
                {
                    conteudoAnotacao.SaveFile(salvarArquivo.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao escrever o arquivo {salvarArquivo}. Erro: {ex}", "ERRO", MessageBoxButtons.OK);
            }
        }

        public RichTextBox AbrirArquivo(RichTextBox conteudoAnotacao, string caminho)
        {
            try
            {
                if (!string.IsNullOrEmpty(caminho))
                {
                    abrirArquivo.FileName = caminho;
                    conteudoAnotacao.LoadFile(abrirArquivo.FileName, RichTextBoxStreamType.RichText);
                    return conteudoAnotacao;
                }

                abrirArquivo.DefaultExt = "*.rtf";
                abrirArquivo.Filter = "Arquivos rtf.(*.rtf)|*.rtf";

                if (abrirArquivo.ShowDialog() == DialogResult.OK)
                {
                    conteudoAnotacao.LoadFile(abrirArquivo.FileName, RichTextBoxStreamType.RichText);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao abrir o arquivo {abrirArquivo}. Erro: {ex}", "ERRO", MessageBoxButtons.OK);
            }
            return conteudoAnotacao;
        }

        public string ObterNomeArquivo()
        {
            var heNovoArquivo = !string.IsNullOrEmpty(salvarArquivo.FileName);
            var nomeArquivo = heNovoArquivo ? salvarArquivo.FileName : abrirArquivo.FileName;

            var parts = nomeArquivo.Split('\\');

            var nomeEstencao = parts[parts.Length - 1].Split('.');
            salvarArquivo.FileName = limparCaminho;
            abrirArquivo.FileName = limparCaminho;
            return $"{nomeEstencao[0]} - Gerente de Horas";
        }

        public void VerificarSaveDoArquivo(string texto, string moduloExecucao, string salvarTexto, RichTextBox conteudoAnotacao)
        {
            var MensagemNovo = "Deseja salvar suas Anotações antes de Criar um novo arquivo?";
            var MensagemClose = "Deseja salvar suas Anotações antes de Sair? Essa ação NÃO salvará o intervalo de horas do dia";

            var verificaModulo = moduloExecucao == "Novo";
            var mensagemAlerta = verificaModulo ? MensagemNovo : MensagemClose;

            if (!string.IsNullOrEmpty(texto))
            {
                if (texto != salvarTexto)
                {
                    if (MessageBox.Show(mensagemAlerta, "Salvar?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SalvarArquivo(conteudoAnotacao, string.Empty);
                        MessageBox.Show("Salvo com Sucesso");
                    }
                }
            }
        }

        public List<Arquivos> GetArquivos(string caminho)
        {
            var listaArquivos = new List<Arquivos>();
            var diretorio = new DirectoryInfo(caminho);
            var arquivos = diretorio.GetFiles("*.rtf");

            foreach (var arquivo in arquivos)
            {
                var dataArquivo = new FileInfo(arquivo.FullName);

                listaArquivos.Add(new Arquivos(arquivo.Name, dataArquivo.CreationTime, arquivo.FullName));
            }
            return listaArquivos;
        }

        public void MostrarConteudoDoArquivo(RichTextBox conteudoAnotacao, ListView listaAnotacoes)
        {
            try
            {
                var linhaSelecionada = listaAnotacoes.SelectedItems[0].Index;
                var caminho = listaAnotacoes.Items[linhaSelecionada].SubItems[2].Text;
                conteudoAnotacao = AbrirArquivo(conteudoAnotacao, caminho);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao abrir o arquivo. Erro: {ex}", "ERRO", MessageBoxButtons.OK);
            }
        }

        public void MostrarEntradas(string rota, ListView listaAnotacoes)
        {
            Arquivos arquivos = new Arquivos();
            var listaArquivos = GetArquivos(string.IsNullOrEmpty(rota) ? rotaPadrao : rota);
            listaAnotacoes.Items.Clear();
            foreach (var arquivo in listaArquivos)
            {
                var item = new string[3];
                item[0] = arquivo.Nome;
                item[1] = arquivo.DataCriacao.ToString();
                item[2] = arquivo.Caminho;

                listaAnotacoes.Items.Add(new ListViewItem(item));
            }
        }
    }
}
//TODO: Adicionar verificador ortografico
//https://help-syncfusion-com.translate.goog/windowsforms/spell-checker/getting-started?_x_tr_sl=en&_x_tr_tl=pt&_x_tr_hl=pt-BR&_x_tr_pto=sc
