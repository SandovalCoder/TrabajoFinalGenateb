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
    public partial class FrmEspecialistaTrabajador : Form
    {
        NEspecialistaTrabajador nes;
        List<EspecialistaTrabajador> listaEspecialistaTrabajador;
        NEspecialista ne;
        List<Especialista> listaEspecialista;
        NTrabajador ntra;
        List<Trabajador> listaTrabajadores;
        public FrmEspecialistaTrabajador()
        {
            InitializeComponent();
            nes = new NEspecialistaTrabajador();
            ne = new NEspecialista();
            ntra=new NTrabajador();
        }
        private void MostrarEspecialistaTrabajador(List<EspecialistaTrabajador> especialistaTrabajadors)
        {
            dtEspecialistaTraba.Rows.Clear();
            foreach (EspecialistaTrabajador item in listaEspecialistaTrabajador)
            {
                dtEspecialistaTraba.Rows.Add(item.EspecialistaTrabajadorId, item.AreaTrabajo, item.Activo, item.Eliminado, item.Trabajador_TrabajadorId, item.Especialista_EspecialistaId);
            }
        }

        private void CrearColumnasGridEspecialistaTrabajador()
        {
            dtEspecialistaTraba.Columns.Clear();
            dtEspecialistaTraba.Columns.Add("EspecialistaTrabajadorId", "EspecialistaTrabajadorId");
            dtEspecialistaTraba.Columns.Add("AreaTrabajo", "AreaTrabajo");
            dtEspecialistaTraba.Columns.Add("Activo", "Activo");
            dtEspecialistaTraba.Columns.Add("Eliminado", "Eliminado");
            dtEspecialistaTraba.Columns.Add("Trabajador_TrabajadorId", "Trabajador_TrabajadorId");
            dtEspecialistaTraba.Columns.Add("Especialista_EspecialistaId", "Especialista_EspecialistaId");
        }

        private void MostrarEspecialistaTrabajador(EspecialistaTrabajador especialistaTrabajador)
        {
            textIEspeTra.Text = especialistaTrabajador.EspecialistaTrabajadorId.ToString();
            textAreaTra.Text = especialistaTrabajador.AreaTrabajo;
            radioTrue.Checked = especialistaTrabajador.Activo;
            cbEspecialistaId.SelectedValue = especialistaTrabajador.Especialista_EspecialistaId;
            cbTrabajadorId.SelectedValue = especialistaTrabajador.Trabajador_TrabajadorId; 
        }


        private void buttonGrabar_Click(object sender, EventArgs e)
        {
           
            EspecialistaTrabajador especialistaTrabajador = new EspecialistaTrabajador();
            int especialistaTrabajadorId = 0;

            especialistaTrabajador.AreaTrabajo = textAreaTra.Text.Trim();
            especialistaTrabajador.Activo = radioTrue.Checked;
            especialistaTrabajador.Eliminado = false;
            especialistaTrabajador.UsuarioModificacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
            especialistaTrabajador.FechaModificacion = DateTime.UtcNow;
            especialistaTrabajador.Especialista_EspecialistaId = (int)cbEspecialistaId.SelectedValue;
            especialistaTrabajador.Trabajador_TrabajadorId = (int)cbTrabajadorId.SelectedValue;

            especialistaTrabajador.EspecialistaTrabajadorId = textIEspeTra.Text.Equals("") ? -1 : int.Parse(textIEspeTra.Text);

            //sin validacion

            if (!textIEspeTra.Text.Equals(""))
            {
                especialistaTrabajadorId = nes.Editar(especialistaTrabajador);
            }
            else
            {
                especialistaTrabajador.UsuarioCreacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
                especialistaTrabajador.FechaCreacion = DateTime.UtcNow;
                especialistaTrabajadorId = nes.Insertar(especialistaTrabajador);
            }

            listaEspecialistaTrabajador = nes.ListarEspecialistaTrabajador();
            MostrarEspecialistaTrabajador(listaEspecialistaTrabajador);

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int especialistaTrabajadorId = (int)dtEspecialistaTraba.CurrentRow.Cells["EspecialistaTrabajadorId"].Value;
            EspecialistaTrabajador especialistaTrabajador = nes.EspecialistaTrabajadorPorId(especialistaTrabajadorId);
            especialistaTrabajador.Eliminado = true;
            especialistaTrabajador.UsuarioModificacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
            especialistaTrabajador.FechaModificacion = DateTime.UtcNow;

            nes.EliminacionLogica(especialistaTrabajador);
            listaEspecialistaTrabajador = nes.ListarEspecialistaTrabajador();
            MostrarEspecialistaTrabajador(listaEspecialistaTrabajador);

        }
        private void LimpiarComponentes()
        {
            textIEspeTra.Text = "";
            textAreaTra.Text = "";
            radioTrue.Checked = false;
            cbEspecialistaId.SelectedIndex = 0;
            cbTrabajadorId.SelectedIndex = 0;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }

        private void dtEspecialistaTraba_SelectionChanged(object sender, EventArgs e)
        {
            int especialistaTrabajadorId = (int)dtEspecialistaTraba.CurrentRow.Cells["EspecialistaTrabajadorId"].Value;
            EspecialistaTrabajador especialistaTrabajador = nes.EspecialistaTrabajadorPorId(especialistaTrabajadorId);
            if (especialistaTrabajador != null)
            {
                MostrarEspecialistaTrabajador(especialistaTrabajador);
            }
        }

        private void FrmEspecialistaTrabajador_Load(object sender, EventArgs e)
        {
            CrearColumnasGridEspecialistaTrabajador();

            listaEspecialistaTrabajador = nes.ListarEspecialistaTrabajador();
            MostrarEspecialistaTrabajador(listaEspecialistaTrabajador);

            listaEspecialista = ne.ListarEspecialista();
            cbEspecialistaId.DataSource = listaEspecialista;
            cbEspecialistaId.DisplayMember = "NombreEspecialista";
            cbEspecialistaId.ValueMember = "EspecialistaId";

            listaTrabajadores = ntra.ListarTrabajadores();
            cbTrabajadorId.DataSource = listaTrabajadores;
            cbTrabajadorId.DisplayMember = "NombreTrabajador";
            cbTrabajadorId.ValueMember = "TrabajadorId";
        }
    }
}
