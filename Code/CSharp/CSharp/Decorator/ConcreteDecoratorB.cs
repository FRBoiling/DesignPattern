
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ConcreteDecoratorB : Decorator {

    public override void Operation() {
        base.Operation();
        AddedBehavior();
    }

    private void AddedBehavior() {
        // TODO implement here
    }

}