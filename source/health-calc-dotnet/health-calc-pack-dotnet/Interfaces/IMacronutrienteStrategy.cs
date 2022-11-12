using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using health_calc_pack_dotnet.Models;

namespace health_calc_pack_dotnet.Interfaces
{
    interface IMacronutrienteStrategy
    {
        MacronutrienteModel Calc(double Weight);
    }
}
