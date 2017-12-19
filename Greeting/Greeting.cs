﻿namespace Greeting
{
    public class Greetings
    {
        private const string StartNormalGreet = "Hello, ";
        private const string StartShoutingGreet = "HELLO ";
        private const string EndNormalGreet = ".";
        private const string EndShoutingGreet = "!";
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
            if(names == null)
                return StartNormalGreet + DefaultName + EndNormalGreet;
            switch (names.Length)
            {
                case 0:
                    return StartNormalGreet + DefaultName + EndNormalGreet;
                case 1:
                    if (string.IsNullOrEmpty(names[0]))
                        return StartNormalGreet + DefaultName + EndNormalGreet;
                    return IsShouting(names[0]) ?
                        StartShoutingGreet + names[0] + EndShoutingGreet:
                        StartNormalGreet + names[0] + EndNormalGreet;
                    default:
                        return "";
            }

        }


        private bool IsShouting(string name)
        {
            return name.ToUpperInvariant() == name;
        }
    }
}
