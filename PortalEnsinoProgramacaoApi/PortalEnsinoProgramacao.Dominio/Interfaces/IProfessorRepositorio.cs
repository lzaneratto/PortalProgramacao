using PortalEnsinoProgramacao.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalEnsinoProgramacao.Dominio.Interfaces
{
    public interface IProfessorRepositorio
    {
        Professor ListarProfessor(int matricula);

        void CadastrarMaterial(Material material);    

    }
}
