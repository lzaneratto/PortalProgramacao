using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PortalEnsinoProgramacao.Dominio.Entidades
{
    public class Trabalho
    {
        public Guid Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public decimal NotaFinal { get; set; }

        public FileStream ArquivoCodigoFonte { get; set; }

        public Aluno Aluno { get; set; }

        public List<Aluno> AlunosAvaliadores { get; set; }

        public List<Professor> ProfessoresAvaliadores { get; set; }

    }
}
