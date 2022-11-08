using health_calc_pack_dotnet.Interfaces;
using System;

namespace health_calc_pack_dotnet
{
    public class IMC : IIMC
    {
        public double Calc(double Height, double Weigth)
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

        public string GetIMCCategory(double IMC)
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
                Result = "Pré-obesidade";
            else if (IMC >= 30 && IMC < 35)
                Result = "Obesidade Grau 1";
            else if (IMC >= 35 && IMC < 40)
                Result = "Obesidade Grau 2";
            else if (IMC >= 40)
                Result = "Obesidade Grau 3";

            return Result;
        }

        public bool IsValiData(double Height, double Weight)
        {
            if (Height <= 0 || Weight <= 0)
                return false;
            else
                return true;
        }
    }
}
