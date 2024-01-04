// Примітка 1: Декоратор це по суті -- адаптер, декоратор виконує певні дії до того як буде виконана основна дія, але навідмінну від адаптера, має можливість накладатись поверх іншого декоратору, таким чином є можливість використовувати декілька декораторів, для одного об'єкту.
// Примітка 2: Чому не використати делегати для цього, залишається загадкою.
// Примітка 3: Не зміг придумати хоч трішки логічний приклад для рішення, тому воно буде умовним.

namespace patternsSamples.Structural_Paterns.Decorator
{
    internal interface IMassage
    {
        public string SendMessage();
    }
    internal class Messager : IMassage
    {
        string message;
        public string SendMessage()
        {
            return $"message says:\n{message}\n";
        }
    }
    internal class MessageDecorator : IMassage
    {
        public IMassage messager { get; set; }
        public virtual string SendMessage()
        {
            return messager.SendMessage();
        }
    }

    internal class EncryptMessageDecorator : MessageDecorator
    {
        public override string SendMessage()
        {
            return $"{base.SendMessage()}Encrypting\n";
        }
    }

    internal class CompressMessageDecorator : MessageDecorator
    {
        public override string SendMessage()
        {
            return $"{base.SendMessage()}Compressing\n";
        }
    }
}
