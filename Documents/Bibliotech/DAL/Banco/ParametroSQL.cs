namespace DAL.Banco
{
    public class ParametroSQL
    {
        //propierts private
        private string parametro;
        private string valor;

        //propierts public
        public string Parametro
        {
            get { return parametro; }
            set { parametro = value; }
        }
        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

    }
}
