using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App_SpartansCustom_Rifas.Helpers
{
    public static class General
    {
        public static string FechaRetorno(DateTime fecha)
        {
            return (fecha.Year + "/" + fecha.Month + "/" + fecha.Day).ToString();
        }
    }
}