using WarehouseLibrary;
namespace NumberWarehouse
{
    public class NumberWarehouse
    {
        const int MsgTitle = 0;
        const int MsgTitleWarehouseNums = 2;
        const int MsgTitleSortWarehouseNums = 3;
        const int MinNumInput = 0;
        public static void Main(string[] args)
        {
            UserInteractionClass.ConsolePrint(MsgTitle);
            int warehouseLenght = UserInteractionClass.UserIntInput(MinNumInput);
            
            int[] userNumWarehouse = new int[warehouseLenght];
            ArrayClass.FillArray(userNumWarehouse);
            UserInteractionClass.ConsolePrint(MsgTitleWarehouseNums);
            ArrayClass.PrintArray(userNumWarehouse);
            ArrayClass.SortArray(userNumWarehouse);
            UserInteractionClass.ConsolePrint(MsgTitleSortWarehouseNums);
            ArrayClass.PrintArray(userNumWarehouse);
        }
    }
}