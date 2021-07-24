using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quark_academy.Modelo
{
    class Cotizacion
    {
        private int numeroIdentificacion;
        private DateTime fecha;
        private int fKVendedor;
        private int unidad;
        private double importe;

        public int NumeroIdentificacion { get => numeroIdentificacion; set => numeroIdentificacion = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int FKVendedor { get => fKVendedor; set => fKVendedor = value; }
        public int Unidad { get => unidad; set => unidad = value; }
        public double Importe { get => importe; set => importe = value; }

        public Cotizacion(int numeroIdentificacion, DateTime fecha, int fKVendedor, int unidad, double importe)
        {
            this.NumeroIdentificacion = numeroIdentificacion;
            this.Fecha = fecha;
            this.FKVendedor = fKVendedor;
            this.Unidad = unidad;
            this.Importe = importe;
        }
    }
}
