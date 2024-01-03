// Задача: тепер необхідна можливість виготовлення повної копії стільців з певного шаблону.
// Рішення: патерн Prototype, який дозволяє створювати копію об'єкту.
// Примітка 1: в випадку з C#, це означає реалізацію інтерфейсу ICloneable, в загальному випадку, означає створення такого інтерфейсу окремо.
// Примітка 2: конструктор копіювання в данному випадку не підходить.

namespace patternsSamples.Creational_Paterns.Prototype
{
    internal class Chair : ICloneable
    {
        int legs;
        string name;
        bool back;
        public object Clone()
        {
            return new Chair() { legs = legs, name = name, back = back };    
        }
    }
}
