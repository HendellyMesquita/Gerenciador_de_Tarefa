using System;
using System.Windows.Forms;
namespace GerenciadorDeTarefa.Domain.Alertas
{
    public class ServicoDeAlerta : IServicoDeAlerta
    {
        private readonly Alerta _alerta = new Alerta();

        public void ObterHorasEMinutos(string intervalo)
        {
            string[] Horaintervalo = intervalo.Split(':');
            _alerta.HoraIntervalo = int.Parse(Horaintervalo[0]);
            _alerta.MinutoIntervalo = int.Parse(Horaintervalo[1]);
        }

        public TimeSpan ObterIntervaloDeHoras(DateTime horaIntervalo)
        {

            TimeSpan intervalo = horaIntervalo - DateTime.Now;

            return intervalo;
        }

        public bool VerificaTimer(bool timeAtivado)
        {
            if (_alerta.HoraIntervalo == DateTime.Now.Hour && _alerta.MinutoIntervalo == DateTime.Now.Minute)
            {
                timeAtivado = false;
                if (MessageBox.Show($"Já são {DateTime.Now.ToString("t")}, Voce Fará uma pausa?", " Pausa Para Descanço",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    _alerta.MinutoIntervalo = _alerta.DezMinutos.Minute;

                    MessageBox.Show($"Alarme Alterado para daqui 10 minutos, Proximo alarme acontecerá as" +
                        $" {DateTime.Now.AddMinutes(10).ToString("t")} Horas. ", " Pausa Para Descanço");
                    timeAtivado = true;
                }
            }
            return timeAtivado;
        }
    }
}