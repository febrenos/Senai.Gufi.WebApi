using System;
using System.Collections.Generic;

namespace Senai.Gufi.WebApi.Domains
{
    public partial class TipoEvento
    {

        public int IdTipoEvento { get; set; }

        public string TituloTipoEvento { get; set; }

        public ICollection<Evento> Evento { get; set; }
    }
}
