using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;

namespace Negocio
{
    public class NRegistroTrabajador
    {
        DRegistroTrabajador der;

        public NRegistroTrabajador()
        {
            der = new DRegistroTrabajador();
        }
        public List<RegistroTrabajador> ListaregistroTrabajadores()
        {
            return der.ListaregistroTrabajadores();
        }
        public RegistroTrabajador registroTrabajadorPorId(int objRegistroTrabajador)
        {
            return der.registroTrabajadorPorId(objRegistroTrabajador);
        }
        public int Insertar(RegistroTrabajador objRegistroTrabajador)
        {
            return der.Insertar(objRegistroTrabajador);
        }
        public int Editar(RegistroTrabajador objRegistroTrabajador)
        {
            return der.Editar(objRegistroTrabajador);
        }
        public string EliminacionLogica(RegistroTrabajador objRegistroTrabajador)
        {
            return der.EliminacionLogica(objRegistroTrabajador);
        }


    }
}
