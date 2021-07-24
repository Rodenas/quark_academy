using quark_academy.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quark_academy.Data
{
    class VendedorData
    {
        static List<Vendedor> lstVendedorData;

        /// <summary>
        /// Inicializa el dato en memoria de Vendedor
        /// </summary>
        public static void InicializarDatoVendedor()
        {
            lstVendedorData = new List<Vendedor>();

            lstVendedorData.Add(new Vendedor(1111,
                                             "Pepe",
                                             "Perez"));
            lstVendedorData.Add(new Vendedor(2222,
                                             "Carlos",
                                             "Gonzales"));
        }

        /// <summary>
        /// Buscar al Vendedor en la base de datos segun su codigo
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Vendedor GetVendedor(int codigo)
        {
            return lstVendedorData.Where(x => x.Codigo == codigo).FirstOrDefault();
        }
    }   
}
