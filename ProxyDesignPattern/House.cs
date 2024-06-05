using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class House : IHouse
    {
        public void GoBedroom()
        {
            Console.WriteLine("Can Go to Bedrrom");
        }

        public void GoKuxna()
        {
            Console.WriteLine("Can Go to Kuxna");
        }

        public void GoLivingRoom()
        {
            Console.WriteLine("Can Go to LivingRoom");
        }
    }
}
