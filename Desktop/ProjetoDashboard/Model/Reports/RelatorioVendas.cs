using System;
using System.Collections.Generic;

namespace Model
{
    public class RelatorioVendas
    {
        //Attributes-Properties
        public DateTime dataRelatorio { get; private set; }
        public DateTime dataInicio { get; private set; }
        public DateTime dataFim { get; private set; }
        public List<ListaVendas> listaVendas { get; private set; }
        public List<VendasLiquidasPorPeriodo> vendasLiquidasPorPeriodo { get; private set; }
        public double totalVendasLiquidas { get; private set; }
    }
}
