using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NTrabajador
    {
        DTrabajador tra;

        public NTrabajador()
        {
            tra = new DTrabajador();
        }

        public List<Trabajador> ListarTrabajadores()
        {
            return tra.ListarTrabajadores();
        }

        public Trabajador TrabajadorPorId(int idTrabajador)
        {
            return tra.TrabajadorPorId(idTrabajador);
        }

        public bool DniTrabajadorExiste(string dniTrabajador, int idTrabajador)
        {
            return tra.DniTrabajadorExiste(dniTrabajador, idTrabajador);
        }
        public int Insertar(Trabajador objTrabajador)
        {
            return tra.Insertar(objTrabajador);
        }
        public int Editar(Trabajador objTrabajador)
        {
            return tra.Editar(objTrabajador);
        }
        public string EliminacionLogica(Trabajador objTrabajador)
        {
            return tra.EliminacionLogica(objTrabajador);
        }
    }
}
