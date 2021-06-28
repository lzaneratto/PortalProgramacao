﻿using PortalEnsinoProgramacao.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalEnsinoProgramacao.Dominio.Interfaces
{
    public interface ITrabalhoRepositorio
    {
        Trabalho ConsultarTrabalho(Guid id);

        Trabalho VerificarAvaliacoes(Trabalho trabalho);

    }
}
