//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sigue.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblasesor
    {
        public tblasesor()
        {
            this.tblAsesor_estudiante = new HashSet<tblAsesor_estudiante>();
        }
    
        public int AsesorId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public int FacultadId { get; set; }
        public byte[] Imagen { get; set; }
        public string Descripcion { get; set; }
    
        public virtual tblfacultad tblfacultad { get; set; }
        public virtual ICollection<tblAsesor_estudiante> tblAsesor_estudiante { get; set; }
    }
}
