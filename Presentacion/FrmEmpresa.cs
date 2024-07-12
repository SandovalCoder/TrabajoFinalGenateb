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
    public partial class FrmEmpresa : Form
    {
        NEmpresa emp;
        List<Empresa> listaEmpresas;
        public FrmEmpresa()
        {
            InitializeComponent();
            emp=new NEmpresa();
        }
        private void MostrarlistaEmpresas(List<Empresa> lista)
        {  
            dtEmpresa.Rows.Clear();
            foreach (Empresa item in lista)
            {
                dtEmpresa.Rows.Add(item.EmpresaId, item.NombreEmpresa, item.DireccionEmpresa, item.CiudadEmpresa, item.Activo, item.Eliminado, item.UsuarioCreacionId);
            }
        }

        private void CrearColumnasGridUsuarios()
        {
            dtEmpresa.Columns.Clear();
            dtEmpresa.Columns.Add("EmpresaId", "EmpresaId");
            dtEmpresa.Columns.Add("NombreEmpresa", "NombreEmpresa");
            dtEmpresa.Columns.Add("DireccionEmpresa", "DireccionEmpresa");
            dtEmpresa.Columns.Add("CiudadEmpresa", "CiudadEmpresa");
            dtEmpresa.Columns.Add("Activo", "Activo");
            dtEmpresa.Columns.Add("Eliminado", "Eliminado");
            dtEmpresa.Columns.Add("UsuarioCreacionId", "UsuarioCreacionId");
        }

        private void MostrarEmpresa(Empresa empresa)
        {
            textIdEmpresa.Text = empresa.EmpresaId.ToString();
            textNombreEm.Text = empresa.NombreEmpresa;
            textDireccionEm.Text = empresa.DireccionEmpresa;
            textCiudadEm.Text = empresa.CiudadEmpresa;
            radioactivo.Checked = empresa.Activo;
        }

        private void buttonGrabar_Click(object sender, EventArgs e)
        {
            
            Empresa empres = new Empresa();
            int empresaId = 0;

            empres.NombreEmpresa = textNombreEm.Text.Trim();
            empres.DireccionEmpresa = textDireccionEm.Text.Trim();
            empres.CiudadEmpresa = textCiudadEm.Text.Trim();
            empres.Activo = radioactivo.Checked;
            empres.Eliminado = false;
            empres.UsuarioModificacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
            empres.FechaModificacion = DateTime.UtcNow;

            empres.EmpresaId = textIdEmpresa.Text.Equals("") ? -1 : int.Parse(textIdEmpresa.Text);

            if (emp.NombreEmpresaExiste(empres.NombreEmpresa, empres.EmpresaId))
            {
                MessageBox.Show("Nombre de empresa ya registrado");
                return;
            }

            if (!textIdEmpresa.Text.Equals(""))
            {
                empresaId = emp.Editar(empres);
            }
            else
            {
                empres.UsuarioCreacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
                empres.FechaCreacion = DateTime.UtcNow;
                empresaId = emp.Insertar(empres);
            }

            listaEmpresas = emp.ListarEmpresas();
            MostrarlistaEmpresas(listaEmpresas);

            empres = emp.EmpresaPorId(empresaId);
            MostrarEmpresa(empres);

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int empresaId = (int)dtEmpresa.CurrentRow.Cells["EmpresaId"].Value;
            Empresa empresa = emp.EmpresaPorId(empresaId);
            empresa.Eliminado = true;
            empresa.UsuarioModificacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
            empresa.FechaModificacion = DateTime.UtcNow;

            emp.EliminacionLogica(empresa);

            listaEmpresas = emp.ListarEmpresas();
            MostrarlistaEmpresas(listaEmpresas);
        }
        private void LimpiarComponentes()
        {
            textIdEmpresa.Text = "";
            textNombreEm.Text = "";
            textDireccionEm.Text = "";
            textCiudadEm.Text = "";
            radioactivo.Checked = false;
        }
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }

        private void dtEmpresa_SelectionChanged(object sender, EventArgs e)
        {
            int empresaId = (int)dtEmpresa.CurrentRow.Cells["EmpresaId"].Value;
            Empresa empresa = emp.EmpresaPorId(empresaId);
            if (empresa != null)
            {
                MostrarEmpresa(empresa);
            }
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            CrearColumnasGridUsuarios();
            listaEmpresas = emp.ListarEmpresas();
            MostrarlistaEmpresas(listaEmpresas);
        }
    }
}
