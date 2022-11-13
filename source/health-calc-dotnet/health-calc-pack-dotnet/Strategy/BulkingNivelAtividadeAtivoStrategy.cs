using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using health_calc_pack_dotnet.Models;
using health_calc_pack_dotnet.Strategy.Base;
using health_calc_pack_dotnet.Enums;

namespace health_calc_pack_dotnet.Interfaces
{
    class BulkingNivelAtividadeAtivoStrategy : MacronutrienteBase, IMacronutrienteStrategy
    {
        const int PROTEINA = 2;
        const int GORDURA = 2;
        const int CARBOIDRATO = 7;

        public BulkingNivelAtividadeAtivoStrategy(SexoEnum Sexo):base(Sexo)
        {

        }

        public MacronutrienteModel Calc(double Weight)
        {
            var Result = new MacronutrienteModel()
            {
                Proteinas = PROTEINA * (int)Weight * GENDER_MULTPLIER,
                Carboidratos = CARBOIDRATO * (int)Weight * GENDER_MULTPLIER,
                Gorduras = GORDURA * (int)Weight * GENDER_MULTPLIER
            };

            return Result;
        }
    }
}
