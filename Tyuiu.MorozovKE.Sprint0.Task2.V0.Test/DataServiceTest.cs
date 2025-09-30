using Tyuiu.MorozovKE.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MorozovKE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Кирилл";
            var res = DataService.GetMessage(name);

            //вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет, Кирилл", res);
        }
    }
}
