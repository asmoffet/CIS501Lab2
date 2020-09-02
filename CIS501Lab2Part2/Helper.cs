using System;
using System.Collections.Generic;
using System.Text;

namespace CIS501Lab2Part2
{
    public class Helper : removeMethod
    {
        removeMethod.RemoveMethod remove;
        removeMethod rMethod;
        public Helper(removeMethod.RemoveMethod r)
        {
            remove = r;
        }
        public void doWork()
        {
            Console.WriteLine("doing work");

        }
        public void finished()
        {
            Console.WriteLine("job is finished");
            remove(this);
        }
    }
}
