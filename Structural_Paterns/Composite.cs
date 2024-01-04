// Задача: припустим наш стіл чи стілець, складається з декількох елементів, які можуть кріпитись один до одного в різному порядку, наприклад до основи стола, прикрутим верх і ніжки, а до ніжок ще по одній ніжці.
// Рішення: використання патерну Composite, дозволить створити структуру, для збереження і опрацювання елементів меблів.
// Примітка 1: конкретно ця задача погано продумана, і можливо рішення не саме логічно, але мені треба було щось писати.
namespace patternsSamples.Structural_Paterns.Composite
{
    internal interface IComposite
    {
        protected ICollection<IComposite> Children { get; set; }
        public ICollection<IComposite> GetElements()
        {
            ICollection<IComposite> collectionOfComposits = new List<IComposite>();
            foreach (var child in Children)
            {
                collectionOfComposits.Concat(child.GetElements());
            }
            collectionOfComposits.Add(this);
            return collectionOfComposits;
        }
    }
    public class Leg : IComposite
    {
        private ICollection<IComposite> attachedElements;
        ICollection<IComposite> IComposite.Children { get => attachedElements; set => attachedElements = value; }
    }
    public class Sit : IComposite
    {
        private ICollection<IComposite> attachedElements;
        ICollection<IComposite> IComposite.Children { get => attachedElements; set => attachedElements = value; }
    }
    public class Back : IComposite
    {
        private ICollection<IComposite> attachedElements;
        ICollection<IComposite> IComposite.Children { get => attachedElements; set => attachedElements = value; }
    }
    public class Chair
    {
        private IComposite baseElement;
    }
}
