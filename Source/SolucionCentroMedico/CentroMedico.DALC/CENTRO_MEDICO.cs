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
    
    public partial class CENTRO_MEDICO
    {
        public CENTRO_MEDICO()
        {
            this.CALENDARIO_BASE = new HashSet<CALENDARIO_BASE>();
            this.MEDICO = new HashSet<MEDICO>();
            this.SECRETARIA = new HashSet<SECRETARIA>();
        }
    
        public int ID { get; set; }
        public int RUT { get; set; }
        public string DV { get; set; }
        public string NOMBRE { get; set; }
        public string DIRECCION { get; set; }
        public int TELEFONO { get; set; }
        public string EMAIL { get; set; }
    
        public virtual ICollection<CALENDARIO_BASE> CALENDARIO_BASE { get; set; }
        public virtual ICollection<MEDICO> MEDICO { get; set; }
        public virtual ICollection<SECRETARIA> SECRETARIA { get; set; }
    }
}
