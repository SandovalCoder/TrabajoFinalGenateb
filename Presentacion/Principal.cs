using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void hideSubMenu()
        {
            panelSubTrabajador.Visible = false;
            panelSubRegistros.Visible = false;
            panelReportes.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmInicio());
            hideSubMenu();
        }

        private void buttonRegistrarTrabajador_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubTrabajador);
        }

        private void buttonEspecialista_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEspecialista());
            hideSubMenu();
        }
        private void buttonEmpresa_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEmpresa());
            hideSubMenu();
        }
        private void buttonTrabajador_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmTrabajador());
            hideSubMenu();
        }
        private void buttonRegistrarEspecialistaTrabajador_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmEspecialistaTrabajador());
            hideSubMenu();
        }
        private void buttonRegistros_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubRegistros);
        }
        private void buttonErgonomico_Click(object sender, EventArgs e)
        { 
            openChildForm(new FrmRegistroMonitoreoErgonomico());
            hideSubMenu();
        }
        private void buttonTermica_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmRegistroResistenciaTermica());
            hideSubMenu();
        }
        private void buttonMetabolico_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmRegistroConsumoMetabolico());
            hideSubMenu();
        }
        private void buttonRegistroOcupacional_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmRegistroTrabajador());
            hideSubMenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelPrinicipal.Controls.Add(childForm);
            panelPrinicipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }   
}
    