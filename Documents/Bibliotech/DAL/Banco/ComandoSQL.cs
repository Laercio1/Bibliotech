using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL.Banco
{
    public class ComandoSQL
    {
        //propierts private
        private SqlCommand comando;
        private List<ParametroSQL> parametros;

        //propierts public 
        public List<ParametroSQL> Parametros
        {
            get { return parametros; }
            set { parametros = value; }
        }
        public SqlCommand Comando
        {
            get { return comando; }
            set { comando = value; }
        }
    }
}
