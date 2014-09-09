using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interface;

namespace Repository.Model
{
    public class FooTwo : IFoo
    {
        string IFoo.GetFooString()
        {
            return "FooTwo Foo";
        }

        string IAsdf.GetAsdfString()
        {
            return "FooTwo Asdf";
        }
    }
}
