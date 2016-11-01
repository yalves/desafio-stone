using System;
using static System.Console;
using static Desafio_Stone.Util;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Stone
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeDePreposicoesNoTexto = DescobrirQuantidadeDePreposicoesNoTexto(TEXTO_NO_IDIOMA_PREDATOR);
            WriteLine($"Existem {quantidadeDePreposicoesNoTexto} preposições no texto");

            int quantidadeDeVerbosEmPrimeiraPessoa;
            int quantidadeDeVerbosNoTexto = DescobrirQuantidadeDeVerbosNoTexto(TEXTO_NO_IDIOMA_PREDATOR, out quantidadeDeVerbosEmPrimeiraPessoa);
            WriteLine($"Há {quantidadeDeVerbosNoTexto} verbos no texto");
            WriteLine($"Há {quantidadeDeVerbosEmPrimeiraPessoa} verbos em primeira pessoa no texto");

            WriteLine("Em seguida, a lista de vocabulário do texto:");
            var vocabulario = CriarVocabularioPedrator(TEXTO_NO_IDIOMA_PREDATOR);
            foreach (var palavra in vocabulario)
                Write($"{palavra} ");

            int quantidadeDeNumerosLindosDistintosNoTexto;
            int quantidadeDeNumerosBonitosDistintosNoTexto = DescobrirQuantidadeDeNumerosBonitosDistintosNoTexto(TEXTO_NO_IDIOMA_PREDATOR, out quantidadeDeNumerosLindosDistintosNoTexto);
            WriteLine($"No texto, há {quantidadeDeNumerosBonitosDistintosNoTexto} números bonitos distintos.");
            WriteLine($"No texto, há {quantidadeDeNumerosLindosDistintosNoTexto} números lindos distintos.");

            ReadKey();
        }
    }
}
