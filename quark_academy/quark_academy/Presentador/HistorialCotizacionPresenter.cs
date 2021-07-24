using quark_academy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quark_academy.Presentador
{
    class HistorialCotizacionPresenter
    {
        private CotizacionData cotizacionData;

        public HistorialCotizacionPresenter(IHistorialCotizacion view)
        {
            cotizacionData = new CotizacionData();
            view.ResultHistorialCotizacion(cotizacionData.GetCotizaciones());
        }
    }
}
