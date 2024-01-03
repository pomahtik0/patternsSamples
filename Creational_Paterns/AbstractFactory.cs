// Задача: давайте, уявимо, що до задачі з фабрикою, додались ще умови, тепер ми можемо створювати меблі у різних стилях..
// Рішення: вирішимо це питання за допомогою патерну Абстрактна фабрика.
// Висновок: як на мене, від звичайної фабрики мало відрізняється, суть залишається не змінною: використання інкапсуляції для класів що виходять з фабрики.
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

    #region Factory
    internal abstract class AbstractFactory
    {
        public abstract Chair ProduceChair();
        public abstract Table ProduceTable();
    }

    internal class ModernFactory : AbstractFactory
    {
        public override Chair ProduceChair()
        {
            return new ModernChair();
        }

        public override Table ProduceTable()
        {
            return new ModernTable();
        }
    }

    internal class RetroFactory : AbstractFactory
    {
        public override Chair ProduceChair()
        {
            return new RetroChair();
        }

        public override Table ProduceTable()
        {
            return new RetroTable();
        }
    }
    #endregion
}
