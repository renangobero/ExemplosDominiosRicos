using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos.Domain
{
    public class ClasseDeCalculo
    {

        public void Iniciar()
        {

            var valorDividir = 2;
            var valor = 10;
            var novoValor = valor * 100;
            var novoValorDividido = valorDividir != 0 ? novoValor / valorDividir : 0;

            Console.WriteLine(valor.ToString("n2"));
            Console.WriteLine(novoValor.ToString("n2"));
            Console.WriteLine(novoValorDividido.ToString("n2"));

            Console.WriteLine("Classe iniciada");
            Console.WriteLine("Obrigado!!!");

        }
    }
}
