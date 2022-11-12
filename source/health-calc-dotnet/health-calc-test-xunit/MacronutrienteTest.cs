
using Xunit;
using health_calc_pack_dotnet;
using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Models;

namespace health_calc_test_xunit
{
    public class MacronutrienteTest 
    {
        [Fact]
        public void When_RequestMacronutrientesCalcWithValidData_ThenReturnResult()
        {
            //Arrange
            var MacronutrienteObj = new Macronutriente();
            var Sexo = SexoEnum.Masculino;
            var Height = 1.68;
            var Weight = 85;
            var NivelAtiviadeFisca = NivelAtividadeFisicaEnum.Sedentario;
            var ObjetivoFisico = ObjetivoFisicoEnum.Cutting;

            var Expected = new MacronutrienteModel()
            {
                Carboidratos = 170,
                Proteinas=  170,
                Gorduras = 85
            };

            //Act
            var Result = MacronutrienteObj.Calc(
                Sexo,
                Height,
                Weight,
                NivelAtiviadeFisca,
                ObjetivoFisico);

            //Assert
            Assert.Equal(Expected.Carboidrato, Result.Carboidratos);
            Assert.Equal(Expected.Proteinas, Result.Proteinas);
            Assert.Equal(Expected.Gorduras, Result.Gorduras);
        }

        [Fact]
        public void When_RequestMacronutrientesCalcWithValidDataForBucking_ThenReturnResult()
        {
            //Arrange
            var MacronutrienteObj = new Macronutriente();
            var Sexo = SexoEnum.Masculino;
            var Height = 1.68;
            var Weight = 85;
            var NivelAtiviadeFisca = NivelAtividadeFisicaEnum.Sedentario;
            var ObjetivoFisico = ObjetivoFisicoEnum.Bucking;

            var Expected = new MacronutrienteModel()
            {
                Carboidratos = 170,
                Proteinas = 170,
                Gorduras = 85
            };

            //Act
            var Result = MacronutrienteObj.Calc(
                Sexo,
                Height,
                Weight,
                NivelAtiviadeFisca,
                ObjetivoFisico);

            //Assert
            Assert.Equal(Expected.Carboidratos, Result.Carboidratos);
            Assert.Equal(Expected.Proteinas, Result.Proteinas);
            Assert.Equal(Expected.Gorduras, Result.Gorduras);
        }

        [Theory]
        [InlineData (NivelAtividadeFisicaEnum.Sedentario, 340)]
        [InlineData(NivelAtividadeFisicaEnum.ModeradamenteAtivo, 340)]
        [InlineData(NivelAtividadeFisicaEnum.BastanteAtivo, 595)]
        [InlineData(NivelAtividadeFisicaEnum.ExtremanteAtivo, 595)]
        public void When_RequestMacronutrientsCalcWithValidDataFor




    }
}
