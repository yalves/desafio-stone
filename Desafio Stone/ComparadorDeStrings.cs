using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Stone
{
    public class ComparadorDeStrings : IComparer<string>
    {
        private const string Ordem = "qwtrbnvmczspkjgxdflh";

        public int Compare(string a, string b)
        {
            string variavelDeMenorTamanho = a.Length <= b.Length ? a : b;

            for (int i = 0; i < variavelDeMenorTamanho.Length; i++)
            {
                int indexDeA = Ordem.IndexOf(a[i]);
                int indexDeB = Ordem.IndexOf(b[i]);
                if (indexDeA < indexDeB) { return -1; }
                else if (indexDeB < indexDeA) { return 1; }
            }
            return 0;
        }
    }
}
