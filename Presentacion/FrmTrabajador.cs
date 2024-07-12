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

using Datos;


namespace Presentacion
{
    public partial class FrmTrabajador : Form
    {
        NTrabajador ntra;
        List<Trabajador> listaTrabajadores;
        NEmpresa    nemp;
        List<Empresa> listaEmpresas;
        public FrmTrabajador()
        {
            InitializeComponent();
            ntra=new NTrabajador();
        }
        private void MostrarListaEmpresas(List<Trabajador> trabajadors)
        {    
            dtTrabajador.Rows.Clear();
            foreach (Trabajador item in trabajadors)
            {
                dtTrabajador.Rows.Add(item.TrabajadorId, item.DniTrabajador, item.NombreTrabajador, item.ApellidoTrabajador, item.Activo, item.Eliminado, item.Empresa_EmpresaId, item.UsuarioCreacionId);
            }
        }

        private void CrearColumnasGridTrabajador()
        {
            dtTrabajador.Columns.Clear();
            dtTrabajador.Columns.Add("TrabajadorId", "TrabajadorId");
            dtTrabajador.Columns.Add("DniTrabajador", "DniTrabajador");
            dtTrabajador.Columns.Add("NombreTrabajador", "NombreTrabajador");
            dtTrabajador.Columns.Add("ApellidoTrabajador", "ApellidoTrabajador");
            dtTrabajador.Columns.Add("Activo", "Activo");
            dtTrabajador.Columns.Add("Eliminado", "Eliminado");
            dtTrabajador.Columns.Add("Empresa_EmpresaId", "Empresa_EmpresaId");
        }

        private void MostrarTrabajador(Trabajador traba)
        {
            textTraba.Text = traba.TrabajadorId.ToString();
            textDniTra.Text = traba.DniTrabajador;
            textNombreTra.Text = traba.NombreTrabajador;
            textApellidoTra.Text = traba.ApellidoTrabajador;
            radioTrue.Checked = traba.Activo;
            cbEmpresa.SelectedValue = traba.Empresa_EmpresaId;

        }
        private void buttonGrabar_Click(object sender, EventArgs e)
        {
            Trabajador trabajador = new Trabajador();
            int trabajadorId = 0;

            trabajador.DniTrabajador = textDniTra.Text.Trim();
            trabajador.NombreTrabajador = textNombreTra.Text.Trim();
            trabajador.ApellidoTrabajador = textApellidoTra.Text.Trim();
            trabajador.Activo = radioTrue.Checked;
            trabajador.Eliminado = false;
            trabajador.UsuarioModificacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
            trabajador.FechaModificacion = DateTime.UtcNow;
            trabajador.Empresa_EmpresaId = (int)cbEmpresa.SelectedValue;

            trabajador.TrabajadorId = textTraba.Text.Equals("") ? -1 : int.Parse(textTraba.Text);

            if (ntra.DniTrabajadorExiste(trabajador.DniTrabajador, trabajador.TrabajadorId))
            {
                MessageBox.Show("Dni ya registrado");
                return;
            }

           
            if (!textTraba.Text.Equals(""))
            {
                trabajadorId = ntra.Editar(trabajador);
            }
            else
            {
                trabajador.UsuarioCreacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
                trabajador.FechaCreacion = DateTime.UtcNow;
                trabajadorId = ntra.Insertar(trabajador);
            }

            
            listaTrabajadores = ntra.ListarTrabajadores();
            MostrarListaEmpresas(listaTrabajadores);

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int trabajadorId = (int)dtTrabajador.CurrentRow.Cells["TrabajadorId"].Value;
            Trabajador trabajador = ntra.TrabajadorPorId(trabajadorId);
            trabajador.Eliminado = true;
            trabajador.UsuarioModificacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
            trabajador.FechaModificacion = DateTime.UtcNow;

            ntra.EliminacionLogica(trabajador);

            listaTrabajadores = ntra.ListarTrabajadores();
            MostrarListaEmpresas(listaTrabajadores);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void FrmTrabajador_Load(object sender, EventArgs e)
        {
            CrearColumnasGridTrabajador();
            listaTrabajadores = ntra.ListarTrabajadores();
            MostrarListaEmpresas(listaTrabajadores);

            nemp = new NEmpresa();
            listaEmpresas = nemp.ListarEmpresas();
            cbEmpresa.DataSource = listaEmpresas;
            cbEmpresa.DisplayMember = "NombreEmpresa";
            cbEmpresa.ValueMember = "EmpresaId";
        }

        private void dtTrabajador_SelectionChanged(object sender, EventArgs e)
        {
            int trabajadorId = (int)dtTrabajador.CurrentRow.Cells["TrabajadorId"].Value;
            Trabajador trabajador = ntra.TrabajadorPorId(trabajadorId);
            if (trabajador != null)
            {
                MostrarTrabajador(trabajador);
            }

        }
        private void LimpiarControles()
        {
            textTraba.Text = "";
            textDniTra.Text = "";
            textNombreTra.Text = "";
            textApellidoTra.Text = "";
            radioTrue.Checked = false;
            cbEmpresa.SelectedIndex = 0;

           
        }
    }
}
