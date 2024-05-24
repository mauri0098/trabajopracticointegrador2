using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajopracticointegrador2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        classBasededatos objbase = new classBasededatos();
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            classBasededatos objbase = new classBasededatos();
            objbase.conectarBD();
            objbase.guardar(txtUsuario.Text, txtContraseña.Text);
            objbase.RegistroLogInicioSesion();

        }

        private void btnRegitrarse_Click(object sender, EventArgs e)
        {
           
            objbase.guardar(txtUsuario.Text, txtContraseña.Text);
            objbase.RegistroLogInicioSesion();
            objbase.RegistroLogInicioSesion2();            
        }
    }
}
