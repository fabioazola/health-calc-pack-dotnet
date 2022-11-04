using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_calc_pack_dotnet.Interfaces
{
    public interface IIMC
    {
        double CalcularIMC(double Heigth, double Wedding);
        string RetornarClassificacaoIMC(double IMC);
        bool validarDados(double Heigth, double Wedding);


    }
}
