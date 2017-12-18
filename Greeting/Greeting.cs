namespace Greeting
{
    public class Greetings
    {
        private const string StartNormalGreet = "Hello, ";
        private const string StartShoutingGreet = "HELLO ";
        private const string EndNormalGreet = ".";
        private const string EndShoutingGreet = "!";
        private const string DefaultName = "my friend";

        public string Greet(string name)
        {
            if (string.IsNullOrEmpty(name))
                name = DefaultName;

            if (IsShouting(name))
                return StartShoutingGreet + name + EndShoutingGreet;


            return StartNormalGreet + name + EndNormalGreet;
        }

        private bool IsShouting(string name)
        {
            return name.ToUpperInvariant() == name;
        }
    }
}
