using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackend.dominio
{
  public  class Asignatura
    {

        public int IdAsignatura { get; set; }
        public string Nombre { get; set; }
        public List<Asignatura> Detalles { get; set; } //En prespuesto no tenía el set     set;

        public Asignatura()
        {
            Detalles = new List<Asignatura>();

        }

        public void QuitarDetalle(int nro)
        {
            Detalles.RemoveAt(nro);
        }

    }
}
