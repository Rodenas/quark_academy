using quark_academy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quark_academy.Modelo
{
    class Vendedor
    {
        private int codigo;
        private string nombre;
        private string apellido;

        public int Codigo { get => codigo; }
        public string Nombre { get => nombre; }
        public string Apellido { get => apellido; }

        private VendedorData vendedorData;

        /// <summary>
        /// Construye al objeto segun el codigo
        /// </summary>
        /// <param name="codigo"></param>
        public Vendedor(int codigo)
        {
            vendedorData = new VendedorData();
            var obj = vendedorData.GetVendedor(codigo);
            this.codigo = obj.codigo;
            this.nombre = obj.nombre;
            this.apellido = obj.apellido;
        }

        public Vendedor(int codigo, string nombre, string apellido)
        {
            vendedorData = new VendedorData();
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}
