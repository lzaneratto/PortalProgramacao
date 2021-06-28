using PortalEnsinoProgramacao.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace PortalEnsinoProgramacao.Dominio.Interfaces
{
    public interface IUsuarioRepositorio
    {
        void Cadastrar(Usuario usuario);

        void Excluir(Guid id);

        void Editar(Usuario usuario);

        List<Usuario> ListarTodos();

        bool EfetuarLogin(Aluno Aluno);

        bool EfetuarLogin(Professor Aluno);

        void DefinirPerfilAdministrador();

        void AvaliarTrabalho(Guid id);

    }
}
