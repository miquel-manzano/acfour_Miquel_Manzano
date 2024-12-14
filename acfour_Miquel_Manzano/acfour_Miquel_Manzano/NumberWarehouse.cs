using WarehouseLibrary;
namespace NumberWarehouse
{
    public class NumberWarehouse
    {
        const int MsgTitle = 0;
        const int MinNumInput = 0;
        public static void Main(string[] args)
        {
            UserInteractionClass.ConsolePrint(MsgTitle);
            int warehouseLenght = UserInteractionClass.UserIntInput(MinNumInput);
            
            int[] userNumWarehouse = new int[warehouseLenght];
            ArrayClass.FillArray(userNumWarehouse);
            ArrayClass.PrintArray(userNumWarehouse);
        }
    }
}