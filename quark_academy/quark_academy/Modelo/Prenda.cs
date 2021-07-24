using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace quark_academy.Modelo
{
    abstract class Prenda
    {
        public enum enum_calidad
        {
            Standar = 0,
            Premium = 1
        }

        protected int codigo;
        protected enum_calidad calidad;
        protected double precio;
        protected int cantidad;

        public int Codigo { get => codigo; }
        public enum_calidad Calidad { get => calidad; }
        public double Precio { get => precio; }
        public int Cantidad { get => cantidad; }

        public abstract double CalcularPrecio();
    }
}
