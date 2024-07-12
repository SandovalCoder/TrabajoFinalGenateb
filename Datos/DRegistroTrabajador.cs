using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public partial class RegistroTrabajador
    { 
        public RegistroTrabajador UsuarioCreacion { get; set; }
        public RegistroTrabajador UsuarioModificacion { get; set; }
    }
    public class DRegistroTrabajador
    {
        public DRegistroTrabajador()
        {
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
        }

        
        public List<RegistroTrabajador> ListaregistroTrabajadores()
        {
            using (var context = new Trabajo_Final())
            {
                List<RegistroTrabajador> listaRegistroTrabajador = context.RegistroTrabajador.Include("Trabajador").Include("RegistroResistenciaTermica").Include("RegistroMonitoreoErgonomico").Include("RegistroConsumoMetabolico").Where(u => u.Eliminado == false).ToList();
                return listaRegistroTrabajador;
            }
        }
       
        public RegistroTrabajador registroTrabajadorPorId(int objRegistroTrabajador)
        {
            RegistroTrabajador userTemp = null;
            using (var context = new Trabajo_Final())
            {
                userTemp = context.RegistroTrabajador.Include("Trabajador").Include("RegistroResistenciaTermica").Include("RegistroMonitoreoErgonomico").Include("RegistroConsumoMetabolico").FirstOrDefault(u => u.RegistroTrabajadorId== objRegistroTrabajador);
                if (userTemp != null)
                {
                    userTemp.UsuarioCreacion = context.RegistroTrabajador.FirstOrDefault(u => u.RegistroTrabajadorId == userTemp.UsuarioCreacionId);
                    userTemp.UsuarioModificacion = context.RegistroTrabajador.FirstOrDefault(u => u.RegistroTrabajadorId== userTemp.UsuarioModificacionId);
                }
            }

            return userTemp;
        }

        public int Insertar(RegistroTrabajador objRegistroTrabajador)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    context.RegistroTrabajador.Add(objRegistroTrabajador);
                    context.SaveChanges();
                    return objRegistroTrabajador.RegistroTrabajadorId;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

       public int Editar(RegistroTrabajador objRegistroTrabajador)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    var userTemp = context.RegistroTrabajador.FirstOrDefault(u => u.RegistroTrabajadorId == objRegistroTrabajador.RegistroTrabajadorId);
                    if (userTemp != null)
                    {
                      
                        userTemp.RegistroConsumoMetabolico_RegistroConsumoMetabolicoId = objRegistroTrabajador.RegistroConsumoMetabolico_RegistroConsumoMetabolicoId;
                        userTemp.RegistroResistenciaTermica_RegistroResistenciaTermicaId = objRegistroTrabajador.RegistroResistenciaTermica_RegistroResistenciaTermicaId;
                        userTemp.RegistroMonitoreoErgonomico_RegistroMonitoreoErgonomicoId = objRegistroTrabajador.RegistroMonitoreoErgonomico_RegistroMonitoreoErgonomicoId;
                        userTemp.Trabajador_TrabajadorId = objRegistroTrabajador.Trabajador_TrabajadorId;
                        userTemp.Eliminado = objRegistroTrabajador.Eliminado;
                        userTemp.UsuarioCreacionId = objRegistroTrabajador.UsuarioCreacionId;
                        userTemp.FechaCreacion = objRegistroTrabajador.FechaCreacion;
                        userTemp.UsuarioModificacionId = objRegistroTrabajador.UsuarioModificacionId;
                        userTemp.FechaModificacion = objRegistroTrabajador.FechaModificacion;
                        context.SaveChanges();

                        return userTemp.RegistroTrabajadorId;
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

        public string EliminacionLogica(RegistroTrabajador objRegistroTrabajador)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    RegistroTrabajador registroTrabajadorTemp = context.RegistroTrabajador.Find(objRegistroTrabajador.RegistroTrabajadorId);
                    registroTrabajadorTemp.Eliminado = true;
                    registroTrabajadorTemp.UsuarioModificacionId = objRegistroTrabajador.UsuarioModificacionId;
                    registroTrabajadorTemp.FechaModificacion = objRegistroTrabajador.FechaModificacion;
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
