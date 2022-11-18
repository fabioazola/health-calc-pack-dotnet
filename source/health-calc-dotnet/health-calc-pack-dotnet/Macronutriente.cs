using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;
using health_calc_pack_dotnet.Strategy;

namespace health_calc_pack_dotnet
{
    public class Macronutriente : IMacronutriente
    {
        const int MIN_WEIGTH = 35;

        public bool IsValidData(double Weight)
        {
            if (Weight <= MIN_WEIGTH)
                return false;

            return true;
        }

         public MacronutrienteModel Calc(
                                        SexoEnum Sexo, 
                                        double Height, 
                                        double Weight, 
                                        NivelAtividadeFisicaEnum NivelAtividadeFisica, 
                                        ObjetivoFisicoEnum ObjetivoFisico)
        {

            if (!IsValidData(Weight))
                throw new Exception("Invalid Parameters");

            IMacronutrienteStrategy macronutrienteStrategy = new CuttingStrategy(); // iniciando com uma strategia

            if (ObjetivoFisico == ObjetivoFisicoEnum.Cutting)
                macronutrienteStrategy = new CuttingStrategy();
            else if (ObjetivoFisico == ObjetivoFisicoEnum.Bucking)
            {
                if (NivelAtividadeFisica == NivelAtividadeFisicaEnum.BastanteAtivo ||
                    NivelAtividadeFisica == NivelAtividadeFisicaEnum.ExtremanteAtivo)
                        macronutrienteStrategy = new BulkingNivelAtividadeAtivoStrategy(Sexo);
                else
                    macronutrienteStrategy = new BulkingStrategy();
            }
            else if (ObjetivoFisico == ObjetivoFisicoEnum.Maintenance)
                macronutrienteStrategy = new MaitenanceStrategy();

            var context = new MacronutrienteContext(macronutrienteStrategy);
            var Result = context.Execute(Weight);

            return Result;
        }
    }
}
