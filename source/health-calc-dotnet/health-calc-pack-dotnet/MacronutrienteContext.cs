using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using health_calc_pack_dotnet.Interfaces;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet
{
    public class MacronutrienteContext
    {
        private IMacronutrienteStrategy MacronutrienteStrategy;

        public MacronutrienteContext(IMacronutrienteStrategy strategy)
        {
            MacronutrienteStrategy = strategy;
        }

        public void SetStrategy(IMacronutrienteStrategy strategy)
        {
            MacronutrienteStrategy = strategy;
        }

        public MacronutrienteModel Execute (double Weight)
        {
            return MacronutrienteStrategy.Calc(Weight);
        }

    }
}
