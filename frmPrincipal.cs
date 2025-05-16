using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMartinez_Gestion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        int tiempoTranscurrido = 0;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString();
            temporizador.Enabled = true;
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            tiempoTranscurrido ++;
        }
    }
}
