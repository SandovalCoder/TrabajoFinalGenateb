using Datos;
using Negocio;
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
    public partial class FrmRegistroConsumoMetabolico : Form
    {
        NRegistroConsumoMetabolico nregi;
        List<RegistroConsumoMetabolico> registroConsumoMetabolicos;
        public FrmRegistroConsumoMetabolico()
        {
            InitializeComponent();
        }

        private void MostrarEspecialistaRegistro(List<RegistroConsumoMetabolico> registroConsumos)
        {
           
            dtMetabolico.Rows.Clear();
            foreach (RegistroConsumoMetabolico item in registroConsumos)
            {
                dtMetabolico.Rows.Add(item.RegistroConsumoMetabolicoId, item.PosicionTrabajador, item.TiempoPosicion, item.TipoTrabajo, item.TiempoTrabajo, item.NivelHemoglobina, item.RangoHemoglobina, item.LaboratorioClinico, item.Eliminado);
            }
        }

        private void CrearColumnasGridMentabolico()
        {
            dtMetabolico.Columns.Clear();
            dtMetabolico.Columns.Add("RegistroConsumoMetabolicoId", "RegistroConsumoMetabolicoId");
            dtMetabolico.Columns.Add("PosicionTrabajador", "PosicionTrabajador");
            dtMetabolico.Columns.Add("TiempoPosicion", "TiempoPosicion");
            dtMetabolico.Columns.Add("TipoTrabajo", "TipoTrabajo");
            dtMetabolico.Columns.Add("TiempoTrabajo", "TiempoTrabajo");
            dtMetabolico.Columns.Add("NivelHemoglobina", "NivelHemoglobina");
            dtMetabolico.Columns.Add("RangoHemoglobina", "RangoHemoglobina");
            dtMetabolico.Columns.Add("LaboratorioClinico", "LaboratorioClinico");
            dtMetabolico.Columns.Add("Eliminado", "Eliminado");
        }

        private void MostrarRegistroErgonomico(RegistroConsumoMetabolico registroConsumoMetabolico)
        {
            textIdMeta.Text = registroConsumoMetabolico.RegistroConsumoMetabolicoId.ToString();
            cbPosicion.SelectedValue = registroConsumoMetabolico.PosicionTrabajador;
            textTiempoA.Text = registroConsumoMetabolico.TiempoPosicion.ToString();
            cbTipo.SelectedValue = registroConsumoMetabolico.TipoTrabajo;
            textTiempoB.Text = registroConsumoMetabolico.TiempoTrabajo.ToString();
            textNivel.Text = registroConsumoMetabolico.NivelHemoglobina.ToString();
            cbRango.SelectedValue = registroConsumoMetabolico.RangoHemoglobina;
            textClinico.Text = registroConsumoMetabolico.LaboratorioClinico.ToString();
        }

        private void buttonGrabar_Click(object sender, EventArgs e)
        {
          
            RegistroConsumoMetabolico registroConsumoMe = new RegistroConsumoMetabolico();

            int registroConsumoMetabolicoId = 0;

            registroConsumoMe.PosicionTrabajador = cbPosicion.Text.Trim();
            registroConsumoMe.TiempoPosicion = int.Parse(textTiempoA.Text.Trim());
            registroConsumoMe.TipoTrabajo = cbTipo.Text.Trim();
            registroConsumoMe.TiempoTrabajo = int.Parse(textTiempoB.Text.Trim());
            registroConsumoMe.NivelHemoglobina = float.Parse(textNivel.Text.Trim());
            registroConsumoMe.RangoHemoglobina = cbRango.Text.Trim();
            registroConsumoMe.LaboratorioClinico = textClinico.Text.Trim();
            registroConsumoMe.Eliminado = false;
            registroConsumoMe.UsuarioModificacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
            registroConsumoMe.FechaModificacion = DateTime.UtcNow;

            registroConsumoMe.RegistroConsumoMetabolicoId = textIdMeta.Text.Equals("") ? -1 : int.Parse(textIdMeta.Text);

            //sin validacion

            if (!textIdMeta.Text.Equals(""))
            {
                registroConsumoMetabolicoId = nregi.Editar(registroConsumoMe);
            }
            else
            {
                registroConsumoMe.UsuarioCreacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
                registroConsumoMe.FechaCreacion = DateTime.UtcNow;
                registroConsumoMetabolicoId = nregi.Insertar(registroConsumoMe);
            }

            registroConsumoMetabolicos = nregi.ListaregistroConsumoMetabolicos();
            MostrarEspecialistaRegistro(registroConsumoMetabolicos);


        }


        private void FrmRegistroConsumoMetabolico_Load(object sender, EventArgs e)
        {
            nregi = new NRegistroConsumoMetabolico();
            registroConsumoMetabolicos = nregi.ListaregistroConsumoMetabolicos();
            CrearColumnasGridMentabolico();
            MostrarEspecialistaRegistro(registroConsumoMetabolicos);

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            int registroConsumoMetabolicoId = (int)dtMetabolico.CurrentRow.Cells["RegistroConsumoMetabolicoId"].Value;
            RegistroConsumoMetabolico registroConsumoMetabolico = nregi.registroConsumoMetabolicoPorId(registroConsumoMetabolicoId);
            registroConsumoMetabolico.Eliminado = true;
            registroConsumoMetabolico.UsuarioModificacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
            registroConsumoMetabolico.FechaModificacion = DateTime.UtcNow;

            nregi.EliminacionLogica(registroConsumoMetabolico);
            registroConsumoMetabolicos = nregi.ListaregistroConsumoMetabolicos();
            MostrarEspecialistaRegistro(registroConsumoMetabolicos);
        }


        private void buttonLimpiar_Click(object sender, EventArgs e)
        { 
            textIdMeta.Text = "";
            cbPosicion.SelectedItem = 0;
            textTiempoA.Text = "";
            cbTipo.SelectedItem = 0;
            textTiempoB.Text = "";
            textNivel.Text = "";
            cbRango.SelectedItem = 0;
            textClinico.Text = "";
        }

        private void dtMetabolico_SelectionChanged(object sender, EventArgs e)
        {
            int registroConsumoMetabolicoId = (int)dtMetabolico.CurrentRow.Cells["RegistroConsumoMetabolicoId"].Value;
            RegistroConsumoMetabolico registroConsumoMetabolico = nregi.registroConsumoMetabolicoPorId(registroConsumoMetabolicoId);
            if (registroConsumoMetabolico != null)
            {
                MostrarRegistroErgonomico(registroConsumoMetabolico);
            }

        }
    }
}
