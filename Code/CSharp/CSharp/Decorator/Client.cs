using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DecoratorPattern
{
    public  class Client
    {
        public Client() {
            ConcreteComponent concreteComponent = new ConcreteComponent();

            ConcreteDecoratorA concreteDecoratorA = new ConcreteDecoratorA();
            ConcreteDecoratorB concreteDecoratorB = new ConcreteDecoratorB();


            concreteDecoratorA.SetComponent(concreteComponent);
            concreteDecoratorB.SetComponent(concreteDecoratorA);
            concreteDecoratorB.Operation();

            Console.Read();
        }
    }
}
