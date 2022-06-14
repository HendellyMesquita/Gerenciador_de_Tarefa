using System;
using System.IO;
using System.Windows.Forms;
using GerenciadorDeTarefa.Domain.Alertas;
using GerenciadorDeTarefa.Domain.GerenciadorHoras;
using GerenciadorDeTarefa.Infra.TodosBlocoDeNotas;
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
        private int cont = 0;
        private DialogResult AcaoArquivo;
        private string lastpath;
        private string salvarTexto;


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

        private void ObterTitulo(string tituloArquivo)
        {
            Text = $"{tituloArquivo}";
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: criar serviço para abrir arquivo
            openFileDialog1.DefaultExt = ".txt";
            openFileDialog1.Filter = "Text Files(*.txt)|*.txt";

            AcaoArquivo = openFileDialog1.ShowDialog();
            if (AcaoArquivo.Equals(DialogResult.OK))
            {
                lastpath = openFileDialog1.FileName;

            /**/     ObterTitulo(TodosServicoBlocoDeNota.ObterNomeArquivo(lastpath));
                TbAnotacao.Text = TodosServicoBlocoDeNota.LerArquivo(lastpath);
                salvarTexto = TbAnotacao.Text;
            }
        }

        private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(lastpath))
            {
            /**/    TodosServicoBlocoDeNota.EscreverArquivo(lastpath, TbAnotacao.Text);
                salvarTexto = TbAnotacao.Text;
            }
            else
            {
                //TODO: criar serviço para salvar arquivo
                saveFileDialog1.Filter = "Text Files(*.txt)|*.txt";
                AcaoArquivo = saveFileDialog1.ShowDialog();

                if (AcaoArquivo.Equals(DialogResult.OK))
                {
                    lastpath = saveFileDialog1.FileName;
            /**/        TodosServicoBlocoDeNota.EscreverArquivo(lastpath, TbAnotacao.Text);
            /**/        ObterTitulo(TodosServicoBlocoDeNota.ObterNomeArquivo(lastpath));
                    salvarTexto = TbAnotacao.Text;
                }
            }
        }

        private void SalvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files(*.txt)|*.txt";
            AcaoArquivo = saveFileDialog1.ShowDialog();

            if (AcaoArquivo.Equals(DialogResult.OK))
            {
                lastpath = saveFileDialog1.FileName;

                //TODO: Fazer serviço de bloco de notas para chamar funções todosServicoDeNotas
        /**/        TodosServicoBlocoDeNota.EscreverArquivo(lastpath, TbAnotacao.Text);
        /**/        ObterTitulo(TodosServicoBlocoDeNota.ObterNomeArquivo(lastpath));
                salvarTexto = TbAnotacao.Text;
            }
        }

        private void TsNegrito_Click(object sender, EventArgs e)
        {
            //TODO: criar função negrito
        }

        private void TsItalico_Click(object sender, EventArgs e)
        {
            //TODO: criar função italico
        }

        private void TsSublinhado_Click(object sender, EventArgs e)
        {
            //TODO: criar função sublinhado
        }

        private void TsCorTexto_Click(object sender, EventArgs e)
        {
            //TODO: criar função cor do Texto
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

                if (TbAnotacao.Text != salvarTexto)
                {
                    if (MessageBox.Show("Deseja salvar suas Anotações antes de Sair? Essa ação NÃO salvará o intervalo de horas do dia", "Salvar?",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SalvarToolStripMenuItem_Click(sender, e);
                    }
                }
            }
            catch (ClousingException ex)
            {
                throw new Exception($"Erro Ao Encerrar Sistema. Erro:{ex}");
            }
        }
    }
}