//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class RegistroResistenciaTermica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RegistroResistenciaTermica()
        {
            this.RegistroTrabajador = new HashSet<RegistroTrabajador>();
        }
    
        public int RegistroResistenciaTermicaId { get; set; }
        public string PrendaRopaInterior { get; set; }
        public string PrendaCamisa { get; set; }
        public string PrendaPantalones { get; set; }
        public string PrendaVestidos { get; set; }
        public string PrendaChaqueta { get; set; }
        public bool Eliminado { get; set; }
        public int UsuarioCreacionId { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public int UsuarioModificacionId { get; set; }
        public System.DateTime FechaModificacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RegistroTrabajador> RegistroTrabajador { get; set; }
    }
}