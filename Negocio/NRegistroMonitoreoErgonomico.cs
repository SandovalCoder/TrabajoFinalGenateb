using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
namespace Negocio
{
    public class NRegistroMonitoreoErgonomico
    {
        DRegistroMonitoreoErgonomico drme;

        public NRegistroMonitoreoErgonomico()
        {
            drme = new DRegistroMonitoreoErgonomico();
        }

        public List<RegistroMonitoreoErgonomico> ListaregistroMonitoreoErgonomicos()
        {
            return drme.ListaregistroMonitoreoErgonomicos();
        }

        public RegistroMonitoreoErgonomico registroMonitoreoErgonomicoPorId(int objRegistroMonitoreoErgonomico)
        {
            return drme.registroMonitoreoErgonomicoPorId(objRegistroMonitoreoErgonomico);
        }

        public int Insertar(RegistroMonitoreoErgonomico objRegistroMonitoreoErgonomico)
        {
            return drme.Insertar(objRegistroMonitoreoErgonomico);
        }

        public int Editar(RegistroMonitoreoErgonomico objRegistroMonitoreoErgonomico)
        {
            return drme.Editar(objRegistroMonitoreoErgonomico);
        }

        public string EliminacionLogica(RegistroMonitoreoErgonomico objRegistroMonitoreoErgonomico)
        {
            return drme.EliminacionLogica(objRegistroMonitoreoErgonomico);
        }
    }
}
