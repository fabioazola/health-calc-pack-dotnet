using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet.Interfaces
{
    class BulkingNivelAtividadeAtivoStrategy : IMacronutrienteStrategy
    {
        const int PROTEINA = 2;
        const int GORDURA = 2;
        const int CARBOIDRATO = 4;

        public MacronutrienteModel Calc(double Weight)
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
