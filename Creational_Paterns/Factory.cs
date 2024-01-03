// Задача: виготовлення на якомусь меблевому заводі, стільців і столів.
// Рішення: завод розділяється на два відділи, один з яких робить меблі-стільці, а інший меблі-столи.

namespace patternsSamples.Creational_Paterns.Factory
{
    #region Furniture
    internal interface IFurniture
    {
        public void Description();
    }
    internal class Chair : IFurniture
    {
        public void Description()
        {
            Console.WriteLine("It's a chair");
        }
    }
    internal class Table : IFurniture
    {
        public void Description()
        {
            Console.WriteLine("It's a table");
        }
    }
    #endregion
    internal abstract class Factory
    {
        // тут реалізується деяка логіка
        public abstract IFurniture CreateProduct();
    }
    internal class FactoryOfChairs : Factory 
    {
        public override IFurniture CreateProduct()
        {
            return new Chair();
        }
    }
    internal class FactoryOfTables : Factory 
    {
        public override IFurniture CreateProduct()
        {
            return new Table();
        }
    }
}
