using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackend.dominio
{
  public  class DetalleCarrera
    {
        public Asignatura Asignatura { get; set; }

        public int AnioCursado { get; set; }

        public int TipoDeCursado { get; set; }

    }
}
