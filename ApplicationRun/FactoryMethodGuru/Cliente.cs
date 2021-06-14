using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodGuru
{
    public class Cliente
    {
        public void Main()
        {
            Console.WriteLine("App: Corriendo con la clase ConcreteCreator1.");
            ClientCode(new ConcreteCreator1());

            Console.WriteLine("");

            Console.WriteLine("App: Corriendo con la clase ConcreteCreator2.");
            ClientCode(new ConcreteCreator2());
        }

        // The client code works with an instance of a concrete creator, albeit
        // through its base interface. As long as the client keeps working with
        // the creator via the base interface, you can pass it any creator's
        // subclass.
        public void ClientCode(Creator creator)
        {
            // ...
            Console.WriteLine("Client:No conozco la clase del creador " +
                 "pero todavía funciona.\n" + creator.SomeOperation());
            // ...
        }
    }
}
