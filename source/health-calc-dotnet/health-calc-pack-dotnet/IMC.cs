using health_calc_pack_dotnet.Interfaces;
using System;

namespace health_calc_pack_dotnet
{
    public class IMC : IIMC
    {
        public double CalcularIMC(double Height, double Weigt)
        {
            return Math.Round(Weigt / (Math.Pow(Height, 2)), 2);
        }

        public string RetornarClassificacaoIMC(double IMC)
        {
            throw new NotImplementedException();
        }

        public bool validarDados(double Heigth, double Wedding)
        {
            throw new NotImplementedException();
        }
    }
}
