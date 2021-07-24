using quark_academy.Data;
using quark_academy.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quark_academy.Presentador
{
    interface IHistorialCotizacion
    {
        void ResultHistorialCotizacion(List<Cotizacion> lst);
    }
}
