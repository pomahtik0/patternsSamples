using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternsSamples.Creational_Paterns.Factory
{
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

    internal abstract class Factory
    {
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
