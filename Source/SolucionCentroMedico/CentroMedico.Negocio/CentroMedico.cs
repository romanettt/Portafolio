using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentroMedico.Negocio
{
    class CentroMedico
    {
        public int Id { get; set; }
        public int Rut { get; set; }
        public string Dv { get; set; }
        public string Direccion { get; set; }
        public int Tefono { get; set; }
        public string Email { get; set; }

        public CentroMedico()
        {
            this.Id = 0;
            this.Rut = 000000;
            this.Dv = string.Empty;
            this.Direccion = string.Empty;
            this.Tefono = 0000000;
            this.Email = string.Empty;
        }
        public CentroMedico(int id, int rut, string dv, string direccion, int telefono, string email)
        {
            this.Id = id;
            this.Rut = rut;
            this.Dv = dv;
            this.Direccion = direccion;
            this.Tefono = telefono;
            this.Email = email;

        }
    }
     
}
