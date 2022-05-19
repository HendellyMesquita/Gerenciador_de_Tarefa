using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefa.Domain.Exceptions
{
    public class GerenciadorDeTarefaException
    {
        public class LimparFiltroException : Exception
        {
            public LimparFiltroException() : base() { }
            public LimparFiltroException(string message) : base(message) { }
            public LimparFiltroException(string message, Exception inner) : base(message, inner) { }
        }
        public class MarcadorHorasException : Exception
        {
            public MarcadorHorasException() : base() { }
            public MarcadorHorasException(string message) : base(message) { }
            public MarcadorHorasException(string message, Exception inner) : base(message, inner) { }
        }
        public class TotalHorasTrabalhadaException : Exception
        {
            public TotalHorasTrabalhadaException() : base() { }
            public TotalHorasTrabalhadaException(string message) : base(message) { }
            public TotalHorasTrabalhadaException(string message, Exception inner) : base(message, inner) { }
        }
    }
}
