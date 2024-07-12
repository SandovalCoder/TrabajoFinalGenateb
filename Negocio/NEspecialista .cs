using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
namespace Negocio
{
    public class NEspecialista
    {
        DEspecialista espe;
        public static Especialista EspecialistaLogueado { get; set; }
        public NEspecialista()
        {
            espe = new DEspecialista();
        }

 
        public List<Especialista> ListarEspecialista()
        {
            return espe.ListarEspecialista();
        }

        public Especialista Login(string dni, string contraseña)
        {
            EspecialistaLogueado = espe.Login(dni, contraseña);
            return EspecialistaLogueado;
        }

        public bool DniExiste(string dni, int objEspecialista)
        {
            return espe.DniExiste(dni, objEspecialista);
        }

        public Especialista EspecialistaPorId(int objEspecialista)
        {
            return espe.EspecialistaPorId(objEspecialista);
        }

        public int Insertar(Especialista objEspecialista)
        {
            return espe.Insertar(objEspecialista);
        }
        public int Editar(Especialista objEspecialista)
        {
            return espe.Editar(objEspecialista);
        }
        public string Eliminacionlogica(Especialista objEspecialista)
        {
            return espe.Eliminacionlogica(objEspecialista);
        }

    }
}
