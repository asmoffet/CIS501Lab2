using System;
using System.Collections.Generic;
using System.Text;

namespace CIS501Lab2Part2
{
    
    public class Manager:removeMethod
    {
        
        public Client _client;
        private List<Helper> active = new List<Helper>();
        removeMethod.RemoveMethod rMethod;
        public Manager(Client client)
        {
            _client = client;
            rMethod = remove;

        }
        public void remove(Helper h)
        {
            active.Remove(h);
            Console.WriteLine("Helper Removed");
        }
        public Helper requestHelp()
        {
            Console.WriteLine("assigning help to client");
            Helper h = new Helper(rMethod);
            active.Add(h);
            return h;
        }
    }
}
