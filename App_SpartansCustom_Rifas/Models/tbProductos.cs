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
    
    public partial class tbProductos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbProductos()
        {
            this.tbImagenProductos = new HashSet<tbImagenProductos>();
        }
    
        public int prod_Id { get; set; }
        public string prod_Codigo { get; set; }
        public Nullable<int> scprod_Id { get; set; }
        public string prod_Descripcion { get; set; }
        public Nullable<decimal> prod_Costo { get; set; }
        public Nullable<decimal> prod_Precio { get; set; }
        public int prod_UsuarioCrea { get; set; }
        public System.DateTime prod_FechaCrea { get; set; }
        public Nullable<int> prod_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> prod_FechaModifica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbImagenProductos> tbImagenProductos { get; set; }
        public virtual tbUsuarios tbUsuarios { get; set; }
        public virtual tbUsuarios tbUsuarios1 { get; set; }
        public virtual tbSubCategoriaProductos tbSubCategoriaProductos { get; set; }
    }
}