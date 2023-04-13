using Xunit;
using System;




namespace Atividade_IMC_xUnit{

public class UnitTest1 
{
    [Fact] // marcação de teste simples e direcionado 
    public void Testar_CalculoDoImc()
    {
        double ResultadoEsperado = 31.25;

        IMC i = new IMC();

        //Arrange
        i.peso = 80;
        i.altura = 1.60;

        //Act
        i.Calcular_IMC();

        //Assert
        Assert.Equal(ResultadoEsperado, i.imc);
    }
    /////////*********Testes com Múltiplos dados **********\\\\\\\\\\\\

    [Theory]
    [InlineData("Abaixo do peso")]
    [InlineData("Peso Normal")]
    [InlineData("Sobrepeso")]
    [InlineData("Obesidade Grau I")]
    [InlineData("Obesidade Grau II")]
    [InlineData("Obesidade Grau III")]

    public void TestarImcMultiplosDados(string cat)
    {
        IMC i = new IMC();

        i.peso = 80;
        i.altura = 1.60;
        i.Calcular_IMC();
        i.Classificar_IMC();
        Assert.Equal(i.categoria, cat);

    }




}
}