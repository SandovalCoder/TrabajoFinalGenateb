using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{ 
    public partial class RegistroMonitoreoErgonomico
    {
        public RegistroMonitoreoErgonomico UsuarioCreacion { get; set; }
        public RegistroMonitoreoErgonomico UsuarioModificacion { get; set; }
    }
    public class DRegistroMonitoreoErgonomico
    {
        public DRegistroMonitoreoErgonomico()
        {
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
        }

        public List<RegistroMonitoreoErgonomico> ListaregistroMonitoreoErgonomicos()
        {
            using (var context = new Trabajo_Final())
            {
                List<RegistroMonitoreoErgonomico> listaRegistroMonitoreoErgonomico = context.RegistroMonitoreoErgonomico.Include("RegistroTrabajador").Where(u => u.Eliminado == false).ToList();
                return listaRegistroMonitoreoErgonomico;
            }
        }
        
        public RegistroMonitoreoErgonomico registroMonitoreoErgonomicoPorId(int objRegistroMonitoreoErgonomico)
        {
            RegistroMonitoreoErgonomico userTemp = null;
            using (var context = new Trabajo_Final())
            {
                userTemp = context.RegistroMonitoreoErgonomico.Include("RegistroTrabajador").FirstOrDefault(u => u.RegistroMonitoreoErgonomicoId == objRegistroMonitoreoErgonomico);
                if (userTemp != null)
                { 
                    userTemp.UsuarioCreacion = context.RegistroMonitoreoErgonomico.FirstOrDefault(u => u.RegistroMonitoreoErgonomicoId == userTemp.UsuarioCreacionId);
                    userTemp.UsuarioModificacion = context.RegistroMonitoreoErgonomico.FirstOrDefault(u => u.RegistroMonitoreoErgonomicoId == userTemp.UsuarioModificacionId);
                }
            }

            return userTemp;
        }


        public int Insertar(RegistroMonitoreoErgonomico objRegistroMonitoreoErgonomico)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    context.RegistroMonitoreoErgonomico.Add(objRegistroMonitoreoErgonomico);
                    context.SaveChanges();
                    return objRegistroMonitoreoErgonomico.RegistroMonitoreoErgonomicoId;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Editar(RegistroMonitoreoErgonomico objRegistroMonitoreoErgonomico)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    RegistroMonitoreoErgonomico registroMonitoreoErgonomicoTemp = context.RegistroMonitoreoErgonomico.Find(objRegistroMonitoreoErgonomico.RegistroMonitoreoErgonomicoId);

                    if (registroMonitoreoErgonomicoTemp != null)
                    {
                        registroMonitoreoErgonomicoTemp.ErgonomiaDatos = objRegistroMonitoreoErgonomico.ErgonomiaDatos;
                        registroMonitoreoErgonomicoTemp.TiempoDato = objRegistroMonitoreoErgonomico.TiempoDato;
                        registroMonitoreoErgonomicoTemp.EquipamientoOficina = objRegistroMonitoreoErgonomico.EquipamientoOficina;
                        registroMonitoreoErgonomicoTemp.TiempoEquipamiento = objRegistroMonitoreoErgonomico.TiempoEquipamiento;
                        registroMonitoreoErgonomicoTemp.Eliminado = objRegistroMonitoreoErgonomico.Eliminado;
                        registroMonitoreoErgonomicoTemp.UsuarioModificacionId = objRegistroMonitoreoErgonomico.UsuarioModificacionId;
                        registroMonitoreoErgonomicoTemp.FechaModificacion = objRegistroMonitoreoErgonomico.FechaModificacion;
                        context.SaveChanges();
                        return registroMonitoreoErgonomicoTemp.RegistroMonitoreoErgonomicoId;
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

        public string EliminacionLogica(RegistroMonitoreoErgonomico objRegistroMonitoreoErgonomico)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    RegistroMonitoreoErgonomico registroMonitoreoErgonomicoTemp = context.RegistroMonitoreoErgonomico.Find(objRegistroMonitoreoErgonomico.RegistroMonitoreoErgonomicoId);
                    registroMonitoreoErgonomicoTemp.Eliminado = true;
                    registroMonitoreoErgonomicoTemp.UsuarioModificacionId = objRegistroMonitoreoErgonomico.UsuarioModificacionId;
                    registroMonitoreoErgonomicoTemp.FechaModificacion = objRegistroMonitoreoErgonomico.FechaModificacion;
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
