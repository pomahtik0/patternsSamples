// Задача: тепер наш меблевий завод виготовляє стільці на замовлення, в стільця може бути певна кількість ніжок, може бути сидіння, може бути спинка, можуть бути підлокітники, а може взагалі нічого не бути.
// Рішення: вирішимо подібну задачу за допомогою патерну Builder, що передбачає створення класу який збирає наш "стілець", по крокам (не всі з яких є обов'язкові).
namespace patternsSamples.Creational_Paterns.Builder
{
    internal class Chair
    {
        public int NumberOfLegs { get; set; }
        public bool HasASit { get; set; }
        public bool HasABack { get; set; }
        public bool HasAnArmrest { get; set; }
    }
    internal class Builder
    {
        Chair chair = new Chair();
        public void PutLegs(int numberOfLegs) => chair.NumberOfLegs = numberOfLegs;
        public void PutASit() => chair.HasASit = true;
        public void PutABack() => chair.HasABack = true;
        public void PutAnArmrest() => chair.HasAnArmrest = true;
        public Chair GetCreatedChair() => chair;
        public void Reset() => chair = new Chair();
    }
}
