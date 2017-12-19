namespace Greeting
{
    public class Greetings
    {
        private const string StartNormalGreet = "Hello, ";
        private const string StartShoutingGreet = "HELLO ";
        private const string EndNormalGreet = ".";
        private const string EndShoutingGreet = "!";
        private const string Separator = " and ";
        private const string DefaultName = "my friend";

        private string Greet(string name)
        {
            if (string.IsNullOrEmpty(name))
                name = DefaultName;

            if (IsShouting(name))
                return StartShoutingGreet + name + EndShoutingGreet;


            return StartNormalGreet + name + EndNormalGreet;
        }

        public string Greet(params string[] names)
        {
            if(names == null || names.Length == 0 || (names.Length == 1 && string.IsNullOrEmpty(names[0])))
                return ComposeGreet(DefaultName);

            switch (names.Length)
            {
                case 1:
                    return IsShouting(names[0]) ? ComposeShoutingGreet(names[0]):
                        ComposeGreet(names[0]);
                case 2:
                    return ComposeGreet(names[0] + Separator + names[1]);
                default:
                        return "";
            }

        }

        private string ComposeGreet(string name)
        {
            return StartNormalGreet + name + EndNormalGreet;
        }

        private string ComposeShoutingGreet(string name)
        {
            return StartShoutingGreet + name + EndShoutingGreet;
        }

        private bool IsShouting(string name)
        {
            return name.ToUpperInvariant() == name;
        }
    }
}
