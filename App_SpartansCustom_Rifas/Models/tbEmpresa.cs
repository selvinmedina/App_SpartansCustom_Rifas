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
    
    public partial class tbEmpresa
    {
        public int empr_Id { get; set; }
        public string empr_NombreEmpresa { get; set; }
        public string empr_ImagenLogo { get; set; }
        public string empr_ImagenPortada { get; set; }
        public string empr_NombreUsuarioFacebook { get; set; }
        public string empr_NombreUsuarioInstagram { get; set; }
        public string empr_NombreUsuarioTwitter { get; set; }
        public string empr_Telefono { get; set; }
        public string empr_CorreoElectronico { get; set; }
        public int empr_UsuarioCrea { get; set; }
        public System.DateTime empr_FechaCrea { get; set; }
        public Nullable<int> empr_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> empr_FechaModifica { get; set; }
    
        public virtual tbUsuarios tbUsuarios { get; set; }
        public virtual tbUsuarios tbUsuarios1 { get; set; }
    }
}
