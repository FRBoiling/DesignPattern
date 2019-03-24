
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp.AdapterPattern
{
    public class Client
    {
        public Client()
        {
            Target target = new Adapter();
            target.Request();

            Console.Read();
        }
    }

}