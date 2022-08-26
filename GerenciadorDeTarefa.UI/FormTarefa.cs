using GerenciadorDeTarefa.Domain.Alertas;
using GerenciadorDeTarefa.Domain.BlocoDeNotas;
using GerenciadorDeTarefa.Domain.BlocoDeNotas.Fonte;
using GerenciadorDeTarefa.Domain.GerenciadorHoras;
using System;
using System.Windows.Forms;
using static GerenciadorDeTarefa.Domain.Exceptions.GerenciadorDeFuncoesException;

namespace GerenciadorDeTarefa.UI
{
    public partial class FormTarefa : Form
    {

        private IServicoGerenciamentoHora _servicoGerenciamento;
        private IServicoDeAlerta _servicoDeAlerta;
        private IServicoDeGerrenciamentoDeArquivos _servicoDeGerrenciamentoDeArquivos;
        private IServicoDeFontes _servicoDeFontes;
        private GerenciadorHora _gerenciadorHora;
        private FonteDeNota _fonte;
        private string salvarTexto;
        private int cont = 0;
        private int HoraIntervalo;
        private int MinutoIntervalo;

        public FormTarefa(
            IServicoGerenciamentoHora servicoGerenciamento,
            IServicoDeAlerta servicoDeAlerta,
            IServicoDeGerrenciamentoDeArquivos servicoDeGerrenciamentoDeArquivos,
            IServicoDeFontes servicoDeFontes,
            GerenciadorHora gerenciadorHora,
            FonteDeNota fonte)
        {
            InitializeComponent();

            _servicoGerenciamento = servicoGerenciamento;
            _servicoDeAlerta = servicoDeAlerta;
            _servicoDeGerrenciamentoDeArquivos = servicoDeGerrenciamentoDeArquivos;
            _servicoDeFontes = servicoDeFontes;
            _gerenciadorHora = gerenciadorHora;
            _fonte = fonte;
        }

        /*GERENCIADOR*/
        private void MarcarHoraAtual()
        {
            var contador = _servicoGerenciamento.MarcadorHoras(cont, _gerenciadorHora).ToString("t");

            switch (cont)
            {
                case 0:
                    lbEntrada1.Text = contador;
                    cont++;
                    break;
                case 1:
                    lbSaida1.Text = contador;
                    cont++;
                    break;
                case 2:
                    lbEntrada2.Text = contador;
                    cont++;
                    break;
                case 3:
                    lbSaida2.Text = contador;
                    cont++;
                    break;
                case 4:
                    lbEntrada3.Text = contador;
                    cont++;
                    break;
                case 5:
                    lbSaida3.Text = contador;
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
                timer1.Enabled = true;
                ActiveControl = null;

                var intervalo = _servicoDeAlerta.ObterIntervaloDeHoras(teIntervalo.Time);
                MessageBox.Show($" O Alerta disparará em {intervalo.ToString("hh' Horas e 'mm' Minutos'")}");

                ObterHorasEMinutos();

            }
            catch (AlertaException ex)
            {
                throw new Exception($"Erro Ao Salvar Alarme. Erro:{ex}");
            }
        }
        private void ObterHorasEMinutos()
        {
            string[] Horaintervalo = teIntervalo.Text.Split(':');
            HoraIntervalo = int.Parse(Horaintervalo[0]);
            MinutoIntervalo = int.Parse(Horaintervalo[1]);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

                if (HoraIntervalo == DateTime.Now.Hour && MinutoIntervalo == DateTime.Now.Minute)
                {
                    timer1.Enabled = false;
                    if (MessageBox.Show($"Já são {DateTime.Now.ToString("t")}, Voce Fará uma pausa?", " Pausa Para Descanço",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        MinutoIntervalo = DateTime.Now.AddMinutes(10).Minute;

                        MessageBox.Show($"Alarme Alterado para daqui 10 minutos, Proximo alarme acontecerá as" +
                            $" {DateTime.Now.AddMinutes(10).ToString("t")} Horas. ", " Pausa Para Descanço");
                        timer1.Enabled = true;
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
                var moduloExecucao = sender.ToString();
                _servicoDeGerrenciamentoDeArquivos.VerificarSaveDoArquivo(TbAnotacao.Text, moduloExecucao, salvarTexto, TbAnotacao);

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
            var moduloExecucao = sender.ToString();
            _servicoDeGerrenciamentoDeArquivos.VerificarSaveDoArquivo(TbAnotacao.Text, moduloExecucao, salvarTexto, TbAnotacao);
            TbAnotacao = _servicoDeGerrenciamentoDeArquivos.AbrirArquivo(TbAnotacao);
            ObterTituloDoArquivo(_servicoDeGerrenciamentoDeArquivos.ObterNomeArquivo());
            salvarTexto = TbAnotacao.Text;
        }
        private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _servicoDeGerrenciamentoDeArquivos.SalvarArquivo(TbAnotacao, txtTarefa.Text);
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

        private void tsImagem_Click(object sender, EventArgs e)
        {
            _servicoDeFontes.AnexarImagem(TbAnotacao, openFileDialog1);
        }

        private void tsAlinhaCentro_Click(object sender, EventArgs e)
        {
            var moduloExecucao = sender.ToString();
            _servicoDeFontes.Alinhamento(TbAnotacao, moduloExecucao);
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
                var moduloExecucao = sender.ToString();
                _servicoDeGerrenciamentoDeArquivos.VerificarSaveDoArquivo(TbAnotacao.Text, moduloExecucao, salvarTexto, TbAnotacao);

            }
            catch (ClousingException ex)
            {
                throw new Exception($"Erro Ao Encerrar Sistema. Erro:{ex}");
            }
        }

        /*FORMULÁRIO*/
        private void splitter1_DoubleClick(object sender, EventArgs e)
        {
            if (GerenteContainer.Panel2Collapsed)
            {
                GerenteContainer.Panel2Collapsed = false;
                return;
            }
            GerenteContainer.Panel2Collapsed = true;
        }
        private void splitter2_DoubleClick(object sender, EventArgs e)
        {
            if (HorasContainer.Panel2Collapsed)
            {
                HorasContainer.Panel2Collapsed = false;
                return;
            }
            HorasContainer.Panel2Collapsed = true;
        }

        private void RelogioDigital_Tick(object sender, EventArgs e)
        {
            lbRelogioDigital.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparFiltro();
        }

        private void lbEntrada1_Click(object sender, EventArgs e)
        {

        }
    }
}