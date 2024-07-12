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
    public partial class FrmRegistroTrabajador : Form
    {
        NRegistroTrabajador nreg;
        List<RegistroTrabajador> listaRegistroTrabajadores;
        NRegistroConsumoMetabolico nregi;
        List<RegistroConsumoMetabolico> registroConsumoMetabolicos;
        NRegistroMonitoreoErgonomico nregis;
        List<RegistroMonitoreoErgonomico> registroMonitoreoErgonomicos;
        NRegistroResistenciaTermica nregisr;
        List<RegistroResistenciaTermica> registroResistenciaTermicas;

        public FrmRegistroTrabajador()
        {
            InitializeComponent();
            nreg = new NRegistroTrabajador();
            nregi = new NRegistroConsumoMetabolico();
            nregis = new NRegistroMonitoreoErgonomico();
            nregisr = new NRegistroResistenciaTermica();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void MostrarEspecialistaRegistro(List<RegistroTrabajador> regis)
        {
            dtregistro.Rows.Clear();
            foreach (RegistroTrabajador item in regis)
            {
                dtregistro.Rows.Add(item.RegistroTrabajadorId, item.RegistroConsumoMetabolico_RegistroConsumoMetabolicoId, item.RegistroResistenciaTermica_RegistroResistenciaTermicaId, item.RegistroMonitoreoErgonomico_RegistroMonitoreoErgonomicoId, item.Trabajador_TrabajadorId, item.Eliminado);
            }

        }

        private void CrearColumnasGridRegistraba()
        {
            dtregistro.Columns.Clear();
            dtregistro.Columns.Add("RegistroTrabajadorId", "RegistroTrabajadorId");
            dtregistro.Columns.Add("RegistroConsumoMetabolico_RegistroConsumoMetabolicoId", "RegistroConsumoMetabolico_RegistroConsumoMetabolicoId");
            dtregistro.Columns.Add("RegistroResistenciaTermica_RegistroResistenciaTermicaId", "RegistroResistenciaTermica_RegistroResistenciaTermicaId");
            dtregistro.Columns.Add("RegistroMonitoreoErgonomico_RegistroMonitoreoErgonomicoId", "RegistroMonitoreoErgonomico_RegistroMonitoreoErgonomicoId");
            dtregistro.Columns.Add("Trabajador_TrabajadorId", "Trabajador_TrabajadorId");
            dtregistro.Columns.Add("Eliminado", "Eliminado");
        }

        private void MostrarRegistroregistra(RegistroTrabajador regist)
        {
            textIdres.Text = regist.RegistroTrabajadorId.ToString();
            cbconsumo.SelectedValue = regist.RegistroConsumoMetabolico_RegistroConsumoMetabolicoId;
            cbtermica.SelectedValue = regist.RegistroResistenciaTermica_RegistroResistenciaTermicaId;
            cbErgonomico.SelectedValue=regist.RegistroMonitoreoErgonomico_RegistroMonitoreoErgonomicoId;
            cbtrabajador.SelectedValue = regist.Trabajador_TrabajadorId;
        }
        private void LimpiarComponentes()
        {
            textIdres.Text = "";
            cbconsumo.SelectedIndex =0;
            cbtermica.SelectedIndex = 0;
            cbErgonomico.SelectedIndex = 0;
            cbtrabajador.SelectedIndex = 0;
        }


        private void buttonGrabar_Click(object sender, EventArgs e)
        {
            
            RegistroTrabajador resgitra= new RegistroTrabajador();
            int registroId = 0;

            resgitra.RegistroConsumoMetabolico_RegistroConsumoMetabolicoId = (int)cbconsumo.SelectedValue;
            resgitra.RegistroResistenciaTermica_RegistroResistenciaTermicaId = (int)cbtermica.SelectedValue;
            resgitra.RegistroMonitoreoErgonomico_RegistroMonitoreoErgonomicoId = (int)cbErgonomico.SelectedValue;
            resgitra.Trabajador_TrabajadorId = (int)cbtrabajador.SelectedValue;
            resgitra.Eliminado = false;
            resgitra.UsuarioModificacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
            resgitra.FechaModificacion = DateTime.UtcNow;

            resgitra.RegistroTrabajadorId = textIdres.Text.Equals("") ? -1 : int.Parse(textIdres.Text);

            //sin validacion

            if (!textIdres.Text.Equals(""))
            {
                registroId = nreg.Editar(resgitra);
            }
            else
            {
                resgitra.UsuarioCreacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
                resgitra.FechaCreacion = DateTime.UtcNow;
                registroId = nreg.Insertar(resgitra);
            }

            listaRegistroTrabajadores = nreg.ListaregistroTrabajadores();
            MostrarEspecialistaRegistro(listaRegistroTrabajadores);


        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int registroId = (int)dtregistro.CurrentRow.Cells["RegistroTrabajadorId"].Value;
            RegistroTrabajador registro = nreg.registroTrabajadorPorId(registroId);
            registro.Eliminado = true;
            registro.UsuarioModificacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
            registro.FechaModificacion = DateTime.UtcNow;

            nreg.EliminacionLogica(registro);
            listaRegistroTrabajadores = nreg.ListaregistroTrabajadores();
            MostrarEspecialistaRegistro(listaRegistroTrabajadores);

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }

        private void FrmRegistroTrabajador_Load(object sender, EventArgs e)
        {
            nreg = new NRegistroTrabajador();
            listaRegistroTrabajadores = nreg.ListaregistroTrabajadores();
            CrearColumnasGridRegistraba();
            MostrarEspecialistaRegistro(listaRegistroTrabajadores);
            nregi = new NRegistroConsumoMetabolico();
            registroConsumoMetabolicos = nregi.ListaregistroConsumoMetabolicos();
            cbconsumo.DataSource = registroConsumoMetabolicos;
            cbconsumo.DisplayMember = "RegistroConsumoMetabolicoId";
            cbconsumo.ValueMember = "RegistroConsumoMetabolicoId";
            nregis = new NRegistroMonitoreoErgonomico();
            registroMonitoreoErgonomicos = nregis.ListaregistroMonitoreoErgonomicos();
            cbErgonomico.DataSource = registroMonitoreoErgonomicos;
            cbErgonomico.DisplayMember = "RegistroMonitoreoErgonomicoId";
            cbErgonomico.ValueMember = "RegistroMonitoreoErgonomicoId";
            nregisr = new NRegistroResistenciaTermica();
            registroResistenciaTermicas = nregisr.ListaregistroResistenciaTermicas();
            cbtermica.DataSource = registroResistenciaTermicas;
            cbtermica.DisplayMember = "RegistroResistenciaTermicaId";
            cbtermica.ValueMember = "RegistroResistenciaTermicaId";

            NTrabajador ntra = new NTrabajador();
            List<Trabajador> listaTrabajadores = ntra.ListarTrabajadores();
            cbtrabajador.DataSource = listaTrabajadores;
            cbtrabajador.DisplayMember = "TrabajadorId";
            cbtrabajador.ValueMember = "TrabajadorId";

        }

        private void dtregistro_SelectionChanged(object sender, EventArgs e)
        {
            int registroId = (int)dtregistro.CurrentRow.Cells["RegistroTrabajadorId"].Value;
            RegistroTrabajador registro = nreg.registroTrabajadorPorId(registroId);
            if (registro != null)
            {
                MostrarRegistroregistra(registro);
            }
        }
    }
}
