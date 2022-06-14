using System;

namespace Model
{
    public class ListaVendas
    {
        public int vendaId { get; set; }
        public DateTime vendaData { get; set; }
        public string cliente { get; set; }
        public string produto { get; set; }
        public double valorTotal { get; set; }
    }
}
