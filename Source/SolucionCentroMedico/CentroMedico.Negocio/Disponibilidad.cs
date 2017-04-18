using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentroMedico.DALC;

namespace CentroMedico.Negocio
{
    public class Disponibilidad
    {
        public int Id { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }
        public bool Lunes { get; set; }
        public bool Martes { get; set; }
        public bool Miercoles { get; set; }
        public bool Jueves { get; set; }
        public bool Viernes { get; set; }
        public bool Sabado { get; set; }
        public bool Domingo { get; set; }

        public int MedicoId { get; set; }

        public Disponibilidad()
        {
            this.Id = 0;
            this.HoraInicio = new DateTime();
            this.HoraTermino = new DateTime();
            this.Lunes = false;
            this.Martes = false;
            this.Miercoles = false;
            this.Jueves = false;
            this.Viernes = false;
            this.Sabado = false;
            this.Domingo = false;
            this.MedicoId = 0;
        }

        public Disponibilidad(int id , DateTime horaInicio,DateTime horaTermino,bool lunes,bool martes,bool miercoles, bool jueves,bool viernes,bool sabado,bool domingo,int medicoId)
        {
            this.Id = id;
            this.HoraInicio = horaInicio;
            this.HoraTermino = horaTermino;
            this.Lunes = lunes;
            this.Martes = martes;
            this.Miercoles = miercoles;
            this.Jueves = jueves;
            this.Viernes = viernes;
            this.Sabado = sabado;
            this.Domingo = domingo;
            this.MedicoId = medicoId;
           
        }
      
    }
}
