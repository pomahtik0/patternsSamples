// Задача: На стільці можна сидіти, чому не можна сісти на стіл? Потрібно терміново виправити!
// Рішення: Використати клас адаптер, який буде реалізовувати сидіння на столі.

namespace patternsSamples.Structural_Paterns.Adapter
{
    internal interface ISit
    {
        public void Sit();
    }

    internal class Chair : ISit
    {
        public void Sit()
        {
            Console.WriteLine("Сижу на стільці");
        }
    }
    internal class Table
    {

    }

    internal class AdapterForTable : ISit 
    {
        Table table;
        public void Sit()
        {
            // some adaptation logic
            Console.WriteLine("Сів на стіл");
        }
    }
}
