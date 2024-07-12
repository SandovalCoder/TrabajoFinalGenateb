using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
namespace Negocio
{
    public class NRegistroResistenciaTermica
    {
        DRegistroResistenciaTermica drt;

        public NRegistroResistenciaTermica()
        {
            drt = new DRegistroResistenciaTermica();
        }

        public List<RegistroResistenciaTermica> ListaregistroResistenciaTermicas()
        {
            return drt.ListaregistroResistenciaTermicas();
        }

        public RegistroResistenciaTermica registroResistenciaTermicaPorId(int objRegistroResistenciaTermica)
        {
            return drt.registroResistenciaTermicaPorId(objRegistroResistenciaTermica);
        }

        public int Insertar(RegistroResistenciaTermica objRegistroResistenciaTermica)
        {
            return drt.Insertar(objRegistroResistenciaTermica);
        }

        public int Editar(RegistroResistenciaTermica objRegistroResistenciaTermica)
        {
            return drt.Editar(objRegistroResistenciaTermica);
        }

        public string EliminacionLogica(RegistroResistenciaTermica objRegistroResistenciaTermica)
        {
            return drt.EliminacionLogica(objRegistroResistenciaTermica);
        }
    }
}
