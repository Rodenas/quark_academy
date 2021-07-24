using quark_academy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quark_academy.Modelo
{
    class Tienda
    {
        private int codigo;
        private string nombre;
        private string direccion;
        private List<Prenda> lstPrenda;

        private TiendaData tiendaData;
        private PrendaData prendaData;

        public int Codigo { get => codigo; }
        public string Nombre { get => nombre; }
        public string Direccion { get => direccion; }
        public List<Prenda> LstPrenda { get => lstPrenda; }

        /// <summary>
        /// Construye al objeto segun el codigo
        /// </summary>
        /// <param name="codigo"></param>
        public Tienda(int codigo)
        {
            tiendaData = new TiendaData();
            var obj = tiendaData.GetTienda(codigo);
            this.codigo = obj.codigo;
            this.nombre = obj.nombre;
            this.direccion = obj.direccion;
            this.lstPrenda = obj.lstPrenda;
        }

        public Tienda(int codigo, string nombre, string direccion)
        {
            tiendaData = new TiendaData();
            prendaData = new PrendaData();

            this.codigo = codigo;
            this.nombre = nombre;
            this.direccion = direccion;
            this.lstPrenda = prendaData.GetPrendaTienda(codigo);
        }

        
    }
}
