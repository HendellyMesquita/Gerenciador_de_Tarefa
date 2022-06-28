using System;
using System.IO;
using System.Windows.Forms;
using GerenciadorDeTarefa.Domain.Alertas;
using GerenciadorDeTarefa.Domain.BlocoDeNotas.Fonte;
using GerenciadorDeTarefa.Domain.BlocoDeNotas;
using GerenciadorDeTarefa.Domain.GerenciadorHoras;
using Microsoft.VisualBasic;
using static GerenciadorDeTarefa.Domain.Exceptions.GerenciadorDeFuncoesException;

namespace GerenciadorDeTarefa.UI
{
    public partial class FormTarefa : Form
    {

        private IServicoGerenciamentoHora _servicoGerenciamento;
        private IServicoDeAlerta _servicoDeAlerta;
        private IServicoBlocoDeNota _servicoBlocoDeNotas;
        private GerenciadorHora _gerenciadorHora;
        private Alerta _alerta;
        private FonteDeNota _fonte;
        private DialogResult AcaoArquivo;
        private int cont = 0;
        private string? lastpath;
        private string salvarTexto;

        public FormTarefa(
            IServicoGerenciamentoHora servicoGerenciamento,
            IServicoDeAlerta servicoDeAlerta,
            IServicoBlocoDeNota servicoBlocoDeNota,
            GerenciadorHora gerenciadorHora,
            Alerta alerta,
            FonteDeNota fonte)
        {
            InitializeComponent();

            _servicoGerenciamento = servicoGerenciamento;
            _servicoDeAlerta = servicoDeAlerta;
            _servicoBlocoDeNotas = servicoBlocoDeNota;
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
                VerificarSaveDoArquivo(sender, e);

                lastpath = null;

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
            TbAnotacao.Text = _servicoBlocoDeNotas.AbrirArquivo();
            ObterTituloDoArquivo(_servicoBlocoDeNotas.ObterNomeArquivo());
            salvarTexto = TbAnotacao.Text;
        }

        private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(lastpath))
            {
                _servicoBlocoDeNotas.SalvarArquivo(TbAnotacao.Text);
                salvarTexto = TbAnotacao.Text;
            }
            else
            {
                SalvarComoToolStripMenuItem_Click(sender, e);
            }
        }

        private void SalvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _servicoBlocoDeNotas.SalvarArquivo(TbAnotacao.Text);
            ObterTituloDoArquivo(_servicoBlocoDeNotas.ObterNomeArquivo());
            salvarTexto = TbAnotacao.Text;
        }

        private void tsNegrito_Click(object sender, EventArgs e)
        {
            _servicoBlocoDeNotas.DefinirTextoComoNegrito(TbAnotacao, nUpTamanho);
        }

        private void tsItalico_Click(object sender, EventArgs e)
        {
            _servicoBlocoDeNotas.DefinirTextoComoItalico(TbAnotacao, nUpTamanho);
        }

        private void tsSublinhado_Click(object sender, EventArgs e)
        {
            _servicoBlocoDeNotas.DefinirTextoComoSublinhado(TbAnotacao, nUpTamanho);
        }

        private void nUpTamanho_ValueChanged(object sender, EventArgs e)
        {
            _servicoBlocoDeNotas.DefinirTamanhoTexto(TbAnotacao, nUpTamanho);
        }

        private void TsCorTexto_Click(object sender, EventArgs e)
        {
            _fonte.BackColor = BackColor;
            _fonte.ForeColor = ForeColor;
            _servicoBlocoDeNotas.DefinirCorTexto(TbAnotacao, nUpTamanho, colorDialog1);
        }

        private void FormTarefa_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (cont != 0 || _gerenciadorHora.Tarefa != null)
                {
                    if (MessageBox.Show("Você tem certeza? Após Esta Ação Todos Os Dados Serão Perdidos", "Atenção!",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
                VerificarSaveDoArquivo(sender, e);

            }
            catch (ClousingException ex)
            {
                throw new Exception($"Erro Ao Encerrar Sistema. Erro:{ex}");
            }
        }

        //TODO: mover verificarSaveDoArquivoPara Serviço
        private void VerificarSaveDoArquivo(object sender, EventArgs e)
        {
            var MensagemNovo = "Deseja salvar suas Anotações antes de Criar um novo arquivo?";
            var MensagemClose = "Deseja salvar suas Anotações antes de Sair? Essa ação NÃO salvará o intervalo de horas do dia";

            var verificaSender = sender.ToString() == "Novo";
            var mensagemAlerta = verificaSender ? MensagemNovo : MensagemClose;

            if (TbAnotacao.Text != "")
            {
                if (TbAnotacao.Text != salvarTexto)
                {
                    if (MessageBox.Show(mensagemAlerta, "Salvar?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SalvarToolStripMenuItem_Click(sender, e);
                        MessageBox.Show("Salvo com Sucesso");
                    }
                }
            }
        }
    }
}