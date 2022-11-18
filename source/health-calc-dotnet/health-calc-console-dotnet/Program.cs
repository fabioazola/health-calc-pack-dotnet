using System;

using health_calc_pack_dotnet;

namespace health_calc_console_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com sua altura e peso para calcular seu IMC!");

            Console.Write("Altura :");
            var Heigth = Console.ReadLine();

            Console.Write("Peso : ");
            var Weight = Console.ReadLine();

            Console.Write("Sexo (0-Masculino ou 1-Feminino) : ");
            var Sexo = Console.ReadLine();

            IMC objIMC = new IMC();
            Macronutriente objMacro = new Macronutriente();
            
            double Result = objIMC.Calc(double.Parse(Heigth), double.Parse(Weight));
            string Catergory = objIMC.GetIMCCategory(Result);

            var ResultMacronutriente = objMacro.Calc(
                (health_calc_pack_dotnet.Enums.SexoEnum)int.Parse(Sexo),
                double.Parse(Heigth),
                double.Parse(Weight),
                (health_calc_pack_dotnet.Enums.NivelAtividadeFisicaEnum)0,
                (health_calc_pack_dotnet.Enums.ObjetivoFisicoEnum)1);
            

            Console.WriteLine("O resultado de seu IMC foi : "+Catergory);
            Console.WriteLine("Tabela de Macronutriente:");
            Console.WriteLine("Carboidrato: "+ResultMacronutriente.Carboidratos);
            Console.WriteLine("Proteinas: " + ResultMacronutriente.Proteinas);
            Console.WriteLine("Gorduras: " + ResultMacronutriente.Gorduras);



            Console.ReadKey();

        }
    }
}
