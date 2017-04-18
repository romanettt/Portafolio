using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentroMedico.DALC;

namespace CentroMedico.Negocio
{
    public class EspecialidadDAO : ICrud<Especialidad>
    {
        public bool Create(Especialidad o)
        {
            try
            {
                //CommonBC.ModeloCentroMedico.ESPECIALIDAD_INSERT(o.Id, o.Nombre);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Delete(int id)
        {
            try
            {
                //CommonBC.ModeloCentroMedico.ESPECIALIDAD_DELETE(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Especialidad Read(int id)
        {
            try
            {
                ESPECIALIDAD esp = CommonBC.ModeloCentroMedico.ESPECIALIDAD.First(f => f.ID == id);
                Especialidad especialidad = new Especialidad(esp.ID, esp.NOMBRE);

                return especialidad;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Especialidad> ReadAll()
        {
            List<Especialidad> lista = null;
            try
            {
                var res = CommonBC.ModeloCentroMedico.ESPECIALIDAD;

                lista = new List<Especialidad>();

                foreach (DALC.ESPECIALIDAD item in res.ToList())
                {
                    Especialidad esp = new Especialidad();
                    esp.Id = item.ID;
                    esp.Nombre = item.NOMBRE;

                    lista.Add(esp);
                }
                return lista;
            }
            catch (Exception)
            {

                return lista;
            }
        }

        public bool Update(Especialidad o)
        {
            try
            {
                //CommonBC.ModeloCentroMedico.ESPECIALIDAD_UPDATE(o.Id, o.Nombre);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
