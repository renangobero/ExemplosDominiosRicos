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

            var valorDividir = 0;
            var valor = 10;
            var novoValor = valor * 100;
            var novoValorDivido = novoValor / valorDividir;

            Console.WriteLine(valor.ToString("n2"));
            Console.WriteLine(novoValor.ToString("n2"));
            Console.WriteLine(novoValorDivido.ToString("n2"));

            Console.WriteLine("Classe iniciad");
            Console.WriteLine("Obrgado!!!");

        }
    }
}
