using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDesignPattern
{
    public class HouseProxy:IHouse
    {
        public House House { get; set; } = new House();

        public HouseProxy(string access)
        {
            this.access = access;
        }

        public string access {  get; set; }

        public void GoBedroom()
        {
            if(access == "Ata" || access == "Ana")
                House.GoBedroom();
            else
                Console.WriteLine("you could not go bedroom");
        }

        public void GoKuxna()
        {
            if (access == "Ata" || access == "Ana")
                House.GoKuxna();
            else
                Console.WriteLine("you could not go kuxna");
        }

        public void GoLivingRoom()
        {
            if (access == "Ata" || access == "Ana" || access == "Qonaq")
                House.GoLivingRoom();
            else
                Console.WriteLine("you could not go living room");
        }
    }
}
