using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            double sumaTotal = 0;
            int cantNotasValidas = 0;

            //if(nota1 >= 0 && nota1 <= 10)
            //{
            //    sumaTotal += nota1.Value;
            //    cantNotasValidas++;
            //}

            sumaTotal += (nota1 >= 0 && nota1 <= 10) ? nota1.Value : 0;
            cantNotasValidas = (nota1 >= 0 && nota1 <= 10) ? 1 : 0;

            if (nota2 >= 0 && nota2 <= 10)
            {
                sumaTotal += nota2.Value;
                cantNotasValidas++;
            }
            if (nota3 >= 0 && nota3 <= 10)
            {
                sumaTotal += nota3.Value;
                cantNotasValidas++;
            }
            //if(sumaTotal == 0)
            //{
            //    return 0;
            //}

            //return sumaTotal / cantNotasValidas;

            return (cantNotasValidas == 0) ? 0 : sumaTotal / cantNotasValidas;
        }
    }
}
