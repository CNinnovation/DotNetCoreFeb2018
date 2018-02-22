using LegacyLib;
using System;

namespace MyStandardLib
{
    public class Demo
    {
        public string Hello(string name) => $"Hello, {name}";

        public void OldHello(string message) => new OldCode().Message(message);
    }
}
