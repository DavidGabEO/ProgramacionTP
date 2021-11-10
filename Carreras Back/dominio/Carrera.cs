using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackend.dominio
{
    public class Carrera
    {

        public int IdCarrera { get; set; }
        public string Nombre { get; set; }

        public string Titulo { get; set; }

        public int TipoCarrera { get; set; }

        public List<DetalleCarrera> Detalles { get; set; } //En prespuesto no tenía el set     set;


        public Carrera()
        {
            Detalles = new List<DetalleCarrera>();

        }


        public void AgregarDetalle(DetalleCarrera detalle)
        {
            Detalles.Add(detalle);
        }


        public void QuitarDetalle(int nro)
        {
            Detalles.RemoveAt(nro);
        }




    }
}
