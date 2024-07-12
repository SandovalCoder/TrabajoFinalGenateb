using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public partial class RegistroConsumoMetabolico
    {
        public RegistroConsumoMetabolico UsuarioCreacion { get; set; }
        public RegistroConsumoMetabolico UsuarioModificacion { get; set; }
    }
    public class DRegistroConsumoMetabolico
    {
        public DRegistroConsumoMetabolico()
        {
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
        }

        public List<RegistroConsumoMetabolico> ListaregistroConsumoMetabolicos()
        {
            using (var context = new Trabajo_Final())
            {
                List<RegistroConsumoMetabolico> listaRegistroConsumoMetabolico = context.RegistroConsumoMetabolico.Include("RegistroTrabajador").Where(u => u.Eliminado == false).ToList();
                return listaRegistroConsumoMetabolico;
            }
        }

        public RegistroConsumoMetabolico registroConsumoMetabolicoPorId(int objRegistroConsumoMetabolico)
        {
            RegistroConsumoMetabolico userTemp = null;
            using (var context = new Trabajo_Final())
            {
                userTemp = context.RegistroConsumoMetabolico.Include("RegistroTrabajador").FirstOrDefault(u => u.RegistroConsumoMetabolicoId == objRegistroConsumoMetabolico);
                if (userTemp != null)
                {
                    userTemp.UsuarioCreacion = context.RegistroConsumoMetabolico.FirstOrDefault(u => u.RegistroConsumoMetabolicoId == userTemp.UsuarioCreacionId);
                    userTemp.UsuarioModificacion = context.RegistroConsumoMetabolico.FirstOrDefault(u => u.RegistroConsumoMetabolicoId == userTemp.UsuarioModificacionId);
                }
            }

            return userTemp;
        }

        public int Insertar(RegistroConsumoMetabolico objRegistroConsumoMetabolico)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    context.RegistroConsumoMetabolico.Add(objRegistroConsumoMetabolico);
                    context.SaveChanges();
                    return objRegistroConsumoMetabolico.RegistroConsumoMetabolicoId;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
       

        public int Editar(RegistroConsumoMetabolico objRegistroConsumoMetabolico)
        {

            try
            {
                using (var context = new Trabajo_Final())
                {
                    RegistroConsumoMetabolico registroConsumoMetabolicoTemp = context.RegistroConsumoMetabolico.Find(objRegistroConsumoMetabolico.RegistroConsumoMetabolicoId);

                    if (registroConsumoMetabolicoTemp != null)
                    {
                        registroConsumoMetabolicoTemp.PosicionTrabajador = objRegistroConsumoMetabolico.PosicionTrabajador;
                        registroConsumoMetabolicoTemp.TiempoPosicion = objRegistroConsumoMetabolico.TiempoPosicion;
                        registroConsumoMetabolicoTemp.TipoTrabajo = objRegistroConsumoMetabolico.TipoTrabajo;
                        registroConsumoMetabolicoTemp.TiempoTrabajo = objRegistroConsumoMetabolico.TiempoTrabajo;
                        registroConsumoMetabolicoTemp.NivelHemoglobina = objRegistroConsumoMetabolico.NivelHemoglobina;
                        registroConsumoMetabolicoTemp.RangoHemoglobina = objRegistroConsumoMetabolico.RangoHemoglobina;
                        registroConsumoMetabolicoTemp.LaboratorioClinico = objRegistroConsumoMetabolico.LaboratorioClinico;
                        registroConsumoMetabolicoTemp.Eliminado = objRegistroConsumoMetabolico.Eliminado;
                        registroConsumoMetabolicoTemp.UsuarioModificacionId = objRegistroConsumoMetabolico.UsuarioModificacionId;
                        registroConsumoMetabolicoTemp.FechaModificacion = objRegistroConsumoMetabolico.FechaModificacion;
                        context.SaveChanges();
                        return registroConsumoMetabolicoTemp.RegistroConsumoMetabolicoId;
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


        public string EliminacionLogica(RegistroConsumoMetabolico objRegistroConsumoMetabolico)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    RegistroConsumoMetabolico registroConsumoMetabolicoTemp = context.RegistroConsumoMetabolico.Find(objRegistroConsumoMetabolico.RegistroConsumoMetabolicoId);
                    registroConsumoMetabolicoTemp.Eliminado = true;
                    registroConsumoMetabolicoTemp.UsuarioModificacionId = objRegistroConsumoMetabolico.UsuarioModificacionId;
                    registroConsumoMetabolicoTemp.FechaModificacion = objRegistroConsumoMetabolico.FechaModificacion;
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
