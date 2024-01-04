// Задача: уявимо ту ж задачу, що і з абстрактною фабрикою, потрібно аби була можливість виготовляти меблі в різному стилі, але при цьому потрібно максимально спростити додавання нового виду меблів, або нових стилів.
// Рішення: використання патерну Bridge
namespace patternsSamples.Structural_Paterns.Bridge
{
    #region Styles
    internal interface IStyle
    {
        string GetStyle();
    }
    internal class Modern : IStyle
    {
        public string GetStyle()
        {
            return "Modern";
        }
    }
    internal class Retro : IStyle
    {
        public string GetStyle()
        {
            return "Retro";
        }
    }
    #endregion
    internal interface IFurniture
    {
        public IStyle CurrentStyle { get; set; }
    }
}
