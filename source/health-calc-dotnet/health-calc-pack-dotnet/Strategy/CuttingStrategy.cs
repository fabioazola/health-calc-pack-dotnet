using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using health_calc_pack_dotnet.Models;
using health_calc_pack_dotnet.Interfaces;

namespace health_calc_pack_dotnet.Strategy
{
    class CuttingStrategy : IMacronutrienteStrategy
    {
        const int PROTEINA = 2;
        const int GORDURA = 1;
        const int CARBOIDRATO = 2;

        public MacronutrienteModel Calc (double Weight)
        {
            var Result = new MacronutrienteModel()
            {
                Proteinas = PROTEINA * (int)Weight,
                Carboidratos = CARBOIDRATO * (int)Weight,
                Gorduras = GORDURA * (int)Weight
            };
            return Result;
        }
    }
}
