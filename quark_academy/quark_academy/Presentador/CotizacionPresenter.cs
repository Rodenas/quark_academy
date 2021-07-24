using quark_academy.Data;
using quark_academy.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quark_academy.Presentador
{
    class CotizacionPresenter
    {
        Cotizacion cotizacion;
        ICotizacionView view;

        PrendaData prendaData;
        CotizacionData cotizacionData;

        public CotizacionPresenter(ICotizacionView view)
        {
            prendaData = new PrendaData();
            cotizacionData = new CotizacionData();

            this.view = view;
            Prenda _prenda = view.GetPrenda();
            int _unidad = view.GetUnidad();
            Vendedor _vendedor = view.GetVendedor();

            if (prendaData.TieneStock(_prenda, _unidad))
            {
                double total = _unidad * _prenda.CalcularPrecio();
                Random random = new Random();

                Cotizacion _cotizacion = new Cotizacion(random.Next(),
                                                        DateTime.Now,
                                                        _vendedor.Codigo,
                                                        _unidad,
                                                        total);

                cotizacionData.GuardarCotizacion(_cotizacion);

                view.ImporteResultado(total.ToString());
            }
            else
            {//No tiene stock
                view.MensajeResultado("No se puede realizar una cotización sobre una cantidad de stock no disponible");
            }


        }
    }
}
