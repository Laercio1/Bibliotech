using Model.ClassesModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Infra
{
    public static class LeitorCsv
    {
        public static IEnumerable<Feriado> ObterFeriados()
        {
            var feriados = new List<Feriado>();
            var linhas = File.ReadAllLines("./feriados_nacionais.xls");

            foreach (var linha in linhas)
            {
                var dados = linha.Split(',');
                feriados.Add(new Feriado(DateTime.ParseExact(dados[0], "dd/MM/yyyy", CultureInfo.InvariantCulture), dados[1]));
            }

            return feriados;
        }
    }
}
