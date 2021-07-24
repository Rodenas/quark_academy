using quark_academy.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static quark_academy.Modelo.Pantalon;

namespace quark_academy.Data
{
    class PrendaData
    {
        static List<Prenda> lstPrendaData;

        /// <summary>
        /// Inicializa el dato en memoria de las Prendas
        /// </summary>
        public static void InicializarDatoPrenda()
        {
            lstPrendaData = new List<Prenda>();

            //PANTALONES
            lstPrendaData.Add(new Pantalon(enum_tipo_pantalon.Chupin,
                                           Prenda.enum_calidad.Standar,
                                           750));

            lstPrendaData.Add(new Pantalon(enum_tipo_pantalon.Chupin,
                                           Prenda.enum_calidad.Premium,
                                           750));

            lstPrendaData.Add(new Pantalon(enum_tipo_pantalon.Comun,
                                           Prenda.enum_calidad.Standar,
                                           250));

            lstPrendaData.Add(new Pantalon(enum_tipo_pantalon.Comun,
                                           Prenda.enum_calidad.Premium,
                                           250));

            //CAMISAS
            lstPrendaData.Add(new Camisa(Camisa.enum_tipo_manga.Corta,
                                         true,
                                         Prenda.enum_calidad.Standar,
                                         100));

            lstPrendaData.Add(new Camisa(Camisa.enum_tipo_manga.Corta,
                                         true,
                                         Prenda.enum_calidad.Premium,
                                         100));

            lstPrendaData.Add(new Camisa(Camisa.enum_tipo_manga.Corta,
                                         false,
                                         Prenda.enum_calidad.Standar,
                                         150));

            lstPrendaData.Add(new Camisa(Camisa.enum_tipo_manga.Corta,
                                         false,
                                         Prenda.enum_calidad.Premium,
                                         150));

            lstPrendaData.Add(new Camisa(Camisa.enum_tipo_manga.Larga,
                                         true,
                                         Prenda.enum_calidad.Standar,
                                         75));

            lstPrendaData.Add(new Camisa(Camisa.enum_tipo_manga.Larga,
                                         true,
                                         Prenda.enum_calidad.Premium,
                                         75));

            lstPrendaData.Add(new Camisa(Camisa.enum_tipo_manga.Larga,
                                         false,
                                         Prenda.enum_calidad.Standar,
                                         175));

            lstPrendaData.Add(new Camisa(Camisa.enum_tipo_manga.Larga,
                                         false,
                                         Prenda.enum_calidad.Premium,
                                         175));
        }

        /// <summary>
        /// Obtiene las prendas de una tienda
        /// </summary>
        public List<Prenda> GetPrendaTienda(int codigo_tienda)
        {
            return PrendaData.lstPrendaData;
        }

        /// <summary>
        /// Verifica si hay stock de una prenda
        /// </summary>
        /// <param name="prenda"></param>
        /// <param name="unidad"></param>
        /// <returns></returns>
        public bool TieneStock(Prenda prenda, int unidad)
        {
            //ESTO ESTA MAL HECHO
            int cantidad = 0;

            if (prenda.GetType() == typeof(Camisa))
            {
                var lstCamisa = lstPrendaData.Where(x => x.GetType() == typeof(Camisa)).ToList();

                cantidad = lstCamisa.Where(x => ((Camisa)x).Manga == ((Camisa)prenda).Manga
                                     && ((Camisa)x).CuelloMao == ((Camisa)prenda).CuelloMao
                                     && x.Calidad == prenda.Calidad
                                     && x.Cantidad >= unidad).ToList().Count();
            }
            else
            {
                var lstPantalon = lstPrendaData.Where(x => x.GetType() == typeof(Pantalon)).ToList();

                cantidad = lstPantalon.Where(x => ((Pantalon)x).Tipo == ((Pantalon)prenda).Tipo
                                         && x.Calidad == prenda.Calidad
                                         && x.Cantidad >= unidad).ToList().Count(); ;
            }

            return cantidad == 1;


        }
    }
}
