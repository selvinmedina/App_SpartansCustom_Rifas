//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App_SpartansCustom_Rifas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbRoles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbRoles()
        {
            this.tbPantallasRoles = new HashSet<tbPantallasRoles>();
            this.tbRolesPermisos = new HashSet<tbRolesPermisos>();
            this.tbUsuariosRoles = new HashSet<tbUsuariosRoles>();
        }
    
        public int rol_Id { get; set; }
        public string rol_Descripcion { get; set; }
        public int rol_UsuarioCrea { get; set; }
        public System.DateTime rol_FechaCrea { get; set; }
        public Nullable<int> rol_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> rol_FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPantallasRoles> tbPantallasRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbRolesPermisos> tbRolesPermisos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbUsuariosRoles> tbUsuariosRoles { get; set; }
        public virtual tbUsuarios tbUsuarios { get; set; }
        public virtual tbUsuarios tbUsuarios1 { get; set; }
    }
}