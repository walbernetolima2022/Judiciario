using System;
using Xunit;

namespace juridico_TDD
{
    public class AdvogadoTDD
    {
        [Fact]
        public void AdvogadoRetornarNomeCompletotrue()
        {
            //Arrange - Prepara��o
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
        [Theory]
        [InlineData("reginaldo", "vinicius", "reginaldo vinicius")]
        [InlineData] ("Jos�", "Santos", "jos� santos")]
        [InlineData] ("Bozo","vai preso","bozo vai preso")
        public void advogadoRetornarNomeCompletoVariosCenarios(string nome, string sob, string esperado)
        { 
            //Arrange
            advogado adv = new advogado();
            adv.nome = nome;
            adv.sobrenome = sob;
            //Act
            string resultado = adv.getNomecompleto();
            Assert.Equal(resultado, esperado);


        }
}
