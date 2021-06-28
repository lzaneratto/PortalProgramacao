using System;
using System.Collections.Generic;
using System.Text;

namespace PortalEnsinoProgramacao.Dominio.Entidades
{
    public class Professor
    {
        public Guid Id { get; set; }

        public string Funcional { get; set; }

        public bool Administrador { get; set; }

        public List<Disciplina> Disciplinas { get; set; }
    }
}
