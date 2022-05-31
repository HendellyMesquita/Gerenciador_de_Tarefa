using System;
using System.Windows.Forms;
using static GerenciadorDeTarefa.Domain.Exceptions.GerenciadorDeFuncoesException;

namespace GerenciadorDeTarefa.UI.Alertas
{
    public partial class FormAlerta : Form
    {

        public FormAlerta()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Você tem certeza? Após Esta Ação Todos Os Dados Serão Perdidos", "Atenção!",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Close();
                }
            }
            catch (ClousingException ex)
            {

                throw new Exception($"Erro Ao Encerrar Sistema.  Erro:{ex}");

            }
        }
    }
}
