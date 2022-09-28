using DAL.ClassesDAL;
using System.Data;

namespace BLL.ClassesBLL
{
    public class EstadoBLL
    {
        //Método de buscar cadastros de estados que estão cadastrados e armazenados no banco de dados.
        public DataTable Buscar(string _filtro)
        {
            EstadoDAL estadoDAL = new EstadoDAL();
            return estadoDAL.Buscar(_filtro);
        }
    }
}
