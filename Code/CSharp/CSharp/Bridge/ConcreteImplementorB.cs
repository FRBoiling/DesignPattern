
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ConcreteImplementorB : Implementor {
    public override void Operation()
    {
        Console.WriteLine("具体实现B的方法执行");
    }
}