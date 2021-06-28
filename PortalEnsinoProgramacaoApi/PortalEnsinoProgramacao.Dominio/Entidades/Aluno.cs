using System;
using System.Collections.Generic;
using System.Text;

namespace PortalEnsinoProgramacao.Dominio.Entidades
{
    public class Aluno
    {
        public Guid Id { get; set; }

        public string Matricula { get; set; }

        public Usuario Usuario { get; set; }

        public List<Disciplina> Disciplinas { get; set; }

    }
}
