using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
namespace Negocio
{
    public class NEmpresa
    {
        DEmpresa emp;

        public NEmpresa()
        {
            emp = new DEmpresa();
        }

        public List<Empresa> ListarEmpresas()
        { 
            return emp.ListarEmpresas();
        }

        public Empresa EmpresaPorId(int idEmpresa)
        {
            return  emp.EmpresaPorId(idEmpresa);
        }
        public bool NombreEmpresaExiste(string nombreEmpresa, int idEmpresa)
        {
            return emp.NombreEmpresaExiste(nombreEmpresa, idEmpresa);
        }
        public int Insertar(Empresa objEmpresa)
        {
            return emp.Insertar(objEmpresa);
        }
        public int Editar(Empresa objEmpresa)
        {
            return emp.Editar(objEmpresa);
        }
        public string EliminacionLogica(Empresa objEmpresa)
        {
            return emp.EliminacionLogica(objEmpresa);
        }
    }
}
