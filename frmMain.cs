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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        clsConexion login = new clsConexion();

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            login.Usuario();
            login.ValidarUsuario(txtUsuario.Text, txtContraseña.Text);
            if(login.estadoConexion == "Usuario EXISTE") 
            {
                MessageBox.Show("Bienvenido");
                frmPrincipal frm = new frmPrincipal();
                frm.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
