﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeTarefa.Domain.Alertas
{
    public interface IServicoDeAlerta
    {
        void ObterHorasEMinutos(string intervalo);
        TimeSpan ObterIntervaloDeHoras( DateTime HoraIntervalo);

    }
}