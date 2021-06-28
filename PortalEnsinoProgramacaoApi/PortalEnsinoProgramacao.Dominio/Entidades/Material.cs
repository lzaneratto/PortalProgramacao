using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PortalEnsinoProgramacao.Dominio.Entidades
{
    public class Material
    {
        public Guid Id { get; set; }

        public string Autor { get; set; }

        public FileStream ArquivoFisico { get; set; }

        public string Descricao { get; set; }

    }
}
