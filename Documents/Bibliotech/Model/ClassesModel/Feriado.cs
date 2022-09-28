using System;

namespace Model.ClassesModel
{
    public class Feriado
    {
        public Feriado(DateTime data, string descricao)
        {
            Data = data;
            Descricao = descricao;
        }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string DataFormatada => Data.ToString("dd/MM/yyyy");
    }
}
