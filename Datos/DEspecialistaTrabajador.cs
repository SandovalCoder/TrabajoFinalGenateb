using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public partial class EspecialistaTrabajador
    {
        public EspecialistaTrabajador UsuarioCreacion { get; set; }
        public EspecialistaTrabajador UsuarioModificacion { get; set; }
    }
    public  class DEspecialistaTrabajador
    {
        public DEspecialistaTrabajador()
        {
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
        }
        public List<EspecialistaTrabajador> ListarEspecialistaTrabajador()
        {
            using (var context = new Trabajo_Final())
            {
                List<EspecialistaTrabajador> listaEspecialistaTrabajador = context.EspecialistaTrabajador.Include("Especialista").Include("Trabajador").Where(u => u.Eliminado == false).ToList();
                return listaEspecialistaTrabajador;
            }
        }

        public EspecialistaTrabajador EspecialistaTrabajadorPorId(int objEspecialistaTrabajador)
        {
            EspecialistaTrabajador userTemp = null;
            using (var context = new Trabajo_Final())
            {
                userTemp = context.EspecialistaTrabajador.Include("Especialista").Include("Trabajador").FirstOrDefault(u => u.EspecialistaTrabajadorId == objEspecialistaTrabajador);
                if (userTemp != null)
                {
                    userTemp.UsuarioCreacion = context.EspecialistaTrabajador.FirstOrDefault(u => u.EspecialistaTrabajadorId == userTemp.UsuarioCreacionId);
                    userTemp.UsuarioModificacion = context.EspecialistaTrabajador.FirstOrDefault(u => u.EspecialistaTrabajadorId == userTemp.UsuarioModificacionId);
                }
            }

            return userTemp;
        }

        public int Insertar(EspecialistaTrabajador objEspecialistaTrabajador)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    context.EspecialistaTrabajador.Add(objEspecialistaTrabajador);
                    context.SaveChanges();
                    return objEspecialistaTrabajador.EspecialistaTrabajadorId;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Editar(EspecialistaTrabajador objEspecialistaTrabajador)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    EspecialistaTrabajador especialistaTrabajadorTemp = context.EspecialistaTrabajador.Find(objEspecialistaTrabajador.EspecialistaTrabajadorId);

                    if (especialistaTrabajadorTemp != null)
                    {
                        especialistaTrabajadorTemp.AreaTrabajo = objEspecialistaTrabajador.AreaTrabajo;
                        especialistaTrabajadorTemp.Activo = objEspecialistaTrabajador.Activo;
                        especialistaTrabajadorTemp.Eliminado = objEspecialistaTrabajador.Eliminado;
                        especialistaTrabajadorTemp.Trabajador_TrabajadorId = objEspecialistaTrabajador.Trabajador_TrabajadorId;
                        especialistaTrabajadorTemp.Especialista_EspecialistaId = objEspecialistaTrabajador.Especialista_EspecialistaId;
                        especialistaTrabajadorTemp.UsuarioModificacionId = objEspecialistaTrabajador.UsuarioModificacionId;
                        especialistaTrabajadorTemp.FechaModificacion = objEspecialistaTrabajador.FechaModificacion;
                        context.SaveChanges();
                        return especialistaTrabajadorTemp.EspecialistaTrabajadorId;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public string EliminacionLogica(EspecialistaTrabajador objEspecialistaTrabajador)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    EspecialistaTrabajador especialistaTrabajadorTemp = context.EspecialistaTrabajador.Find(objEspecialistaTrabajador.EspecialistaTrabajadorId);
                    especialistaTrabajadorTemp.Eliminado = true;
                    especialistaTrabajadorTemp.UsuarioModificacionId = objEspecialistaTrabajador.UsuarioModificacionId;
                    especialistaTrabajadorTemp.FechaModificacion = objEspecialistaTrabajador.FechaModificacion;
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
