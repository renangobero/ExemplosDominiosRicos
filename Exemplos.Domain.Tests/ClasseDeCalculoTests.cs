using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exemplos.Domain;

namespace Exemplos.Domain.Tests
{
    [TestClass]
    public class ClasseDeCalculoTests
    {
        [TestMethod]
        public void Iniciar_PrintsExpectedMessages()
        {
            // Arrange
            var calculo = new ClasseDeCalculo();
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                calculo.Iniciar();

                // Assert
                var output = sw.ToString();
                StringAssert.Contains(output, "Classe iniciada");
                StringAssert.Contains(output, "Obrigado!!!");
            }
        }
    }
}
