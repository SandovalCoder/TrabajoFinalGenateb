using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public partial class RegistroResistenciaTermica
    {
        public RegistroResistenciaTermica UsuarioCreacion { get; set; }
        public RegistroResistenciaTermica UsuarioModificacion { get; set; }
    }
    public class DRegistroResistenciaTermica
    {
        public DRegistroResistenciaTermica()
        {
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
        }

        public List<RegistroResistenciaTermica> ListaregistroResistenciaTermicas()
        {
            using (var context = new Trabajo_Final())
            {
                List<RegistroResistenciaTermica> listaRegistroResistenciaTermica = context.RegistroResistenciaTermica.Include("RegistroTrabajador").Where(u => u.Eliminado == false).ToList();
                return listaRegistroResistenciaTermica;
            }
        }

        public RegistroResistenciaTermica registroResistenciaTermicaPorId(int objRegistroResistenciaTermica)
        {
            RegistroResistenciaTermica userTemp = null;
            using (var context = new Trabajo_Final())
            {
                userTemp = context.RegistroResistenciaTermica.Include("RegistroTrabajador").FirstOrDefault(u => u.RegistroResistenciaTermicaId == objRegistroResistenciaTermica);
                if (userTemp != null)
                {
                    userTemp.UsuarioCreacion = context.RegistroResistenciaTermica.FirstOrDefault(u => u.RegistroResistenciaTermicaId == userTemp.UsuarioCreacionId);
                    userTemp.UsuarioModificacion = context.RegistroResistenciaTermica.FirstOrDefault(u => u.RegistroResistenciaTermicaId == userTemp.UsuarioModificacionId);
                }
            }

            return userTemp;
        }

        public int Insertar(RegistroResistenciaTermica objRegistroResistenciaTermica)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    context.RegistroResistenciaTermica.Add(objRegistroResistenciaTermica);
                    context.SaveChanges();
                    return objRegistroResistenciaTermica.RegistroResistenciaTermicaId;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int Editar(RegistroResistenciaTermica objRegistroResistenciaTermica)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                   
                    RegistroResistenciaTermica registroResistenciaTermicaTemp = context.RegistroResistenciaTermica.Find(objRegistroResistenciaTermica.RegistroResistenciaTermicaId);

                    if (registroResistenciaTermicaTemp != null)
                    {
                        // Actualizar los valores con los nuevos datos
                        registroResistenciaTermicaTemp.PrendaRopaInterior = objRegistroResistenciaTermica.PrendaRopaInterior;
                        registroResistenciaTermicaTemp.PrendaCamisa = objRegistroResistenciaTermica.PrendaCamisa;
                        registroResistenciaTermicaTemp.PrendaPantalones = objRegistroResistenciaTermica.PrendaPantalones;
                        registroResistenciaTermicaTemp.PrendaVestidos = objRegistroResistenciaTermica.PrendaVestidos;
                        registroResistenciaTermicaTemp.PrendaChaqueta = objRegistroResistenciaTermica.PrendaChaqueta;
                        registroResistenciaTermicaTemp.Eliminado = objRegistroResistenciaTermica.Eliminado;
                        registroResistenciaTermicaTemp.UsuarioCreacionId = objRegistroResistenciaTermica.UsuarioCreacionId;
                        registroResistenciaTermicaTemp.FechaCreacion = objRegistroResistenciaTermica.FechaCreacion;
                        registroResistenciaTermicaTemp.UsuarioModificacionId = objRegistroResistenciaTermica.UsuarioModificacionId;
                        registroResistenciaTermicaTemp.FechaModificacion = objRegistroResistenciaTermica.FechaModificacion;

                       
                        context.SaveChanges();

                        
                        return objRegistroResistenciaTermica.RegistroResistenciaTermicaId;
                    }
                    else
                    {
                        // Si no se encuentra el registro, devolver 0
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar la excepción lanzando un nuevo objeto de excepción con el mensaje original
                throw new Exception(ex.Message);
            }
        }






        public string EliminacionLogica(RegistroResistenciaTermica objRegistroResistenciaTermica)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    RegistroResistenciaTermica registroResistenciaTermicaTemp = context.RegistroResistenciaTermica.Find(objRegistroResistenciaTermica.RegistroResistenciaTermicaId);
                    registroResistenciaTermicaTemp.Eliminado = true;
                    registroResistenciaTermicaTemp.UsuarioModificacionId = objRegistroResistenciaTermica.UsuarioModificacionId;
                    registroResistenciaTermicaTemp.FechaModificacion = objRegistroResistenciaTermica.FechaModificacion;
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
