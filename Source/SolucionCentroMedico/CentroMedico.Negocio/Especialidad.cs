using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentroMedico.DALC;

namespace CentroMedico.Negocio
{
    public class Especialidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        
        public Especialidad()
        {
            this.Id = 0;
            this.Nombre = string.Empty;
        }

        public Especialidad(int id, string nombre)
        {
            this.Id = id;
            this.Nombre = nombre;
        }

       
    }
}
