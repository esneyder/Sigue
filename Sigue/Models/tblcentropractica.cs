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
    
    public partial class tblcentropractica
    {
        public tblcentropractica()
        {
            this.tblEmpresa_estudiante = new HashSet<tblEmpresa_estudiante>();
            this.tblcooperadors = new HashSet<tblcooperador>();
            this.tblrepresentantes = new HashSet<tblrepresentante>();
            this.tblresponsables = new HashSet<tblresponsable>();
            this.tblvacantes = new HashSet<tblvacante>();
        }
    
        public int CentroPracticaId { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public string Nit { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
        public string Actividad { get; set; }
    
        public virtual ICollection<tblEmpresa_estudiante> tblEmpresa_estudiante { get; set; }
        public virtual ICollection<tblcooperador> tblcooperadors { get; set; }
        public virtual ICollection<tblrepresentante> tblrepresentantes { get; set; }
        public virtual ICollection<tblresponsable> tblresponsables { get; set; }
        public virtual ICollection<tblvacante> tblvacantes { get; set; }
    }
}