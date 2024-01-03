// Задача: тепер наш меблевий завод виготовляє стільці на замовлення, в стільця може бути певна кількість ніжок, може бути сидіння, може бути спинка, можуть бути підлокітники, а може взагалі нічого не бути.
// Рішення: вирішимо подібну задачу за допомогою патерну Builder, що передбачає створення класу який збирає наш "стілець", по крокам (не всі з яких є обов'язкові).
// Примітка 1: це лише можлива реалізація, можлива також реалізація з використанням "менеджера", який має декілька "робітників" кожен з яких сам використовує Свої кроки для створення об'єкту. І через "менеджера" використовується той "робітник", який видасть необхідний в данному випадку продукт.
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
