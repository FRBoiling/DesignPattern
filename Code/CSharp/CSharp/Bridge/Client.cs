using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.BridgePattern
{
    class Client
    {
        public Client()
        {
            Abstraction abstraction = new RefinedAbstracttion();
            abstraction.SetImplementor(new ConcreteImplementorA());
            abstraction.Operation();
            abstraction.SetImplementor(new ConcreteImplementorB());
            abstraction.Operation();

            Console.Read();
        }
    }
}
