using System;
using System.Collections.Generic;
using System.Text;

namespace PortalEnsinoProgramacao.Dominio.Entidades
{
    public class Disciplina
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        List<Professor> Professores { get; set; }
    }
}
