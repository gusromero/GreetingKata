namespace Greeting
{
    public class Greetings
    {
        private const string StartGreet = "Hello, ";
        private const string EndGreet = ".";
        private const string DefaultName = "my friend";

        public string Greet(string name)
        {
            if (string.IsNullOrEmpty(name))
                name = DefaultName;
           
            return StartGreet + name + EndGreet;
        }

    }
}
