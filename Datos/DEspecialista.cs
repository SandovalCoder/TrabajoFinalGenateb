using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public partial class Especialista
    {
        public Especialista UsuarioCreacion { get; set; }
        public Especialista UsuarioModificacion { get; set; }
    }

    public class DEspecialista
    {
        public DEspecialista()
        {
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
        }

        public List<Especialista>ListarEspecialista()
        {
            using (var context = new Trabajo_Final())
            {
                List<Especialista> listaEspecialista = context.Especialista.Include("EspecialistaTrabajador").Where(u => u.Eliminado == false).ToList();
                return listaEspecialista;
            }
        }

        
        public Especialista Login(string dni,string contraseña)
        {
            Especialista userTemp = null;
            using (var context = new Trabajo_Final())
            {
                var query = from b in context.Especialista
                            where b.DniEspecialista == dni && b.Contrasena == contraseña
                                  && b.Eliminado == false
                                  && b.Activo == true
                            select b;
                userTemp = query.FirstOrDefault();
            }

            return userTemp;
        }


        public Especialista EspecialistaPorId(int objEspecialista)
        {
            Especialista userTemp = null;
            using (var context = new Trabajo_Final())
            {
               
                userTemp = context.Especialista.FirstOrDefault(u => u.EspecialistaId == objEspecialista);
                if (userTemp != null)
                {
                    userTemp.UsuarioCreacion = context.Especialista.FirstOrDefault(u => u.EspecialistaId == userTemp.UsuarioCreacionId);
                    userTemp.UsuarioModificacion = context.Especialista.FirstOrDefault(u => u.EspecialistaId == userTemp.UsuarioModificacionId);
                }
            }

            return userTemp;
        }
       
        public bool DniExiste(string dni, int objEspecialista)
        {
            using (var context = new Trabajo_Final())
            {
                Especialista usuario = context.Especialista.FirstOrDefault(p => p.DniEspecialista == dni && p.EspecialistaId != objEspecialista && p.Eliminado == false);
                return (usuario != null) ? true : false;
            }
        }

      
        public int Insertar(Especialista objEspecialista)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    context.Especialista.Add(objEspecialista);
                    context.SaveChanges();

                    //se retorna el ID en caso la lógica de negocio lo necesitase
                    return objEspecialista.EspecialistaId;
                }
            }
            catch (Exception)
            {
                
                return -1;
            }
        }
       
        public int Editar(Especialista objEspecialista)
        {
            Especialista userTemp = null;
            try
            {
                using (var context = new Trabajo_Final())
                {
                    userTemp = context.Especialista.Find(objEspecialista.EspecialistaId);
                    userTemp.DniEspecialista = objEspecialista.DniEspecialista;
                    userTemp.Contrasena = objEspecialista.Contrasena;
                    userTemp.NombreEspecialista = objEspecialista.NombreEspecialista;
                    userTemp.ApellidoEspecialista = objEspecialista.ApellidoEspecialista;
                    userTemp.Ocupacion = objEspecialista.Ocupacion;
                    userTemp.Activo = objEspecialista.Activo;
                    userTemp.Eliminado = objEspecialista.Eliminado;
                    userTemp.UsuarioCreacionId = objEspecialista.UsuarioCreacionId;
                    userTemp.FechaCreacion = objEspecialista.FechaCreacion;
                    userTemp.UsuarioModificacionId = objEspecialista.UsuarioModificacionId;
                    userTemp.FechaModificacion = objEspecialista.FechaModificacion;
                    context.SaveChanges();

                  
                    return userTemp.EspecialistaId;
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

       
        public string Eliminacionlogica(Especialista objEspecialista)
        {
            try
            {
                using (var context = new Trabajo_Final())
                {
                    Especialista userTemp = context.Especialista.Find(objEspecialista.EspecialistaId);
                    userTemp.Eliminado = true;
                    userTemp.UsuarioModificacionId = objEspecialista.UsuarioModificacionId;
                    userTemp.FechaModificacion = objEspecialista.FechaModificacion;
                    context.SaveChanges();
                    return "";
                }
            }
            catch (Exception ex)
            {
                //Aqui se debería de guardar a BD o a archivo el error que salio para un posterior análisis
                return ex.Message;
            }
        }

    }
}
