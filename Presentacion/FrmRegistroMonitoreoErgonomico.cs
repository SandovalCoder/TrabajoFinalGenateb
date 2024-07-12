using Datos;
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


namespace Presentacion
{
    public partial class FrmRegistroMonitoreoErgonomico : Form
    {

        NRegistroMonitoreoErgonomico nreg;
        List<RegistroMonitoreoErgonomico> listaRegistroMonitoreoErgonomicos;
        public FrmRegistroMonitoreoErgonomico()
        {
            InitializeComponent();
            nreg = new NRegistroMonitoreoErgonomico();
        }
        private void MostrarEspecialistaRegistro(List<RegistroMonitoreoErgonomico> registroMonitoreo)
        {
            dtErgonomico.Rows.Clear();
            foreach (RegistroMonitoreoErgonomico item in registroMonitoreo)
            {
                dtErgonomico.Rows.Add(item.RegistroMonitoreoErgonomicoId, item.ErgonomiaDatos, item.TiempoDato, item.EquipamientoOficina, item.TiempoEquipamiento, item.Eliminado);
            }
        }

        private void CrearColumnasGridErgonomico()
        {

            dtErgonomico.Columns.Clear();
            dtErgonomico.Columns.Add("RegistroMonitoreoErgonomicoId", "RegistroMonitoreoErgonomicoId");
            dtErgonomico.Columns.Add("ErgonomiaDatos", "ErgonomiaDatos");
            dtErgonomico.Columns.Add("TiempoDato", "TiempoDato");
            dtErgonomico.Columns.Add("EquipamientoOficina", "EquipamientoOficina");
            dtErgonomico.Columns.Add("TiempoEquipamiento", "TiempoEquipamiento");
            dtErgonomico.Columns.Add("Eliminado", "Eliminado");
        }

        private void MostrarRegistroErgonomico(RegistroMonitoreoErgonomico registroMonitoreoErgonomico)
        {
            textIdEr.Text = registroMonitoreoErgonomico.RegistroMonitoreoErgonomicoId.ToString(); 
            cbA.SelectedValue = registroMonitoreoErgonomico.ErgonomiaDatos;
            textdato.Text = registroMonitoreoErgonomico.TiempoDato.ToString();
            cbB.SelectedValue = registroMonitoreoErgonomico.EquipamientoOficina;
            texttiempo.Text = registroMonitoreoErgonomico.TiempoEquipamiento.ToString();
        }
        private void buttonGrabar_Click(object sender, EventArgs e)
        { 

            RegistroMonitoreoErgonomico registro= new   RegistroMonitoreoErgonomico();
            int registroId = 0;

            registro.ErgonomiaDatos =cbA.Text.Trim();
            registro.TiempoDato = int.Parse(textdato.Text.Trim());
            registro.EquipamientoOficina = cbB.Text.Trim();
            registro.TiempoEquipamiento = int.Parse(texttiempo.Text.Trim());
            registro.Eliminado = false;
            registro.UsuarioModificacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
            registro.FechaModificacion = DateTime.UtcNow;

            registro.RegistroMonitoreoErgonomicoId = textIdEr.Text.Equals("") ? -1 : int.Parse(textIdEr.Text);

            //sin validacion

            if (!textIdEr.Text.Equals(""))
            {
                registroId = nreg.Editar(registro);
            }
            else
            {
                registro.UsuarioCreacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
                registro.FechaCreacion = DateTime.UtcNow;
                registroId = nreg.Insertar(registro);
            }

            listaRegistroMonitoreoErgonomicos = nreg.ListaregistroMonitoreoErgonomicos();
            MostrarEspecialistaRegistro(listaRegistroMonitoreoErgonomicos);
        }
        private void LimpiarComponentes()
        {
            textIdEr.Text = "";
            cbA.SelectedItem = 0;
            textdato.Text = "";
            cbB.SelectedItem = 0;
            texttiempo.Text = "";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int registroId = (int)dtErgonomico.CurrentRow.Cells["RegistroMonitoreoErgonomicoId"].Value;
            RegistroMonitoreoErgonomico registro = nreg.registroMonitoreoErgonomicoPorId(registroId);
            registro.Eliminado = true;
            registro.UsuarioModificacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
            registro.FechaModificacion = DateTime.UtcNow;


            nreg.EliminacionLogica(registro);
            listaRegistroMonitoreoErgonomicos = nreg.ListaregistroMonitoreoErgonomicos();
            MostrarEspecialistaRegistro(listaRegistroMonitoreoErgonomicos);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }

        private void dtErgonomico_SelectionChanged(object sender, EventArgs e)
        {
            int registroId = (int)dtErgonomico.CurrentRow.Cells["RegistroMonitoreoErgonomicoId"].Value;
            RegistroMonitoreoErgonomico registro = nreg.registroMonitoreoErgonomicoPorId(registroId);
            if (registro != null)
            {
                MostrarRegistroErgonomico(registro);
            }
        }

        private void FrmRegistroConsumoMetabolico_Load(object sender, EventArgs e)
        {
            CrearColumnasGridErgonomico();
            listaRegistroMonitoreoErgonomicos = nreg.ListaregistroMonitoreoErgonomicos();
            MostrarEspecialistaRegistro(listaRegistroMonitoreoErgonomicos);
        }
    }
}
