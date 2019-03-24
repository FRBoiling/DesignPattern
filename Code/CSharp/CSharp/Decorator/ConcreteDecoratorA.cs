
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ConcreteDecoratorA : Decorator {

    private string addedState;

    public override void Operation()
    {
        base.Operation();
        addedState = "New State";
        Console.WriteLine("具体装饰对象A的操作");
    }

}