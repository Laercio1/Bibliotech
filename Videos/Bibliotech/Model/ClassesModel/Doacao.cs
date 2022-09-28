using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ClassesModel
{
    public class Doacao
    {
        //propierts private 
        private int codigo;
        private string descricao;
        private int quantidade;
        private DateTime data_cadastro;

        //propierts public 
        public DateTime DATA_CADASTRO
        {
            get { return data_cadastro; }
            set { data_cadastro = value; }
        }
        public string DESCRICAO
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public int QUANTIDADE
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        public int CODIGO
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
