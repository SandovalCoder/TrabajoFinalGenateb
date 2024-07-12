using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
namespace Negocio
{
    public class NRegistroConsumoMetabolico
    {
        DRegistroConsumoMetabolico drcm;

        public NRegistroConsumoMetabolico()
        {
            drcm = new DRegistroConsumoMetabolico();
        }

        public List<RegistroConsumoMetabolico> ListaregistroConsumoMetabolicos()
        {
            return drcm.ListaregistroConsumoMetabolicos();
        }

        public RegistroConsumoMetabolico registroConsumoMetabolicoPorId(int objRegistroConsumoMetabolico)
        {
            return drcm.registroConsumoMetabolicoPorId(objRegistroConsumoMetabolico);
        }

        public int Insertar(RegistroConsumoMetabolico objRegistroConsumoMetabolico)
        {
            return drcm.Insertar(objRegistroConsumoMetabolico);
        }
        public int Editar(RegistroConsumoMetabolico objRegistroConsumoMetabolico)
        {
            return drcm.Editar(objRegistroConsumoMetabolico);
        }
        
        public string EliminacionLogica(RegistroConsumoMetabolico objRegistroConsumoMetabolico)
        {
            return drcm.EliminacionLogica(objRegistroConsumoMetabolico);
        }
    }
}
