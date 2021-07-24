using quark_academy.Modelo;
using quark_academy.Presentador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quark_academy.Vista
{
    public partial class frmCotizaciones : Form, IHistorialCotizacion
    {
        public frmCotizaciones()
        {
            InitializeComponent();

            HistorialCotizacionPresenter HC = new HistorialCotizacionPresenter(this);
        }

        void IHistorialCotizacion.ResultHistorialCotizacion(List<Cotizacion> lst)
        {
            dataGridView1.DataSource = lst;
        }
    }
}
