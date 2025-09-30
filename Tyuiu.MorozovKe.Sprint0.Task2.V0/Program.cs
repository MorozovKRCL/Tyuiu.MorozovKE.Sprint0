using Tyuiu.MorozovKE.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MorozovKE.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // вызов класса DataSrvice и метода GetMessage
            // из библиотеки
            Console.WriteLine(DataService.GetMessage("Кирилл"));
            Console.ReadKey();
        }
    }
}
