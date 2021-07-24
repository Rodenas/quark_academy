using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quark_academy.Modelo
{
    class Pantalon : Prenda
    {
        public enum enum_tipo_pantalon
        {
            Comun = 0,
            Chupin = 1
        }

        private enum_tipo_pantalon tipo;

        public enum_tipo_pantalon Tipo
        {
            get { return tipo; }
        }

        public Pantalon(enum_tipo_pantalon tipo, enum_calidad calidad, double precio)
        {
            this.tipo = tipo;
            this.calidad = calidad;
            this.precio = precio;
        }

        public Pantalon(enum_tipo_pantalon tipo, enum_calidad calidad, int cantidad)
        {
            this.tipo = tipo;
            this.calidad = calidad;
            this.cantidad = cantidad;
        }

        public override double CalcularPrecio()
        {
            double resultado = this.precio;

            if (tipo == enum_tipo_pantalon.Chupin)
                resultado -= resultado * 0.12;
            if (calidad == enum_calidad.Premium)
                resultado += resultado * 0.30;

            return resultado;
        }
    }
}
