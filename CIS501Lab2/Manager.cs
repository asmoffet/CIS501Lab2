using System;
using System.Collections.Generic;
using System.Text;

namespace CIS501Lab2
{
    public class Manager
    {
        public Client _client;
        private List<Helper> active = new List<Helper>();
        public Manager(Client client)
        {
            _client = client;
            
        }
        public void remove(Helper h)
        {
            active.Remove(h);
            Console.WriteLine("Helper Removed");
        }
        public Helper requestHelp()
        {
            Console.WriteLine("assigning help to client");
            Helper h = new Helper(this);
            active.Add(h);
            return h;
        }
    }
}
