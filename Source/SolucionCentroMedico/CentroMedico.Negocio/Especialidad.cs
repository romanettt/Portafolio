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

        // CRUD

        public bool Create()
        {
            try
            {
                DALC.ESPECIALIDAD especialidad = new DALC.ESPECIALIDAD();
                especialidad.ID = Id;
                especialidad.NOMBRE = Nombre;

                CommonBC.ModeloCentroMedico.ESPECIALIDAD.Add(especialidad);
                CommonBC.ModeloCentroMedico.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }

        }

        public bool Read(int id)
        {
            try
            {
                DALC.ESPECIALIDAD especialidad = CommonBC.ModeloCentroMedico.ESPECIALIDAD.First(f => f.ID == id);
                Id = especialidad.ID;
                Nombre = especialidad.NOMBRE;

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public List<Especialidad> ReadAll()
        {
            var res = CommonBC.ModeloCentroMedico.ESPECIALIDAD;
            return GenerarListado(res.ToList());
        }

        private List<Especialidad> GenerarListado(List<ESPECIALIDAD> list)
        {
            List<Especialidad> lista = new List<Especialidad>();
            foreach (DALC.ESPECIALIDAD item in list)
            {
                Especialidad esp = new Especialidad();
                esp.Id = item.ID;
                esp.Nombre = item.NOMBRE;
                lista.Add(esp);
            }

            return lista;
        }
    }
}
