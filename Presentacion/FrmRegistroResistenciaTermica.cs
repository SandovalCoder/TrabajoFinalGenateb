using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;

namespace Presentacion
{
    public partial class FrmRegistroResistenciaTermica : Form
    {
        NRegistroResistenciaTermica nr;
        List<RegistroResistenciaTermica> registroResistenciaTer;
        public FrmRegistroResistenciaTermica()
        {
            InitializeComponent();
            nr = new NRegistroResistenciaTermica();
        }
        private void MostrarResiTermica(List<RegistroResistenciaTermica> termicas)
        {
            dtTermica.Rows.Clear();
            foreach (RegistroResistenciaTermica item in termicas)
            {
                dtTermica.Rows.Add(item.RegistroResistenciaTermicaId, item.PrendaRopaInterior, item.PrendaCamisa, item.PrendaPantalones, item.PrendaVestidos, item.PrendaChaqueta, item.Eliminado);
            }

        }
        private void CrearColumnasGridTermicas()
        {
            dtTermica.Columns.Clear();
            dtTermica.Columns.Add("RegistroResistenciaTermicaId", "RegistroResistenciaTermicaId");
            dtTermica.Columns.Add("PrendaRopaInterior", "PrendaRopaInterior");
            dtTermica.Columns.Add("PrendaCamisa", "PrendaCamisa");
            dtTermica.Columns.Add("PrendaPantalones", "PrendaPantalones");
            dtTermica.Columns.Add("PrendaVestidos", "PrendaVestidos");
            dtTermica.Columns.Add("PrendaChaqueta", "PrendaChaqueta");
            dtTermica.Columns.Add("Eliminado", "Eliminado");
        }

        private void MostrarRegistroErgonomico(RegistroResistenciaTermica registroResistenciaTermica)
        {
           textIdTer.Text=registroResistenciaTermica.RegistroResistenciaTermicaId.ToString();
           cbInterior.SelectedValue=registroResistenciaTermica.PrendaRopaInterior;
           cbCamisa.SelectedValue=registroResistenciaTermica.PrendaCamisa;
           cbPantalones.SelectedValue=registroResistenciaTermica.PrendaPantalones;
           cbVestidos.SelectedValue=registroResistenciaTermica.PrendaVestidos;
           cbChaqueta.SelectedValue=registroResistenciaTermica.PrendaChaqueta;
        }

        private void LimpiarComponentes()
        {
            textIdTer.Text = "";
            cbInterior.SelectedIndex = 0;
            cbCamisa.SelectedIndex = 0;
            cbPantalones.SelectedIndex = 0;
            cbVestidos.SelectedIndex = 0;
            cbChaqueta.SelectedIndex = 0;
        }


        private void buttonGrabar_Click(object sender, EventArgs e)
        {


            RegistroResistenciaTermica registroResistenciaTermica = new RegistroResistenciaTermica();
            int registroResistenciaTermicaId = 0;

            registroResistenciaTermica.PrendaRopaInterior = cbInterior.Text.Trim();
            registroResistenciaTermica.PrendaCamisa = cbCamisa.Text.Trim();
            registroResistenciaTermica.PrendaPantalones = cbPantalones.Text.Trim();
            registroResistenciaTermica.PrendaVestidos = cbVestidos.Text.Trim();
            registroResistenciaTermica.PrendaChaqueta = cbChaqueta.Text.Trim();
            registroResistenciaTermica.Eliminado = false;
            registroResistenciaTermica.UsuarioModificacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
            registroResistenciaTermica.FechaModificacion = DateTime.UtcNow;

            registroResistenciaTermica.RegistroResistenciaTermicaId = textIdTer.Text.Equals("") ? -1 : int.Parse(textIdTer.Text);

            //sin validacion

            if (!textIdTer.Text.Equals(""))
            {
                registroResistenciaTermicaId = nr.Editar(registroResistenciaTermica);
            }
            else
            {
                registroResistenciaTermica.UsuarioCreacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
                registroResistenciaTermica.FechaCreacion = DateTime.UtcNow;
                registroResistenciaTermicaId = nr.Insertar(registroResistenciaTermica);
            }

            registroResistenciaTer = nr.ListaregistroResistenciaTermicas();
            MostrarResiTermica(registroResistenciaTer);

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int registroResistenciaTermicaId = (int)dtTermica.CurrentRow.Cells["RegistroResistenciaTermicaId"].Value;
            RegistroResistenciaTermica registroResistenciaTermica = nr.registroResistenciaTermicaPorId(registroResistenciaTermicaId);
            registroResistenciaTermica.Eliminado = true;
            registroResistenciaTermica.UsuarioModificacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
            registroResistenciaTermica.FechaModificacion = DateTime.UtcNow;

            nr.EliminacionLogica(registroResistenciaTermica);
            registroResistenciaTermica = nr.registroResistenciaTermicaPorId(registroResistenciaTermicaId);
            MostrarRegistroErgonomico(registroResistenciaTermica);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }

        private void dtTermica_SelectionChanged(object sender, EventArgs e)
        {
           
            int registroResistenciaTermicaId = (int)dtTermica.CurrentRow.Cells["RegistroResistenciaTermicaId"].Value;
            RegistroResistenciaTermica registroResistenciaTermica = nr.registroResistenciaTermicaPorId(registroResistenciaTermicaId);
            if (registroResistenciaTermica != null)
            {
                MostrarRegistroErgonomico(registroResistenciaTermica);
            }

           
        }

        private void FrmRegistroResistenciaTermica_Load(object sender, EventArgs e)
        {
            CrearColumnasGridTermicas();
            registroResistenciaTer= nr.ListaregistroResistenciaTermicas();
            MostrarResiTermica(registroResistenciaTer);
        }
    }
}
