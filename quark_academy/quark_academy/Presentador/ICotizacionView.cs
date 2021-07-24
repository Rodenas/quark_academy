using quark_academy.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quark_academy.Presentador
{
    interface ICotizacionView
    {
        void MensajeResultado(string result);
        Prenda GetPrenda();
        int GetUnidad();
        Vendedor GetVendedor();
        void ImporteResultado(string result);

    }
}
