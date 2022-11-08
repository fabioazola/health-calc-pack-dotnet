
using Xunit;
using health_calc_pack_dotnet;

namespace health_calc_test_xunit
{
    public class IMCTest 
    {
        [Fact]
        public void When_RequestIMCCalcWithValidData_ThenReturnIMCIndex()
        {
            //Arrange
            var Imc = new IMC();
            var Heigth = 1.68;
            var Weigth = 85;
            var Expected = 30.12;

            //Act
            var Result = Imc.Calc(Heigth, Weigth);

            //Assert
            Assert.Equal(Expected, Result);
        }


        [Fact]
        public void When_RequestIMCCalcWithValidData_ThenReturnIMCIndexWithRangeAssert()
        {
            //Arrange
            var Imc = new IMC();
            var Heigth = 1.68;
            var Weigth = 85;
            var ExpectedMin = 30.10;
            var ExpectedMax = 30.14;

            //Act
            var Result = Imc.Calc(Heigth, Weigth);

            //Assert
            Assert.InRange(Result, ExpectedMin, ExpectedMax);
        }

        [Fact]
        public void When_RequestIMCCalcWithInvalidData_ThenReturnIMCNaN()
        {
            //Arrange
            var Imc = new IMC();
            var Heigth = 0.0;
            var Weigth = 0.0;
            var Expected = double.NaN;

            //Act
            var Result = Imc.Calc(Heigth, Weigth);

            //Assert
            Assert.Equal(Expected, Result);
        }


        [Fact]
        public void When_RequestIMCCalcWithInvalidData_ThenReturnInfinity()
        {
            //Arrange
            var Imc = new IMC();
            var Heigth = 0;
            var Weigth = 85;
            var Expected = double.NegativeInfinity;

            //Act
            var Result = Imc.Calc(Heigth, Weigth);

            //Assert
            Assert.Equal(Expected, Result);
        }


        [Theory]
        [InlineData(17.5,"Abaixo do peso")]
        [InlineData(18.49, "Abaixo do peso")]
        [InlineData(18.50, "Peso normal")]
        [InlineData(24.99, "Peso normal")]
        [InlineData(25, "Pré-obesidade")]
        [InlineData(29.99, "Pré-obesidade")]
        [InlineData(30, "Obesidade Grau 1")]
        [InlineData(34.99, "Obesidade Grau 1")]
        [InlineData(35, "Obesidade Grau 2")]
        [InlineData(35.99, "Obesidade Grau 2")]
        [InlineData(40, "Obesidade Grau 3")]
        [InlineData(45, "Obesidade Grau 3")]

        public void When_RequestIMCCategory_ThenReturnCategory(double IMC, string ExpectedResult)
        {
            //Arrange
            var Imc = new IMC();

            //Act
            string Result = Imc.GetIMCCategory(IMC);

            //Assert
            Assert.Equal(ExpectedResult, Result);
        }

    }
}
