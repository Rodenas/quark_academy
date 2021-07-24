using quark_academy.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quark_academy.Data
{
    class CotizacionData
    {
        static List<Cotizacion> lstCotizacion = new List<Cotizacion>();

        internal void GuardarCotizacion(Cotizacion cotizacion)
        {
            lstCotizacion.Add(cotizacion);
        }

        internal List<Cotizacion> GetCotizaciones()
        {
            return lstCotizacion;
        }
    }
}
