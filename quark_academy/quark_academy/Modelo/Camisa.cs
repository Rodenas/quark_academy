using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace quark_academy.Modelo
{
    class Camisa : Prenda
    {
        public enum enum_tipo_manga
        {
            Corta = 0,
            Larga = 1
        }

        private enum_tipo_manga manga;
        private bool cuelloMao;

        public enum_tipo_manga Manga { get => manga; }
        public bool CuelloMao { get => cuelloMao; }

        public Camisa(enum_tipo_manga manga, bool cuello_mao, enum_calidad calidad, double precio)
        {
            this.manga = manga;
            this.cuelloMao = cuello_mao;
            this.calidad = calidad;
            this.precio = precio;
        }

        public Camisa(enum_tipo_manga manga, bool cuello_mao, enum_calidad calidad, int cantidad)
        {
            this.manga = manga;
            this.cuelloMao = cuello_mao;
            this.calidad = calidad;
            this.cantidad = cantidad;
        }

        public override double CalcularPrecio()
        {
            double resultado = this.precio;

            if (manga == enum_tipo_manga.Corta)
                resultado -= resultado * 0.10;
            if (cuelloMao)
                resultado += resultado * 0.03;

            return resultado;
        }
    }
}
