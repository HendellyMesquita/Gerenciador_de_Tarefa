using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefa.Domain.Exceptions
{
    public class GerenciadorDeAlertasException
    {
        public class AlertaLimparFiltro : Exception
        {
            public class AlertaLimparFiltroException : Exception
            {
                public AlertaLimparFiltroException() : base() { }
                public AlertaLimparFiltroException(string message) : base(message) { }
                public AlertaLimparFiltroException(string message, Exception inner) : base(message, inner) { }
            }
            public class AlertaClosingCessaoException : Exception
            {
                public AlertaClosingCessaoException() : base() { }
                public AlertaClosingCessaoException(string message) : base(message) { }
                public AlertaClosingCessaoException(string message, Exception inner) : base(message, inner) { }
            }
        }
    }
}
