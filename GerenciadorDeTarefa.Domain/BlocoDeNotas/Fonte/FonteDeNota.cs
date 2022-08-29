using System.Drawing;

namespace GerenciadorDeTarefa.Domain.BlocoDeNotas.Fonte
{
    public class FonteDeNota
    {
        public FontStyle Negrito { get; set; }
        public FontStyle Italico { get; set; }
        public FontStyle Sublinhado { get; set; }
        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }
    }
}
