using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class NEspecialistaTrabajador
    {
        DEspecialistaTrabajador des;

        public NEspecialistaTrabajador()
        {
            des=new DEspecialistaTrabajador();
        }

        public List<EspecialistaTrabajador> ListarEspecialistaTrabajador()
        {
            return des.ListarEspecialistaTrabajador();
        }
        public EspecialistaTrabajador EspecialistaTrabajadorPorId(int objEspecialistaTrabajador)
        {
            return des.EspecialistaTrabajadorPorId(objEspecialistaTrabajador);
        }
        public int Insertar(EspecialistaTrabajador objEspecialistaTrabajador)
        {
            return des.Insertar(objEspecialistaTrabajador);
        }
        public int Editar(EspecialistaTrabajador objEspecialistaTrabajador)
        {
            return des.Editar(objEspecialistaTrabajador);
        }
        public string EliminacionLogica(EspecialistaTrabajador objEspecialistaTrabajador)
        {
            return des.EliminacionLogica(objEspecialistaTrabajador);
        }
    }
}
