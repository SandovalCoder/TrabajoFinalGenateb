using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Datos;
using Negocio;


namespace Presentacion
{
    public partial class FrmLogin : Form
    {

        NEspecialista nEspecialista;

        public FrmLogin()
        {
            InitializeComponent();
            nEspecialista = new NEspecialista();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            string dni = textDni.Text.Trim();
            string contraseña = textcontraseña.Text.Trim();

            Especialista userTemp = nEspecialista.Login(dni, contraseña);

            if (userTemp == null)
            {
                MessageBox.Show("Dni o contraseña incorrecto");
            }
            else
            {
                this.Hide();
                Principal objPrincipal = new Principal();
                objPrincipal.ShowDialog();
                this.Close();
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
