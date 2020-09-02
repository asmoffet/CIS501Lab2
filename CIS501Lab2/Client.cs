using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CIS501Lab2
{
    public class Client
    {
        public void Work()
        {
            Manager mngr = new Manager(this);
            Console.WriteLine("requesting help to thhe manager");
            Helper h = mngr.requestHelp();
            h.doWork();
            h.finished();
            Console.WriteLine("client is happy :]");
        }
    }
}
