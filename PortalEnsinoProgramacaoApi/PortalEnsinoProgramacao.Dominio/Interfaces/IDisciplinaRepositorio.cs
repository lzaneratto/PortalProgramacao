using PortalEnsinoProgramacao.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalEnsinoProgramacao.Dominio.Interfaces
{
    public interface IDisciplinaRepositorio
    {
        void Cadastrar(Disciplina disciplina);

        Disciplina Editar(Disciplina disciplina);

        void Excluir(Guid id);

        List<Disciplina> Listar(Guid id);


    }
}
