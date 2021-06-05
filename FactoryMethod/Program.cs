using System;
using framework;
using IDCard;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new IDCardFactory();
            Product card1 = factory.create("John");
            Product card2 = factory.create("Bob");
            Product card3 = factory.create("Qujen");
            card1.use();
            card2.use();
            card3.use();
        }
    }
}
