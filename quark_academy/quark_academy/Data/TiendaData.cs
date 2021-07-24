using quark_academy.Modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quark_academy.Data
{
    class TiendaData
    {
        static List<Tienda> lstTiendaData;

        /// <summary>
        /// Inicializa el dato en memoria de Tienda
        /// </summary>
        public static void InicializarDatoTienda()
        {
            lstTiendaData = new List<Tienda>();

            lstTiendaData.Add(new Tienda(3225,
                                         "Nicolas Paez",
                                         "Bulevard Illia 116"));
        }

        /// <summary>
        /// Buscar a la Tienda en la base de datos segun su codigo
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Tienda GetTienda(int codigo)
        {
            return lstTiendaData.Where(x => x.Codigo == codigo).FirstOrDefault(); 
        }
    }
}
