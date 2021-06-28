using PortalEnsinoProgramacao.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalEnsinoProgramacao.Dominio.Interfaces
{
    public interface IMaterialRepositorio
    {
        Material ListarMaterial(Guid id);
    }
}
