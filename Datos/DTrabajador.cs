using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public partial class Trabajador
    {
        public Trabajador UsuarioCreacion { get; set; }
        public Trabajador UsuarioModificacion { get; set; }
    }

    public class DTrabajador
    {
        public List<Trabajador> ListarTrabajadores()
        {
            using (var context = new Trabajo_Final())
            {

                List<Trabajador> listaTrabajadores = context.Trabajador.Include("Empresa").Include("EspecialistaTrabajador").Include("RegistroTrabajador").Where(u => u.Eliminado == false).ToList();
                return listaTrabajadores;
            }
        }

        public Trabajador TrabajadorPorId(int idTrabajador)
        {
            Trabajador trabajador = null;
            using (var context = new Trabajo_Final())
            {
                trabajador = context.Trabajador.Include("Empresa").Include("EspecialistaTrabajador").Include("RegistroTrabajador").FirstOrDefault(u => u.TrabajadorId == idTrabajador);
                if (trabajador != null)
                {
                    trabajador.UsuarioCreacion = context.Trabajador.FirstOrDefault(u => u.TrabajadorId == trabajador.UsuarioCreacionId);
                    trabajador.UsuarioModificacion = context.Trabajador.FirstOrDefault(u => u.TrabajadorId == trabajador.UsuarioModificacionId);
                }
            }

            return trabajador;
        }

        public bool DniTrabajadorExiste(string dniTrabajador, int idTrabajador)
        {
            using (var context = new Trabajo_Final())
            {
                Trabajador trabajador = context.Trabajador.FirstOrDefault(p => p.DniTrabajador == dniTrabajador && p.TrabajadorId != idTrabajador && p.Eliminado == false);
                return (trabajador != null) ? true : false;
            }
        }

        public int Insertar(Trabajador objTrabajador)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    context.Trabajador.Add(objTrabajador);
                    context.SaveChanges();

                    return objTrabajador.TrabajadorId;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int Editar(Trabajador objTrabajador)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    Trabajador trabajadorTemp = context.Trabajador.Find(objTrabajador.TrabajadorId);

                    if (trabajadorTemp != null)
                    {
                        trabajadorTemp.DniTrabajador = objTrabajador.DniTrabajador;
                        trabajadorTemp.NombreTrabajador = objTrabajador.NombreTrabajador;
                        trabajadorTemp.ApellidoTrabajador = objTrabajador.ApellidoTrabajador;
                        trabajadorTemp.Activo = objTrabajador.Activo;
                        trabajadorTemp.Eliminado = objTrabajador.Eliminado;
                        trabajadorTemp.Empresa_EmpresaId = objTrabajador.Empresa_EmpresaId;
                        trabajadorTemp.UsuarioCreacionId = objTrabajador.UsuarioCreacionId;
                        trabajadorTemp.FechaCreacion = objTrabajador.FechaCreacion;
                        trabajadorTemp.UsuarioModificacionId = objTrabajador.UsuarioModificacionId;
                        trabajadorTemp.FechaModificacion = objTrabajador.FechaModificacion;

                        context.SaveChanges();

                        return trabajadorTemp.TrabajadorId;
                    }
                    else
                    {
                        // El trabajador no se encontró en la base de datos
                        return -1;
                    }
                }
            }
            catch (Exception)
            {
                // Manejo de excepciones
                return -1;
            }
        }
        public string EliminacionLogica(Trabajador objTrabajador)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    Trabajador trabajadorTemp = context.Trabajador.Find(objTrabajador.TrabajadorId);
                    trabajadorTemp.Eliminado = true;
                    trabajadorTemp.UsuarioModificacionId = objTrabajador.UsuarioModificacionId;
                    trabajadorTemp.FechaModificacion = objTrabajador.FechaModificacion;
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
