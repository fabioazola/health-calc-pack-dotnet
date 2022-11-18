using System;


namespace helth_calc_console_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com sua altura e peso para calcular seu IMC!");

            Console.Write("Altura");
            var Heigth = Console.ReadLine();

            Console.Write("Peso: ");
            var Weight = Console.ReadLine();

            //IMC objIMC = new IMC();

            //double Result = objIMC.Calc(double.Parse(Heigth), double.Parse(Weight));
            //Console.WriteLine(Result);
        }
    }
}
