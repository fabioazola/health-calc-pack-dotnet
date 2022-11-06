using health_calc_pack_dotnet.Interfaces;
using System;

namespace health_calc_pack_dotnet
{
    public class IMC : IIMC
    {
        double IIMC.Calc(double Height, double Weigth)
        {
            try
            {
                var Result = Math.Round(Weigth / (Math.Pow(Height, 2)), 2);
                return Result;
            }
            catch
            {
                throw;
            }
        }

        public object Calc(double heigth, int weigth)
        {
            throw new NotImplementedException();
        }

        string IIMC.GetIMCCategory(double IMC)
        {
            //Menor que 18.5 - Abaixo do peso;
            //Entre 18.5 e 24.9 - Peso normal;
            //Entre 25.0 e 29.9 - Pré-obesidade
            //Entre 30.0 e 39.9 - Obesidade Grau 1;
            //Entre 35.0 e 39.9 - Obesidade Grau 2;
            //Acima de 40 - Obesidade de Grau 3

            var Result = string.Empty;

            if (IMC < 18.5)
                Result = "Abaixo do peso";
            else if (IMC >= 18.5 && IMC < 25)
                Result = "Peso normal";
            else if (IMC >= 25 && IMC < 30)
                Result = "Pré-obsidade";
            else if (IMC >= 30 && IMC < 35)
                Result = "Obesidade Grau 1";
            else if (IMC >= 35 && IMC < 40)
                Result = "Obesidade Grau 2";
            else if (IMC > 40)
                Result = "Obesidade Grau 3";

            return Result;
        }

        bool IIMC.IsValiData(double Height, double Weight)
        {
            throw new NotImplementedException();
        }

        public object CalcularIMC(double heigth, int weigth)
        {
            throw new NotImplementedException();
        }

        public object Calc(double heigth, double weigth)
        {
            throw new NotImplementedException();
        }
    }
}
