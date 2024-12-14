using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseLibrary
{
    public class UserInteractionClass
    {
        public static int UserIntInput(int min) // SUPERMEGA UTIL FUNCIO 
        {
            int userNum;
            bool chekUserNum = int.TryParse(Console.ReadLine(), out userNum);

            while (!chekUserNum || (userNum <= min))
            {
                ConsolePrint(1);
                chekUserNum = int.TryParse(Console.ReadLine(), out userNum);
            }
            return userNum;
        }

        public static void ConsolePrint(int option)
        {
            string Msg;
            switch(option)
            {
                case 0:
                    Msg = "Defineix el tamany del teu magatzem de nombres naturals";
                    break;
                case 1:
                    Msg = $"Numero no valid, torna a probar...\n Nomes aceptem nombres naturals, 0 no inclos.";
                    break;
                default:
                    Msg = "Error desconegut";
                    break;
            }
            Console.WriteLine(Msg);
        }

        public static void ConsolePrint(int[] array, int posision)
        {
            Console.WriteLine($"{posision+1}: " + array[posision]);
        }

        public static void ConsolePrint(string texto, int num)
        {
            Console.WriteLine(texto + num);
        }
    }
}
