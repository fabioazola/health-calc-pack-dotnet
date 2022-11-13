using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using health_calc_pack_dotnet.Enums;

namespace health_calc_pack_dotnet.Strategy.Base
{
    
    public abstract class MacronutrienteBase
    {
        public double GENDER_MULTPLIER;

        public MacronutrienteBase (SexoEnum Sexo)
        {
            GENDER_MULTPLIER = (Sexo == SexoEnum.Feminino) ? 0.8 : 1;
        }

    }
}
