using System;
using System.Linq;

namespace Infra
{
    public class DiasUteis
    {
        public static bool EhFeriado(DateTime data)
        {
            var feriados = LeitorCsv.ObterFeriados();

            return feriados.Any(x => x.Data == data);
        }
        public static bool EhFinalDeSemana(DateTime data)
        {
            return data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}
