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
    
    public partial class SECRETARIA
    {
        public int ID { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public int RUT { get; set; }
        public string DV { get; set; }
        public string PATERNO { get; set; }
        public string MATERNO { get; set; }
        public string NOMBRES { get; set; }
        public string EMAIL { get; set; }
        public string CLAVE { get; set; }
        public int CENTRO_MEDICO_ID { get; set; }
    
        public virtual CENTRO_MEDICO CENTRO_MEDICO { get; set; }
    }
}
