﻿using GerenciadorDeTarefa.Domain.GerenciadorHoras;
using System;
using System.IO;
using System.Windows.Forms;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas
{
    public class ServicoDeGerrenciamentoDeArquivos : IServicoDeGerrenciamentoDeArquivos
    {
        GerenciamentoDeArquivo _gerenciamentoDeArquivo = new GerenciamentoDeArquivo();
        SaveFileDialog salvarArquivo = new SaveFileDialog();
        OpenFileDialog abrirArquivo = new OpenFileDialog();

        public void SalvarArquivo(RichTextBox tbAnotacao)
        {
            try
            {
                salvarArquivo = new SaveFileDialog { Filter = @"Arquivos rtf.(*.rtf)|*.rtf", OverwritePrompt = true };
                salvarArquivo.FileName = $"{DateTime.Today:ddMMyyyy}_{DateTime.Now:HHmmss}.rtf";

                if (salvarArquivo.ShowDialog() == DialogResult.OK)
                {
                    tbAnotacao.SaveFile(salvarArquivo.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao escrever o arquivo {salvarArquivo}. Erro: {ex}", "ERRO", MessageBoxButtons.OK);
            }
        }

        public RichTextBox AbrirArquivo(RichTextBox tbAnotacao)
        {
            try
            {
                abrirArquivo.DefaultExt = "*.rtf";
                abrirArquivo.Filter = "Arquivos rtf.(*.rtf)|*.rtf";

                if (abrirArquivo.ShowDialog() == DialogResult.OK)
                {
                    tbAnotacao.LoadFile(abrirArquivo.FileName, RichTextBoxStreamType.RichText);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um erro ao abrir o arquivo {abrirArquivo}. Erro: {ex}", "ERRO", MessageBoxButtons.OK);
            }
            return tbAnotacao;
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

        public void VerificarSaveDoArquivo(string texto, string moduloExecucao, string salvarTexto, RichTextBox tbAnotacao)
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
                        SalvarArquivo(tbAnotacao);
                        MessageBox.Show("Salvo com Sucesso");
                    }
                }
            }
        }

    }
}
//TODO: Adicionar verificador ortografico
//https://help-syncfusion-com.translate.goog/windowsforms/spell-checker/getting-started?_x_tr_sl=en&_x_tr_tl=pt&_x_tr_hl=pt-BR&_x_tr_pto=sc

//Criar tela de historico de notas

//criar função notas fixcadas