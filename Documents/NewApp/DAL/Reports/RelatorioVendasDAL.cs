using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class RelatorioVendasDAL
    {
        //Atributos - Propiedades
        public DateTime dataRelatorio { get; private set; }
        public DateTime dataInicio { get; private set; }
        public DateTime dataFim { get; private set; }
        public List<ListaVendas> listaVendas { get; private set; }
        public List<VendasLiquidasPorPeriodo> vendasLiquidasPorPeriodos { get; private set; }
        public double totalVendasLiquidas { get; private set; }
        //Metódos
        public void criarRelatorioEncomendasVendas(DateTime fromDate, DateTime toDate)
        {
            //implementar datas
            dataRelatorio = DateTime.Now;
            dataInicio = fromDate;
            dataFim = toDate;
            //criar listagem de vendas
            var orderDAL = new OrderDAL();
            var result = orderDAL.getSalesOrder(fromDate, toDate);
            listaVendas = new List<ListaVendas>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var vendasModel = new ListaVendas()
                {
                    vendaId = Convert.ToInt32(rows[0]),
                    vendaData = Convert.ToDateTime(rows[1]),
                    cliente = Convert.ToString(rows[2]),
                    produto = Convert.ToString(rows[3]),
                    valorTotal = Convert.ToDouble(rows[4])
                };
                listaVendas.Add(vendasModel);
                //calcular o total das vendas líquidas
                totalVendasLiquidas += Convert.ToDouble(rows[4]);
            }
            //criar vendas líquidas por período
            ////criar vendas líquidas de lista temporária por data
            var listaVendasPorData = (from vendas in listaVendas
                                      group vendas by vendas.vendaData
                       into listaVendas
                                      select new
                                      {
                                          data = listaVendas.Key,
                                          quantidade = listaVendas.Sum(item => item.valorTotal)
                                      }).AsEnumerable();
            ////obter número de dias
            int totalDias = Convert.ToInt32((toDate - fromDate).Days);
            ////período de grupo por dias
            if (totalDias <= 7)
            {
                vendasLiquidasPorPeriodos = (from vendas in listaVendasPorData
                                             group vendas by vendas.data.ToString("dd-MMM-yyyy")
                           into listaVendas
                                             select new VendasLiquidasPorPeriodo
                                             {
                                                 periodo = listaVendas.Key,
                                                 vendasLiquidas = listaVendas.Sum(item => item.quantidade)
                                             }).ToList();
            }
            ////período de grupo por semanas
            else if (totalDias <= 30)
            {
                vendasLiquidasPorPeriodos = (from vendas in listaVendasPorData
                                             group vendas by
                                             System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                               vendas.data, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                        into listaVendas
                                             select new VendasLiquidasPorPeriodo
                                             {
                                                 periodo = "Week " + listaVendas.Key.ToString(),
                                                 vendasLiquidas = listaVendas.Sum(item => item.quantidade)
                                             }).ToList();
            }
            ////período de grupo por meses
            else if (totalDias <= 365)
            {
                vendasLiquidasPorPeriodos = (from vendas in listaVendasPorData
                                             group vendas by vendas.data.ToString("MMM-yyyy")
                        into listaVendas
                                             select new VendasLiquidasPorPeriodo
                                             {
                                                 periodo = listaVendas.Key,
                                                 vendasLiquidas = listaVendas.Sum(item => item.quantidade)
                                             }).ToList();
            }
            ////período de grupo por anos
            else
            {
                vendasLiquidasPorPeriodos = (from vendas in listaVendasPorData
                                             group vendas by vendas.data.ToString("yyyy")
                        into listaVendas
                                             select new VendasLiquidasPorPeriodo
                                             {
                                                 periodo = listaVendas.Key,
                                                 vendasLiquidas = listaVendas.Sum(item => item.quantidade)
                                             }).ToList();
            }
        }
    }
}
