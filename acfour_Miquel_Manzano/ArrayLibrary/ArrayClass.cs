using System.Collections;

namespace WarehouseLibrary
{
    public class ArrayClass
    {
        const int minArray = 0;

        public static void FillArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                UserInteractionClass.ConsolePrint("Posicio: ", i+1);
                int userNum = UserInteractionClass.UserIntInput(minArray);
                array[i] = userNum;
            }
        }

        public static void FillArray(int[] array, int num) // Sobrecarga de funcio per comprobar amb unit test. simulem el input amb un valor fix.
        {
            for (int i = 0; i < array.Length; i++)
            {
                UserInteractionClass.ConsolePrint("Posicio: ", i + 1);
                
                array[i] = num + 1;
                ++num;
            }
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                UserInteractionClass.ConsolePrint(array, i);
            }
        }

        public static void SortArray(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int aux = array[i];
                        array[i] = array[j];
                        array[j] = aux;
                    }
                }
            }
        }
    }
}
