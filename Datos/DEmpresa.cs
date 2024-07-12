using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public partial class Empresa
    {
        public Empresa UsuarioCreacion { get; set; }
        public Empresa UsuarioModificacion { get; set; }
    }

    public class DEmpresa
    {
        public DEmpresa()
        {
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
        }

        public List<Empresa> ListarEmpresas()
        {
            using (var context = new Trabajo_Final())
            {
                List<Empresa> listaEmpresas = context.Empresa.Include("Trabajador").Where(u => u.Eliminado == false).ToList();
                return listaEmpresas;
            }
        }
        public Empresa EmpresaPorId(int idEmpresa)
        {
            Empresa empresa = null;
            using (var context = new Trabajo_Final())
            {
                empresa = context.Empresa.FirstOrDefault(u => u.EmpresaId == idEmpresa);
                if (empresa != null)
                {
                    empresa.UsuarioCreacion = context.Empresa.FirstOrDefault(u => u.EmpresaId == empresa.UsuarioCreacionId);
                    empresa.UsuarioModificacion = context.Empresa.FirstOrDefault(u => u.EmpresaId == empresa.UsuarioModificacionId);
                }
            }

            return empresa;
        }

        public bool NombreEmpresaExiste(string nombreEmpresa, int idEmpresa)
        {
            using (var context = new Trabajo_Final())
            {
                Empresa empresa = context.Empresa.FirstOrDefault(p => p.NombreEmpresa == nombreEmpresa && p.EmpresaId != idEmpresa && p.Eliminado == false);
                return (empresa != null) ? true : false;
            }
        }

        public int Insertar(Empresa objEmpresa)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    context.Empresa.Add(objEmpresa);
                    context.SaveChanges();

                    
                    return objEmpresa.EmpresaId;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int Editar(Empresa objEmpresa)
        {
            Empresa empresaTemp = null;
            try
            {
                using (var context = new Trabajo_Final())
                {
                    empresaTemp = context.Empresa.Find(objEmpresa.EmpresaId);
                    empresaTemp.NombreEmpresa = objEmpresa.NombreEmpresa;
                    empresaTemp.DireccionEmpresa = objEmpresa.DireccionEmpresa;
                    empresaTemp.CiudadEmpresa = objEmpresa.CiudadEmpresa;
                    empresaTemp.Activo = objEmpresa.Activo;
                    empresaTemp.Eliminado = objEmpresa.Eliminado;
                    empresaTemp.UsuarioCreacionId = objEmpresa.UsuarioCreacionId;
                    empresaTemp.FechaCreacion = objEmpresa.FechaCreacion;
                    empresaTemp.UsuarioModificacionId = objEmpresa.UsuarioModificacionId;
                    empresaTemp.FechaModificacion = objEmpresa.FechaModificacion;
                    context.SaveChanges();

                    return empresaTemp.EmpresaId;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public string EliminacionLogica(Empresa objEmpresa)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    Empresa empresaTemp = context.Empresa.Find(objEmpresa.EmpresaId);
                    empresaTemp.Eliminado = true;
                    empresaTemp.UsuarioModificacionId = objEmpresa.UsuarioModificacionId;
                    empresaTemp.FechaModificacion = objEmpresa.FechaModificacion;
                    context.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
