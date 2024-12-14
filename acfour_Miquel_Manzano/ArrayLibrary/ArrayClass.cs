﻿using System.Collections;

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

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                UserInteractionClass.ConsolePrint(array, i);
            }
        }
    }
}