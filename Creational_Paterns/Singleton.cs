// Задача: тут я задачу придумати не зміг, тому просто приклад реалізації цього патерну.
// Рішення: створення класу, який створюється лише один раз, і при кожній наступній спробі створити новий клас, повертає той що був створений першим.

namespace patternsSamples.Creational_Paterns
{
    internal class Singleton
    {
        private static Singleton? instance;
        private Singleton() 
        { 
            instance = this;
        }

        public static Singleton GetSingleton()
        {
            return instance ?? new Singleton();
        }
    }
}
