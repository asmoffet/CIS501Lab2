using System;
using System.Collections.Generic;
using System.Text;

namespace CIS501Lab2
{
    public class Helper
    {
        Manager myManager;
        
        public Helper(Manager manager)
        {
            myManager = manager;
        }
        public void doWork()
        {
            Console.WriteLine("doing work");

        }
        public void finished()
        {
            Console.WriteLine("job is finished");
            myManager.remove(this);
        }
    }
}
