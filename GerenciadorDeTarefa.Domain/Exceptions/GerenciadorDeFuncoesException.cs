using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefa.Domain.Exceptions
{
    public class GerenciadorDeFuncoesException : Exception
    {
      public class EdicaoException : Exception
        {          
            public EdicaoException() : base() { }
            public EdicaoException(string message) : base(message) { }
            public EdicaoException(string message, Exception inner) : base(message, inner) { }
        }
      public class EntradaException : Exception
        {          
            public EntradaException() : base() { }
            public EntradaException(string message) : base(message) { }
            public EntradaException(string message, Exception inner) : base(message, inner) { }
        }
      public class ClousingException : Exception
        {          
            public ClousingException() : base() { }
            public ClousingException(string message) : base(message) { }
            public ClousingException(string message, Exception inner) : base(message, inner) { }
        }
    }
}