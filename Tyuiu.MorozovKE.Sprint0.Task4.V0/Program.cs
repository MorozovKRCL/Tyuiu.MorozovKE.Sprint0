using Tyuiu.MorozovKE.Sprint0.Task4.V0.Lib;

namespace Tyuiu.MorozovKE.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // пример линейной структуры программы
            // вызов методов сложения, вычитания и тд
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Substraction(28, 11));
            Console.WriteLine(DataService.Multiplication(27, 3));
            Console.WriteLine(DataService.Division(18, 9));
            Console.ReadLine();
        }
    }
}
