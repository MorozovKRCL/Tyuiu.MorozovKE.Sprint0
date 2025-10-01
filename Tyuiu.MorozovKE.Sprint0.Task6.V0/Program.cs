using Tyuiu.MorozovKE.Sprint0.Task6.V0.Lib;

namespace Tyuiu.MorozovKE.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            //AddictionArray
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArray));

            //SubstractionArray
            Console.WriteLine("разность элементов массива = " + DataService.SubstractionArray(numsArray));

            //MultiplicationArray
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
