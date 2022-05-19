using System;
using System.Windows.Forms;
using GerenciadorDeTarefa.Domain.GerenciadorHoras;
using Microsoft.VisualBasic;
using static GerenciadorDeTarefa.Domain.Exceptions.GerenciadorDeFuncoesException;

namespace GerenciadorDeTarefa.UI
{
    public partial class FormTarefa : Form
    {
        private GerenciadorHora _gerenciadorHora;
        private IServicoGerenciamentoHora _servicoGerenciamento;
        int cont = 0;
        public FormTarefa(IServicoGerenciamentoHora servicoGerenciamento, GerenciadorHora gerenciadorHora)
        {
            InitializeComponent();
            _servicoGerenciamento = servicoGerenciamento;
            _gerenciadorHora = gerenciadorHora;
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            try
            {
                MarcarHoraAtual();
                AtualizarTotal();

                if (cont == 7)
                {
                    LimparFiltro();
                }
            }
            catch (EntradaException ex)
            {

                throw new Exception($"Erro Ao atualizar Sistema.  Erro:{ex}");

            }
        }

        private void MarcarHoraAtual()
        {
            var contador = _servicoGerenciamento.MarcadorHoras(cont, _gerenciadorHora);

            switch (cont)
            {
                case 0:
                    lbEntrada1.Text = contador.ToString("t");
                    cont++;
                    break;
                case 1:
                    lbSaida1.Text = contador.ToString("t");
                    cont++;
                    break;
                case 2:
                    lbEntrada2.Text = contador.ToString("t");
                    cont++;
                    break;
                case 3:
                    lbSaida2.Text = contador.ToString("t");
                    cont++;
                    break;
                case 4:
                    lbEntrada3.Text = contador.ToString("t");
                    cont++;
                    break;
                case 5:
                    lbSaida3.Text = contador.ToString("t");
                    btnEntrada.Text = "LIMPAR";
                    cont++;
                    break;
                case 6:
                    cont++;
                    break;

            }
        }
        private void AtualizarTotal()
        {
            string totalHora = _servicoGerenciamento.TotalHorasTrabalhada(cont, _gerenciadorHora);
            lbTotalHora.Text = totalHora;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                var titulo = Interaction.InputBox(
                    "Informe Um Título Para A Tarefa Ou o " +
                    "                                     " +
                    "Nome Da Branch Do Projeto Atual: ",
                    "Edição Título. Projeto BANCKPLUS");

                if (!string.IsNullOrEmpty(titulo))
                {
                    _gerenciadorHora.Tarefa = titulo;
                    lbTarefa.Text = _gerenciadorHora.Tarefa;
                }
            }
            catch(EdicaoException ex)
            {
                throw new Exception($"Erro Ao Editar Titulo.  Erro:{ex}");

            }
        }
        private void LimparFiltro()
        {

            var limpar = _servicoGerenciamento.LimparFiltro(cont, _gerenciadorHora);

            if (MessageBox.Show("Você tem certeza? Após Esta Ação Todos Os Dados Serão Perdidos", "Limpar Solução!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                lbEntrada1.Text = limpar;
                lbSaida1.Text = limpar;
                lbEntrada2.Text = limpar;
                lbSaida2.Text = limpar;
                lbEntrada3.Text = limpar;
                lbSaida3.Text = limpar;
                cont = 0;

                btnEntrada.Text = "NOVO";
            }
        }

        private void FormTarefa_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Você tem certeza? Após Esta Ação Todos Os Dados Serão Perdidos", "Atenção!",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            catch (ClousingException ex)
            {

                throw new Exception($"Erro Ao Encerrar Sistema.  Erro:{ex}");

            }
        }
    }
}