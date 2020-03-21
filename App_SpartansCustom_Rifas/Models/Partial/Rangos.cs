using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace App_SpartansCustom_Rifas.Models
{
    [MetadataType(typeof(Rangos))]
    public partial class tbRangos
    {
    }

    public class Rangos
    {
        [Display(Name = "Número")]
        public int rang_Id { get; set; }

        [Display(Name = "Descripcion")]
        public string rang_Descripcion { get; set; }

        [Display(Name = "Estado")]
        public bool rang_Estado { get; set; }

        [Display(Name = "Usuario Crea")]
        public int rang_UsuarioCrea { get; set; }

        [Display(Name = "Fecha Crea")]
        public System.DateTime rang_FechaCrea { get; set; }

        [Display(Name = "Usuario Modifica")]
        public Nullable<int> rang_UsuarioModifica { get; set; }

        [Display(Name = "Fecha Modifica")]
        public Nullable<System.DateTime> rang_FechaModifica { get; set; }
    }
}