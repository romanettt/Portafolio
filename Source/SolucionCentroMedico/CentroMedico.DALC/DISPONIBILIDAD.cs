//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CentroMedico.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class DISPONIBILIDAD
    {
        public int ID { get; set; }
        public System.DateTime HORA_INICIO { get; set; }
        public System.DateTime HORA_TERMINO { get; set; }
        public decimal LUNES { get; set; }
        public decimal MARTES { get; set; }
        public decimal MIERCOLES { get; set; }
        public decimal JUEVES { get; set; }
        public decimal VIERNES { get; set; }
        public decimal SABADO { get; set; }
        public decimal DOMINGO { get; set; }
        public int MEDICO_ID { get; set; }
    
        public virtual MEDICO MEDICO { get; set; }
    }
}