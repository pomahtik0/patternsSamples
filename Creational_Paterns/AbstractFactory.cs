// Задача: давайте, уявимо, що до задачі з фабрикою, додались ще умови, тепер ми можемо створювати меблі у різних стилях..
// Рішення: вирішимо це питання за допомогою патерну Абстрактна фабрика.

namespace patternsSamples.Creational_Paterns.AbstractFactory
{
    #region Chairs
    internal interface Chair
    {
        public void Description();
        public void SomeChairMethod();
    }
    internal class ModernChair : Chair
    {
        public void Description()
        {
            Console.WriteLine("It's a modern chair");
        }

        public void SomeChairMethod()
        {

        }
    }
    internal class RetroChair : Chair
    {
        public void Description()
        {
            Console.WriteLine("It's a retro chair");
        }

        public void SomeChairMethod()
        {

        }
    }
    #endregion

    #region Tables
    internal interface Table
    {
        public void Description();
        public void SomeTableMethod();
        public void SomeTableMethod1();
    }
    internal class ModernTable : Table
    {
        public void Description()
        {
            Console.WriteLine("It's a modern chair");
        }
        public void SomeTableMethod()
        {

        }
        public void SomeTableMethod1()
        {

        }
    }
    internal class RetroTable : Table
    {
        public void Description()
        {
            Console.WriteLine("It's a retro chair");
        }
        public void SomeTableMethod()
        {

        }
        public void SomeTableMethod1()
        {

        }
    }
    #endregion

    internal abstract class AbstractFactory
    {
    }
}
