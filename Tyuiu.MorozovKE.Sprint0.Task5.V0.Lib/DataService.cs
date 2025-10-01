namespace Tyuiu.MorozovKE.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        //пример линейной структуры

        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Substraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static double Division(int a, int b)
        {
            if (b == 0)
            {
                // пример для демонстрации ветвления
                // в реальных проектах нужно использовать Exception
                Console.WriteLine("Применение b = {0} на ноль делить нельзя", b);
                return -1;
            }
            else 
            {
                return a / b;
            }
        }
    }
}
