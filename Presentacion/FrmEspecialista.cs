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
    public partial class FrmEspecialista : Form
    {
        NEspecialista ne;
        List<Especialista> listaEspecialista;
        public FrmEspecialista()
        {
            InitializeComponent();
            ne = new NEspecialista();
            listaEspecialista = new List<Especialista>();
        }

       

        private void MostrarListaEspecialista(List<Especialista> lista)
        {
            dataEspecialista.Rows.Clear();
            foreach (Especialista item in lista)
            {
                dataEspecialista.Rows.Add(item.EspecialistaId, item.DniEspecialista, item.Contrasena, item.NombreEspecialista, item.ApellidoEspecialista, item.Ocupacion, item.Activo, item.Eliminado);
            }
        }
        private void CrearColumnasGridEspecialista()
        {
            dataEspecialista.Columns.Clear();
            dataEspecialista.Columns.Add("EspecialistaId", "EspecialistaId");
            dataEspecialista.Columns.Add("DniEspecialista", "DniEspecialista");
            dataEspecialista.Columns.Add("Contrasena", "Contrasena");
            dataEspecialista.Columns.Add("NombreEspecialista", "NombreEspecialista");
            dataEspecialista.Columns.Add("ApellidoEspecialista", "ApellidoEspecialista");
            dataEspecialista.Columns.Add("Ocupacion", "Ocupacion");
            dataEspecialista.Columns.Add("Activo", "Activo");
            dataEspecialista.Columns.Add("Eliminado", "Eliminado");

        }
        private void FrmEspecialista_Load(object sender, EventArgs e)
        {
            listaEspecialista = ne.ListarEspecialista();
            CrearColumnasGridEspecialista();
            MostrarListaEspecialista(listaEspecialista);
        }
        private void MostrarEspecialista(Especialista especialista)
        {
            textIdEs.Text = especialista.EspecialistaId.ToString();
            textDni.Text = especialista.DniEspecialista;
            textContraseña.Text = especialista.Contrasena;
            textNombre.Text = especialista.NombreEspecialista;
            textApellido.Text = especialista.ApellidoEspecialista;
            cbOcupacion.Text = especialista.Ocupacion;
            radioactivo.Checked = especialista.Activo;
            labelCreado.Text = (especialista.UsuarioCreacion != null) ? especialista.UsuarioCreacion.NombreEspecialista : "";
            labelModificado.Text = (especialista.UsuarioModificacion != null) ? especialista.UsuarioModificacion.NombreEspecialista : "";
            labelfechamodi.Text = especialista.FechaModificacion.ToString();
            labalfechacrea.Text = especialista.FechaCreacion.ToString();
        }

        private void buttonGrabar_Click(object sender, EventArgs e)
        {
            Especialista especialista = new Especialista();
            int especialistaId = 0;

            especialista.DniEspecialista = textDni.Text.Trim();
            especialista.Contrasena = textContraseña.Text.Trim();
            especialista.NombreEspecialista = textNombre.Text.Trim();
            especialista.ApellidoEspecialista = textApellido.Text.Trim();
            especialista.Ocupacion = cbOcupacion.Text.Trim();
            especialista.Activo = radioactivo.Checked;
            especialista.Eliminado = false;
            especialista.UsuarioModificacionId =NEspecialista.EspecialistaLogueado.EspecialistaId;
            especialista.FechaModificacion = DateTime.UtcNow;

            especialista.EspecialistaId = textIdEs.Text.Equals("") ? -1 : int.Parse(textIdEs.Text);

            if (ne.DniExiste(especialista.DniEspecialista, especialista.EspecialistaId))
            {
                MessageBox.Show("Dni ya registrado");
                return;
            }

            if (!textIdEs.Text.Equals(""))
            {
                especialistaId = ne.Editar(especialista);
            }
            else
            {
                especialista.UsuarioCreacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
                especialista.FechaCreacion = DateTime.UtcNow;
                especialistaId = ne.Insertar(especialista);
            }

            listaEspecialista = ne.ListarEspecialista();
            MostrarListaEspecialista(listaEspecialista);

            especialista = ne.EspecialistaPorId(especialistaId);
            MostrarEspecialista(especialista);

        }
        private void dataEspecialista_SelectionChanged(object sender, EventArgs e)
        {
            int especialistaId = (int)dataEspecialista.CurrentRow.Cells["EspecialistaId"].Value;
            Especialista especialista = ne.EspecialistaPorId(especialistaId);
            if (especialista != null)
            {
                MostrarEspecialista(especialista);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
           
            int especialistaId = (int)dataEspecialista.CurrentRow.Cells["EspecialistaId"].Value;
            Especialista especialista = ne.EspecialistaPorId(especialistaId);
            especialista.Eliminado = true;
            especialista.UsuarioModificacionId = NEspecialista.EspecialistaLogueado.EspecialistaId;
            especialista.FechaModificacion = DateTime.UtcNow;

            ne.Eliminacionlogica(especialista);

            listaEspecialista = ne.ListarEspecialista();
            MostrarListaEspecialista(listaEspecialista);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarComponentes();
        }
        private void LimpiarComponentes()
        {
            textIdEs.Text = "";
            textDni.Text = "";
            textContraseña.Text = "";
            textNombre.Text = "";
            textApellido.Text = "";
            cbOcupacion.Text = "";
            radioactivo.Checked = false;
            labelCreado.Text = "";
            labelModificado.Text = "";
            labelfechamodi.Text = "";
            labalfechacrea.Text = "";
        }

    }
}
