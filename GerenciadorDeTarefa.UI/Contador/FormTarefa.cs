using System;
using System.Windows.Forms;
using GerenciadorDeTarefa.Domain.Alertas;
using GerenciadorDeTarefa.Domain.GerenciadorHoras;
using Microsoft.VisualBasic;
using static GerenciadorDeTarefa.Domain.Exceptions.GerenciadorDeFuncoesException;

namespace GerenciadorDeTarefa.UI.Contador
{
    public partial class FormTarefa : Form
    {
        private GerenciadorHora _gerenciadorHora;
        private Alerta _alerta;
        private IServicoGerenciamentoHora _servicoGerenciamento;
        private IServicoDeAlerta _servicoDeAlerta;
        int cont = 0;
        public FormTarefa(
            IServicoGerenciamentoHora servicoGerenciamento,
            IServicoDeAlerta servicoDeAlerta,
            GerenciadorHora gerenciadorHora,
            Alerta alerta)
        {
            InitializeComponent();
            _servicoGerenciamento = servicoGerenciamento;
            _servicoDeAlerta = servicoDeAlerta;
            _gerenciadorHora = gerenciadorHora;
            _alerta = alerta;

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
                    btnEntrada.Text = "Limpar";
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
            catch (EdicaoException ex)
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
                lbTotalHora.Text = limpar;
                cont = 0;

                btnEntrada.Text = "Novo";
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

                throw new Exception($"Erro Ao Encerrar Sistema. Erro:{ex}");

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (_alerta.HoraIntervalo == DateTime.Now.Hour && _alerta.MinutoIntervalo == DateTime.Now.Minute)
                {
                    timer1.Enabled = false;

                    if (MessageBox.Show($"Já são {DateTime.Now.ToString("t")}, Voce Fará uma pausa?", " Pausa Para Descanço",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        _alerta.MinutoIntervalo = _alerta.DezMinutos.Minute;
                        timer1.Enabled = true;

                        MessageBox.Show($"Alarme Alterado para daqui 10 minutos, Proximo alarme acontecerá as" +
                            $" {DateTime.Now.AddMinutes(10).ToString("t")} Horas. ", " Pausa Para Descanço");
                        return;
                    }

                    if (cont == 1 || cont == 3 || cont == 5)
                    {
                        MessageBox.Show($" Marcando Hora de saida...");
                        MarcarHoraAtual();
                    }
                }
            }
            catch (AlertaException ex)
            {
                throw new Exception($"Erro Ao Salvar Alarme. Erro:{ex}");
            }
        }

        private void teIntervalo_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                _servicoDeAlerta.ObterHorasEMinutos(teIntervalo.Text);

                ActiveControl = null;
                timer1.Enabled = true;

               var intervalo = _servicoDeAlerta.ObterIntervaloDeHoras(teIntervalo.Time);

                MessageBox.Show($" O Alerta disparará em {intervalo.ToString("hh' Horas e 'mm' Minutos'")}");

            }
            catch (AlertaException ex)
            {
                throw new Exception($"Erro Ao Salvar Alarme. Erro:{ex}");
            }
        }
    }
}