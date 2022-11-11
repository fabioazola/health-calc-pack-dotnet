﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using health_calc_pack_dotnet.Enums;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet
{
    public class Macronutriente : IMacronutriente
    {
        const int PROTEINA = 2;
        const int GORDURA_BUKING = 2;
        const int GORDURA = 1;
        const int CARBOIDRATO_BUKING_T1 = 4;
        const int CARBOIDRATO_BUKING_T2 = 7;
        const int CARBOIDRATO_CUTTING  = 2;
        const int CARBOIDDRATO_MAINTENANCE = 5;

        public bool IsValidData(double Weight)
        {
            throw new NotImplementedException();
        }

        public MacronutrienteModel Calc(SexoEnum Sexo, double Height, double Weight, 
                           NivelAtividadeFisicaEnum NivelAtividadeFisica, 
                           ObjetivoFisicoEnum ObjetivoFisico)
        {
            int Proteinas = 0;
            int Carboidratos = 0;
            int Gorduras = 0;

            if (ObjetivoFisico == ObjetivoFisicoEnum.Cutting)
            {
                Proteinas = PROTEINA * (int)Weight;
                Carboidratos = CARBOIDRATO_CUTTING * (int)Weight;
                Gorduras = GORDURA * (int)Weight;
            }
            else if (ObjetivoFisico == ObjetivoFisicoEnum.Bucking)
            {
                Proteinas = PROTEINA * (int)Weight;
                Carboidratos = CARBOIDRATO_BUKING_T1 * (int)Weight;
                Gorduras = GORDURA_BUKING * (int)Weight;

                if (NivelAtividadeFisica == NivelAtividadeFisicaEnum.BastanteAtivo ||
                    NivelAtividadeFisica == NivelAtividadeFisicaEnum.ExtremanteAtivo)
                    Carboidratos = CARBOIDRATO_BUKING_T2 * (int)Weight;
            }
            else if (ObjetivoFisico == ObjetivoFisicoEnum.Maintenance)
            {
                Proteinas = PROTEINA * (int)Weight;
                Carboidratos = CARBOIDDRATO_MAINTENANCE * (int)Weight;
                Gorduras = GORDURA * (int)Weight;
            }

            var Result = new MacronutrienteModel()
            {
                Proteinas = Proteinas,
                Carboidratos = Carboidratos,
                Gorduras = Gorduras
            };

            return Result;

        }

    }
}
