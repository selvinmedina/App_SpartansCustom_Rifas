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
    
    public partial class tbPersonas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbPersonas()
        {
            this.tbClientes = new HashSet<tbClientes>();
        }
    
        public int per_Id { get; set; }
        public string per_NumeroIdentidad { get; set; }
        public string per_Nombres { get; set; }
        public string per_Apellidos { get; set; }
        public System.DateTime per_FechaNacimiento { get; set; }
        public string per_sexo { get; set; }
        public string per_Telefono { get; set; }
        public string per_CorreoElectronico { get; set; }
        public string per_Fotografia { get; set; }
        public bool per_Estado { get; set; }
        public bool per_EsPersonaNatural { get; set; }
        public int per_UsuarioCrea { get; set; }
        public System.DateTime per_FechaCrea { get; set; }
        public Nullable<int> per_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> per_FechaModifica { get; set; }
        public string per_Direccion1 { get; set; }
        public string per_Direccion2 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbClientes> tbClientes { get; set; }
        public virtual tbUsuarios tbUsuarios { get; set; }
        public virtual tbUsuarios tbUsuarios1 { get; set; }
    }
}
