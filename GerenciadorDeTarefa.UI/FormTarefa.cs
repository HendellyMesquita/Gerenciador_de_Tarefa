using GerenciadorDeTarefa.Domain.Alertas;
using GerenciadorDeTarefa.Domain.BlocoDeNotas;
using GerenciadorDeTarefa.Domain.BlocoDeNotas.Fonte;
using GerenciadorDeTarefa.Domain.GerenciadorHoras;
using System.Windows.Controls;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
using static GerenciadorDeTarefa.Domain.Exceptions.GerenciadorDeFuncoesException;
using System.Collections;

namespace GerenciadorDeTarefa.UI
{
    public partial class FormTarefa : Form
    {

        private IServicoGerenciamentoHora _servicoGerenciamento;
        private IServicoDeAlerta _servicoDeAlerta;
        private IServicoDeGerrenciamentoDeArquivos _servicoDeGerrenciamentoDeArquivos;
        private IServicoDeFontes _servicoDeFontes;
        private GerenciadorHora _gerenciadorHora;
        private Alerta _alerta;
        private FonteDeNota _fonte;
        private int cont = 0;
        private string salvarTexto;
        public FormTarefa(
            IServicoGerenciamentoHora servicoGerenciamento,
            IServicoDeAlerta servicoDeAlerta,
            IServicoDeGerrenciamentoDeArquivos servicoDeGerrenciamentoDeArquivos,
            IServicoDeFontes servicoDeFontes,
            GerenciadorHora gerenciadorHora,
            Alerta alerta,
            FonteDeNota fonte)
        {
            InitializeComponent();

            _servicoGerenciamento = servicoGerenciamento;
            _servicoDeAlerta = servicoDeAlerta;
            _servicoDeGerrenciamentoDeArquivos = servicoDeGerrenciamentoDeArquivos;
            _servicoDeFontes = servicoDeFontes;
            _gerenciadorHora = gerenciadorHora;
            _alerta = alerta;
            _fonte = fonte;
        }

        /*GERENCIADOR*/
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

        private void LimparFiltro()
        {
            if (MessageBox.Show("Você tem certeza? Após Esta Ação Todos Os Dados Serão Perdidos", "Limpar Solução!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _servicoGerenciamento.LimparFiltro(cont, _gerenciadorHora);
                var limpar = "00:00";

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

        /*ALERTA*/
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

        /*NOTAS*/
        private void ObterTituloDoArquivo(string tituloArquivo)
        {
            Text = $"{tituloArquivo}";
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _servicoDeGerrenciamentoDeArquivos.VerificarSaveDoArquivo(TbAnotacao.Text, sender.ToString(), salvarTexto);

                if (!string.IsNullOrEmpty(this.TbAnotacao.Text))
                {
                    this.Text = "Sem Título - Gerente de Horas";
                    this.TbAnotacao.Text = string.Empty;
                    return;
                }
            }
            catch (NewException ex)
            {
                throw new Exception($"Erro Ao Abrir Novo Arquivo. Erro:{ex}");
            }
        }
        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _servicoDeGerrenciamentoDeArquivos.VerificarSaveDoArquivo(TbAnotacao.Text, sender.ToString(), salvarTexto);
            TbAnotacao.Text = _servicoDeGerrenciamentoDeArquivos.AbrirArquivo();
            ObterTituloDoArquivo(_servicoDeGerrenciamentoDeArquivos.ObterNomeArquivo());
            salvarTexto = TbAnotacao.Text;
        }

        private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _servicoDeGerrenciamentoDeArquivos.SalvarArquivo(TbAnotacao.Text, sender.ToString());
            ObterTituloDoArquivo(_servicoDeGerrenciamentoDeArquivos.ObterNomeArquivo());
            salvarTexto = TbAnotacao.Text;
        }
        private void tsNegrito_Click(object sender, EventArgs e)
        {
            _servicoDeFontes.DefinirTextoComoNegrito(TbAnotacao, nUpTamanho);
        }

        private void tsItalico_Click(object sender, EventArgs e)
        {
            _servicoDeFontes.DefinirTextoComoItalico(TbAnotacao, nUpTamanho);
        }

        private void tsSublinhado_Click(object sender, EventArgs e)
        {
            _servicoDeFontes.DefinirTextoComoSublinhado(TbAnotacao, nUpTamanho);
        }

        private void nUpTamanho_ValueChanged(object sender, EventArgs e)
        {
            _servicoDeFontes.DefinirTamanhoTexto(TbAnotacao, nUpTamanho);
        }

        private void TsCorTexto_Click(object sender, EventArgs e)
        {
            _fonte.BackColor = BackColor;
            _fonte.ForeColor = ForeColor;
            _servicoDeFontes.DefinirCorTexto(TbAnotacao, nUpTamanho, colorDialog1);
        }

        private void FormTarefa_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (cont != 0 || string.IsNullOrEmpty(_gerenciadorHora.Tarefa))
                {
                    if (MessageBox.Show("Você tem certeza? Após Esta Ação Todos Os Dados Serão Perdidos", "Atenção!",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                _servicoDeGerrenciamentoDeArquivos.VerificarSaveDoArquivo(TbAnotacao.Text, sender.ToString(), salvarTexto);

            }
            catch (ClousingException ex)
            {
                throw new Exception($"Erro Ao Encerrar Sistema. Erro:{ex}");
            }
        }

        private void tsAlinhaCentro_Click(object sender, EventArgs e)
        {
            _servicoDeFontes.Alinhamento(TbAnotacao, sender.ToString());
        }
    }
}