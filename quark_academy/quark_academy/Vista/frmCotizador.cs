using quark_academy.Data;
using quark_academy.Modelo;
using quark_academy.Presentador;
using quark_academy.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static quark_academy.Modelo.Pantalon;

namespace quark_academy
{
    public partial class Form1 : Form, ICotizacionView
    {
        private Tienda tienda;
        private Vendedor vendedor;

        private Cotizacion cotizacion;

        private CotizacionPresenter cotizacionPresenter;

        private Prenda prenda;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrendaData.InicializarDatoPrenda();
            TiendaData.InicializarDatoTienda();
            VendedorData.InicializarDatoVendedor();

            //Iniciar Tienda
            tienda = new Tienda(3225);

            //Iniciar Vendedor
            vendedor = new Vendedor(1111);

            lbl_nombre.Text = tienda.Nombre;
            lbl_nombre.Text = tienda.Direccion;

            lbl_vendedor.Text = $"{vendedor.Nombre} {vendedor.Apellido} | {vendedor.Codigo}";
        }

        private void btn_cotizar_Click(object sender, EventArgs e)
        {
            if (rab_camisa.Checked)
            {
                prenda = new Camisa(chb_manga_corta.Checked ? Camisa.enum_tipo_manga.Corta : Camisa.enum_tipo_manga.Larga,
                                           chb_cuello.Checked,
                                           rab_standar.Checked ? Prenda.enum_calidad.Standar : Prenda.enum_calidad.Premium,
                                           double.Parse(tbx_precio.Text));
            }
            else
            {
                prenda = new Pantalon(chb_chupin.Checked ? enum_tipo_pantalon.Chupin : enum_tipo_pantalon.Comun,
                                      rab_standar.Checked ? Prenda.enum_calidad.Standar : Prenda.enum_calidad.Premium,
                                      double.Parse(tbx_precio.Text));
            }

            cotizacionPresenter = new CotizacionPresenter(this);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            frmCotizaciones f = new frmCotizaciones();
            f.ShowDialog();
        }

        #region Interfaz
        void ICotizacionView.MensajeResultado(string result)
        {
            MessageBox.Show(result);
        }

        Prenda ICotizacionView.GetPrenda()
        {
            return prenda;
        }

        int ICotizacionView.GetUnidad()
        {
            return int.Parse(tbx_cantidad.Text);
        }

        Vendedor ICotizacionView.GetVendedor()
        {
            return vendedor;
        }

        public void ImporteResultado(string result)
        {
            lbl_precio_final.Text = result;
        }
        #endregion


    }
}
