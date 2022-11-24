using System;
using Xunit;

namespace juridico_TDD
{
    public class AdvogadoTDD
    {
        [Fact]
        public void AdvogadoRetornarNomeCompletotrue()
        {
            //Arrange - Preparação
            Advgado adv = new Advogado();
            adv.nome = "vinicius"; 
            adv.sobrenome = "regiando";
            string esperado = "vinicius reginaldo";
            string resultado;
            //Act
            resultado = adv.getNomecompleto();

            //Assert
            Assert.Equal(esperado, resultado);

        }
    }
}
