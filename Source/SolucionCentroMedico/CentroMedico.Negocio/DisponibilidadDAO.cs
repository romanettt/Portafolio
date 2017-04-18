using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentroMedico.DALC;

namespace CentroMedico.Negocio
{
    public class DisponibilidadDAO : ICrud<Disponibilidad>
    {

        public bool Create(Disponibilidad o) {

            try
            {
                
                //CommonBC.ModeloCentroMedico.DISPONIBILIDAD(o.Id,o.HoraInicio,o.HoraTermino,o.Lunes,o.Martes,o.Miercoles,o.Jueves,o.Viernes,o.Sabado,o.Domingo,o.MedicoId);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Delete(int id)
        {
            //CommonBC.ModeloCentroMedico.DISPONIBILIDAD.ESPECIALIDAD_DELETE(id);
        }

        public Disponibilidad Read(int id)
        {
            try
            {
                DISPONIBILIDAD dis = CommonBC.ModeloCentroMedico.DISPONIBILIDAD.First(f => f.ID == id );
                Disponibilidad  disponibilidad = new Disponibilidad(dis.ID, dis.HORA_INICIO,dis.HORA_TERMINO, Convert.ToBoolean(dis.LUNES), Convert.ToBoolean(dis.MARTES), Convert.ToBoolean(dis.MIERCOLES), Convert.ToBoolean(dis.JUEVES), Convert.ToBoolean(dis.VIERNES), Convert.ToBoolean(dis.SABADO), Convert.ToBoolean(dis.DOMINGO),dis.MEDICO_ID);

                return disponibilidad;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Disponibilidad> ReadAll()
        {
            List<Disponibilidad> lista = null;
            try
            {
                var res = CommonBC.ModeloCentroMedico.DISPONIBILIDAD;

                lista = new List<Disponibilidad>();

                foreach (DALC.DISPONIBILIDAD  item in res.ToList())
                {
                    Disponibilidad dis = new Disponibilidad();
                    dis.Id = item.ID;
                    dis.HoraInicio = item.HORA_INICIO;
                    dis.HoraTermino = item.HORA_TERMINO;
                    dis.Lunes = Convert.ToBoolean(item.LUNES);
                    dis.Martes = Convert.ToBoolean(item.MARTES);
                    dis.Miercoles = Convert.ToBoolean(item.MIERCOLES);
                    dis.Jueves = Convert.ToBoolean(item.JUEVES);
                    dis.Viernes = Convert.ToBoolean(item.VIERNES);
                    dis.Sabado = Convert.ToBoolean(item.SABADO);
                    dis.Domingo = Convert.ToBoolean(item.DOMINGO);
                    dis.MedicoId = item.MEDICO_ID;

                    lista.Add(dis);
                }
                return lista;
            }
            catch (Exception)
            {

                return lista;
            }
        }

        public bool Update(Disponibilidad o)
        {
            try
            {
                //CommonBC.ModeloCentroMedico.DISPONIBILIDAD_UPDATE(o.Id, o.Nombre);
               
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



    }

}
