using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interface;

namespace Repository.Model
{
    public class FooOne : IFoo
    {


        public string GetFooString()
        {
            return "FooOne foo";
        }

        public string GetAsdfString()
        {
            return "FooOne asdf";
        }
    }
}
