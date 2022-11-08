using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet.Interfaces
{
    public interface IIMC
    {
        public double Calc(double Height, double Weigth);
        public string GetIMCCategory(double IMC);
        public bool IsValiData(double Height, double Weight);

    }
}
